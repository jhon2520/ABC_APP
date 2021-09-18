
namespace ABC_APP.Vista
{
    partial class FormGrafica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxGrafica = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrafica)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxGrafica
            // 
            this.pbxGrafica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxGrafica.ErrorImage = global::ABC_APP.Properties.Resources.no_imagen;
            this.pbxGrafica.Location = new System.Drawing.Point(0, 0);
            this.pbxGrafica.Name = "pbxGrafica";
            this.pbxGrafica.Size = new System.Drawing.Size(842, 535);
            this.pbxGrafica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGrafica.TabIndex = 0;
            this.pbxGrafica.TabStop = false;
            // 
            // FormGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 535);
            this.Controls.Add(this.pbxGrafica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGrafica";
            this.Text = "FormGrafica";
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrafica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pbxGrafica;
    }
}