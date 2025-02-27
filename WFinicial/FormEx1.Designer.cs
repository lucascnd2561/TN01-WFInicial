namespace WFinicial
{
    partial class FormEx1
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
            lblNota1 = new Label();
            btncalcular = new Button();
            lblnota2 = new Label();
            txtnota1 = new TextBox();
            txtnota2 = new TextBox();
            SuspendLayout();
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(76, 34);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(48, 15);
            lblNota1.TabIndex = 0;
            lblNota1.Text = "Nota 1: ";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(85, 131);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(152, 23);
            btncalcular.TabIndex = 1;
            btncalcular.Text = "Calcular Média";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // lblnota2
            // 
            lblnota2.AutoSize = true;
            lblnota2.Location = new Point(76, 65);
            lblnota2.Name = "lblnota2";
            lblnota2.Size = new Size(45, 15);
            lblnota2.TabIndex = 2;
            lblnota2.Text = "Nota 2:";
            // 
            // txtnota1
            // 
            txtnota1.Location = new Point(137, 26);
            txtnota1.Name = "txtnota1";
            txtnota1.Size = new Size(100, 23);
            txtnota1.TabIndex = 3;
            // 
            // txtnota2
            // 
            txtnota2.Location = new Point(137, 62);
            txtnota2.Name = "txtnota2";
            txtnota2.Size = new Size(100, 23);
            txtnota2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtnota2);
            Controls.Add(txtnota1);
            Controls.Add(lblnota2);
            Controls.Add(btncalcular);
            Controls.Add(lblNota1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNota1;
        private Button btncalcular;
        private Label lblnota2;
        private TextBox txtnota1;
        private TextBox txtnota2;
    }
}
