namespace Ejersicio2._2
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
            components = new System.ComponentModel.Container();
            txtMinutos = new TextBox();
            txtSegundos = new TextBox();
            btnIniciar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTiempo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtMinutos
            // 
            txtMinutos.Location = new Point(2, 50);
            txtMinutos.Name = "txtMinutos";
            txtMinutos.Size = new Size(125, 27);
            txtMinutos.TabIndex = 0;
            txtMinutos.TextChanged += textBox1_TextChanged;
            // 
            // txtSegundos
            // 
            txtSegundos.Location = new Point(2, 112);
            txtSegundos.Name = "txtSegundos";
            txtSegundos.Size = new Size(125, 27);
            txtSegundos.TabIndex = 1;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(163, 80);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(94, 29);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(285, 25);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(0, 20);
            lblTiempo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 27);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 4;
            label1.Text = "Minutos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 89);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 5;
            label2.Text = "Segundos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 112);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 159);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTiempo);
            Controls.Add(btnIniciar);
            Controls.Add(txtSegundos);
            Controls.Add(txtMinutos);
            Name = "Form1";
            Text = "Cronometro";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMinutos;
        private TextBox txtSegundos;
        private Button btnIniciar;
        private System.Windows.Forms.Timer timer1;
        private Label lblTiempo;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
