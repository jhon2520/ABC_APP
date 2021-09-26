using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_APP.logica;
using ABC_APP.VistaModuloPython;

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
        private FormVerCodigoPython formVerCodigoPython;
        private FormError formError;


        public FormMainController(FormMain formMain)
        {
            this.formMain = formMain;
            Recargas();
            this.formMain.jrDropDownMenu1.IsMainMenu = true;
            this.formMain.jrDropDownMenuSistema.IsMainMenu = true;
        }

        private void Recargas()
        {
            this.formMain.btnClose.Click += new EventHandler(CerrarForm);
            this.formMain.analisisHorizontalToolStripMenuItem.Click += new EventHandler(AbrirFormHorizontal);
            this.formMain.analizarToolStripMenuItem.Click += new EventHandler(AbrirFormSector);
            this.formMain.compilarArchivoSupersolidariaToolStripMenuItem.Click += new EventHandler(AbrirFormCompilar);
            this.formMain.compilarArchivosToolStripMenuItem.Click += new EventHandler(AbrirCodigoPythonCompilar);
            this.formMain.btnReturn.Click += new EventHandler(CerrarFormActivo);
            this.formMain.btnAnalisisFinanciero.Click += new EventHandler(BtnAnalisisFinanciero);
            this.formMain.btnSistema.Click += new EventHandler(BtnSistema);
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
       
        private void LeerCodigoPythonCompilar(string titulo, string nombreArchivo)
        {
            if (formComportamiento.activeForm != null)
            {
                using (formConfirmacion = new FormConfirmacion("¿Desea cambiar de ventana reiniciar la actual?"))
                {
                    DialogResult result = formConfirmacion.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        formVerCodigoPython = new FormVerCodigoPython(titulo,nombreArchivo);
                        formComportamiento.AbrirFormHijo(formVerCodigoPython, this.formMain.pnlCentral);

                    }
                }
            }
            else
            {
                formVerCodigoPython = new FormVerCodigoPython(titulo, nombreArchivo);
                formComportamiento.AbrirFormHijo(formVerCodigoPython, this.formMain.pnlCentral);
            }
            //compilarArchivosToolStripMenuItem
        }

        private void AbrirCodigoPythonCompilar(object sender, EventArgs args)
        {
            try
            {
                string currentDomain = AppDomain.CurrentDomain.BaseDirectory + @"VistaModuloPython\";
                LeerCodigoPythonCompilar("Codigo para compilar archivo SuperSolidaria", File.ReadAllText(currentDomain + "codigo_compilar_archivos.txt"));
            }
            catch (Exception ex)
            {
                formError = new FormError(ex.ToString());
                formError.ShowDialog();
            }
        
        }


        private void BtnAnalisisFinanciero(object sender, EventArgs args)
        {
            this.formMain.jrDropDownMenu1.Show(this.formMain.btnAnalisisFinanciero, this.formMain.btnAnalisisFinanciero.Width,0);
        }
        private void BtnSistema(object sender, EventArgs args)
        {
            this.formMain.jrDropDownMenuSistema.Show(this.formMain.btnSistema, this.formMain.btnSistema.Width, 0);
        }




    }
}
