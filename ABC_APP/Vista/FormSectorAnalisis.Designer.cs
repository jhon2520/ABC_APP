
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
            this.components = new System.ComponentModel.Container();
            this.dgImport = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImportar = new System.Windows.Forms.Button();
            this.tbxRuta = new System.Windows.Forms.TextBox();
            this.btnPython = new System.Windows.Forms.Button();
            this.btnSobreescribirGrid = new System.Windows.Forms.Button();
            this.btnAlertas = new System.Windows.Forms.Button();
            this.cbxAlertas = new System.Windows.Forms.ComboBox();
            this.contadorAlertas = new System.Windows.Forms.NumericUpDown();
            this.pbarVisualizador = new System.Windows.Forms.ProgressBar();
            this.bgwEjecutarPython = new System.ComponentModel.BackgroundWorker();
            this.timerEjecutarPython = new System.Windows.Forms.Timer(this.components);
            this.elipseBtnImportar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxLimInf = new System.Windows.Forms.TextBox();
            this.tbxDif = new System.Windows.Forms.TextBox();
            this.tbxMin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxLimSup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbxMax = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbxDifPor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDesviacion = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbxProm = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbxCuenta = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.elipseBtnPython = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnDatos = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnAlertas = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pbxLoagindGif = new System.Windows.Forms.PictureBox();
            this.btnExportarGrid = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.pbxAyuda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contadorAlertas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoagindGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAyuda)).BeginInit();
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
            this.dgImport.Size = new System.Drawing.Size(690, 323);
            this.dgImport.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(39, 381);
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
            this.btnImportar.Location = new System.Drawing.Point(550, 358);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(147, 26);
            this.btnImportar.TabIndex = 5;
            this.btnImportar.Text = "Importar Datos";
            this.btnImportar.UseVisualStyleBackColor = false;
            // 
            // tbxRuta
            // 
            this.tbxRuta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxRuta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxRuta.ForeColor = System.Drawing.Color.DimGray;
            this.tbxRuta.Location = new System.Drawing.Point(39, 362);
            this.tbxRuta.Name = "tbxRuta";
            this.tbxRuta.Size = new System.Drawing.Size(505, 17);
            this.tbxRuta.TabIndex = 4;
            // 
            // btnPython
            // 
            this.btnPython.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(18)))), ((int)(((byte)(129)))));
            this.btnPython.FlatAppearance.BorderSize = 0;
            this.btnPython.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPython.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPython.ForeColor = System.Drawing.Color.White;
            this.btnPython.Location = new System.Drawing.Point(39, 406);
            this.btnPython.Name = "btnPython";
            this.btnPython.Size = new System.Drawing.Size(190, 26);
            this.btnPython.TabIndex = 15;
            this.btnPython.Text = "Ejecutar Python";
            this.btnPython.UseVisualStyleBackColor = false;
            // 
            // btnSobreescribirGrid
            // 
            this.btnSobreescribirGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(174)))), ((int)(((byte)(152)))));
            this.btnSobreescribirGrid.FlatAppearance.BorderSize = 0;
            this.btnSobreescribirGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobreescribirGrid.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobreescribirGrid.ForeColor = System.Drawing.Color.White;
            this.btnSobreescribirGrid.Location = new System.Drawing.Point(239, 406);
            this.btnSobreescribirGrid.Name = "btnSobreescribirGrid";
            this.btnSobreescribirGrid.Size = new System.Drawing.Size(190, 26);
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
            this.btnAlertas.Location = new System.Drawing.Point(436, 406);
            this.btnAlertas.Name = "btnAlertas";
            this.btnAlertas.Size = new System.Drawing.Size(190, 26);
            this.btnAlertas.TabIndex = 15;
            this.btnAlertas.Text = "Hallar Alertas";
            this.btnAlertas.UseVisualStyleBackColor = false;
            // 
            // cbxAlertas
            // 
            this.cbxAlertas.BackColor = System.Drawing.Color.White;
            this.cbxAlertas.DropDownHeight = 80;
            this.cbxAlertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAlertas.ForeColor = System.Drawing.Color.DimGray;
            this.cbxAlertas.FormattingEnabled = true;
            this.cbxAlertas.IntegralHeight = false;
            this.cbxAlertas.Location = new System.Drawing.Point(39, 448);
            this.cbxAlertas.Name = "cbxAlertas";
            this.cbxAlertas.Size = new System.Drawing.Size(690, 27);
            this.cbxAlertas.TabIndex = 16;
            this.cbxAlertas.Text = "Cuentas con alertas";
            // 
            // contadorAlertas
            // 
            this.contadorAlertas.BackColor = System.Drawing.Color.White;
            this.contadorAlertas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contadorAlertas.Enabled = false;
            this.contadorAlertas.ForeColor = System.Drawing.Color.DimGray;
            this.contadorAlertas.Location = new System.Drawing.Point(631, 409);
            this.contadorAlertas.Name = "contadorAlertas";
            this.contadorAlertas.ReadOnly = true;
            this.contadorAlertas.Size = new System.Drawing.Size(45, 20);
            this.contadorAlertas.TabIndex = 17;
            // 
            // pbarVisualizador
            // 
            this.pbarVisualizador.Location = new System.Drawing.Point(39, 693);
            this.pbarVisualizador.Name = "pbarVisualizador";
            this.pbarVisualizador.Size = new System.Drawing.Size(690, 10);
            this.pbarVisualizador.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbarVisualizador.TabIndex = 18;
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
            // elipseBtnImportar
            // 
            this.elipseBtnImportar.ElipseRadius = 4;
            this.elipseBtnImportar.TargetControl = this.btnImportar;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbxLimInf);
            this.panel2.Controls.Add(this.tbxDif);
            this.panel2.Controls.Add(this.tbxMin);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbxLimSup);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbxUser);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.tbxMax);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.tbxDifPor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbxDesviacion);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.tbxProm);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.tbxCuenta);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(39, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 153);
            this.panel2.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(463, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 22);
            this.label10.TabIndex = 11;
            this.label10.Text = "L. Inf.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(463, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Difer.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(463, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mín.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(243, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "L. Sup";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(243, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(243, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Máx.";
            // 
            // tbxLimInf
            // 
            this.tbxLimInf.BackColor = System.Drawing.Color.White;
            this.tbxLimInf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxLimInf.ForeColor = System.Drawing.Color.DimGray;
            this.tbxLimInf.Location = new System.Drawing.Point(514, 115);
            this.tbxLimInf.Name = "tbxLimInf";
            this.tbxLimInf.Size = new System.Drawing.Size(145, 17);
            this.tbxLimInf.TabIndex = 4;
            this.tbxLimInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxDif
            // 
            this.tbxDif.BackColor = System.Drawing.Color.White;
            this.tbxDif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDif.ForeColor = System.Drawing.Color.DimGray;
            this.tbxDif.Location = new System.Drawing.Point(514, 82);
            this.tbxDif.Name = "tbxDif";
            this.tbxDif.Size = new System.Drawing.Size(145, 17);
            this.tbxDif.TabIndex = 4;
            this.tbxDif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxMin
            // 
            this.tbxMin.BackColor = System.Drawing.Color.White;
            this.tbxMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxMin.ForeColor = System.Drawing.Color.DimGray;
            this.tbxMin.Location = new System.Drawing.Point(514, 48);
            this.tbxMin.Name = "tbxMin";
            this.tbxMin.Size = new System.Drawing.Size(145, 17);
            this.tbxMin.TabIndex = 4;
            this.tbxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(31, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "D. Porc.";
            // 
            // tbxLimSup
            // 
            this.tbxLimSup.BackColor = System.Drawing.Color.White;
            this.tbxLimSup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxLimSup.ForeColor = System.Drawing.Color.DimGray;
            this.tbxLimSup.Location = new System.Drawing.Point(294, 115);
            this.tbxLimSup.Name = "tbxLimSup";
            this.tbxLimSup.Size = new System.Drawing.Size(145, 17);
            this.tbxLimSup.TabIndex = 4;
            this.tbxLimSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(31, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "D. Est.";
            // 
            // tbxUser
            // 
            this.tbxUser.BackColor = System.Drawing.Color.White;
            this.tbxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUser.ForeColor = System.Drawing.Color.DimGray;
            this.tbxUser.Location = new System.Drawing.Point(294, 82);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(145, 17);
            this.tbxUser.TabIndex = 4;
            this.tbxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Silver;
            this.panel12.Location = new System.Drawing.Point(514, 134);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(145, 1);
            this.panel12.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(31, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Prom.";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Silver;
            this.panel9.Location = new System.Drawing.Point(514, 101);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(145, 1);
            this.panel9.TabIndex = 6;
            // 
            // tbxMax
            // 
            this.tbxMax.BackColor = System.Drawing.Color.White;
            this.tbxMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxMax.ForeColor = System.Drawing.Color.DimGray;
            this.tbxMax.Location = new System.Drawing.Point(294, 48);
            this.tbxMax.Name = "tbxMax";
            this.tbxMax.Size = new System.Drawing.Size(145, 17);
            this.tbxMax.TabIndex = 4;
            this.tbxMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Silver;
            this.panel11.Location = new System.Drawing.Point(294, 134);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(145, 1);
            this.panel11.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(514, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(145, 1);
            this.panel6.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Silver;
            this.panel8.Location = new System.Drawing.Point(294, 101);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(145, 1);
            this.panel8.TabIndex = 6;
            // 
            // tbxDifPor
            // 
            this.tbxDifPor.BackColor = System.Drawing.Color.White;
            this.tbxDifPor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDifPor.ForeColor = System.Drawing.Color.DimGray;
            this.tbxDifPor.Location = new System.Drawing.Point(82, 115);
            this.tbxDifPor.Name = "tbxDifPor";
            this.tbxDifPor.Size = new System.Drawing.Size(145, 17);
            this.tbxDifPor.TabIndex = 4;
            this.tbxDifPor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(32, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cuenta";
            // 
            // tbxDesviacion
            // 
            this.tbxDesviacion.BackColor = System.Drawing.Color.White;
            this.tbxDesviacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDesviacion.ForeColor = System.Drawing.Color.DimGray;
            this.tbxDesviacion.Location = new System.Drawing.Point(82, 82);
            this.tbxDesviacion.Name = "tbxDesviacion";
            this.tbxDesviacion.Size = new System.Drawing.Size(145, 17);
            this.tbxDesviacion.TabIndex = 4;
            this.tbxDesviacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Silver;
            this.panel10.Location = new System.Drawing.Point(82, 134);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(145, 1);
            this.panel10.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(294, 67);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(145, 1);
            this.panel5.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Location = new System.Drawing.Point(82, 101);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(145, 1);
            this.panel7.TabIndex = 6;
            // 
            // tbxProm
            // 
            this.tbxProm.BackColor = System.Drawing.Color.White;
            this.tbxProm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxProm.ForeColor = System.Drawing.Color.DimGray;
            this.tbxProm.Location = new System.Drawing.Point(82, 48);
            this.tbxProm.Name = "tbxProm";
            this.tbxProm.Size = new System.Drawing.Size(145, 17);
            this.tbxProm.TabIndex = 4;
            this.tbxProm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(82, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(145, 1);
            this.panel4.TabIndex = 6;
            // 
            // tbxCuenta
            // 
            this.tbxCuenta.BackColor = System.Drawing.Color.White;
            this.tbxCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCuenta.ForeColor = System.Drawing.Color.DimGray;
            this.tbxCuenta.Location = new System.Drawing.Point(93, 12);
            this.tbxCuenta.Name = "tbxCuenta";
            this.tbxCuenta.Size = new System.Drawing.Size(565, 17);
            this.tbxCuenta.TabIndex = 4;
            this.tbxCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(93, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(565, 1);
            this.panel3.TabIndex = 6;
            // 
            // elipseBtnPython
            // 
            this.elipseBtnPython.ElipseRadius = 4;
            this.elipseBtnPython.TargetControl = this.btnPython;
            // 
            // elipseBtnDatos
            // 
            this.elipseBtnDatos.ElipseRadius = 4;
            this.elipseBtnDatos.TargetControl = this.btnSobreescribirGrid;
            // 
            // elipseBtnAlertas
            // 
            this.elipseBtnAlertas.ElipseRadius = 4;
            this.elipseBtnAlertas.TargetControl = this.btnAlertas;
            // 
            // pbxLoagindGif
            // 
            this.pbxLoagindGif.Image = global::ABC_APP.Properties.Resources.loading;
            this.pbxLoagindGif.Location = new System.Drawing.Point(708, 672);
            this.pbxLoagindGif.Name = "pbxLoagindGif";
            this.pbxLoagindGif.Size = new System.Drawing.Size(20, 20);
            this.pbxLoagindGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLoagindGif.TabIndex = 19;
            this.pbxLoagindGif.TabStop = false;
            this.pbxLoagindGif.Visible = false;
            // 
            // btnExportarGrid
            // 
            this.btnExportarGrid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExportarGrid.BackgroundImage = global::ABC_APP.Properties.Resources.excel;
            this.btnExportarGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportarGrid.FlatAppearance.BorderSize = 0;
            this.btnExportarGrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExportarGrid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExportarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarGrid.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarGrid.ForeColor = System.Drawing.Color.White;
            this.btnExportarGrid.Location = new System.Drawing.Point(687, 403);
            this.btnExportarGrid.Name = "btnExportarGrid";
            this.btnExportarGrid.Size = new System.Drawing.Size(35, 35);
            this.btnExportarGrid.TabIndex = 15;
            this.btnExportarGrid.UseVisualStyleBackColor = false;
            // 
            // btnGrafica
            // 
            this.btnGrafica.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGrafica.BackgroundImage = global::ABC_APP.Properties.Resources.plot;
            this.btnGrafica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrafica.FlatAppearance.BorderSize = 0;
            this.btnGrafica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGrafica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGrafica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafica.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafica.ForeColor = System.Drawing.Color.White;
            this.btnGrafica.Location = new System.Drawing.Point(360, 647);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(49, 44);
            this.btnGrafica.TabIndex = 15;
            this.btnGrafica.UseVisualStyleBackColor = false;
            // 
            // pbxAyuda
            // 
            this.pbxAyuda.Image = global::ABC_APP.Properties.Resources.question2;
            this.pbxAyuda.Location = new System.Drawing.Point(703, 358);
            this.pbxAyuda.Name = "pbxAyuda";
            this.pbxAyuda.Size = new System.Drawing.Size(26, 26);
            this.pbxAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAyuda.TabIndex = 14;
            this.pbxAyuda.TabStop = false;
            // 
            // FormSectorAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(769, 724);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbxLoagindGif);
            this.Controls.Add(this.pbarVisualizador);
            this.Controls.Add(this.contadorAlertas);
            this.Controls.Add(this.cbxAlertas);
            this.Controls.Add(this.btnAlertas);
            this.Controls.Add(this.btnExportarGrid);
            this.Controls.Add(this.btnGrafica);
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
            ((System.ComponentModel.ISupportInitialize)(this.contadorAlertas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoagindGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAyuda)).EndInit();
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
        public System.Windows.Forms.PictureBox pbxLoagindGif;
        public System.Windows.Forms.ProgressBar pbarVisualizador;
        public System.ComponentModel.BackgroundWorker bgwEjecutarPython;
        public System.Windows.Forms.Timer timerEjecutarPython;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnImportar;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnExportarGrid;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbxCuenta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxLimInf;
        public System.Windows.Forms.TextBox tbxDif;
        public System.Windows.Forms.TextBox tbxMin;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbxLimSup;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.TextBox tbxMax;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.TextBox tbxDifPor;
        public System.Windows.Forms.TextBox tbxDesviacion;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.TextBox tbxProm;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btnGrafica;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnPython;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnDatos;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnAlertas;
    }
}