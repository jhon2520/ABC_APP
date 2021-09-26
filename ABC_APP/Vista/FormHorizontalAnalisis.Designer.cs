
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
            this.components = new System.ComponentModel.Container();
            this.dgImport = new System.Windows.Forms.DataGridView();
            this.tbxRuta = new System.Windows.Forms.TextBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnFormato = new System.Windows.Forms.Button();
            this.btnPython = new System.Windows.Forms.Button();
            this.dgExport = new System.Windows.Forms.DataGridView();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUPDownFormato = new System.Windows.Forms.NumericUpDown();
            this.cbxColumns = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiarCbx = new System.Windows.Forms.PictureBox();
            this.btnFormatoCelda = new System.Windows.Forms.PictureBox();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.btnBorrarFormato = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.elipseBtnImportar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUPDownFormato)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiarCbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFormatoCelda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgImport
            // 
            this.dgImport.AllowUserToAddRows = false;
            this.dgImport.AllowUserToDeleteRows = false;
            this.dgImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImport.Location = new System.Drawing.Point(37, 26);
            this.dgImport.Name = "dgImport";
            this.dgImport.ReadOnly = true;
            this.dgImport.Size = new System.Drawing.Size(694, 200);
            this.dgImport.TabIndex = 0;
            // 
            // tbxRuta
            // 
            this.tbxRuta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxRuta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxRuta.Location = new System.Drawing.Point(38, 234);
            this.tbxRuta.Name = "tbxRuta";
            this.tbxRuta.Size = new System.Drawing.Size(525, 17);
            this.tbxRuta.TabIndex = 1;
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(174)))), ((int)(((byte)(152)))));
            this.btnImportar.FlatAppearance.BorderSize = 0;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ForeColor = System.Drawing.Color.White;
            this.btnImportar.Location = new System.Drawing.Point(569, 229);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(162, 26);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            // 
            // btnFormato
            // 
            this.btnFormato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(18)))), ((int)(((byte)(129)))));
            this.btnFormato.FlatAppearance.BorderSize = 0;
            this.btnFormato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormato.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormato.ForeColor = System.Drawing.Color.White;
            this.btnFormato.Location = new System.Drawing.Point(187, 139);
            this.btnFormato.Name = "btnFormato";
            this.btnFormato.Size = new System.Drawing.Size(160, 26);
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
            this.btnPython.Location = new System.Drawing.Point(37, 262);
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
            this.dgExport.Location = new System.Drawing.Point(37, 293);
            this.dgExport.Name = "dgExport";
            this.dgExport.ReadOnly = true;
            this.dgExport.Size = new System.Drawing.Size(694, 200);
            this.dgExport.TabIndex = 0;
            // 
            // btnGrafica
            // 
            this.btnGrafica.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGrafica.FlatAppearance.BorderSize = 0;
            this.btnGrafica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafica.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafica.ForeColor = System.Drawing.Color.White;
            this.btnGrafica.Location = new System.Drawing.Point(-1, 686);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(269, 30);
            this.btnGrafica.TabIndex = 2;
            this.btnGrafica.Text = "Ver Grafica";
            this.btnGrafica.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(38, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 1);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(213, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aquí podrá ejectuar el código de python para iniciar el análisis.";
            // 
            // numericUPDownFormato
            // 
            this.numericUPDownFormato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUPDownFormato.DecimalPlaces = 1;
            this.numericUPDownFormato.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUPDownFormato.ForeColor = System.Drawing.Color.DimGray;
            this.numericUPDownFormato.Location = new System.Drawing.Point(348, 44);
            this.numericUPDownFormato.Name = "numericUPDownFormato";
            this.numericUPDownFormato.Size = new System.Drawing.Size(68, 21);
            this.numericUPDownFormato.TabIndex = 5;
            this.numericUPDownFormato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxColumns
            // 
            this.cbxColumns.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxColumns.ForeColor = System.Drawing.Color.DimGray;
            this.cbxColumns.FormattingEnabled = true;
            this.cbxColumns.Location = new System.Drawing.Point(95, 81);
            this.cbxColumns.Name = "cbxColumns";
            this.cbxColumns.Size = new System.Drawing.Size(89, 27);
            this.cbxColumns.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnBorrarFormato);
            this.panel2.Controls.Add(this.btnLimpiarCbx);
            this.panel2.Controls.Add(this.btnFormatoCelda);
            this.panel2.Controls.Add(this.btnFormato);
            this.panel2.Controls.Add(this.cbxDestino);
            this.panel2.Controls.Add(this.cbxColumns);
            this.panel2.Controls.Add(this.numericUPDownFormato);
            this.panel2.Location = new System.Drawing.Point(37, 499);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 172);
            this.panel2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(186, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = ">>> Seleccione columnas a formatear >>>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(421, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = ">>> Seleccione un limite superior (%)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(12, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(680, 1);
            this.panel3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(20, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Formato de Celdas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(101, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = ">>> Seleccione un color de formato";
            // 
            // btnLimpiarCbx
            // 
            this.btnLimpiarCbx.Image = global::ABC_APP.Properties.Resources.clear;
            this.btnLimpiarCbx.Location = new System.Drawing.Point(575, 83);
            this.btnLimpiarCbx.Name = "btnLimpiarCbx";
            this.btnLimpiarCbx.Size = new System.Drawing.Size(25, 25);
            this.btnLimpiarCbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLimpiarCbx.TabIndex = 8;
            this.btnLimpiarCbx.TabStop = false;
            // 
            // btnFormatoCelda
            // 
            this.btnFormatoCelda.Image = global::ABC_APP.Properties.Resources.colors;
            this.btnFormatoCelda.Location = new System.Drawing.Point(73, 45);
            this.btnFormatoCelda.Name = "btnFormatoCelda";
            this.btnFormatoCelda.Size = new System.Drawing.Size(25, 25);
            this.btnFormatoCelda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFormatoCelda.TabIndex = 8;
            this.btnFormatoCelda.TabStop = false;
            // 
            // cbxDestino
            // 
            this.cbxDestino.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDestino.ForeColor = System.Drawing.Color.DimGray;
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(457, 81);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(112, 27);
            this.cbxDestino.TabIndex = 7;
            // 
            // btnBorrarFormato
            // 
            this.btnBorrarFormato.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBorrarFormato.FlatAppearance.BorderSize = 0;
            this.btnBorrarFormato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarFormato.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarFormato.ForeColor = System.Drawing.Color.White;
            this.btnBorrarFormato.Location = new System.Drawing.Point(347, 139);
            this.btnBorrarFormato.Name = "btnBorrarFormato";
            this.btnBorrarFormato.Size = new System.Drawing.Size(160, 26);
            this.btnBorrarFormato.TabIndex = 2;
            this.btnBorrarFormato.Text = "Borrar Formato";
            this.btnBorrarFormato.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(500, 686);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(270, 30);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar Ventana";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // elipseBtnImportar
            // 
            this.elipseBtnImportar.ElipseRadius = 3;
            this.elipseBtnImportar.TargetControl = this.btnImportar;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGenerarReporte.FlatAppearance.BorderSize = 0;
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(268, 686);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(232, 30);
            this.btnGenerarReporte.TabIndex = 2;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            // 
            // FormHorizontalAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 724);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPython);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.btnGrafica);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUPDownFormato)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiarCbx)).EndInit();
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
        public System.Windows.Forms.ComboBox cbxColumns;
        public System.Windows.Forms.PictureBox btnFormatoCelda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnBorrarFormato;
        public System.Windows.Forms.ComboBox cbxDestino;
        public System.Windows.Forms.PictureBox btnLimpiarCbx;
        public System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.NumericUpDown numericUPDownFormato;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnImportar;
        public System.Windows.Forms.Button btnGenerarReporte;
    }
}