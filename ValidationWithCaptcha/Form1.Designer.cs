namespace ValidationWithCaptcha
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
            loginButton = new Button();
            captchaLabel = new Label();
            captchaTextBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(53, 184);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
            loginButton.TabIndex = 0;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // captchaLabel
            // 
            captchaLabel.Location = new Point(86, 8);
            captchaLabel.Name = "captchaLabel";
            captchaLabel.Size = new Size(158, 56);
            captchaLabel.TabIndex = 1;
            // 
            // captchaTextBox
            // 
            captchaTextBox.Location = new Point(152, 75);
            captchaTextBox.Name = "captchaTextBox";
            captchaTextBox.Size = new Size(125, 27);
            captchaTextBox.TabIndex = 2;
            captchaTextBox.TextChanged += captchaTextBox_TextChanged;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(39, 88);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(125, 27);
            usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(39, 139);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(125, 27);
            passwordTextBox.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(usernameTextBox);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(loginButton);
            panel1.Location = new Point(300, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 252);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(39, 117);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 7;
            label2.Text = "Пароль:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(39, 66);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 6;
            label1.Text = "Логин:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.YellowGreen;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(captchaTextBox);
            panel2.Controls.Add(captchaLabel);
            panel2.Location = new Point(230, 325);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 108);
            panel2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(29, 77);
            label3.Name = "label3";
            label3.Size = new Size(117, 19);
            label3.TabIndex = 8;
            label3.Text = "Введите капчу:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button loginButton;
        private Label captchaLabel;
        private TextBox captchaTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label3;
    }
}
