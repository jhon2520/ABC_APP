
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
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgImport
            // 
            this.dgImport.AllowUserToAddRows = false;
            this.dgImport.AllowUserToDeleteRows = false;
            this.dgImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImport.Location = new System.Drawing.Point(51, 16);
            this.dgImport.Name = "dgImport";
            this.dgImport.ReadOnly = true;
            this.dgImport.Size = new System.Drawing.Size(657, 245);
            this.dgImport.TabIndex = 0;
            // 
            // tbxRuta
            // 
            this.tbxRuta.Location = new System.Drawing.Point(51, 269);
            this.tbxRuta.Name = "tbxRuta";
            this.tbxRuta.Size = new System.Drawing.Size(512, 24);
            this.tbxRuta.TabIndex = 1;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(569, 267);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(139, 26);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnFormato
            // 
            this.btnFormato.Location = new System.Drawing.Point(569, 632);
            this.btnFormato.Name = "btnFormato";
            this.btnFormato.Size = new System.Drawing.Size(139, 26);
            this.btnFormato.TabIndex = 2;
            this.btnFormato.Text = "Formato";
            this.btnFormato.UseVisualStyleBackColor = true;
            // 
            // btnPython
            // 
            this.btnPython.Location = new System.Drawing.Point(330, 305);
            this.btnPython.Name = "btnPython";
            this.btnPython.Size = new System.Drawing.Size(139, 26);
            this.btnPython.TabIndex = 2;
            this.btnPython.Text = "Ejecutar Python";
            this.btnPython.UseVisualStyleBackColor = true;
            // 
            // dgExport
            // 
            this.dgExport.AllowUserToAddRows = false;
            this.dgExport.AllowUserToDeleteRows = false;
            this.dgExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExport.Location = new System.Drawing.Point(51, 337);
            this.dgExport.Name = "dgExport";
            this.dgExport.ReadOnly = true;
            this.dgExport.Size = new System.Drawing.Size(657, 289);
            this.dgExport.TabIndex = 0;
            // 
            // btnGrafica
            // 
            this.btnGrafica.Location = new System.Drawing.Point(569, 664);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(139, 26);
            this.btnGrafica.TabIndex = 2;
            this.btnGrafica.Text = "Ver Grafica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            // 
            // FormHorizontalAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 724);
            this.Controls.Add(this.btnPython);
            this.Controls.Add(this.btnGrafica);
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
    }
}