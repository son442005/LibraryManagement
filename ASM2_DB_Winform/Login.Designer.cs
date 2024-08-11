namespace ASM2_DB_Winform
{
    partial class Login
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
            label1 = new Label();
            txbUsername = new TextBox();
            txbPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            lbError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 44);
            label1.Name = "label1";
            label1.Size = new Size(180, 62);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(235, 146);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(311, 27);
            txbUsername.TabIndex = 1;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(235, 216);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(311, 27);
            txbPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 149);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 219);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(255, 287);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(412, 287);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lbError
            // 
            lbError.AutoSize = true;
            lbError.BackColor = Color.White;
            lbError.ForeColor = Color.Red;
            lbError.Location = new Point(253, 253);
            lbError.Name = "lbError";
            lbError.Size = new Size(0, 20);
            lbError.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbError);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txbPassword);
            Controls.Add(txbUsername);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbUsername;
        private TextBox txbPassword;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private Button btnExit;
        private Label lbError;
    }
}