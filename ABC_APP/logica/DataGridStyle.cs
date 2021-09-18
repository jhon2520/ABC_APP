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

    }
}
