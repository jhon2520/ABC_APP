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
        private Archivos archivos = new Archivos();


        public void ImportarExcelOpenFile(DataGridView dataGridView, string nombreHoja, string rutaArchivo,TextBox textBox)
        {
            string ruta = "";
            string pathC = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string completePath = pathC + @"\archivosABC";

            try 
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files |*.xlsx";
                openFileDialog.Title = "Selecciones el archivo de excel";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ruta = openFileDialog.FileName;
                    rutaArchivo = ruta;
                    textBox.Text = ruta;
                     
                }
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                adapter = new OleDbDataAdapter("Select * from [" + nombreHoja + "$]", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;


                //copiar archivo a la carpeta
                archivos.CopiarArchivo(rutaArchivo, completePath);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ImportarExcelDeRuta(DataGridView dataGridView, string nombreHoja, string rutaArchivo)
        {
            string ruta = "";

            try
            {

                ruta = rutaArchivo;
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
