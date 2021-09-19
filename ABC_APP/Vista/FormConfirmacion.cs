using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_APP.Vista
{
    public partial class FormConfirmacion : Form
    {
        public FormConfirmacion(string pregunta)
        {
            InitializeComponent();
            this.lblMensaje.Text = pregunta;
            FormConfirmacionController formConfirmacionController = new FormConfirmacionController(this);
        }
    }
}
