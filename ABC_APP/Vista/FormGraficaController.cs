using ABC_APP.logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_APP.Vista
{
    class FormGraficaController
    {
        private FormGrafica formGrafica;
        private Archivos archivos = new Archivos();
        private FormError formError;

        public FormGraficaController(FormGrafica formGrafica)
        {
            this.formGrafica = formGrafica;
            Sobrecargas();
        }

        public void Sobrecargas()
        {
            this.formGrafica.Load += new EventHandler(AbrirForm);
        }

        public void AbrirForm(object sender, EventArgs args)
        {
            //TODO: Crear método abstracto para esto con un try catch

            try
            {
                this.formGrafica.pbxGrafica.Image = Image.FromFile(@"C:\Users\Jhon Romero\archivosABC\Grafica.png");
            }
            catch (Exception ex)
            {
                formError = new FormError(ex.ToString());
                formError.ShowDialog();
            }

        }
    }
}
