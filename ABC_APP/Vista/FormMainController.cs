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
        private FormConfirmacion formConfirmacion;
        private FormCompiladorSuperSociedades formCompilador;


        public FormMainController(FormMain formMain)
        {
            this.formMain = formMain;
            Recargas();
            this.formMain.jrDropDownMenu1.IsMainMenu = true;
        }

        private void Recargas()
        {
            this.formMain.btnClose.Click += new EventHandler(CerrarForm);
            this.formMain.analisisHorizontalToolStripMenuItem.Click += new EventHandler(AbrirFormHorizontal);
            this.formMain.analizarToolStripMenuItem.Click += new EventHandler(AbrirFormSector);
            this.formMain.compilarArchivoSupersolidariaToolStripMenuItem.Click += new EventHandler(AbrirFormCompilar);
            this.formMain.btnReturn.Click += new EventHandler(CerrarFormActivo);
            this.formMain.btnAnalisisFinanciero.Click += new EventHandler(BtnAnalisisFinanciero);

        }

        private void CerrarForm(object sender, EventArgs args)
        {
            Application.Exit();
        }

        private void AbrirFormHorizontal(object sender, EventArgs args)
        {

            if (formComportamiento.activeForm != null)
            {
                using (formConfirmacion = new FormConfirmacion("¿Desea cambiar de ventana de análisis o reiniciar la actual?"))
                {
                    //TODO: Crear form para confirmar cambio
                    DialogResult result = formConfirmacion.ShowDialog();
                    if (result == DialogResult.OK)
                    {

                        formHorizontalAnalisis = new FormHorizontalAnalisis();
                        formComportamiento.AbrirFormHijo(formHorizontalAnalisis, this.formMain.pnlCentral);
                    }


                }
            }
            else
            {
                formHorizontalAnalisis = new FormHorizontalAnalisis();
                formComportamiento.AbrirFormHijo(formHorizontalAnalisis, this.formMain.pnlCentral);
            }

        }
        private void AbrirFormCompilar(object sender, EventArgs args)
        {
            if (formComportamiento.activeForm != null)
            {
                using (formConfirmacion = new FormConfirmacion("¿Desea cambiar de ventana de análisis o reiniciar la actual?"))
                {
                    DialogResult result = formConfirmacion.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        formCompilador = new FormCompiladorSuperSociedades();
                        formComportamiento.AbrirFormHijo(formCompilador, this.formMain.pnlCentral);

                    }
                }
            }
            else
            { 
                formCompilador = new FormCompiladorSuperSociedades();
                formComportamiento.AbrirFormHijo(formCompilador, this.formMain.pnlCentral);
            }

        }
        //compilarArchivoSupersolidariaToolStripMenuItem
    

        private void AbrirFormSector(object sender, EventArgs args)
        {

            if (formComportamiento.activeForm != null)
            {
                using (formConfirmacion = new FormConfirmacion("¿Desea cambiar de ventana de análisis o reiniciar la actual?"))
                {
                    //TODO: Crear form para confirmar cambio
                    DialogResult result = formConfirmacion.ShowDialog();
                    if (result == DialogResult.OK)
                    {

                        //TODO: Crear form para confirmar cambio
                        formSectorAnalisis = new FormSectorAnalisis();
                        formComportamiento.AbrirFormHijo(formSectorAnalisis, this.formMain.pnlCentral);

                    }


                }
            }
            else
            {
                //TODO: Crear form para confirmar cambio
                formSectorAnalisis = new FormSectorAnalisis();
                formComportamiento.AbrirFormHijo(formSectorAnalisis, this.formMain.pnlCentral);

            }

        }

        private void CerrarFormActivo(object sender, EventArgs args)
        {
            if (formComportamiento.activeForm != null) 
            {
                using (formConfirmacion = new FormConfirmacion("¿Desea volver a la ventana principal? Perderá los cambios que no haya exportado o almacenado"))
                {
                    DialogResult result = formConfirmacion.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        formComportamiento.activeForm.Close();
                        formComportamiento.activeForm = null;
                    }
                }
            }
        }

        private void BtnAnalisisFinanciero(object sender, EventArgs args)
        {
            this.formMain.jrDropDownMenu1.Show(this.formMain.btnAnalisisFinanciero, this.formMain.btnAnalisisFinanciero.Width,0);
        }




    }
}
