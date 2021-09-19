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
        

        public FormHorizontalController(FormHorizontalAnalisis formHorizontalAnalisis)
        {
            this.formHorizontalAnalisis = formHorizontalAnalisis;
            dataGridStyle.DataGridGetStyle(new List<DataGridView>() { this.formHorizontalAnalisis.dgImport ,this.formHorizontalAnalisis.dgExport} );
            Recargas();
            CreateFolder();
            
        }

        private void Recargas()
        {
            this.formHorizontalAnalisis.btnImportar.Click += new EventHandler(ImportarExcelToDGVSuperior);
            this.formHorizontalAnalisis.btnFormato.Click += new EventHandler(DataGridCellFormating);
            this.formHorizontalAnalisis.btnPython.Click += new EventHandler(EjecutarPython);
            this.formHorizontalAnalisis.btnGrafica.Click += new EventHandler(MostrarGrafica);
            
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
            }
            catch (Exception ex)
            {

                FormError = new FormError(ex.ToString());
                FormError.ShowDialog();
            }


        }

        private void DataGridCellFormating(object sender, EventArgs args)
        {
            gridCellFormat.dataGrid = this.formHorizontalAnalisis.dgImport; 
            this.formHorizontalAnalisis.dgImport.CellFormatting += new DataGridViewCellFormattingEventHandler(gridCellFormat.DataGridFormat);
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


    }
}
