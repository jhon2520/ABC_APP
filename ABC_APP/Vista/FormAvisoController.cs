using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_APP.Vista
{
    class FormAvisoController
    {
        private FormAviso formAviso;

        public FormAvisoController(FormAviso formAviso)
        {
            this.formAviso = formAviso;
            Recargas();
        }

        private void Recargas()
        {
            this.formAviso.btnAceptar.Click += new EventHandler(CerrarForm);
        }

        private void CerrarForm(object sender, EventArgs args)
        {
            this.formAviso.Close();
        }
    }
}
