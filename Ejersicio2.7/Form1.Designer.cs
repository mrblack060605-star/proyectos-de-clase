namespace Ejersicio2._7
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
            btnBuscar = new Button();
            txtInicio = new TextBox();
            listBox1 = new ListBox();
            txtFin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(310, 46);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(10, 46);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(125, 27);
            txtInicio.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(41, 115);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 144);
            listBox1.TabIndex = 3;
            // 
            // txtFin
            // 
            txtFin.Location = new Point(163, 44);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(125, 27);
            txtFin.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 23);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 5;
            label1.Text = "Inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 23);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 6;
            label2.Text = "Fin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 92);
            label3.Name = "label3";
            label3.Size = new Size(204, 20);
            label3.TabIndex = 7;
            label3.Text = "Numeros Primos encontrados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 285);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFin);
            Controls.Add(listBox1);
            Controls.Add(txtInicio);
            Controls.Add(btnBuscar);
            Name = "Form1";
            Text = "Numeros Primos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button button2;
        private TextBox txtInicio;
        private ListBox listBox1;
        private TextBox txtFin;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
