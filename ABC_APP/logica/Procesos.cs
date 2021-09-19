using ABC_APP.Vista;
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

        private FormAviso formAviso;
        /// <summary>
        /// Método usado para ejecutar un archivo .exe en una ruta especificada
        /// </summary>
        /// <param name="ruta">Ruta donde se aloja el archivo .exe</param>
        public void EjecutarProceso(string ruta)
        {
            //System.Diagnostics.Process.Start(ruta);
            formAviso = new FormAviso("Espere mientras el archivo python es ejecutado (esto puede tardar un momento)");

            System.Diagnostics.Process process = new System.Diagnostics.Process
            {
                StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = ruta
                }
            };
            process.Start();

            formAviso.ShowDialog();
            formAviso = new FormAviso("El proceso a terminado, gracias por la espera");
            process.WaitForExit();
            formAviso.ShowDialog();


        }
    }
}
