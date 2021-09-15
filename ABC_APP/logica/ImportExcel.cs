using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ABC_APP.logica
{
    class ImportExcel
    {

        private OleDbConnection conn;
        private OleDbDataAdapter adapter;
        private DataTable dt;


        public void ImportarExcel(DataGridView dataGridView, string nombreHoja, TextBox textBox)
        {
            string ruta = "";

            try 
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files |*.xlsx";
                openFileDialog.Title = "Selecciones el archivo de excel";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ruta = openFileDialog.FileName;
                    textBox.Text = ruta;
                }
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                adapter = new OleDbDataAdapter("Select * from [" + nombreHoja + "$]", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
