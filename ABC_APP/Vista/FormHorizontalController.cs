using ABC_APP.logica;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_APP.Vista
{
    class FormHorizontalController
    {
        private FormHorizontalAnalisis formHorizontalAnalisis;
        private ImportExcel importExcel;
        private DataGridStyle dataGridStyle = new DataGridStyle();
        private DataGridCellFormat gridCellFormat = new DataGridCellFormat();

        public FormHorizontalController(FormHorizontalAnalisis formHorizontalAnalisis)
        {
            this.formHorizontalAnalisis = formHorizontalAnalisis;
            dataGridStyle.DataGridGetStyle(this.formHorizontalAnalisis.dgImport);
            Recargas();
        }

        private void Recargas()
        {
            this.formHorizontalAnalisis.btnImportar.Click += new EventHandler(Prueba);
            this.formHorizontalAnalisis.btnFormato.Click += new EventHandler(DataGridCellFormating);
        }


        private void Prueba(object sender, EventArgs args)
        {
            importExcel = new ImportExcel();
            importExcel.ImportarExcel(this.formHorizontalAnalisis.dgImport, "Hoja1",this.formHorizontalAnalisis.tbxRuta);

        }
        private void DataGridCellFormating(object sender, EventArgs args)
        {
            gridCellFormat.dataGrid = this.formHorizontalAnalisis.dgImport; 
            this.formHorizontalAnalisis.dgImport.CellFormatting += new DataGridViewCellFormattingEventHandler(gridCellFormat.DataGridFormat);
        }

    }
}
