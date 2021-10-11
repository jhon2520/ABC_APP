using ABC_APP.logica;
using ABC_APP.Vista;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_APP.VistaModuloPython
{
    class FormVerCodigoPythonController
    {
        private FormVerCodigoPython formVerCodigo;
        string currentDomain = AppDomain.CurrentDomain.BaseDirectory + @"VistaModuloPython\";
        private FormError formError;
        private FormAviso formAviso;
        private Archivos archivos = new Archivos();

        public FormVerCodigoPythonController(FormVerCodigoPython formVerCodigo)
        {
            this.formVerCodigo = formVerCodigo;
            Recargas();
        }

        private void Recargas()
        {
           // compararSupersociedadesToolStripMenuItem
            this.formVerCodigo.btnCopiarCodigo.Click += new EventHandler(CopiarCodigoToClipBoard);
        }

        private void CopiarCodigoToClipBoard(object sender, EventArgs args)
        {
            if (this.formVerCodigo.tbxCodigo.Text != string.Empty)
            {
                try
                {
                    using (formAviso = new FormAviso("Codigo copiado"))
                    {
                        archivos.CopiarToClipBoard(this.formVerCodigo.tbxCodigo.Text);
                        formAviso.ShowDialog();

                    }

                }
                catch (Exception e)
                {

                    using (formError = new FormError(e.ToString()))
                    {
                        formError.ShowDialog();
                    }
                }
            }
 
        }
    }
}
