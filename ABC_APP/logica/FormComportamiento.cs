using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_APP.logica
{
    class FormComportamiento
    {
        public Form activeForm = null;
        public Form dragedForm;

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
        public void BackGroundFormOpacity(Form formEmergente, Form formBase)
        {
            /*
             Nota: el formulario que se va a mostrar encima, en este caso, FormAviso, debe tener las propiedades siguientes

            startposition = centerScreen
            TopMost = true
             
             */
            Form formBG = new Form();
            using (formEmergente = new Form())
            {
                formBG.StartPosition = FormStartPosition.Manual;
                formBG.FormBorderStyle = FormBorderStyle.None;
                formBG.Opacity = 0.7d;
                formBG.BackColor = Color.Black;
                formBG.WindowState = FormWindowState.Maximized;
                formBG.TopMost = true;
                formBG.Location = formBase.Location;
                formBG.ShowInTaskbar = false;
                formBG.Show();

                formEmergente.Owner = formBG;
                formEmergente.ShowDialog();
                formBG.Dispose();

            }
        }


    }
}
