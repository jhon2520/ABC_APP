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
        public void DataGridGetStyle(DataGridView dataGridView)
        {
            dataGridView.BackgroundColor = Color.FromArgb(45, 65, 91);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 65, 91);
            dataGridView.RowsDefaultCellStyle.Font = new Font("poppins",8);
            dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dataGridView.RowsDefaultCellStyle.ForeColor = Color.White;
            dataGridView.GridColor = Color.SteelBlue;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3,101,202);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ColumnHeadersHeight = 30;
            dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 65, 91);
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AllowUserToResizeRows = false;
            //dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

    }
}
