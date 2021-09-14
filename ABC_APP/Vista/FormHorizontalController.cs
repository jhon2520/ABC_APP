using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_APP.Vista
{
    class FormHorizontalController
    {
        private FormHorizontalAnalisis formHorizontalAnalisis;

        public FormHorizontalController(FormHorizontalAnalisis formHorizontalAnalisis)
        {
            this.formHorizontalAnalisis = formHorizontalAnalisis;
            Recargas();
        }

        private void Recargas()
        {
            this.formHorizontalAnalisis.btnImportar.Click += new EventHandler(Prueba);
        }

        private void Prueba(object sender, EventArgs args)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Archivos\";
            MessageBox.Show(ruta);
        }

    }
}
