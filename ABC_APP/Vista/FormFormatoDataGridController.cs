using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_APP.Vista
{
    class FormFormatoDataGridController
    {
        private FormFormatoDataGrid formFormato;
        private FormConfirmacion formConfirmacion;

        public FormFormatoDataGridController(FormFormatoDataGrid formFormato)
        {
            this.formFormato = formFormato;
            Recargas();
            GetDefaultColors();
        }

        private void Recargas()
        {
            this.formFormato.btnCambiarFondo.Click += new EventHandler(CambiarFondo);
            this.formFormato.BtnCambiarColorLetra.Click += new EventHandler(CambiarFuente);
            this.formFormato.btnClose.Click += new EventHandler(CerrarForm);
            this.formFormato.btnAceptar.Click += new EventHandler(AceptarCambios);
        }

        private void GetDefaultColors()
        {
            this.formFormato.tbxTextoMuestra.BackColor = CacheData.Cache.ColorFondo;
            this.formFormato.tbxTextoMuestra.ForeColor = CacheData.Cache.ColorLetra;
        }

        private void CambiarFondo(object sender,EventArgs args)
        {
            DialogResult result = this.formFormato.colorDialogFondo.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.formFormato.tbxTextoMuestra.BackColor = this.formFormato.colorDialogFondo.Color;
            }

        }
        private void CambiarFuente(object sender, EventArgs args)
        {
            DialogResult result = this.formFormato.colorDialogFondo.ShowDialog();
            if (result == DialogResult.OK)
            {             
                this.formFormato.tbxTextoMuestra.ForeColor = this.formFormato.colorDialogFondo.Color;
            }
        }

        private void CerrarForm(object sender, EventArgs args)
        {
            this.formFormato.Close();
        }

        private void AceptarCambios(object sender, EventArgs args)
        {
            using (formConfirmacion = new FormConfirmacion("¿Desea guardar los cambios de formato?"))
            {
                DialogResult result = formConfirmacion.ShowDialog();
                if (result == DialogResult.OK)
                {
                    SetDefaultColors();
                    this.formFormato.Close();
                }
          
            }
          
        }

        private void SetDefaultColors()
        {
            CacheData.Cache.ColorFondo = this.formFormato.tbxTextoMuestra.BackColor;
            CacheData.Cache.ColorLetra = this.formFormato.tbxTextoMuestra.ForeColor;
        }

    }
}
