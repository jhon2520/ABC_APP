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
        public List<string> columnas = new List<string>();


        /// <summary>
        /// Este método dará un formato específico las celdas de un datagrid que cumplan una condición
        /// </summary>
        public void LimpiarFormateoDeCeldas(object sender, DataGridViewCellFormattingEventArgs e)
        {

            foreach (string item in columnas)
            {
                if (this.dataGrid.Columns[e.ColumnIndex].Name == item)
                {

                    try
                    {
                        if (e.Value != null && e.Value.ToString() != string.Empty)
                        {
                            //las condiciones deben estar anidadas 
                            if (Convert.ToInt32(e.Value) >= CacheData.Cache.ValorCeldaFormato)
                            {
                                e.CellStyle.ForeColor = Color.White;
                                e.CellStyle.BackColor = Color.FromArgb(45, 65, 91);

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


        public void EjecutarFormateoDeCeldas(object sender, DataGridViewCellFormattingEventArgs e)
        {
     
            foreach (string item in columnas)
            {
                if (this.dataGrid.Columns[e.ColumnIndex].Name == item)
                {
         
                    try
                    {
                        if (e.Value != null && e.Value.ToString() != string.Empty)
                        {
                            //las condiciones deben estar anidadas 
                            if (Convert.ToInt32(e.Value) >= CacheData.Cache.ValorCeldaFormato)
                            {
                                e.CellStyle.ForeColor = CacheData.Cache.ColorLetra;
                                e.CellStyle.BackColor = CacheData.Cache.ColorFondo;

                                //if (Convert.ToInt32(e.Value) <= 1000)
                                //{
                                //    e.CellStyle.ForeColor = Color.White;
                                //    e.CellStyle.BackColor = Color.Green;
                                //}

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
        public void EjecutarFormateoDeAlertas(object sender, DataGridViewCellFormattingEventArgs e)
        {

                if (this.dataGrid.Columns[e.ColumnIndex].Name == "Alertas")
                {

                    try
                    {
                        if (e.Value != null && e.Value.ToString() != string.Empty)
                        {
                            //las condiciones deben estar anidadas 
                            if (Convert.ToInt32(e.Value) > 0)
                            {
                                e.CellStyle.ForeColor = Color.White;
                                e.CellStyle.BackColor = Color.Red;
                                

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
