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
    public partial class FormAviso : Form
    {
        public FormAviso(string mensaje)
        {
            InitializeComponent();
            this.lblMensaje.Text = mensaje;
            FormAvisoController formAvisoController = new FormAvisoController(this);
        }
    }
}
