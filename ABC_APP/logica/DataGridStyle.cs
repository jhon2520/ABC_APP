using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_APP.logica
{
    class DataGridStyle
    {
        public DataGridView DataGridGetStyle( DataGridView dataGridViews)
        {
            //foreach (var item in dataGridViews)
            //{
                dataGridViews.BackgroundColor = Color.FromArgb(45, 65, 91);
                dataGridViews.BorderStyle = BorderStyle.None;
                dataGridViews.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 65, 91);
                dataGridViews.RowsDefaultCellStyle.Font = new Font("poppins", 8);
                dataGridViews.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
                dataGridViews.RowsDefaultCellStyle.ForeColor = Color.White;
                dataGridViews.GridColor = Color.SteelBlue;
                dataGridViews.EnableHeadersVisualStyles = false;
                dataGridViews.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 101, 202);
                dataGridViews.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViews.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViews.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dataGridViews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dataGridViews.ColumnHeadersHeight = 30;
                dataGridViews.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 65, 91);
                dataGridViews.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dataGridViews.RowHeadersVisible = false;
                dataGridViews.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViews.AllowUserToResizeRows = false;

            //}

            return dataGridViews;

        }

        public void DataGridDecimales(DataGridView dataGridView)
        {
 
            for (int i = 0; i < dataGridView.Columns.Count-1; i++)
            {
                dataGridView.Columns[i + 1].DefaultCellStyle.Format = "N3";
            }
        }
        /// <summary>
        /// Agrega todas las columnas de un Datagrid como item de un combobox
        /// </summary>
        /// <param name="dataGridView">DataGrdi de donde se tomarán los nombres de columnas</param>
        /// <param name="comboBox">Combobox al cual se le agregaran las columnas</param>
        public void GetDataGridColumns(DataGridView dataGridView, ComboBox comboBox)
        {
            for (int i = 0; i < dataGridView.Columns.Count ; i++)
            {
                comboBox.Items.Add(dataGridView.Columns[i].Name);
            }
        }

    }
}
