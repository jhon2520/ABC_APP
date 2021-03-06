using ABC_APP.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_APP.Vista
{
    class FormSectorController
    {
        private FormSectorAnalisis formSectorAnalisis;
        private DataGridStyle dataGridStyle = new DataGridStyle();
        private ImportExcel importExcel;
        private FormError formError;
        private FormAviso formAviso;
        private Archivos archivos = new Archivos();
        private Procesos procesos = new Procesos();
        private FormGrafica formGrafica;
        private string pathC = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        private DataGridCellFormat gridCellFormat = new DataGridCellFormat();
        private int contador = 0;
        private int alertas = 0;
        private Excel excel;
        private string rutaCarpeta;
        string pathArchivosABC = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\archivosABC";
 

        public FormSectorController(FormSectorAnalisis formSectorAnalisis)
        {
            this.formSectorAnalisis = formSectorAnalisis;
            dataGridStyle.DataGridGetStyle( this.formSectorAnalisis.dgImport);
            Recargas();
        }

        private void Recargas()
        {
            this.formSectorAnalisis.btnImportar.Click += new EventHandler(ImportarExcel);
            this.formSectorAnalisis.pbxAyuda.Click += new EventHandler(BtnAyuda);
            this.formSectorAnalisis.btnPython.Click += new EventHandler(BtnEjecutarPython);
            this.formSectorAnalisis.btnSobreescribirGrid.Click += new EventHandler(BtnSobreescribirGrid);
            this.formSectorAnalisis.btnAlertas.Click += new EventHandler(BtnAlertas);
            this.formSectorAnalisis.dgImport.CellContentClick += new DataGridViewCellEventHandler(BtnMostrarDatosGridEnTbx);
            this.formSectorAnalisis.dgImport.CellClick += new DataGridViewCellEventHandler(BtnMostrarDatosGridEnTbx);
            this.formSectorAnalisis.btnGrafica.Click+= new EventHandler(MostrarGrafica);
            this.formSectorAnalisis.btnExportarGrid.Click+= new EventHandler(ExportarArchivoCompilado);
            this.formSectorAnalisis.cbxAlertas.SelectedValueChanged += new EventHandler(ComboBoxAlertasCambio);
            this.formSectorAnalisis.cbxAlertas.MouseWheel += new MouseEventHandler(ComboBoxMauseWheel);


            this.formSectorAnalisis.bgwEjecutarPython.DoWork += new DoWorkEventHandler(BackGroundWorkerDoWork);
            this.formSectorAnalisis.bgwEjecutarPython.ProgressChanged += new ProgressChangedEventHandler(BackGroundWorkerProgress);
            this.formSectorAnalisis.bgwEjecutarPython.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackGroundWorkerCompleted);
            this.formSectorAnalisis.timerEjecutarPython.Tick += new EventHandler(TimerTick);

        }

        #region Importar Archivos

        private void ImportarExcel(object sender, EventArgs args)
        {
            try
            {
                importExcel = new ImportExcel();
                importExcel.ImportarExcelOpenFile(this.formSectorAnalisis.dgImport, "EF", this.formSectorAnalisis.tbxRuta.Text, this.formSectorAnalisis.tbxRuta);
                if(this.formSectorAnalisis.tbxRuta.Text != string.Empty)
                {
                    ValidarNombreArchivo();
                }
            }
            catch (Exception ex)
            {

                formError = new FormError(ex.ToString());
                formError.ShowDialog();
            }
        }
        #endregion

        #region Botones

        private void BtnAyuda(object sender, EventArgs args)
        {

            Form formBG = new Form();
            using (formAviso = new FormAviso("rchivo 'archivo_usuario_CIIU.xlsx', nombre hoja 'EF' comparado con df_complete_supersolidaria.xlsx"))
            {
                formBG.StartPosition = FormStartPosition.Manual;
                formBG.FormBorderStyle = FormBorderStyle.None;
                formBG.Opacity = 0.7d;
                formBG.BackColor = Color.Black;
                formBG.Left = 0;
                formBG.Top = 0;
                formBG.Width = Screen.PrimaryScreen.WorkingArea.Width;
                formBG.Height = Screen.PrimaryScreen.WorkingArea.Height;
                formBG.TopMost = true;
                formBG.Location = this.formSectorAnalisis.Location;
                formBG.ShowInTaskbar = false;
                formBG.Show();

                formAviso.Owner = formBG;
                formAviso.ShowDialog();
                formBG.Dispose();

            }


        }

        private void BtnSobreescribirGrid(object sender, EventArgs args)
        {
            ImportarExcelToDGV();
            //gridCellFormat.RellenarCeldasDataGrid(this.formSectorAnalisis.dgImport, 0);
        }
        private void BtnAlertas(object sender, EventArgs args)
        {
            gridCellFormat.dataGrid = this.formSectorAnalisis.dgImport;
            this.formSectorAnalisis.dgImport.CellFormatting += new DataGridViewCellFormattingEventHandler(gridCellFormat.EjecutarFormateoDeAlertas);
            ContadorDeAlertas();
        }

        private void MostrarDatosGridEnTbx()
        {
            try
            {

                if (this.formSectorAnalisis.dgImport.Columns.Count > 4)
                {

                    this.formSectorAnalisis.tbxCuenta.Text = this.formSectorAnalisis.dgImport.CurrentRow.Cells[1].Value.ToString();
                    this.formSectorAnalisis.tbxProm.Text = this.formSectorAnalisis.dgImport.CurrentRow.Cells[2].Value.ToString();
                    this.formSectorAnalisis.tbxMax.Text = this.formSectorAnalisis.dgImport.CurrentRow.Cells[3].Value.ToString();
                    this.formSectorAnalisis.tbxMin.Text = this.formSectorAnalisis.dgImport.CurrentRow.Cells[4].Value.ToString();
                    this.formSectorAnalisis.tbxDesviacion.Text = this.formSectorAnalisis.dgImport.CurrentRow.Cells[5].Value.ToString();
                    this.formSectorAnalisis.tbxUser.Text = this.formSectorAnalisis.dgImport.CurrentRow.Cells[6].Value.ToString();
                    this.formSectorAnalisis.tbxDif.Text = this.formSectorAnalisis.dgImport.CurrentRow.Cells[7].Value.ToString();
                    this.formSectorAnalisis.tbxDifPor.Text = this.formSectorAnalisis.dgImport.CurrentRow.Cells[8].Value.ToString();
                    this.formSectorAnalisis.tbxLimSup.Text = this.formSectorAnalisis.dgImport.CurrentRow.Cells[9].Value.ToString();
                    this.formSectorAnalisis.tbxLimInf.Text = this.formSectorAnalisis.dgImport.CurrentRow.Cells[10].Value.ToString();

                    this.formSectorAnalisis.tbxProm.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(this.formSectorAnalisis.tbxProm.Text));
                    this.formSectorAnalisis.tbxMax.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(this.formSectorAnalisis.tbxMax.Text));
                    this.formSectorAnalisis.tbxMin.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(this.formSectorAnalisis.tbxMin.Text));
                    this.formSectorAnalisis.tbxDesviacion.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(this.formSectorAnalisis.tbxDesviacion.Text));
                    this.formSectorAnalisis.tbxUser.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(this.formSectorAnalisis.tbxUser.Text));
                    this.formSectorAnalisis.tbxDif.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(this.formSectorAnalisis.tbxDif.Text));
                    this.formSectorAnalisis.tbxDifPor.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(this.formSectorAnalisis.tbxDifPor.Text));
                    this.formSectorAnalisis.tbxLimSup.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(this.formSectorAnalisis.tbxLimSup.Text));
                    this.formSectorAnalisis.tbxLimInf.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(this.formSectorAnalisis.tbxLimInf.Text));

                }
            }
            catch (Exception e)
            {

                using (formError = new FormError(e.ToString()))
                {
                    formError.ShowDialog();
                }
            }

        }

        private void BtnMostrarDatosGridEnTbx(object sender, DataGridViewCellEventArgs e)
        {

            MostrarDatosGridEnTbx();
        }


        private void ComboBoxAlertasCambio(object sender, EventArgs args)
        {
           
            for(int i =0; i< this.formSectorAnalisis.dgImport.Rows.Count; i++)
            {
                if(this.formSectorAnalisis.dgImport.Rows[i].Cells[1].Value == this.formSectorAnalisis.cbxAlertas.SelectedItem)
                {
                    this.formSectorAnalisis.dgImport.ClearSelection();
                    this.formSectorAnalisis.dgImport.Rows[i].Cells[1].Selected = true;
                    this.formSectorAnalisis.dgImport.CurrentCell = this.formSectorAnalisis.dgImport.Rows[i].Cells[1];
                    MostrarDatosGridEnTbx();
            
                }
            }
        }

        private void ComboBoxMauseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void MostrarGrafica(object sender, EventArgs args)
        {
            Form formBG = new Form();
            using (formGrafica = new FormGrafica("comparacion_CIIU_user"))
            {
                formBG.StartPosition = FormStartPosition.Manual;
                formBG.FormBorderStyle = FormBorderStyle.None;
                formBG.Opacity = 0.7d;
                formBG.BackColor = Color.Black;
                formBG.Left = 0;
                formBG.Top = 0;
                formBG.Width = Screen.PrimaryScreen.WorkingArea.Width;
                formBG.Height = Screen.PrimaryScreen.WorkingArea.Height;
                formBG.TopMost = true;
                formBG.Location = this.formSectorAnalisis.Location;
                formBG.ShowInTaskbar = false;
                formBG.Show();

                formGrafica.Owner = formBG;
                formGrafica.ShowDialog();
                formBG.Dispose();

            }
            
        }



        private void ExportarArchivoCompilado(object sender, EventArgs args)
        {
            try
            {
                //using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                //{
                //    DialogResult result = folderBrowserDialog.ShowDialog();
                //    if (result == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                //    {

                //        rutaCarpeta = folderBrowserDialog.SelectedPath;
                //        archivos.CopiarArchivo(pathArchivosABC + @"\archivo_usuario_CIIU_final.xlsx", rutaCarpeta);
                //        formAviso = new FormAviso("Archivo copiado en la ruta: " + rutaCarpeta);
                //        formAviso.ShowDialog();

                //    }
                //}
                excel = new Excel();
                excel.ExportToExcelWithFormatting(this.formSectorAnalisis.dgImport);
            }
            catch (Exception ex)
            {
                formError = new FormError(ex.ToString());
                formError.ShowDialog();
            }


        }

        #endregion

        #region Validaciones
        private void ValidarNombreArchivo()
        {
            if (!archivos.ValidarNombreImportado(this.formSectorAnalisis.tbxRuta.Text, "archivo_usuario_CIIU.xlsx"))
            {
                formError = new FormError("Advertencia: El nombre del archivo no corresponde al nombre: ef_sector.xlsx");
                formError.ShowDialog();

            }
            
        }
        private void ImportarExcelToDGV()
        {

            try
            {
                importExcel = new ImportExcel();
                string completePath = this.pathC + @"\archivosABC\archivo_usuario_CIIU_final.xlsx";
                importExcel.ImportarExcelDeRuta(this.formSectorAnalisis.dgImport, "Results", completePath);
                dataGridStyle.DataGridDecimales(this.formSectorAnalisis.dgImport);
      
            }
            catch (Exception ex)
            {

                formError = new FormError(ex.ToString());
                formError.ShowDialog();
            }


        }

        private void ContadorDeAlertas()
        {
            for(int row = 0; row < this.formSectorAnalisis.dgImport.Rows.Count; row++)
            {
                if(this.formSectorAnalisis.dgImport.Rows[row].Cells[11].Value.ToString().Contains("1"))
                {
                    alertas++;
                    this.formSectorAnalisis.cbxAlertas.Items.Add(this.formSectorAnalisis.dgImport.Rows[row].Cells[1].Value.ToString());
                }
            }
            this.formSectorAnalisis.contadorAlertas.Value = alertas;
        }

        #endregion

        #region ProgressBar
        private void BtnEjecutarPython(object sender, EventArgs args)
        {

            this.formSectorAnalisis.timerEjecutarPython.Enabled = true;
            this.formSectorAnalisis.timerEjecutarPython.Start();
            if (this.formSectorAnalisis.bgwEjecutarPython.IsBusy != true)
            {
                this.formSectorAnalisis.bgwEjecutarPython.RunWorkerAsync();
            }

        }

        private void BackGroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {

            if (this.formSectorAnalisis.pbarVisualizador.InvokeRequired || this.formSectorAnalisis.pbxLoagindGif.InvokeRequired)
            {
                this.formSectorAnalisis.pbarVisualizador.Invoke(new Action(() =>
                {
                    this.formSectorAnalisis.pbarVisualizador.Visible = true;
                    this.formSectorAnalisis.pbxLoagindGif.Visible = true;

                }));
            }

            try
            {
                string currentDomain = AppDomain.CurrentDomain.BaseDirectory + @"PythonCode\comparar_archivos_super.exe";
                procesos.EjecutarProceso(currentDomain);
               // ImportarExcelToDGV();



            }
            catch (Exception ex)
            {

                formError = new FormError(ex.ToString());
                formError.ShowDialog();
            }

            this.formSectorAnalisis.timerEjecutarPython.Stop();
            this.formSectorAnalisis.bgwEjecutarPython.ReportProgress(100);
        }

        private void BackGroundWorkerProgress(object sender, ProgressChangedEventArgs e)
        {
            this.formSectorAnalisis.pbarVisualizador.Value = e.ProgressPercentage;
        }

        private void BackGroundWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            using (formAviso = new FormAviso("Proceso terminado, gracias por esperar"))
            {
                this.formSectorAnalisis.pbarVisualizador.Visible = false;
                this.formSectorAnalisis.pbxLoagindGif.Visible = false;
                formAviso.ShowDialog();
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            this.contador++;
            this.formSectorAnalisis.bgwEjecutarPython.ReportProgress(100 - (100 / contador));
        }
        #endregion





    }
}
