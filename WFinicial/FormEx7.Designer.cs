namespace WFinicial
{
    partial class FormEx7
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
            lblProduto = new Label();
            txtNomeProduto = new TextBox();
            txtValorProduto = new TextBox();
            btnCadastrar = new Button();
            lblValor = new Label();
            SuspendLayout();
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(180, 70);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(53, 15);
            lblProduto.TabIndex = 1;
            lblProduto.Text = "Produto:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(278, 62);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(100, 23);
            txtNomeProduto.TabIndex = 2;
            // 
            // txtValorProduto
            // 
            txtValorProduto.Location = new Point(278, 141);
            txtValorProduto.Name = "txtValorProduto";
            txtValorProduto.Size = new Size(100, 23);
            txtValorProduto.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(270, 247);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(108, 23);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(180, 149);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(36, 15);
            lblValor.TabIndex = 5;
            lblValor.Text = "Valor:";
            // 
            // FormEx7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblValor);
            Controls.Add(btnCadastrar);
            Controls.Add(txtValorProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblProduto);
            Name = "FormEx7";
            Text = "FormEx7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduto;
        private TextBox txtNomeProduto;
        private TextBox txtValorProduto;
        private Button btnCadastrar;
        private Label lblValor;
    }
}