using ABC_APP.Vista;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_APP.logica
{
    class Archivos
    {

        
            

        /// <summary>
        /// Este método crea una carpeta en una ruta específica
        /// </summary>
        public void CrearCarpetaABC(string ruta, string nombreCarpeta)
        {
            
            string completePath = ruta + @"\"+ nombreCarpeta;

            try
            {
                if (!Directory.Exists(completePath))
                {
                    Directory.CreateDirectory(completePath);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        /// <summary>
        /// Metodo usado para copiar un archivo a una carpeta destino
        /// </summary>
        /// <param name="rutaArchivoOrigen"></param>
        public void CopiarArchivo(string rutaArchivoOrigen, string rutaCarpetaDestino)
        {
            FileInfo fileInfo = new FileInfo(rutaArchivoOrigen);
            string rutaCompleta = Path.Combine(rutaCarpetaDestino, fileInfo.Name);
            File.Copy(rutaArchivoOrigen, rutaCompleta, true);
           // MessageBox.Show("Archivo copiado");

        }

        /// <summary>
        /// Método para mostrar una gráfica en un picture box
        /// </summary>
        /// <param name="ruta">Ruta donde está alojada la imagen</param>
        /// <param name="pictureBox">PictureBox donde se mostrará la imagen</param>
        public void MostrarGrafica(string ruta, PictureBox pictureBox)
        {
            pictureBox.Image = Image.FromFile(ruta);
  
        }

        public void CopiarToClipBoard(string texto)
        {
            Clipboard.SetText(texto);
        }

    }
}
