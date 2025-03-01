namespace WFinicial
{
    partial class FormEx6
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
            btnCal = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            lblValorHora = new Label();
            lblQuantHoras = new Label();
            txtQuantHoras = new TextBox();
            txtValorHora = new TextBox();
            SuspendLayout();
            // 
            // btnCal
            // 
            btnCal.Location = new Point(258, 257);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(92, 38);
            btnCal.TabIndex = 0;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(94, 108);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(240, 100);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 2;
            // 
            // lblValorHora
            // 
            lblValorHora.AutoSize = true;
            lblValorHora.Location = new Point(94, 149);
            lblValorHora.Name = "lblValorHora";
            lblValorHora.Size = new Size(65, 15);
            lblValorHora.TabIndex = 3;
            lblValorHora.Text = "Valor Hora:";
            // 
            // lblQuantHoras
            // 
            lblQuantHoras.AutoSize = true;
            lblQuantHoras.Location = new Point(94, 210);
            lblQuantHoras.Name = "lblQuantHoras";
            lblQuantHoras.Size = new Size(106, 15);
            lblQuantHoras.TabIndex = 4;
            lblQuantHoras.Text = "Quantidade Horas:";
            // 
            // txtQuantHoras
            // 
            txtQuantHoras.Location = new Point(240, 202);
            txtQuantHoras.Name = "txtQuantHoras";
            txtQuantHoras.Size = new Size(100, 23);
            txtQuantHoras.TabIndex = 5;
            // 
            // txtValorHora
            // 
            txtValorHora.Location = new Point(240, 149);
            txtValorHora.Name = "txtValorHora";
            txtValorHora.Size = new Size(100, 23);
            txtValorHora.TabIndex = 6;
            // 
            // FormEx6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtValorHora);
            Controls.Add(txtQuantHoras);
            Controls.Add(lblQuantHoras);
            Controls.Add(lblValorHora);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnCal);
            Name = "FormEx6";
            Text = "FormEx6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCal;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblValorHora;
        private Label lblQuantHoras;
        private TextBox txtQuantHoras;
        private TextBox txtValorHora;
    }
}