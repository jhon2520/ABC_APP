using ABC_APP.logica;
using System;
using System.Collections.Generic;
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
        private string pathC = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        private DataGridCellFormat gridCellFormat = new DataGridCellFormat();

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

        }

        #region Importar Archivos

        private void ImportarExcel(object sender, EventArgs args)
        {
            try
            {
                importExcel = new ImportExcel();
                importExcel.ImportarExcelOpenFile(this.formSectorAnalisis.dgImport, "EF", this.formSectorAnalisis.tbxRuta.Text, this.formSectorAnalisis.tbxRuta);
                ValidarNombreArchivo();
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

        private void BtnEjecutarPython(object sender, EventArgs args)
        {
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
        }

        private void BtnSobreescribirGrid(object sender, EventArgs args)
        {
            ImportarExcelToDGV();
        }
        private void BtnAlertas(object sender, EventArgs args)
        {
            gridCellFormat.dataGrid = this.formSectorAnalisis.dgImport;
            this.formSectorAnalisis.dgImport.CellFormatting += new DataGridViewCellFormattingEventHandler(gridCellFormat.EjecutarFormateoDeAlertas);

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


        #endregion
    }
}
