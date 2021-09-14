
namespace ABC_APP.Vista
{
    partial class FormMain
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.btnSector = new System.Windows.Forms.Button();
            this.btnHorizontal = new System.Windows.Forms.Button();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.dragSuperior = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnReturn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pnlSuperior.SuspendLayout();
            this.pnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.pnlSuperior.Controls.Add(this.btnReturn);
            this.pnlSuperior.Controls.Add(this.pictureBox1);
            this.pnlSuperior.Controls.Add(this.btnClose);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(895, 54);
            this.pnlSuperior.TabIndex = 0;
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(9)))), ((int)(((byte)(68)))));
            this.pnlIzquierdo.Controls.Add(this.btnSector);
            this.pnlIzquierdo.Controls.Add(this.btnHorizontal);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Location = new System.Drawing.Point(0, 54);
            this.pnlIzquierdo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(126, 724);
            this.pnlIzquierdo.TabIndex = 0;
            // 
            // btnSector
            // 
            this.btnSector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(9)))), ((int)(((byte)(68)))));
            this.btnSector.FlatAppearance.BorderSize = 0;
            this.btnSector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnSector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSector.ForeColor = System.Drawing.Color.White;
            this.btnSector.Location = new System.Drawing.Point(0, 376);
            this.btnSector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSector.Name = "btnSector";
            this.btnSector.Size = new System.Drawing.Size(126, 24);
            this.btnSector.TabIndex = 0;
            this.btnSector.Text = "Análisis Sector";
            this.btnSector.UseVisualStyleBackColor = false;
            // 
            // btnHorizontal
            // 
            this.btnHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(9)))), ((int)(((byte)(68)))));
            this.btnHorizontal.FlatAppearance.BorderSize = 0;
            this.btnHorizontal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHorizontal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnHorizontal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorizontal.ForeColor = System.Drawing.Color.White;
            this.btnHorizontal.Location = new System.Drawing.Point(0, 347);
            this.btnHorizontal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHorizontal.Name = "btnHorizontal";
            this.btnHorizontal.Size = new System.Drawing.Size(126, 24);
            this.btnHorizontal.TabIndex = 0;
            this.btnHorizontal.Text = "Análisis Horizontal";
            this.btnHorizontal.UseVisualStyleBackColor = false;
            // 
            // pnlCentral
            // 
            this.pnlCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(126, 54);
            this.pnlCentral.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(769, 724);
            this.pnlCentral.TabIndex = 0;
            // 
            // dragSuperior
            // 
            this.dragSuperior.Fixed = true;
            this.dragSuperior.Horizontal = true;
            this.dragSuperior.TargetControl = this.pnlSuperior;
            this.dragSuperior.Vertical = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Image = global::ABC_APP.Properties.Resources._return;
            this.btnReturn.Location = new System.Drawing.Point(12, 10);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(35, 35);
            this.btnReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReturn.TabIndex = 0;
            this.btnReturn.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABC_APP.Properties.Resources.minimice1;
            this.pictureBox1.Location = new System.Drawing.Point(843, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::ABC_APP.Properties.Resources.close2;
            this.btnClose.Location = new System.Drawing.Point(869, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 778);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlIzquierdo);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.pnlSuperior.ResumeLayout(false);
            this.pnlIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlSuperior;
        public System.Windows.Forms.Panel pnlIzquierdo;
        public System.Windows.Forms.Panel pnlCentral;
        private Bunifu.Framework.UI.BunifuDragControl dragSuperior;
        public System.Windows.Forms.Button btnSector;
        public System.Windows.Forms.Button btnHorizontal;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox btnClose;
        public System.Windows.Forms.PictureBox btnReturn;
    }
}