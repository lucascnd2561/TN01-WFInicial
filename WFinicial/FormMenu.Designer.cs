namespace WFinicial
{
    partial class FormMenu
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
            btnEx1 = new Button();
            btnEx2 = new Button();
            btnEX3 = new Button();
            btnEx4 = new Button();
            btnEX5 = new Button();
            btnEx6 = new Button();
            btnEx7 = new Button();
            SuspendLayout();
            // 
            // btnEx1
            // 
            btnEx1.Location = new Point(39, 30);
            btnEx1.Name = "btnEx1";
            btnEx1.Size = new Size(75, 23);
            btnEx1.TabIndex = 0;
            btnEx1.Text = "Exercício 1:";
            btnEx1.UseVisualStyleBackColor = true;
            btnEx1.Click += btnEx1_Click;
            // 
            // btnEx2
            // 
            btnEx2.Location = new Point(173, 30);
            btnEx2.Name = "btnEx2";
            btnEx2.Size = new Size(75, 23);
            btnEx2.TabIndex = 1;
            btnEx2.Text = "Exercício 2";
            btnEx2.UseVisualStyleBackColor = true;
            btnEx2.Click += btnEx2_Click;
            // 
            // btnEX3
            // 
            btnEX3.Location = new Point(305, 30);
            btnEX3.Name = "btnEX3";
            btnEX3.Size = new Size(75, 23);
            btnEX3.TabIndex = 2;
            btnEX3.Text = "Exercício 3";
            btnEX3.UseVisualStyleBackColor = true;
            btnEX3.Click += btnEX3_Click;
            // 
            // btnEx4
            // 
            btnEx4.Location = new Point(442, 30);
            btnEx4.Name = "btnEx4";
            btnEx4.Size = new Size(75, 23);
            btnEx4.TabIndex = 3;
            btnEx4.Text = "Exercício 4";
            btnEx4.UseVisualStyleBackColor = true;
            btnEx4.Click += btnEx4_Click;
            // 
            // btnEX5
            // 
            btnEX5.Location = new Point(39, 103);
            btnEX5.Name = "btnEX5";
            btnEX5.Size = new Size(75, 23);
            btnEX5.TabIndex = 4;
            btnEX5.Text = "Exercício 5";
            btnEX5.UseVisualStyleBackColor = true;
            btnEX5.Click += btnEX5_Click;
            // 
            // btnEx6
            // 
            btnEx6.Location = new Point(173, 103);
            btnEx6.Name = "btnEx6";
            btnEx6.Size = new Size(75, 23);
            btnEx6.TabIndex = 5;
            btnEx6.Text = "Exercício 6";
            btnEx6.UseVisualStyleBackColor = true;
            btnEx6.Click += btnEx6_Click;
            // 
            // btnEx7
            // 
            btnEx7.Location = new Point(305, 103);
            btnEx7.Name = "btnEx7";
            btnEx7.Size = new Size(75, 23);
            btnEx7.TabIndex = 6;
            btnEx7.Text = "Exercício 7";
            btnEx7.UseVisualStyleBackColor = true;
            btnEx7.Click += btnEx7_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEx7);
            Controls.Add(btnEx6);
            Controls.Add(btnEX5);
            Controls.Add(btnEx4);
            Controls.Add(btnEX3);
            Controls.Add(btnEx2);
            Controls.Add(btnEx1);
            Name = "FormMenu";
            Text = "FormMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEx1;
        private Button btnEx2;
        private Button btnEX3;
        private Button btnEx4;
        private Button btnEX5;
        private Button btnEx6;
        private Button btnEx7;
    }
}