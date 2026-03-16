namespace Actividad4_Formularios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversorDivisasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serieFibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplicacionesToolStripMenuItem
            // 
            this.aplicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroPersonasToolStripMenuItem,
            this.conversorDivisasToolStripMenuItem,
            this.serieFibonacciToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            this.aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // registroPersonasToolStripMenuItem
            // 
            this.registroPersonasToolStripMenuItem.Name = "registroPersonasToolStripMenuItem";
            this.registroPersonasToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.registroPersonasToolStripMenuItem.Text = "Registro Personas";
            this.registroPersonasToolStripMenuItem.Click += new System.EventHandler(this.registroPersonasToolStripMenuItem_Click);
            // 
            // conversorDivisasToolStripMenuItem
            // 
            this.conversorDivisasToolStripMenuItem.Name = "conversorDivisasToolStripMenuItem";
            this.conversorDivisasToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.conversorDivisasToolStripMenuItem.Text = "Conversor Divisas";
            this.conversorDivisasToolStripMenuItem.Click += new System.EventHandler(this.conversorDivisasToolStripMenuItem_Click);
            // 
            // serieFibonacciToolStripMenuItem
            // 
            this.serieFibonacciToolStripMenuItem.Name = "serieFibonacciToolStripMenuItem";
            this.serieFibonacciToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.serieFibonacciToolStripMenuItem.Text = "Serie Fibonacci";
            this.serieFibonacciToolStripMenuItem.Click += new System.EventHandler(this.serieFibonacciToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.salirToolStripMenuItem.Text = "salir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversorDivisasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serieFibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

