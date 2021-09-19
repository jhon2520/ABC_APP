using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_APP.Vista
{
    class FormErrorController
    {
        private FormError formError;

        public FormErrorController(FormError formError)
        {
            this.formError = formError;
            Recargas();
        }

        private void Recargas()
        {
            this.formError.btnAceptar.Click += new EventHandler(CerrarForm);
        }

        private void CerrarForm(object sender, EventArgs args)
        {
            this.formError.Close();
        }
    }
}
