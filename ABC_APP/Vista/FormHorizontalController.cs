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
        private FormError FormError;
        private FormFormatoDataGrid formFormato;
        private ComboBoxLogica comboBoxLogica = new ComboBoxLogica();
        private FormConfirmacion formConfirmacion; 
        

        public FormHorizontalController(FormHorizontalAnalisis formHorizontalAnalisis)
        {
            this.formHorizontalAnalisis = formHorizontalAnalisis;
            dataGridStyle.DataGridGetStyle(new List<DataGridView>() { this.formHorizontalAnalisis.dgImport ,this.formHorizontalAnalisis.dgExport} );
            Recargas();
            SetDefaultColors();
            CreateFolder();
            
        }

        private void Recargas()
        {
            this.formHorizontalAnalisis.btnImportar.Click += new EventHandler(ImportarExcelToDGVSuperior);
            this.formHorizontalAnalisis.btnFormato.Click += new EventHandler(DataGridCellFormating);
            this.formHorizontalAnalisis.btnPython.Click += new EventHandler(EjecutarPython);
            this.formHorizontalAnalisis.btnGrafica.Click += new EventHandler(MostrarGrafica);
            this.formHorizontalAnalisis.btnFormatoCelda.Click += new EventHandler(AbrirFormFormatoGrid);
            this.formHorizontalAnalisis.cbxColumns.SelectedIndexChanged += new EventHandler(PasarItemsComboBox);
            this.formHorizontalAnalisis.btnLimpiarCbx.Click += new EventHandler(LimpiarComboBox);
            this.formHorizontalAnalisis.numericUPDownFormato.ValueChanged += new EventHandler(SetCachevalorCeldaFormato);
            this.formHorizontalAnalisis.btnBorrarFormato.Click += new EventHandler(LimpiarFormato);


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

                FormError = new FormError(ex.ToString());
                FormError.ShowDialog();
            }
      
        }
        private void ImportarExcelToDGVInferior()
        {

            try
            {

                //TODO: Quitar la primera columna del archivo que se exporta
                importExcel = new ImportExcel();
                string completePath = this.pathC + @"\archivosABC\Exportado.xlsx";
                importExcel.ImportarExcelDeRuta(this.formHorizontalAnalisis.dgExport, "Results", completePath);
                dataGridStyle.DataGridDecimales(this.formHorizontalAnalisis.dgExport);
                GetDataGridColumnsToComboBox();
            }
            catch (Exception ex)
            {

                FormError = new FormError(ex.ToString());
                FormError.ShowDialog();
            }


        }

        private void DataGridCellFormating(object sender, EventArgs args)
        {
            gridCellFormat.dataGrid = this.formHorizontalAnalisis.dgExport;
            gridCellFormat.columnas = CrearListaComboBox(this.formHorizontalAnalisis.cbxDestino);
            this.formHorizontalAnalisis.dgExport.CellFormatting += new DataGridViewCellFormattingEventHandler(gridCellFormat.EjecutarFormateoDeCeldas);



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

        private void EjecutarPython(object sender, EventArgs args)
        {
            try
            {
                string currentDomain = AppDomain.CurrentDomain.BaseDirectory + @"PythonCode\main.exe";
                //TODO: Mejor la gráfica visualmente, probar en otro pc el código hasta el momento
                procesos.EjecutarProceso(currentDomain);
                ImportarExcelToDGVInferior();
            }
            catch (Exception ex)
            {

                FormError = new FormError(ex.ToString());
                FormError.ShowDialog();
            }

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

                FormError = new FormError(ex.ToString());
                FormError.ShowDialog();
            }

        }

        private void MostrarGrafica(object sender, EventArgs args)
        {
            formGrafica = new FormGrafica();
            formGrafica.ShowDialog();
        }

        private void GetDataGridColumnsToComboBox()
        {
            dataGridStyle.GetDataGridColumns(this.formHorizontalAnalisis.dgExport, this.formHorizontalAnalisis.cbxColumns);
        }

        private void AbrirFormFormatoGrid(object sender, EventArgs args)
        {
            using (formFormato = new FormFormatoDataGrid())
            {
                formFormato.ShowDialog();
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
                    gridCellFormat.dataGrid = this.formHorizontalAnalisis.dgExport;
                    gridCellFormat.columnas = CrearListaComboBox(this.formHorizontalAnalisis.cbxDestino);
                    this.formHorizontalAnalisis.dgExport.CellFormatting += new DataGridViewCellFormattingEventHandler(gridCellFormat.LimpiarFormateoDeCeldas);
                }
            }


        }


    }
}
