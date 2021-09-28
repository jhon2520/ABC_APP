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
            using (formAviso = new FormAviso("Archivo 'ef_sector.xlsx', nombre hoja 'EF' comparado con df_complete_supersolidaria.xlsx"))
            {
                formAviso.ShowDialog();
            }
        }

        #endregion

        #region Validaciones
        private void ValidarNombreArchivo()
        {
            if (!archivos.ValidarNombreImportado(this.formSectorAnalisis.tbxRuta.Text,"ef_sector.xlsx"))
            {
                formError = new FormError("Advertencia: El nombre del archivo no corresponde al nombre: ef_sector.xlsx");
                formError.ShowDialog();

            }
            
        }
            
        #endregion
    }
}
