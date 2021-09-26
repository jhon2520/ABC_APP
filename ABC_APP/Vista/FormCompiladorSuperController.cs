using ABC_APP.logica;
using System;
using System.Collections.Generic;
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
                         
                            procesos.EjecutarProceso(currentDomain + "compilar_archivos_super.exe");
                            
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
        private void ImportarArchivoCompiladoExcel(object sender, EventArgs args)
        {
            if (this.formCompiladorSuperSociedades.dgCompilado.Rows.Count == 0)
            {

                try
                {
                    if (File.Exists(pathArchivosABC + @"\df_complete_supersolidaria.xlsx"))
                    {

                        using (formAviso = new FormAviso("Espere un momento el cargue de la información"))
                        {
                            importExcel = new ImportExcel();
                            formAviso.ShowDialog();
                            importExcel.ImportarExcelDeRuta(this.formCompiladorSuperSociedades.dgCompilado, "Resultado", pathArchivosABC + @"\df_complete_supersolidaria.xlsx");
                        }

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

         
        }

        private void ExportarArchivoCompilado(object sender, EventArgs args)
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
