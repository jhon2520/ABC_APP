using ABC_APP.logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_APP.Vista
{
    class FormSectorController
    {
        private FormSectorAnalisis formSectorAnalisis;
        private DataGridStyle dataGridStyle = new DataGridStyle();

        public FormSectorController(FormSectorAnalisis formSectorAnalisis)
        {
            this.formSectorAnalisis = formSectorAnalisis;
            dataGridStyle.DataGridGetStyle(new List<DataGridView>() { this.formSectorAnalisis.dgImport});
        }
    }
}
