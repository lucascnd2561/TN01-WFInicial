﻿namespace WFinicial
{
    partial class FormEx4
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
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            lblNum2 = new Label();
            lblNum1 = new Label();
            btnMaior = new Button();
            txtNum3 = new TextBox();
            lblNum3 = new Label();
            SuspendLayout();
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(360, 169);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 9;
            txtNum2.TextChanged += this.txtNum2_TextChanged;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(360, 95);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 8;
            txtNum1.TextChanged += this.txtNum1_TextChanged;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(283, 177);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(60, 15);
            lblNum2.TabIndex = 7;
            lblNum2.Text = "Número2:";
            lblNum2.Click += this.lblNum2_Click;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(283, 103);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(60, 15);
            lblNum1.TabIndex = 6;
            lblNum1.Text = "Número1:";
            lblNum1.Click += this.lblNum1_Click;
            // 
            // btnMaior
            // 
            btnMaior.Location = new Point(292, 314);
            btnMaior.Name = "btnMaior";
            btnMaior.Size = new Size(168, 40);
            btnMaior.TabIndex = 5;
            btnMaior.Text = "Mostrar Maior";
            btnMaior.UseVisualStyleBackColor = true;
            btnMaior.Click += btnMaior_Click;
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(360, 237);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(100, 23);
            txtNum3.TabIndex = 11;
            txtNum3.TextChanged += txtNum3_TextChanged;
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Location = new Point(283, 237);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(60, 15);
            lblNum3.TabIndex = 10;
            lblNum3.Text = "Número3:";
            lblNum3.Click += this.lblNum3_Click;
            // 
            // FormEx4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNum3);
            Controls.Add(lblNum3);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(btnMaior);
            Name = "FormEx4";
            Text = "FormEx4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum2;
        private TextBox txtNum1;
        private Label lblNum2;
        private Label lblNum1;
        private Button btnMaior;
        private TextBox txtNum3;
        private Label lblNum3;
    }
}