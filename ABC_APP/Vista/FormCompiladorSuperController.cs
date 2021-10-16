using ABC_APP.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_APP.Vista
{
    class FormCompiladorSuperController
    {
        private FormCompiladorSuperSociedades formCompiladorSuperSociedades;
        string pathArchivosABC = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\archivosABC";
        private FormError formError;
        private ComboBoxLogica comboBoxLogica = new ComboBoxLogica();
        private Archivos archivos = new Archivos();
        private string rutaCarpeta;
        private FormAviso formAviso;
        private FormConfirmacion formConfirmacion;
        private Procesos procesos = new Procesos();
        string currentDomain = AppDomain.CurrentDomain.BaseDirectory + @"PythonCode\";
        private DataGridStyle dataGridStyle = new DataGridStyle();
        private ImportExcel importExcel;
        private int contador = 1;

        public FormCompiladorSuperController(FormCompiladorSuperSociedades formCompiladorSuperSociedades)
        {
            this.formCompiladorSuperSociedades = formCompiladorSuperSociedades;
            dataGridStyle.DataGridGetStyle(new List<DataGridView>() { this.formCompiladorSuperSociedades.dgCompilado});
            Recargas();
        }

        private void Recargas()
        {
            this.formCompiladorSuperSociedades.btnSeleccionarRuta.Click += new EventHandler(SeleccionarCarpeta);
            this.formCompiladorSuperSociedades.btnCompilarArchivos.Click += new EventHandler(CompilarArchivos);
            this.formCompiladorSuperSociedades.pbxCurrentDomain.Click += new EventHandler(ShowCurrentDomain);
            this.formCompiladorSuperSociedades.btnVerArchivoCompilado.Click += new EventHandler(ImportarArchivoCompiladoExcel);
            this.formCompiladorSuperSociedades.btnExportarCompilado.Click += new EventHandler(ExportarArchivoCompilado);
            this.formCompiladorSuperSociedades.bgwVisualizarCompilado.DoWork += new DoWorkEventHandler(BackGroundWorkerDoWork);
            this.formCompiladorSuperSociedades.bgwVisualizarCompilado.ProgressChanged += new ProgressChangedEventHandler(BackGroundWorkerProgress);
            this.formCompiladorSuperSociedades.bgwVisualizarCompilado.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackGroundWorkerCompleted);
            this.formCompiladorSuperSociedades.timerVisualizarCompilador.Tick += new EventHandler(TimerTick);
        }

        private void SeleccionarCarpeta(object sender, EventArgs args)
        {

            this.formCompiladorSuperSociedades.cbxArchivos.Items.Clear();

            try
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    DialogResult result = folderBrowserDialog.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                    {
                        List<string> archivos = Directory.GetFiles(folderBrowserDialog.SelectedPath).ToList();
                        comboBoxLogica.FromListToComboBox(archivos, this.formCompiladorSuperSociedades.cbxArchivos);
                        rutaCarpeta = folderBrowserDialog.SelectedPath;
                        this.formCompiladorSuperSociedades.tbxRutaFolder.Text = rutaCarpeta;
                        CopiarArchivos();
                    }
                }
            }
            catch (Exception ex)
            {

                formError = new FormError(ex.ToString());
                formError.ShowDialog();
            }
           

            

        }

        private void CopiarArchivos()
        {
            try
            {
                
                foreach (string item in this.formCompiladorSuperSociedades.cbxArchivos.Items)
                {
                    archivos.CopiarArchivo(item, pathArchivosABC);
                }

                formAviso = new FormAviso("¡Los archivos fueron copiados exitosamente!");
                formAviso.ShowDialog();

            }
            catch (Exception ex)
            {

                formError = new FormError(ex.ToString());
                formError.ShowDialog();
            }
        
    
        }

        private void CompilarArchivos(object sender, EventArgs args)
        {
            try
            {
                //saber si ya existe el archivo
                if (File.Exists(pathArchivosABC + @"\df_complete_supersolidaria.xlsx"))
                {
                    using (formConfirmacion = new FormConfirmacion("Ya hay un archivo compilado almacenado \n ¿Desea compilar de nuevo?"))
                    {
                        DialogResult result = formConfirmacion.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            this.formCompiladorSuperSociedades.pbxLoagindGif.Visible = true;
                            procesos.EjecutarProceso(currentDomain + "compilar_archivos_super.exe");
                            this.formCompiladorSuperSociedades.pbxLoagindGif.Visible = false;
                            
                        }
                        else
                        {
                            formAviso = new FormAviso("¡Proceso abortado!");
                            formAviso.ShowDialog();
                        }
                    }
                }
                else
                {
                    formAviso = new FormAviso("Este proceso puede tardar unos 10 minutos, por favor espere");
                    formAviso.ShowDialog();
                    procesos.EjecutarProceso(currentDomain + "compilar_archivos_super.exe");
                    formAviso = new FormAviso("Proceso Terminado");
                    formAviso.ShowDialog();
                }
               
            }
            catch (Exception ex)
            {
                formError = new FormError(ex.ToString());
                formError.ShowDialog();
            }
          
        }

        private void ShowCurrentDomain(object sender, EventArgs args)
        {
            using (formAviso = new FormAviso("Ruta archivo py.exe: " + currentDomain))
            {
                formAviso.ShowDialog();
            }
        }

        #region ProgressBar
        private void ImportarArchivoCompiladoExcel(object sender, EventArgs args)
        {

            this.formCompiladorSuperSociedades.timerVisualizarCompilador.Enabled = true;
            this.formCompiladorSuperSociedades.timerVisualizarCompilador.Start();
            if (this.formCompiladorSuperSociedades.bgwVisualizarCompilado.IsBusy != true)
            {
                this.formCompiladorSuperSociedades.bgwVisualizarCompilado.RunWorkerAsync();
            }
         
        }

        private void BackGroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            if (this.formCompiladorSuperSociedades.dgCompilado.Rows.Count == 0)
            {
                if (this.formCompiladorSuperSociedades.pbarVisualizador.InvokeRequired || this.formCompiladorSuperSociedades.pbxLoagindGif.InvokeRequired)
                {
                    this.formCompiladorSuperSociedades.pbarVisualizador.Invoke(new Action(() =>
                    {
                        this.formCompiladorSuperSociedades.pbarVisualizador.Visible = true;
                        this.formCompiladorSuperSociedades.pbxLoagindGif.Visible = true;

                    }));
                }
                try
                {
                    if (File.Exists(pathArchivosABC + @"\df_complete_supersolidaria.xlsx"))
                    {

                        importExcel = new ImportExcel();
                        importExcel.ImportarExcelDeRuta(this.formCompiladorSuperSociedades.dgCompilado, "Resultado", pathArchivosABC + @"\df_complete_supersolidaria.xlsx");

                    }
                    else
                    {
                        using (formError = new FormError("No se encuentra el archivo compilado en la ruta " + pathArchivosABC))
                        {
                            formError.ShowDialog();
                        }
                    }

            }
                catch (Exception ex)
            {
                formError = new FormError(ex.ToString());
                formError.ShowDialog();
            }
        }

            this.formCompiladorSuperSociedades.timerVisualizarCompilador.Stop();
            this.formCompiladorSuperSociedades.bgwVisualizarCompilado.ReportProgress(100);
        }

        private void BackGroundWorkerProgress(object sender, ProgressChangedEventArgs e)
        {
            this.formCompiladorSuperSociedades.pbarVisualizador.Value = e.ProgressPercentage;
        }

        private void BackGroundWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            using (formAviso = new FormAviso("Proceso terminado, gracias por esperar"))
            {
                this.formCompiladorSuperSociedades.pbarVisualizador.Visible = false;
                this.formCompiladorSuperSociedades.pbxLoagindGif.Visible = false;
                formAviso.ShowDialog();
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            this.contador++;
            this.formCompiladorSuperSociedades.bgwVisualizarCompilado.ReportProgress(100 - (100 / contador));
        }


        #endregion

        private void ExportarArchivoCompilado(object sender, EventArgs args)
        {

            if(this.formCompiladorSuperSociedades.dgCompilado.Rows.Count > 0)
            {

                try
                {

                    using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                    {
                        DialogResult result = folderBrowserDialog.ShowDialog();
                        if (result == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                        {

                            rutaCarpeta = folderBrowserDialog.SelectedPath;
                            archivos.CopiarArchivo(pathArchivosABC + @"\df_complete_supersolidaria.xlsx", rutaCarpeta);
                            formAviso = new FormAviso("Archivo copiado en la ruta: " + rutaCarpeta);
                            formAviso.ShowDialog();

                        }
                    }
                }
                catch (Exception ex)
                {
                    formError = new FormError(ex.ToString());
                    formError.ShowDialog();
                }
            }



        }


    }
}
