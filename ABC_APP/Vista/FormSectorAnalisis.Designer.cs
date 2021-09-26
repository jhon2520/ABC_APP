
namespace ABC_APP.Vista
{
    partial class FormSectorAnalisis
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
            this.dgImport = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImportar = new System.Windows.Forms.Button();
            this.tbxRuta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgImport
            // 
            this.dgImport.AllowUserToAddRows = false;
            this.dgImport.AllowUserToDeleteRows = false;
            this.dgImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImport.Location = new System.Drawing.Point(38, 30);
            this.dgImport.Name = "dgImport";
            this.dgImport.ReadOnly = true;
            this.dgImport.Size = new System.Drawing.Size(251, 641);
            this.dgImport.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(305, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 1);
            this.panel1.TabIndex = 6;
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(174)))), ((int)(((byte)(152)))));
            this.btnImportar.FlatAppearance.BorderSize = 0;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ForeColor = System.Drawing.Color.White;
            this.btnImportar.Location = new System.Drawing.Point(305, 59);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(162, 26);
            this.btnImportar.TabIndex = 5;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            // 
            // tbxRuta
            // 
            this.tbxRuta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxRuta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxRuta.Location = new System.Drawing.Point(305, 33);
            this.tbxRuta.Name = "tbxRuta";
            this.tbxRuta.Size = new System.Drawing.Size(435, 17);
            this.tbxRuta.TabIndex = 4;
            // 
            // FormSectorAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 724);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.tbxRuta);
            this.Controls.Add(this.dgImport);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSectorAnalisis";
            this.Text = "FormSectorAnalisis";
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnImportar;
        public System.Windows.Forms.TextBox tbxRuta;
        public System.Windows.Forms.DataGridView dgImport;
    }
}