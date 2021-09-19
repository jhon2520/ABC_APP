
namespace ABC_APP.Vista
{
    partial class FormHorizontalAnalisis
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
            this.tbxRuta = new System.Windows.Forms.TextBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnFormato = new System.Windows.Forms.Button();
            this.btnPython = new System.Windows.Forms.Button();
            this.dgExport = new System.Windows.Forms.DataGridView();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbxColumns = new System.Windows.Forms.ComboBox();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.btnFormatoCelda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFormatoCelda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgImport
            // 
            this.dgImport.AllowUserToAddRows = false;
            this.dgImport.AllowUserToDeleteRows = false;
            this.dgImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImport.Location = new System.Drawing.Point(19, 16);
            this.dgImport.Name = "dgImport";
            this.dgImport.ReadOnly = true;
            this.dgImport.Size = new System.Drawing.Size(731, 245);
            this.dgImport.TabIndex = 0;
            // 
            // tbxRuta
            // 
            this.tbxRuta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxRuta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxRuta.Location = new System.Drawing.Point(19, 270);
            this.tbxRuta.Name = "tbxRuta";
            this.tbxRuta.Size = new System.Drawing.Size(544, 17);
            this.tbxRuta.TabIndex = 1;
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(174)))), ((int)(((byte)(152)))));
            this.btnImportar.FlatAppearance.BorderSize = 0;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ForeColor = System.Drawing.Color.White;
            this.btnImportar.Location = new System.Drawing.Point(569, 267);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(181, 26);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            // 
            // btnFormato
            // 
            this.btnFormato.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFormato.FlatAppearance.BorderSize = 0;
            this.btnFormato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormato.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormato.ForeColor = System.Drawing.Color.White;
            this.btnFormato.Location = new System.Drawing.Point(50, 632);
            this.btnFormato.Name = "btnFormato";
            this.btnFormato.Size = new System.Drawing.Size(173, 26);
            this.btnFormato.TabIndex = 2;
            this.btnFormato.Text = "Aplicar Formato";
            this.btnFormato.UseVisualStyleBackColor = false;
            // 
            // btnPython
            // 
            this.btnPython.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(18)))), ((int)(((byte)(129)))));
            this.btnPython.FlatAppearance.BorderSize = 0;
            this.btnPython.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPython.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPython.ForeColor = System.Drawing.Color.White;
            this.btnPython.Location = new System.Drawing.Point(19, 305);
            this.btnPython.Name = "btnPython";
            this.btnPython.Size = new System.Drawing.Size(173, 26);
            this.btnPython.TabIndex = 2;
            this.btnPython.Text = "Ejecutar Python";
            this.btnPython.UseVisualStyleBackColor = false;
            // 
            // dgExport
            // 
            this.dgExport.AllowUserToAddRows = false;
            this.dgExport.AllowUserToDeleteRows = false;
            this.dgExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExport.Location = new System.Drawing.Point(19, 337);
            this.dgExport.Name = "dgExport";
            this.dgExport.ReadOnly = true;
            this.dgExport.Size = new System.Drawing.Size(731, 289);
            this.dgExport.TabIndex = 0;
            // 
            // btnGrafica
            // 
            this.btnGrafica.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGrafica.FlatAppearance.BorderSize = 0;
            this.btnGrafica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafica.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafica.ForeColor = System.Drawing.Color.White;
            this.btnGrafica.Location = new System.Drawing.Point(91, 664);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(173, 26);
            this.btnGrafica.TabIndex = 2;
            this.btnGrafica.Text = "Ver Grafica";
            this.btnGrafica.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(19, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 1);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(196, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aquí podrá ejectuar el código de python para iniciar el análisis.";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.DimGray;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(243, 637);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 21);
            this.numericUpDown1.TabIndex = 5;
            // 
            // cbxColumns
            // 
            this.cbxColumns.FormattingEnabled = true;
            this.cbxColumns.Location = new System.Drawing.Point(322, 633);
            this.cbxColumns.Name = "cbxColumns";
            this.cbxColumns.Size = new System.Drawing.Size(121, 27);
            this.cbxColumns.TabIndex = 7;
            // 
            // btnPrueba
            // 
            this.btnPrueba.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrueba.FlatAppearance.BorderSize = 0;
            this.btnPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrueba.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrueba.ForeColor = System.Drawing.Color.White;
            this.btnPrueba.Location = new System.Drawing.Point(526, 637);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(173, 26);
            this.btnPrueba.TabIndex = 2;
            this.btnPrueba.Text = "Prueba";
            this.btnPrueba.UseVisualStyleBackColor = false;
            // 
            // btnFormatoCelda
            // 
            this.btnFormatoCelda.Image = global::ABC_APP.Properties.Resources.colors;
            this.btnFormatoCelda.Location = new System.Drawing.Point(19, 633);
            this.btnFormatoCelda.Name = "btnFormatoCelda";
            this.btnFormatoCelda.Size = new System.Drawing.Size(25, 25);
            this.btnFormatoCelda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFormatoCelda.TabIndex = 8;
            this.btnFormatoCelda.TabStop = false;
            // 
            // FormHorizontalAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(769, 724);
            this.Controls.Add(this.btnFormatoCelda);
            this.Controls.Add(this.cbxColumns);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPython);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.btnFormato);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.tbxRuta);
            this.Controls.Add(this.dgExport);
            this.Controls.Add(this.dgImport);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(769, 724);
            this.MinimumSize = new System.Drawing.Size(769, 724);
            this.Name = "FormHorizontalAnalisis";
            this.Text = "FormHorizontalAnalisis";
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFormatoCelda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnImportar;
        public System.Windows.Forms.TextBox tbxRuta;
        public System.Windows.Forms.DataGridView dgImport;
        public System.Windows.Forms.Button btnFormato;
        public System.Windows.Forms.Button btnPython;
        public System.Windows.Forms.DataGridView dgExport;
        public System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.Button btnPrueba;
        public System.Windows.Forms.ComboBox cbxColumns;
        public System.Windows.Forms.PictureBox btnFormatoCelda;
    }
}