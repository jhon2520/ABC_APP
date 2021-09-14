
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnImportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgImport
            // 
            this.dgImport.AllowUserToAddRows = false;
            this.dgImport.AllowUserToDeleteRows = false;
            this.dgImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImport.Location = new System.Drawing.Point(51, 24);
            this.dgImport.Name = "dgImport";
            this.dgImport.ReadOnly = true;
            this.dgImport.Size = new System.Drawing.Size(657, 150);
            this.dgImport.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(512, 24);
            this.textBox1.TabIndex = 1;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(569, 177);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(139, 26);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // FormHorizontalAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 724);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgImport);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(769, 724);
            this.MinimumSize = new System.Drawing.Size(769, 724);
            this.Name = "FormHorizontalAnalisis";
            this.Text = "FormHorizontalAnalisis";
            ((System.ComponentModel.ISupportInitialize)(this.dgImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgImport;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnImportar;
    }
}