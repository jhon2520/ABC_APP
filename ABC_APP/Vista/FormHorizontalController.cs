using ABC_APP.logica;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.IO;
using System.Drawing;
using System.ComponentModel;


namespace ABC_APP.Vista
{
    class FormHorizontalController
    {
        private FormHorizontalAnalisis formHorizontalAnalisis;
        private ImportExcel importExcel;
        private DataGridStyle dataGridStyle = new DataGridStyle();
        private DataGridCellFormat gridCellFormat = new DataGridCellFormat();
        private Archivos archivos = new Archivos();
        private Procesos procesos = new Procesos();
        private string pathC = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        private FormGrafica formGrafica;
        private FormError formError;
        private FormAviso formAviso;
        private FormFormatoDataGrid formFormato;
        private ComboBoxLogica comboBoxLogica = new ComboBoxLogica();
        private FormConfirmacion formConfirmacion;
        private Excel excel;
        private int contador = 0;



        public FormHorizontalController(FormHorizontalAnalisis formHorizontalAnalisis)
        {
            this.formHorizontalAnalisis = formHorizontalAnalisis;
            this.formHorizontalAnalisis.dgImport = dataGridStyle.DataGridGetStyle(this.formHorizontalAnalisis.dgImport );
            Recargas();
            SetDefaultColors();
            CreateFolder();
            
        }

        private void Recargas()
        {
            this.formHorizontalAnalisis.btnImportar.Click += new EventHandler(ImportarExcelToDGVSuperior);
            this.formHorizontalAnalisis.btnFormato.Click += new EventHandler(DataGridCellFormating);
            this.formHorizontalAnalisis.btnPython.Click += new EventHandler(BtnEjecutarPython);
            this.formHorizontalAnalisis.btnGrafica.Click += new EventHandler(BtnMostrarGrafica);
            this.formHorizontalAnalisis.btnFormatoCelda.Click += new EventHandler(AbrirFormFormatoGrid);
            this.formHorizontalAnalisis.cbxColumns.SelectedIndexChanged += new EventHandler(PasarItemsComboBox);
            this.formHorizontalAnalisis.btnLimpiarCbx.Click += new EventHandler(LimpiarComboBox);
            this.formHorizontalAnalisis.numericUPDownFormato.ValueChanged += new EventHandler(SetCachevalorCeldaFormato);
            this.formHorizontalAnalisis.btnBorrarFormato.Click += new EventHandler(LimpiarFormato);
            this.formHorizontalAnalisis.btnGuardarGrid.Click += new EventHandler(GuardarGridEnCache);
            this.formHorizontalAnalisis.btnTraerGridCache.Click += new EventHandler(TraerGridDeCache);
            this.formHorizontalAnalisis.btnSobreescribirGrid.Click += new EventHandler(BtnSobreescribirGrid);
            this.formHorizontalAnalisis.btnExportarGrid.Click += new EventHandler(BtnExportarGridConFormato);

            //ProgressBarr
            this.formHorizontalAnalisis.bgwEjecutarPython.DoWork += new DoWorkEventHandler(BackGroundWorkerDoWork);
            this.formHorizontalAnalisis.bgwEjecutarPython.ProgressChanged += new ProgressChangedEventHandler(BackGroundWorkerProgress);
            this.formHorizontalAnalisis.bgwEjecutarPython.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackGroundWorkerCompleted);
            this.formHorizontalAnalisis.timerEjecutarPython.Tick += new EventHandler(TimerTick);


        }

        private void SetDefaultColors()
        {
            CacheData.Cache.ColorFondo = Color.Red;
            CacheData.Cache.ColorLetra = Color.White;
            CacheData.Cache.ValorCeldaFormato = 40.0;
        }


