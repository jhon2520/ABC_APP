using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_APP.logica
{
    class FormComportamiento
    {
        public Form activeForm = null;

        public void AbrirFormHijo(Form form, Panel panel)
        {
            if (activeForm != null) { activeForm.Close(); }

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            panel.Tag = form;
            form.BringToFront();
            form.Show();

        }

    }
}
