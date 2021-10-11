using ABC_APP.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public FormSectorController(FormSectorAnalisis formSectorAnalisis)
        {
            this.formSectorAnalisis = formSectorAnalisis;
            dataGridStyle.DataGridGetStyle(new List<DataGridView>() { this.formSectorAnalisis.dgImport});
            Recargas();
        }

        private void Recargas()
        {
            this.formSectorAnalisis.btnImportar.Click += new EventHandler(ImportarExcel);
            this.formSectorAnalisis.pbxAyuda.Click += new EventHandler(BtnAyuda);
            this.formSectorAnalisis.btnPython.Click += new EventHandler(BtnEjecutarPython);
            this.formSectorAnalisis.btnSobreescribirGrid.Click += new EventHandler(BtnSobreescribirGrid);
            this.formSectorAnalisis.btnAlertas.Click += new EventHandler(BtnAlertas);
            this.formSectorAnalisis.dgImport.CellContentClick += new DataGridViewCellEventHandler(MostrarDatosGridEnTbx);
            this.formSectorAnalisis.dgImport.CellClick += new DataGridViewCellEventHandler(MostrarDatosGridEnTbx);
            this.formSectorAnalisis.btnGrafica.Click+= new EventHandler(MostrarGrafica);


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
            using (formAviso = new FormAviso("Archivo 'archivo_usuario_CIIU.xlsx', nombre hoja 'EF' comparado con df_complete_supersolidaria.xlsx"))
            {
                formAviso.ShowDialog();
            }
        }

        private void BtnSobreescribirGrid(object sender, EventArgs args)
        {
            ImportarExcelToDGV();
        }
        private void BtnAlertas(object sender, EventArgs args)
        {
            gridCellFormat.dataGrid = this.formSectorAnalisis.dgImport;
            this.formSectorAnalisis.dgImport.CellFormatting += new DataGridViewCellFormattingEventHandler(gridCellFormat.EjecutarFormateoDeAlertas);
            ContadorDeAlertas();
        }

        private void MostrarDatosGridEnTbx(object sender, DataGridViewCellEventArgs e)
        {
            if(this.formSectorAnalisis.dgImport.Columns.Count > 4)
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

        private void MostrarGrafica(object sender, EventArgs args)
        {
            formGrafica = new FormGrafica("comparacion_CIIU_user");
            formGrafica.ShowDialog();
            
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
