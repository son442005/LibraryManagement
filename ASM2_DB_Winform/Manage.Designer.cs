namespace ASM2_DB_Winform
{
    partial class Manage
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
            btnCheckCate = new Button();
            btnCheckBorrower = new Button();
            btnCheckread = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbCate = new Label();
            lbBorrower = new Label();
            lbRead = new Label();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 9);
            label1.Name = "label1";
            label1.Size = new Size(370, 46);
            label1.TabIndex = 0;
            label1.Text = "Library statistics";
            // 
            // btnCheckCate
            // 
            btnCheckCate.Location = new Point(199, 94);
            btnCheckCate.Name = "btnCheckCate";
            btnCheckCate.Size = new Size(94, 29);
            btnCheckCate.TabIndex = 1;
            btnCheckCate.Text = "Check";
            btnCheckCate.UseVisualStyleBackColor = true;
            btnCheckCate.Click += btnCheckCate_Click;
            // 
            // btnCheckBorrower
            // 
            btnCheckBorrower.Location = new Point(199, 193);
            btnCheckBorrower.Name = "btnCheckBorrower";
            btnCheckBorrower.Size = new Size(94, 29);
            btnCheckBorrower.TabIndex = 2;
            btnCheckBorrower.Text = "Check";
            btnCheckBorrower.UseVisualStyleBackColor = true;
            btnCheckBorrower.Click += btnCheckBorrower_Click;
            // 
            // btnCheckread
            // 
            btnCheckread.Location = new Point(199, 298);
            btnCheckread.Name = "btnCheckread";
            btnCheckread.Size = new Size(94, 29);
            btnCheckread.TabIndex = 3;
            btnCheckread.Text = "Check";
            btnCheckread.UseVisualStyleBackColor = true;
            btnCheckread.Click += btnCheckread_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 98);
            label2.Name = "label2";
            label2.Size = new Size(176, 20);
            label2.TabIndex = 4;
            label2.Text = "Most borrowed category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 197);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 5;
            label3.Text = "Most borrowers:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 302);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 6;
            label4.Text = "Most read month:";
            // 
            // lbCate
            // 
            lbCate.AutoSize = true;
            lbCate.Location = new Point(54, 137);
            lbCate.Name = "lbCate";
            lbCate.Size = new Size(0, 20);
            lbCate.TabIndex = 7;
            // 
            // lbBorrower
            // 
            lbBorrower.AutoSize = true;
            lbBorrower.Location = new Point(54, 234);
            lbBorrower.Name = "lbBorrower";
            lbBorrower.Size = new Size(0, 20);
            lbBorrower.TabIndex = 8;
            // 
            // lbRead
            // 
            lbRead.AutoSize = true;
            lbRead.Location = new Point(54, 338);
            lbRead.Name = "lbRead";
            lbRead.Size = new Size(0, 20);
            lbRead.TabIndex = 9;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(714, 371);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Manage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 412);
            Controls.Add(btnLogout);
            Controls.Add(lbRead);
            Controls.Add(lbBorrower);
            Controls.Add(lbCate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCheckread);
            Controls.Add(btnCheckBorrower);
            Controls.Add(btnCheckCate);
            Controls.Add(label1);
            Name = "Manage";
            Text = "Manage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCheckCate;
        private Button btnCheckBorrower;
        private Button btnCheckread;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbCate;
        private Label lbBorrower;
        private Label lbRead;
        private Button btnLogout;
    }
}