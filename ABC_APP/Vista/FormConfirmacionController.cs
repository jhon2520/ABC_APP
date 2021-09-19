using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_APP.Vista
{
    class FormConfirmacionController
    {
        private FormConfirmacion formConfirmacion;

        public FormConfirmacionController(FormConfirmacion formConfirmacion)
        {
            this.formConfirmacion = formConfirmacion;
            Recargas();
        }
        private void Recargas()
        {
            this.formConfirmacion.btnAceptar.Click += new EventHandler(BtnConfirmar);
            this.formConfirmacion.btnCancelar.Click += new EventHandler(BtnCancelar);

        }
        private void BtnConfirmar(object sender, EventArgs args)
        {
            this.formConfirmacion.DialogResult = DialogResult.OK;
        }
        private void BtnCancelar(object sender, EventArgs args)
        {
            this.formConfirmacion.DialogResult = DialogResult.Cancel;
        }
    }
}
