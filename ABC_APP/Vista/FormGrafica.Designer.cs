
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
            this.btnGuardarGrafica = new System.Windows.Forms.Button();
            this.pbxGrafica = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrafica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarGrafica
            // 
            this.btnGuardarGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarGrafica.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarGrafica.BackgroundImage = global::ABC_APP.Properties.Resources.export_img;
            this.btnGuardarGrafica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarGrafica.FlatAppearance.BorderSize = 0;
            this.btnGuardarGrafica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarGrafica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarGrafica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarGrafica.Location = new System.Drawing.Point(910, 541);
            this.btnGuardarGrafica.Name = "btnGuardarGrafica";
            this.btnGuardarGrafica.Size = new System.Drawing.Size(40, 40);
            this.btnGuardarGrafica.TabIndex = 1;
            this.btnGuardarGrafica.UseVisualStyleBackColor = false;
            // 
            // pbxGrafica
            // 
            this.pbxGrafica.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbxGrafica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxGrafica.ErrorImage = global::ABC_APP.Properties.Resources.no_imagen;
            this.pbxGrafica.Location = new System.Drawing.Point(0, 0);
            this.pbxGrafica.MinimumSize = new System.Drawing.Size(635, 390);
            this.pbxGrafica.Name = "pbxGrafica";
            this.pbxGrafica.Size = new System.Drawing.Size(955, 585);
            this.pbxGrafica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGrafica.TabIndex = 0;
            this.pbxGrafica.TabStop = false;
            // 
            // FormGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 585);
            this.Controls.Add(this.btnGuardarGrafica);
            this.Controls.Add(this.pbxGrafica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGrafica";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrafica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pbxGrafica;
        public System.Windows.Forms.Button btnGuardarGrafica;
    }
}