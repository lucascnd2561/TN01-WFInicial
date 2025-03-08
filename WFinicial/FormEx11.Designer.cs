namespace WFinicial
{
    partial class FormEx11
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
            lblSalarioBruto = new Label();
            txtResultado = new RichTextBox();
            txtSalarioBruto = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblSalarioBruto
            // 
            lblSalarioBruto.AutoSize = true;
            lblSalarioBruto.Location = new Point(46, 68);
            lblSalarioBruto.Name = "lblSalarioBruto";
            lblSalarioBruto.Size = new Size(77, 15);
            lblSalarioBruto.TabIndex = 0;
            lblSalarioBruto.Text = "Salário Bruto:";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(35, 175);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(246, 263);
            txtResultado.TabIndex = 1;
            txtResultado.Text = "";
            // 
            // txtSalarioBruto
            // 
            txtSalarioBruto.Location = new Point(164, 65);
            txtSalarioBruto.Name = "txtSalarioBruto";
            txtSalarioBruto.Size = new Size(100, 23);
            txtSalarioBruto.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(164, 129);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FormEx11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtSalarioBruto);
            Controls.Add(txtResultado);
            Controls.Add(lblSalarioBruto);
            Name = "FormEx11";
            Text = "FormEx11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSalarioBruto;
        private RichTextBox txtResultado;
        private TextBox txtSalarioBruto;
        private Button btnCalcular;
    }
}