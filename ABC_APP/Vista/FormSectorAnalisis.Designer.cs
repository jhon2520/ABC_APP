
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
            this.pbxAyuda = new System.Windows.Forms.PictureBox();
            this.btnPython = new System.Windows.Forms.Button();
            this.btnSobreescribirGrid = new System.Windows.Forms.Button();
            this.btnAlertas = new System.Windows.Forms.Button();
            this.cbxAlertas = new System.Windows.Forms.ComboBox();
            this.contadorAlertas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAyuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contadorAlertas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgImport
            // 
            this.dgImport.AllowUserToAddRows = false;
            this.dgImport.AllowUserToDeleteRows = false;
            this.dgImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImport.Location = new System.Drawing.Point(39, 30);
            this.dgImport.Name = "dgImport";
            this.dgImport.ReadOnly = true;
            this.dgImport.Size = new System.Drawing.Size(690, 336);
            this.dgImport.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(39, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 1);
            this.panel1.TabIndex = 6;
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(174)))), ((int)(((byte)(152)))));
            this.btnImportar.FlatAppearance.BorderSize = 0;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ForeColor = System.Drawing.Color.White;
            this.btnImportar.Location = new System.Drawing.Point(550, 372);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(147, 26);
            this.btnImportar.TabIndex = 5;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            // 
            // tbxRuta
            // 
            this.tbxRuta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxRuta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxRuta.Location = new System.Drawing.Point(39, 376);
            this.tbxRuta.Name = "tbxRuta";
            this.tbxRuta.Size = new System.Drawing.Size(505, 17);
            this.tbxRuta.TabIndex = 4;
            // 
            // pbxAyuda
            // 
            this.pbxAyuda.Image = global::ABC_APP.Properties.Resources.question2;
            this.pbxAyuda.Location = new System.Drawing.Point(703, 372);
            this.pbxAyuda.Name = "pbxAyuda";
            this.pbxAyuda.Size = new System.Drawing.Size(26, 26);
            this.pbxAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAyuda.TabIndex = 14;
            this.pbxAyuda.TabStop = false;
            // 
            // btnPython
            // 
            this.btnPython.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(18)))), ((int)(((byte)(129)))));
            this.btnPython.FlatAppearance.BorderSize = 0;
            this.btnPython.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPython.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPython.ForeColor = System.Drawing.Color.White;
            this.btnPython.Location = new System.Drawing.Point(39, 420);
            this.btnPython.Name = "btnPython";
            this.btnPython.Size = new System.Drawing.Size(213, 26);
            this.btnPython.TabIndex = 15;
            this.btnPython.Text = "Ejecutar Python";
            this.btnPython.UseVisualStyleBackColor = false;
            // 
            // btnSobreescribirGrid
            // 
            this.btnSobreescribirGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(18)))), ((int)(((byte)(129)))));
            this.btnSobreescribirGrid.FlatAppearance.BorderSize = 0;
            this.btnSobreescribirGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobreescribirGrid.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobreescribirGrid.ForeColor = System.Drawing.Color.White;
            this.btnSobreescribirGrid.Location = new System.Drawing.Point(252, 420);
            this.btnSobreescribirGrid.Name = "btnSobreescribirGrid";
            this.btnSobreescribirGrid.Size = new System.Drawing.Size(213, 26);
            this.btnSobreescribirGrid.TabIndex = 15;
            this.btnSobreescribirGrid.Text = "Sobreescribir Datos";
            this.btnSobreescribirGrid.UseVisualStyleBackColor = false;
            // 
            // btnAlertas
            // 
            this.btnAlertas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(18)))), ((int)(((byte)(129)))));
            this.btnAlertas.FlatAppearance.BorderSize = 0;
            this.btnAlertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlertas.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertas.ForeColor = System.Drawing.Color.White;
            this.btnAlertas.Location = new System.Drawing.Point(465, 420);
            this.btnAlertas.Name = "btnAlertas";
            this.btnAlertas.Size = new System.Drawing.Size(213, 26);
            this.btnAlertas.TabIndex = 15;
            this.btnAlertas.Text = "Hallar Alertas";
            this.btnAlertas.UseVisualStyleBackColor = false;
            // 
            // cbxAlertas
            // 
            this.cbxAlertas.BackColor = System.Drawing.Color.White;
            this.cbxAlertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAlertas.ForeColor = System.Drawing.Color.DimGray;
            this.cbxAlertas.FormattingEnabled = true;
            this.cbxAlertas.Location = new System.Drawing.Point(39, 465);
            this.cbxAlertas.Name = "cbxAlertas";
            this.cbxAlertas.Size = new System.Drawing.Size(690, 27);
            this.cbxAlertas.TabIndex = 16;
            // 
            // contadorAlertas
            // 
            this.contadorAlertas.BackColor = System.Drawing.Color.White;
            this.contadorAlertas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contadorAlertas.Enabled = false;
            this.contadorAlertas.ForeColor = System.Drawing.Color.DimGray;
            this.contadorAlertas.Location = new System.Drawing.Point(684, 422);
            this.contadorAlertas.Name = "contadorAlertas";
            this.contadorAlertas.ReadOnly = true;
            this.contadorAlertas.Size = new System.Drawing.Size(45, 20);
            this.contadorAlertas.TabIndex = 17;
            // 
            // FormSectorAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 724);
            this.Controls.Add(this.contadorAlertas);
            this.Controls.Add(this.cbxAlertas);
            this.Controls.Add(this.btnAlertas);
            this.Controls.Add(this.btnSobreescribirGrid);
            this.Controls.Add(this.btnPython);
            this.Controls.Add(this.pbxAyuda);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxAyuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contadorAlertas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnImportar;
        public System.Windows.Forms.TextBox tbxRuta;
        public System.Windows.Forms.DataGridView dgImport;
        public System.Windows.Forms.PictureBox pbxAyuda;
        public System.Windows.Forms.Button btnPython;
        public System.Windows.Forms.Button btnSobreescribirGrid;
        public System.Windows.Forms.Button btnAlertas;
        public System.Windows.Forms.ComboBox cbxAlertas;
        public System.Windows.Forms.NumericUpDown contadorAlertas;
    }
}