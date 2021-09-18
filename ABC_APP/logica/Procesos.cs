using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ABC_APP.logica
{
    class Procesos
    {
        /// <summary>
        /// Método usado para ejecutar un archivo .exe en una ruta especificada
        /// </summary>
        /// <param name="ruta">Ruta donde se aloja el archivo .exe</param>
        public void EjecutarProceso(string ruta)
        {
            //System.Diagnostics.Process.Start(ruta);

            System.Diagnostics.Process process = new System.Diagnostics.Process
            {
                StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = ruta
                }
            };
            process.Start();
            MessageBox.Show("Iniciando proceso");
            process.WaitForExit();
            MessageBox.Show("proceso terminado");


        }
    }
}
