
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgImport = new System.Windows.Forms.DataGridView();
            this.tbxRuta = new System.Windows.Forms.TextBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnPython = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUPDownFormato = new System.Windows.Forms.NumericUpDown();
            this.cbxColumns = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.btnGuardarGrid = new System.Windows.Forms.Button();
            this.elipseBtnImportar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnTraerGridCache = new System.Windows.Forms.Button();
            this.pbarVisualizador = new System.Windows.Forms.ProgressBar();
            this.bgwEjecutarPython = new System.ComponentModel.BackgroundWorker();
            this.timerEjecutarPython = new System.Windows.Forms.Timer(this.components);
            this.btnSobreescribirGrid = new System.Windows.Forms.Button();
            this.btnExportarGrid = new System.Windows.Forms.Button();
            this.pbxLoagindGif = new System.Windows.Forms.PictureBox();
            this.btnBorrarFormato = new System.Windows.Forms.Button();
            this.btnLimpiarCbx = new System.Windows.Forms.PictureBox();
            this.btnFormatoCelda = new System.Windows.Forms.PictureBox();
            this.btnFormato = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.elipseBtnPython = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnSobreescribir = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUPDownFormato)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoagindGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiarCbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFormatoCelda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgImport
            // 
            this.dgImport.AllowUserToAddRows = false;
            this.dgImport.AllowUserToDeleteRows = false;
            this.dgImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgImport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgImport.Location = new System.Drawing.Point(37, 26);
            this.dgImport.Name = "dgImport";
            this.dgImport.ReadOnly = true;
            this.dgImport.Size = new System.Drawing.Size(694, 267);
            this.dgImport.TabIndex = 0;
            // 
            // tbxRuta
            // 
            this.tbxRuta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxRuta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxRuta.Location = new System.Drawing.Point(38, 304);
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
            this.btnImportar.Location = new System.Drawing.Point(569, 299);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(162, 26);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            // 
            // btnPython
            // 
            this.btnPython.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(18)))), ((int)(((byte)(129)))));
            this.btnPython.FlatAppearance.BorderSize = 0;
            this.btnPython.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPython.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPython.ForeColor = System.Drawing.Color.White;
            this.btnPython.Location = new System.Drawing.Point(58, 355);
            this.btnPython.Name = "btnPython";
            this.btnPython.Size = new System.Drawing.Size(258, 26);
            this.btnPython.TabIndex = 2;
            this.btnPython.Text = "Ejecutar Python";
            this.btnPython.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(38, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 1);
            this.panel1.TabIndex = 3;
            // 
            // numericUPDownFormato
            // 
            this.numericUPDownFormato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUPDownFormato.DecimalPlaces = 1;
            this.numericUPDownFormato.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUPDownFormato.ForeColor = System.Drawing.Color.DimGray;
            this.numericUPDownFormato.Location = new System.Drawing.Point(127, 96);
            this.numericUPDownFormato.Name = "numericUPDownFormato";
            this.numericUPDownFormato.Size = new System.Drawing.Size(64, 21);
            this.numericUPDownFormato.TabIndex = 5;
            this.numericUPDownFormato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxColumns
            // 
            this.cbxColumns.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxColumns.ForeColor = System.Drawing.Color.DimGray;
            this.cbxColumns.FormattingEnabled = true;
            this.cbxColumns.Location = new System.Drawing.Point(117, 137);
            this.cbxColumns.Name = "cbxColumns";
            this.cbxColumns.Size = new System.Drawing.Size(104, 27);
            this.cbxColumns.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel4);
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
            this.panel2.Location = new System.Drawing.Point(37, 413);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 251);
            this.panel2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(227, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = ">>> Seleccione columnas a formatear ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(227, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = ">>> Seleccione un limite superior (%)";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(14, 247);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(680, 1);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(14, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(680, 1);
            this.panel3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(19, 1);
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
            this.label2.Location = new System.Drawing.Point(227, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = ">>> Seleccione un color de formato";
            // 
            // cbxDestino
            // 
            this.cbxDestino.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDestino.ForeColor = System.Drawing.Color.DimGray;
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(117, 196);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(104, 27);
            this.cbxDestino.TabIndex = 7;
            // 
            // btnGuardarGrid
            // 
            this.btnGuardarGrid.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardarGrid.FlatAppearance.BorderSize = 0;
            this.btnGuardarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarGrid.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarGrid.ForeColor = System.Drawing.Color.White;
            this.btnGuardarGrid.Location = new System.Drawing.Point(587, 672);
            this.btnGuardarGrid.Name = "btnGuardarGrid";
            this.btnGuardarGrid.Size = new System.Drawing.Size(81, 22);
            this.btnGuardarGrid.TabIndex = 2;
            this.btnGuardarGrid.Text = "GuardarGrid";
            this.btnGuardarGrid.UseVisualStyleBackColor = false;
            this.btnGuardarGrid.Visible = false;
            // 
            // elipseBtnImportar
            // 
            this.elipseBtnImportar.ElipseRadius = 4;
            this.elipseBtnImportar.TargetControl = this.btnImportar;
            // 
            // btnTraerGridCache
            // 
            this.btnTraerGridCache.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTraerGridCache.FlatAppearance.BorderSize = 0;
            this.btnTraerGridCache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraerGridCache.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraerGridCache.ForeColor = System.Drawing.Color.White;
            this.btnTraerGridCache.Location = new System.Drawing.Point(463, 672);
            this.btnTraerGridCache.Name = "btnTraerGridCache";
            this.btnTraerGridCache.Size = new System.Drawing.Size(118, 22);
            this.btnTraerGridCache.TabIndex = 2;
            this.btnTraerGridCache.Text = "TraerGrid";
            this.btnTraerGridCache.UseVisualStyleBackColor = false;
            this.btnTraerGridCache.Visible = false;
            // 
            // pbarVisualizador
            // 
            this.pbarVisualizador.Location = new System.Drawing.Point(31, 700);
            this.pbarVisualizador.Name = "pbarVisualizador";
            this.pbarVisualizador.Size = new System.Drawing.Size(702, 10);
            this.pbarVisualizador.TabIndex = 10;
            this.pbarVisualizador.Visible = false;
            // 
            // bgwEjecutarPython
            // 
            this.bgwEjecutarPython.WorkerReportsProgress = true;
            this.bgwEjecutarPython.WorkerSupportsCancellation = true;
            // 
            // timerEjecutarPython
            // 
            this.timerEjecutarPython.Interval = 1000;
            // 
            // btnSobreescribirGrid
            // 
            this.btnSobreescribirGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(174)))), ((int)(((byte)(152)))));
            this.btnSobreescribirGrid.FlatAppearance.BorderSize = 0;
            this.btnSobreescribirGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobreescribirGrid.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobreescribirGrid.ForeColor = System.Drawing.Color.White;
            this.btnSobreescribirGrid.Location = new System.Drawing.Point(330, 355);
            this.btnSobreescribirGrid.Name = "btnSobreescribirGrid";
            this.btnSobreescribirGrid.Size = new System.Drawing.Size(258, 26);
            this.btnSobreescribirGrid.TabIndex = 21;
            this.btnSobreescribirGrid.Text = "Sobreescribir Datos";
            this.btnSobreescribirGrid.UseVisualStyleBackColor = false;
            // 
            // btnExportarGrid
            // 
            this.btnExportarGrid.BackColor = System.Drawing.Color.White;
            this.btnExportarGrid.BackgroundImage = global::ABC_APP.Properties.Resources.excel;
            this.btnExportarGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportarGrid.FlatAppearance.BorderSize = 0;
            this.btnExportarGrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExportarGrid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExportarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarGrid.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarGrid.ForeColor = System.Drawing.Color.White;
            this.btnExportarGrid.Location = new System.Drawing.Point(604, 350);
            this.btnExportarGrid.Name = "btnExportarGrid";
            this.btnExportarGrid.Size = new System.Drawing.Size(35, 35);
            this.btnExportarGrid.TabIndex = 22;
            this.btnExportarGrid.UseVisualStyleBackColor = false;
            // 
            // pbxLoagindGif
            // 
            this.pbxLoagindGif.Image = global::ABC_APP.Properties.Resources.loading;
            this.pbxLoagindGif.Location = new System.Drawing.Point(712, 679);
            this.pbxLoagindGif.Name = "pbxLoagindGif";
            this.pbxLoagindGif.Size = new System.Drawing.Size(20, 20);
            this.pbxLoagindGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLoagindGif.TabIndex = 20;
            this.pbxLoagindGif.TabStop = false;
            this.pbxLoagindGif.Visible = false;
            // 
            // btnBorrarFormato
            // 
            this.btnBorrarFormato.BackColor = System.Drawing.Color.White;
            this.btnBorrarFormato.BackgroundImage = global::ABC_APP.Properties.Resources.delete;
            this.btnBorrarFormato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrarFormato.FlatAppearance.BorderSize = 0;
            this.btnBorrarFormato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBorrarFormato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBorrarFormato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarFormato.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarFormato.ForeColor = System.Drawing.Color.White;
            this.btnBorrarFormato.Location = new System.Drawing.Point(567, 136);
            this.btnBorrarFormato.Name = "btnBorrarFormato";
            this.btnBorrarFormato.Size = new System.Drawing.Size(45, 45);
            this.btnBorrarFormato.TabIndex = 2;
            this.btnBorrarFormato.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarCbx
            // 
            this.btnLimpiarCbx.Image = global::ABC_APP.Properties.Resources.clear;
            this.btnLimpiarCbx.Location = new System.Drawing.Point(231, 196);
            this.btnLimpiarCbx.Name = "btnLimpiarCbx";
            this.btnLimpiarCbx.Size = new System.Drawing.Size(25, 25);
            this.btnLimpiarCbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLimpiarCbx.TabIndex = 8;
            this.btnLimpiarCbx.TabStop = false;
            // 
            // btnFormatoCelda
            // 
            this.btnFormatoCelda.Image = global::ABC_APP.Properties.Resources.colors;
            this.btnFormatoCelda.Location = new System.Drawing.Point(149, 51);
            this.btnFormatoCelda.Name = "btnFormatoCelda";
            this.btnFormatoCelda.Size = new System.Drawing.Size(30, 30);
            this.btnFormatoCelda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFormatoCelda.TabIndex = 8;
            this.btnFormatoCelda.TabStop = false;
            // 
            // btnFormato
            // 
            this.btnFormato.BackColor = System.Drawing.Color.White;
            this.btnFormato.BackgroundImage = global::ABC_APP.Properties.Resources.formato;
            this.btnFormato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormato.FlatAppearance.BorderSize = 0;
            this.btnFormato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFormato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFormato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormato.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormato.ForeColor = System.Drawing.Color.White;
            this.btnFormato.Location = new System.Drawing.Point(567, 78);
            this.btnFormato.Name = "btnFormato";
            this.btnFormato.Size = new System.Drawing.Size(45, 45);
            this.btnFormato.TabIndex = 2;
            this.btnFormato.UseVisualStyleBackColor = false;
            // 
            // btnGrafica
            // 
            this.btnGrafica.BackColor = System.Drawing.Color.White;
            this.btnGrafica.BackgroundImage = global::ABC_APP.Properties.Resources.plot;
            this.btnGrafica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrafica.FlatAppearance.BorderSize = 0;
            this.btnGrafica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGrafica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGrafica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafica.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafica.ForeColor = System.Drawing.Color.White;
            this.btnGrafica.Location = new System.Drawing.Point(657, 346);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(45, 45);
            this.btnGrafica.TabIndex = 2;
            this.btnGrafica.UseVisualStyleBackColor = false;
            // 
            // elipseBtnPython
            // 
            this.elipseBtnPython.ElipseRadius = 4;
            this.elipseBtnPython.TargetControl = this.btnPython;
            // 
            // elipseBtnSobreescribir
            // 
            this.elipseBtnSobreescribir.ElipseRadius = 4;
            this.elipseBtnSobreescribir.TargetControl = this.btnSobreescribirGrid;
            // 
            // FormHorizontalAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 724);
            this.Controls.Add(this.btnExportarGrid);
            this.Controls.Add(this.btnSobreescribirGrid);
            this.Controls.Add(this.pbxLoagindGif);
            this.Controls.Add(this.pbarVisualizador);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPython);
            this.Controls.Add(this.btnTraerGridCache);
            this.Controls.Add(this.btnGuardarGrid);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.tbxRuta);
            this.Controls.Add(this.dgImport);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(769, 724);
            this.MinimumSize = new System.Drawing.Size(769, 724);
            this.Name = "FormHorizontalAnalisis";
            this.Text = "FormHorizontalAnalisis";
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUPDownFormato)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoagindGif)).EndInit();
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
        public System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Panel panel1;
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
        public System.Windows.Forms.Button btnGuardarGrid;
        public System.Windows.Forms.NumericUpDown numericUPDownFormato;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnImportar;
        public System.Windows.Forms.Button btnTraerGridCache;
        public System.Windows.Forms.PictureBox pbxLoagindGif;
        public System.ComponentModel.BackgroundWorker bgwEjecutarPython;
        public System.Windows.Forms.Timer timerEjecutarPython;
        public System.Windows.Forms.ProgressBar pbarVisualizador;
        public System.Windows.Forms.Button btnSobreescribirGrid;
        public System.Windows.Forms.Button btnExportarGrid;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnPython;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnSobreescribir;
    }
}