        private void ImportarExcelToDGVSuperior(object sender, EventArgs args)
        {
            try
            {
                importExcel = new ImportExcel();
                importExcel.ImportarExcelOpenFile(this.formHorizontalAnalisis.dgImport, "Hoja1", this.formHorizontalAnalisis.tbxRuta.Text, this.formHorizontalAnalisis.tbxRuta);

            }
            catch (Exception ex)
            {

                formError = new FormError(ex.ToString());
                formError.ShowDialog();
            }
      
        }
        private void ImportarExcelToDGVInferior()
        {

            try
            {

                //TODO: Quitar la primera columna del archivo que se exporta
                importExcel = new ImportExcel();
                string completePath = this.pathC + @"\archivosABC\archivo_analisis_horizontal_final.xlsx";
                importExcel.ImportarExcelDeRuta(this.formHorizontalAnalisis.dgImport, "Results", completePath);
                dataGridStyle.DataGridDecimales(this.formHorizontalAnalisis.dgImport);
                GetDataGridColumnsToComboBox();
            }
            catch (Exception ex)
            {

                formError = new FormError(ex.ToString());
                formError.ShowDialog();
            }


        }

        private void DataGridCellFormating(object sender, EventArgs args)
        {
            gridCellFormat.dataGrid = this.formHorizontalAnalisis.dgImport;
            gridCellFormat.columnas = CrearListaComboBox(this.formHorizontalAnalisis.cbxDestino);
            this.formHorizontalAnalisis.dgImport.CellFormatting += new DataGridViewCellFormattingEventHandler(gridCellFormat.EjecutarFormateoDeCeldas);



        }

