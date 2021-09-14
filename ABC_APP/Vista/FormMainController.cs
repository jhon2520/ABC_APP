using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_APP.Vista
{
    class FormMainController
    {

        private FormMain formMain;

        public FormMainController(FormMain formMain)
        {
            this.formMain = formMain;
            Prueba();
        }

        private void Prueba()
        {
            //this.formMain.btnPrueba.Click += new EventHandler(MostrarMensaje);
        }

        private void MostrarMensaje(object sender, EventArgs args)
        {
            MessageBox.Show("Hola mundo");
        }
    }
}
