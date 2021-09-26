
namespace ABC_APP.VistaModuloPython
{
    partial class FormVerCodigoPython
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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.RichTextBox();
            this.btnCopiarCodigo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.elipseTbx = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(36, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(697, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.tbxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCodigo.ForeColor = System.Drawing.Color.White;
            this.tbxCodigo.Location = new System.Drawing.Point(34, 73);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.ReadOnly = true;
            this.tbxCodigo.Size = new System.Drawing.Size(701, 586);
            this.tbxCodigo.TabIndex = 1;
            this.tbxCodigo.Text = "";
            // 
            // btnCopiarCodigo
            // 
            this.btnCopiarCodigo.BackgroundImage = global::ABC_APP.Properties.Resources.copy;
            this.btnCopiarCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopiarCodigo.FlatAppearance.BorderSize = 0;
            this.btnCopiarCodigo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCopiarCodigo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCopiarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiarCodigo.Location = new System.Drawing.Point(700, 665);
            this.btnCopiarCodigo.Name = "btnCopiarCodigo";
            this.btnCopiarCodigo.Size = new System.Drawing.Size(35, 35);
            this.btnCopiarCodigo.TabIndex = 2;
            this.btnCopiarCodigo.Text = "Copiar codigo";
            this.btnCopiarCodigo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(33, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 1);
            this.panel1.TabIndex = 3;
            // 
            // elipseTbx
            // 
            this.elipseTbx.ElipseRadius = 4;
            this.elipseTbx.TargetControl = this.tbxCodigo;
            // 
            // FormVerCodigoPython
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 724);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCopiarCodigo);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormVerCodigoPython";
            this.Text = "FormVerCodigoPython";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.RichTextBox tbxCodigo;
        public System.Windows.Forms.Button btnCopiarCodigo;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse elipseTbx;
    }
}