        private List<string> CrearListaComboBox(ComboBox comboBox)
        {
            List<string> lista = new List<string>();

            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                lista.Add(comboBox.Items[i].ToString());
            }
            return lista;
        }



        private void CreateFolder()
        {
            try
            {
                string completePath = this.pathC + @"\";
                archivos.CrearCarpetaABC(completePath, "archivosABC");
            }
            catch (Exception ex)
            {

                formError = new FormError(ex.ToString());
                formError.ShowDialog();
            }

        }

        private void BtnMostrarGrafica(object sender, EventArgs args)
        {
            //formGrafica = new FormGrafica("crafica_analisis_horizontal");
            //formGrafica.ShowDialog();
            Form formBG = new Form();
            using (formGrafica = new FormGrafica("crafica_analisis_horizontal"))
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
                formBG.Location = this.formHorizontalAnalisis.Location;
                formBG.ShowInTaskbar = false;
                formBG.Show();

                formGrafica.Owner = formBG;
                formGrafica.ShowDialog();
                formBG.Dispose();

            }

        }

        private void GetDataGridColumnsToComboBox()
        {
            dataGridStyle.GetDataGridColumns(this.formHorizontalAnalisis.dgImport, this.formHorizontalAnalisis.cbxColumns);
        }

        private void AbrirFormFormatoGrid(object sender, EventArgs args)
        {
            //using (formFormato = new FormFormatoDataGrid())
            //{
            //    formFormato.ShowDialog();
            //}

            Form formBG = new Form();
            using (formFormato = new FormFormatoDataGrid())
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
                formBG.Location = this.formHorizontalAnalisis.Location;
                formBG.ShowInTaskbar = false;
                formBG.Show();

                formFormato.Owner = formBG;
                formFormato.ShowDialog();
                formBG.Dispose();

            }
        }

        private void PasarItemsComboBox(object sender,EventArgs args)
        {
            comboBoxLogica.PasarItemsComboBox(this.formHorizontalAnalisis.cbxColumns, this.formHorizontalAnalisis.cbxDestino);
            comboBoxLogica.RemoverDuplicados(this.formHorizontalAnalisis.cbxDestino);
        }

        private void LimpiarComboBox(object sender, EventArgs args)
        {
            if (this.formHorizontalAnalisis.cbxDestino.Items.Count > 0)
            {
                using (formConfirmacion = new FormConfirmacion("¿Desea limpiar los elementos del ComboBox destino?"))
                {
                    DialogResult result = formConfirmacion.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.formHorizontalAnalisis.cbxDestino.Items.Clear();
                    }
                }
            }
        }
        private void SetCachevalorCeldaFormato(object sender,EventArgs args)
        {
            CacheData.Cache.ValorCeldaFormato = Convert.ToDouble(this.formHorizontalAnalisis.numericUPDownFormato.Value);
        }

        private void LimpiarFormato(object sender, EventArgs args)
        {
            using (formConfirmacion = new FormConfirmacion("¿Desea eliminar el formato de las celdas?"))
            {
                DialogResult result = formConfirmacion.ShowDialog();
                if (result == DialogResult.OK)
                {
                    gridCellFormat.dataGrid = this.formHorizontalAnalisis.dgImport;
                    gridCellFormat.columnas = CrearListaComboBox(this.formHorizontalAnalisis.cbxDestino);
                    this.formHorizontalAnalisis.dgImport.CellFormatting += new DataGridViewCellFormattingEventHandler(gridCellFormat.LimpiarFormateoDeCeldas);
                }
            }


        }
        private void GuardarGridEnCache(object sender, EventArgs args)
        {
            try
            {
            CacheData.Cache.DataTablePrueba = (DataTable)this.formHorizontalAnalisis.dgImport.DataSource;
                MessageBox.Show("Data grid guardado");

            }
            catch (Exception ex)
            {

                formError = new FormError(ex.ToString());
                formError.ShowDialog();
            }
        }
        private void TraerGridDeCache(object sender, EventArgs args)
        {
            try
            {
                this.formHorizontalAnalisis.dgImport.DataSource = CacheData.Cache.DataTablePrueba;
                MessageBox.Show("Data grid traído");

            }
            catch (Exception ex)
            {

                formError = new FormError(ex.ToString());
                formError.ShowDialog();
            }
        }

        #region ProgressBar


        private void BtnEjecutarPython(object sender, EventArgs args)
        {

            this.formHorizontalAnalisis.timerEjecutarPython.Enabled = true;
            this.formHorizontalAnalisis.timerEjecutarPython.Start();
            if (this.formHorizontalAnalisis.bgwEjecutarPython.IsBusy != true)
            {
                this.formHorizontalAnalisis.bgwEjecutarPython.RunWorkerAsync();
            }

        }

        private void BackGroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {

            if (this.formHorizontalAnalisis.pbarVisualizador.InvokeRequired || this.formHorizontalAnalisis.pbxLoagindGif.InvokeRequired)
            {
                this.formHorizontalAnalisis.pbarVisualizador.Invoke(new Action(() =>
                {
                    this.formHorizontalAnalisis.pbarVisualizador.Visible = true;
                    this.formHorizontalAnalisis.pbxLoagindGif.Visible = true;

                }));
            }

            try
            {
                string currentDomain = AppDomain.CurrentDomain.BaseDirectory + @"PythonCode\comparacion_horizontal.exe";
                procesos.EjecutarProceso(currentDomain);
              

            }
            catch (Exception ex)
            {

                formError = new FormError(ex.ToString());
                formError.ShowDialog();
            }

            this.formHorizontalAnalisis.timerEjecutarPython.Stop();
            this.formHorizontalAnalisis.bgwEjecutarPython.ReportProgress(100);
        }

        private void BackGroundWorkerProgress(object sender, ProgressChangedEventArgs e)
        {
            this.formHorizontalAnalisis.pbarVisualizador.Value = e.ProgressPercentage;
        }

        private void BackGroundWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            using (formAviso = new FormAviso("Proceso terminado, gracias por esperar"))
            {
                this.formHorizontalAnalisis.pbarVisualizador.Visible = false;
                this.formHorizontalAnalisis.pbxLoagindGif.Visible = false;
                formAviso.ShowDialog();
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            this.contador++;
            this.formHorizontalAnalisis.bgwEjecutarPython.ReportProgress(100 - (100 / contador));
        }

        private void BtnSobreescribirGrid(object sender, EventArgs args)
        {
            this.formHorizontalAnalisis.dgImport.DataSource = null;
            this.formHorizontalAnalisis.cbxColumns.Items.Clear();
            ImportarExcelToDGVInferior();
        }

        #endregion

        #region ExportarGridConFormato
     

        private void BtnExportarGridConFormato(object sender, EventArgs args)
        {
            excel = new Excel();
            excel.ExportToExcelWithFormatting(this.formHorizontalAnalisis.dgImport);
        }

        #endregion



    }
}
