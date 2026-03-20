namespace tours
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MenuVertical = new Panel();
            pictureBox2 = new PictureBox();
            BarraTitulo = new Panel();
            pictureBox1 = new PictureBox();
            btnslide = new PictureBox();
            PanelContenedor = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnslide).BeginInit();
            PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(33, 87, 119);
            MenuVertical.Controls.Add(pictureBox2);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(70, 650);
            MenuVertical.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(245, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = SystemColors.ButtonHighlight;
            BarraTitulo.Controls.Add(pictureBox1);
            BarraTitulo.Controls.Add(btnslide);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(70, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1230, 75);
            BarraTitulo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1077, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnslide
            // 
            btnslide.Image = (Image)resources.GetObject("btnslide.Image");
            btnslide.Location = new Point(6, 12);
            btnslide.Name = "btnslide";
            btnslide.Size = new Size(40, 40);
            btnslide.SizeMode = PictureBoxSizeMode.Zoom;
            btnslide.TabIndex = 0;
            btnslide.TabStop = false;
            btnslide.Click += btnslide_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = SystemColors.ButtonHighlight;
            PanelContenedor.Controls.Add(pictureBox4);
            PanelContenedor.Controls.Add(pictureBox3);
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(70, 75);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1230, 575);
            PanelContenedor.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 62);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(299, 78);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 62);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(PanelContenedor);
            Controls.Add(BarraTitulo);
            Controls.Add(MenuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnslide).EndInit();
            PanelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuVertical;
        private Panel panel2;
        private Panel BarraTitulo;
        private PictureBox pictureBox2;
        private PictureBox btnslide;
        private Panel PanelContenedor;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}
