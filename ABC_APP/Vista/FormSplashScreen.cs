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
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (circleBar.Value <100)
            {
                this.circleBar.Value++;
                if (circleBar.Value > 0 && circleBar.Value <= 35)
                {
                    circleBar.ProgressColor = Color.Aqua;
                }
                if (circleBar.Value > 35 && circleBar.Value <= 90)
                {
                    circleBar.ProgressColor = Color.PaleGreen;
                }
                if (circleBar.Value >90)
                {
                    circleBar.ProgressColor = Color.Gold;
                }


            }

            if (circleBar.Value ==100)
            {
                this.timer1.Stop();

                using (FormMain formMain = new FormMain())
                {
                    this.Visible = false ;
                    formMain.ShowDialog();
                }
                
            }
        }
    }
}
