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
    public partial class FormGrafica : Form
    {
        public FormGrafica(string nombreGrafica)
        {
            InitializeComponent();
            FormGraficaController formGrafica = new FormGraficaController(this,nombreGrafica);
        }
    }
}
