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
        public void DataGridGetStyle(List<DataGridView> dataGridViews)
        {
            foreach (var item in dataGridViews)
            {
                item.BackgroundColor = Color.FromArgb(45, 65, 91);
                item.BorderStyle = BorderStyle.None;
                item.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 65, 91);
                item.RowsDefaultCellStyle.Font = new Font("poppins", 8);
                item.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
                item.RowsDefaultCellStyle.ForeColor = Color.White;
                item.GridColor = Color.SteelBlue;
                item.EnableHeadersVisualStyles = false;
                item.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 101, 202);
                item.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                item.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                item.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                item.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                item.ColumnHeadersHeight = 30;
                item.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 65, 91);
                item.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                item.RowHeadersVisible = false;
                item.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                item.AllowUserToResizeRows = false;

            }

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
