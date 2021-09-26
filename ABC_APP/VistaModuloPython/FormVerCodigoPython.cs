using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_APP.VistaModuloPython
{
    public partial class FormVerCodigoPython : Form
    {
        public FormVerCodigoPython(string titulo, string archivoNombre)
        {
            InitializeComponent();
            this.lblTitulo.Text = titulo;
            this.tbxCodigo.Text = archivoNombre;
            FormVerCodigoPythonController formVerCodigoPythonController = new FormVerCodigoPythonController(this);
        }
    }
}
