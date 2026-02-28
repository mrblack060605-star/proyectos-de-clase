namespace Ejersicio2._3
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
            txtValor = new TextBox();
            cmbEntrada = new ComboBox();
            cmbSalida = new ComboBox();
            lblResultado = new Label();
            btnConvertir = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtValor
            // 
            txtValor.Location = new Point(26, 45);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 27);
            txtValor.TabIndex = 0;
            // 
            // cmbEntrada
            // 
            cmbEntrada.FormattingEnabled = true;
            cmbEntrada.Location = new Point(12, 96);
            cmbEntrada.Name = "cmbEntrada";
            cmbEntrada.Size = new Size(151, 28);
            cmbEntrada.TabIndex = 1;
            // 
            // cmbSalida
            // 
            cmbSalida.FormattingEnabled = true;
            cmbSalida.Location = new Point(169, 96);
            cmbSalida.Name = "cmbSalida";
            cmbSalida.Size = new Size(151, 28);
            cmbSalida.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(302, 45);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(178, 45);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(94, 29);
            btnConvertir.TabIndex = 4;
            btnConvertir.Text = "Comvertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // button2
            // 
            button2.Location = new Point(555, 174);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 174);
            Controls.Add(button2);
            Controls.Add(btnConvertir);
            Controls.Add(lblResultado);
            Controls.Add(cmbSalida);
            Controls.Add(cmbEntrada);
            Controls.Add(txtValor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor;
        private ComboBox cmbEntrada;
        private ComboBox cmbSalida;
        private Label lblResultado;
        private Button btnConvertir;
        private Button button2;
    }
}
