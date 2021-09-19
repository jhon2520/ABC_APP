using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_APP.logica
{
    class DataGridCellFormat
    {

        public DataGridView dataGrid { get; set; }
        /// <summary>
        /// Este método dará un formato específico las celdas de un datagrid que cumplan una condición
        /// </summary>
        public void DataGridFormat(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(this.dataGrid.Columns[e.ColumnIndex].Name == "2020")
            {

                try
                {
                    if(e.Value != null)
                    {
                        //las condiciones deben estar anidadas 
                        if (Convert.ToInt32(e.Value) <= 100000)
                        {
                            e.CellStyle.ForeColor = Color.Red;
                            e.CellStyle.BackColor = Color.Orange;

                            if (Convert.ToInt32(e.Value) <= 1000)
                            {
                                e.CellStyle.ForeColor = Color.White;
                                e.CellStyle.BackColor = Color.Green;
                            }

                        }
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

          

            }
        }


    }
}
