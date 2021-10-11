
namespace ABC_APP.Vista
{
    partial class FormCompiladorSuperSociedades
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSeleccionarRuta = new System.Windows.Forms.Button();
            this.tbxRutaFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxArchivos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCompilarArchivos = new System.Windows.Forms.Button();
            this.dgCompilado = new System.Windows.Forms.DataGridView();
            this.btnVerArchivoCompilado = new System.Windows.Forms.Button();
            this.elipseBtnImportar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnCompilar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnVerCompilado = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnExportar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseDg = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pbarVisualizador = new System.Windows.Forms.ProgressBar();
            this.timerVisualizarCompilador = new System.Windows.Forms.Timer(this.components);
            this.bgwVisualizarCompilado = new System.ComponentModel.BackgroundWorker();
            this.pbxLoagindGif = new System.Windows.Forms.PictureBox();
            this.pbxCurrentDomain = new System.Windows.Forms.PictureBox();
            this.btnExportarCompilado = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompilado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoagindGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrentDomain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Location = new System.Drawing.Point(52, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 1);
            this.panel1.TabIndex = 9;
            // 
            // btnSeleccionarRuta
            // 
            this.btnSeleccionarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(174)))), ((int)(((byte)(152)))));
            this.btnSeleccionarRuta.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarRuta.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarRuta.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarRuta.Location = new System.Drawing.Point(52, 281);
            this.btnSeleccionarRuta.Name = "btnSeleccionarRuta";
            this.btnSeleccionarRuta.Size = new System.Drawing.Size(162, 26);
            this.btnSeleccionarRuta.TabIndex = 8;
            this.btnSeleccionarRuta.Text = "Importar";
            this.btnSeleccionarRuta.UseVisualStyleBackColor = false;
            // 
            // tbxRutaFolder
            // 
            this.tbxRutaFolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxRutaFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxRutaFolder.Location = new System.Drawing.Point(52, 258);
            this.tbxRutaFolder.Name = "tbxRutaFolder";
            this.tbxRutaFolder.ReadOnly = true;
            this.tbxRutaFolder.Size = new System.Drawing.Size(665, 17);
            this.tbxRutaFolder.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seleccione la ubicación de la carpeta donde se encuentra los archivos de Supersoc" +
    "iedades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(48, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(48, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(574, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Los archivos deben estar juntos dentro de una misma carpeta con los siguientes no" +
    "mbres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(24, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "►plenas_ind.xlsx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(24, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "►plenas_sep.xlsx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(24, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "►pymes_ind.xlsx";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(24, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "►pymes_sep.xlsx";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(303, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 126);
            this.panel2.TabIndex = 11;
            // 
            // cbxArchivos
            // 
            this.cbxArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxArchivos.ForeColor = System.Drawing.Color.Gray;
            this.cbxArchivos.FormattingEnabled = true;
            this.cbxArchivos.Location = new System.Drawing.Point(53, 349);
            this.cbxArchivos.Name = "cbxArchivos";
            this.cbxArchivos.Size = new System.Drawing.Size(664, 27);
            this.cbxArchivos.TabIndex = 12;
            this.cbxArchivos.Text = "Archivos Supersociedades";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(54, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Arcvhios seleccionados >>>";
            // 
            // btnCompilarArchivos
            // 
            this.btnCompilarArchivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCompilarArchivos.FlatAppearance.BorderSize = 0;
            this.btnCompilarArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompilarArchivos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompilarArchivos.ForeColor = System.Drawing.Color.White;
            this.btnCompilarArchivos.Location = new System.Drawing.Point(53, 389);
            this.btnCompilarArchivos.Name = "btnCompilarArchivos";
            this.btnCompilarArchivos.Size = new System.Drawing.Size(162, 26);
            this.btnCompilarArchivos.TabIndex = 8;
            this.btnCompilarArchivos.Text = "Compilar Archivos";
            this.btnCompilarArchivos.UseVisualStyleBackColor = false;
            // 
            // dgCompilado
            // 
            this.dgCompilado.AllowUserToAddRows = false;
            this.dgCompilado.AllowUserToDeleteRows = false;
            this.dgCompilado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCompilado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompilado.Location = new System.Drawing.Point(52, 421);
            this.dgCompilado.Name = "dgCompilado";
            this.dgCompilado.ReadOnly = true;
            this.dgCompilado.Size = new System.Drawing.Size(675, 234);
            this.dgCompilado.TabIndex = 14;
            // 
            // btnVerArchivoCompilado
            // 
            this.btnVerArchivoCompilado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVerArchivoCompilado.FlatAppearance.BorderSize = 0;
            this.btnVerArchivoCompilado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerArchivoCompilado.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerArchivoCompilado.ForeColor = System.Drawing.Color.White;
            this.btnVerArchivoCompilado.Location = new System.Drawing.Point(52, 662);
            this.btnVerArchivoCompilado.Name = "btnVerArchivoCompilado";
            this.btnVerArchivoCompilado.Size = new System.Drawing.Size(162, 26);
            this.btnVerArchivoCompilado.TabIndex = 8;
            this.btnVerArchivoCompilado.Text = "Visualizar Compilado";
            this.btnVerArchivoCompilado.UseVisualStyleBackColor = false;
            // 
            // elipseBtnImportar
            // 
            this.elipseBtnImportar.ElipseRadius = 4;
            this.elipseBtnImportar.TargetControl = this.btnSeleccionarRuta;
            // 
            // elipseBtnCompilar
            // 
            this.elipseBtnCompilar.ElipseRadius = 4;
            this.elipseBtnCompilar.TargetControl = this.btnCompilarArchivos;
            // 
            // elipseBtnVerCompilado
            // 
            this.elipseBtnVerCompilado.ElipseRadius = 4;
            this.elipseBtnVerCompilado.TargetControl = this.btnVerArchivoCompilado;
            // 
            // elipseBtnExportar
            // 
            this.elipseBtnExportar.ElipseRadius = 4;
            this.elipseBtnExportar.TargetControl = this.btnExportarCompilado;
            // 
            // elipseDg
            // 
            this.elipseDg.ElipseRadius = 4;
            this.elipseDg.TargetControl = this.dgCompilado;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // pbarVisualizador
            // 
            this.pbarVisualizador.Location = new System.Drawing.Point(52, 690);
            this.pbarVisualizador.Name = "pbarVisualizador";
            this.pbarVisualizador.Size = new System.Drawing.Size(674, 10);
            this.pbarVisualizador.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbarVisualizador.TabIndex = 16;
            this.pbarVisualizador.Visible = false;
            // 
            // timerVisualizarCompilador
            // 
            this.timerVisualizarCompilador.Interval = 1000;
            // 
            // bgwVisualizarCompilado
            // 
            this.bgwVisualizarCompilado.WorkerReportsProgress = true;
            this.bgwVisualizarCompilado.WorkerSupportsCancellation = true;
            // 
            // pbxLoagindGif
            // 
            this.pbxLoagindGif.Image = global::ABC_APP.Properties.Resources.loading;
            this.pbxLoagindGif.Location = new System.Drawing.Point(696, 662);
            this.pbxLoagindGif.Name = "pbxLoagindGif";
            this.pbxLoagindGif.Size = new System.Drawing.Size(30, 30);
            this.pbxLoagindGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLoagindGif.TabIndex = 17;
            this.pbxLoagindGif.TabStop = false;
            this.pbxLoagindGif.Visible = false;
            // 
            // pbxCurrentDomain
            // 
            this.pbxCurrentDomain.Image = global::ABC_APP.Properties.Resources.question2;
            this.pbxCurrentDomain.Location = new System.Drawing.Point(220, 389);
            this.pbxCurrentDomain.Name = "pbxCurrentDomain";
            this.pbxCurrentDomain.Size = new System.Drawing.Size(26, 26);
            this.pbxCurrentDomain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCurrentDomain.TabIndex = 13;
            this.pbxCurrentDomain.TabStop = false;
            // 
            // btnExportarCompilado
            // 
            this.btnExportarCompilado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExportarCompilado.BackgroundImage = global::ABC_APP.Properties.Resources.excel;
            this.btnExportarCompilado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportarCompilado.FlatAppearance.BorderSize = 0;
            this.btnExportarCompilado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExportarCompilado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExportarCompilado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarCompilado.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarCompilado.ForeColor = System.Drawing.Color.White;
            this.btnExportarCompilado.Location = new System.Drawing.Point(220, 661);
            this.btnExportarCompilado.Name = "btnExportarCompilado";
            this.btnExportarCompilado.Size = new System.Drawing.Size(28, 28);
            this.btnExportarCompilado.TabIndex = 8;
            this.btnExportarCompilado.UseVisualStyleBackColor = false;
            // 
            // FormCompiladorSuperSociedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(769, 724);
            this.Controls.Add(this.pbxLoagindGif);
            this.Controls.Add(this.pbarVisualizador);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dgCompilado);
            this.Controls.Add(this.pbxCurrentDomain);
            this.Controls.Add(this.cbxArchivos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExportarCompilado);
            this.Controls.Add(this.btnVerArchivoCompilado);
            this.Controls.Add(this.btnCompilarArchivos);
            this.Controls.Add(this.btnSeleccionarRuta);
            this.Controls.Add(this.tbxRutaFolder);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCompiladorSuperSociedades";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCompiladorSuperSociedades";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompilado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoagindGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrentDomain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnSeleccionarRuta;
        public System.Windows.Forms.TextBox tbxRutaFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cbxArchivos;
        public System.Windows.Forms.Button btnCompilarArchivos;
        public System.Windows.Forms.PictureBox pbxCurrentDomain;
        public System.Windows.Forms.DataGridView dgCompilado;
        public System.Windows.Forms.Button btnVerArchivoCompilado;
        public System.Windows.Forms.Button btnExportarCompilado;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnImportar;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnCompilar;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnVerCompilado;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnExportar;
        private Bunifu.Framework.UI.BunifuElipse elipseDg;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Timer timerVisualizarCompilador;
        public System.ComponentModel.BackgroundWorker bgwVisualizarCompilado;
        public System.Windows.Forms.ProgressBar pbarVisualizador;
        public System.Windows.Forms.PictureBox pbxLoagindGif;
    }
}