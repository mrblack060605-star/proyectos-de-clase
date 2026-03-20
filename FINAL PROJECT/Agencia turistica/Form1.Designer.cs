namespace Agencia_turistica
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
            Barratitulo = new Panel();
            btnsilde = new PictureBox();
            panelcontenedor = new Panel();
            pictureBox1 = new PictureBox();
            MenuVertical.SuspendLayout();
            Barratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnsilde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.DodgerBlue;
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(220, 603);
            MenuVertical.TabIndex = 0;
            // 
            // Barratitulo
            // 
            Barratitulo.Controls.Add(btnsilde);
            Barratitulo.Dock = DockStyle.Top;
            Barratitulo.Location = new Point(220, 0);
            Barratitulo.Name = "Barratitulo";
            Barratitulo.Size = new Size(1062, 61);
            Barratitulo.TabIndex = 1;
            // 
            // btnsilde
            // 
            btnsilde.Image = (Image)resources.GetObject("btnsilde.Image");
            btnsilde.Location = new Point(6, 12);
            btnsilde.Name = "btnsilde";
            btnsilde.Size = new Size(35, 35);
            btnsilde.SizeMode = PictureBoxSizeMode.Zoom;
            btnsilde.TabIndex = 0;
            btnsilde.TabStop = false;
            btnsilde.Click += pictureBox1_Click;
            // 
            // panelcontenedor
            // 
            panelcontenedor.Dock = DockStyle.Fill;
            panelcontenedor.ForeColor = SystemColors.ButtonHighlight;
            panelcontenedor.Location = new Point(220, 61);
            panelcontenedor.Name = "panelcontenedor";
            panelcontenedor.Size = new Size(1062, 542);
            panelcontenedor.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 603);
            Controls.Add(panelcontenedor);
            Controls.Add(Barratitulo);
            Controls.Add(MenuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            MenuVertical.ResumeLayout(false);
            Barratitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnsilde).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuVertical;
        private Panel Barratitulo;
        private PictureBox btnsilde;
        private Panel panelcontenedor;
        private PictureBox pictureBox1;
    }
}
