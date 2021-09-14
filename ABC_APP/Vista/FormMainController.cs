using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_APP.logica;

namespace ABC_APP.Vista
{
    class FormMainController
    {

        private FormMain formMain;
        private FormComportamiento formComportamiento = new FormComportamiento();
        private FormHorizontalAnalisis formHorizontalAnalisis;
        private FormSectorAnalisis formSectorAnalisis;


        public FormMainController(FormMain formMain)
        {
            this.formMain = formMain;
            Recargas();
        }

        private void Recargas()
        {
            this.formMain.btnClose.Click += new EventHandler(CerrarForm);
            this.formMain.btnHorizontal.Click += new EventHandler(AbrirFormHorizontal);
            this.formMain.btnSector.Click += new EventHandler(AbrirFormSector);
            this.formMain.btnReturn.Click += new EventHandler(CerrarFormActivo);

        }

        private void MostrarMensaje(object sender, EventArgs args)
        {
            MessageBox.Show("Hola mundo");
        }

        private void CerrarForm(object sender, EventArgs args)
        {
            Application.Exit();
        }

        private void AbrirFormHorizontal(object sender, EventArgs args)
        {
            //TODO: Crear form para confirmar cambio
            formHorizontalAnalisis = new FormHorizontalAnalisis();
            formComportamiento.AbrirFormHijo(formHorizontalAnalisis, this.formMain.pnlCentral);
            

        }
        private void AbrirFormSector(object sender, EventArgs args)
        {
            //TODO: Crear form para confirmar cambio
            formSectorAnalisis = new FormSectorAnalisis();
            formComportamiento.AbrirFormHijo(formSectorAnalisis, this.formMain.pnlCentral);
           
            
        }

        private void CerrarFormActivo(object sender, EventArgs args)
        {
            if (formComportamiento.activeForm != null) { formComportamiento.activeForm.Close(); }
        }


    }
}
