namespace ASM2_DB_Winform
{
    partial class LibraryManagement
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txbBookID = new TextBox();
            txbTitle = new TextBox();
            txbAuthor = new TextBox();
            txbQuantity = new TextBox();
            cbCategory = new ComboBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            label7 = new Label();
            btnCheckloan = new Button();
            btnCheckUserIn4 = new Button();
            btnCheckDmgbook = new Button();
            label8 = new Label();
            label9 = new Label();
            btnLogout2 = new Button();
            lbIDError = new Label();
            lbTitleError = new Label();
            lbAuthorError = new Label();
            lbQuantityError = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(156, 218);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(944, 285);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(513, 19);
            label1.Name = "label1";
            label1.Size = new Size(221, 23);
            label1.TabIndex = 2;
            label1.Text = "Library Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 65);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 3;
            label2.Text = "BookID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 123);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 4;
            label3.Text = "Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 65);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 5;
            label4.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(494, 123);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 6;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(752, 65);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 7;
            label6.Text = "Category";
            // 
            // txbBookID
            // 
            txbBookID.Location = new Point(275, 62);
            txbBookID.Name = "txbBookID";
            txbBookID.Size = new Size(213, 27);
            txbBookID.TabIndex = 8;
            // 
            // txbTitle
            // 
            txbTitle.Location = new Point(275, 120);
            txbTitle.Name = "txbTitle";
            txbTitle.Size = new Size(213, 27);
            txbTitle.TabIndex = 9;
            // 
            // txbAuthor
            // 
            txbAuthor.Location = new Point(565, 61);
            txbAuthor.Name = "txbAuthor";
            txbAuthor.Size = new Size(181, 27);
            txbAuthor.TabIndex = 10;
            // 
            // txbQuantity
            // 
            txbQuantity.Location = new Point(565, 120);
            txbQuantity.Name = "txbQuantity";
            txbQuantity.Size = new Size(110, 27);
            txbQuantity.TabIndex = 11;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(827, 61);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(232, 28);
            cbCategory.TabIndex = 12;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(249, 183);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 13;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(435, 183);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(625, 183);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(805, 183);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 176);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 18;
            label7.Text = "Loans";
            // 
            // btnCheckloan
            // 
            btnCheckloan.Location = new Point(24, 205);
            btnCheckloan.Name = "btnCheckloan";
            btnCheckloan.Size = new Size(94, 29);
            btnCheckloan.TabIndex = 19;
            btnCheckloan.Text = "Check";
            btnCheckloan.UseVisualStyleBackColor = true;
            btnCheckloan.Click += btnCheckloan_Click;
            // 
            // btnCheckUserIn4
            // 
            btnCheckUserIn4.Location = new Point(24, 285);
            btnCheckUserIn4.Name = "btnCheckUserIn4";
            btnCheckUserIn4.Size = new Size(94, 29);
            btnCheckUserIn4.TabIndex = 20;
            btnCheckUserIn4.Text = "Check";
            btnCheckUserIn4.UseVisualStyleBackColor = true;
            btnCheckUserIn4.Click += btnCheckUserIn4_Click;
            // 
            // btnCheckDmgbook
            // 
            btnCheckDmgbook.Location = new Point(24, 367);
            btnCheckDmgbook.Name = "btnCheckDmgbook";
            btnCheckDmgbook.Size = new Size(94, 29);
            btnCheckDmgbook.TabIndex = 21;
            btnCheckDmgbook.Text = "Check";
            btnCheckDmgbook.UseVisualStyleBackColor = true;
            btnCheckDmgbook.Click += btnCheckDmgbook_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 253);
            label8.Name = "label8";
            label8.Size = new Size(120, 20);
            label8.TabIndex = 22;
            label8.Text = "User Information";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 344);
            label9.Name = "label9";
            label9.Size = new Size(113, 20);
            label9.TabIndex = 23;
            label9.Text = "Damaged Book";
            // 
            // btnLogout2
            // 
            btnLogout2.Location = new Point(24, 463);
            btnLogout2.Name = "btnLogout2";
            btnLogout2.Size = new Size(94, 29);
            btnLogout2.TabIndex = 24;
            btnLogout2.Text = "Logout";
            btnLogout2.UseVisualStyleBackColor = true;
            btnLogout2.Click += btnLogout2_Click;
            // 
            // lbIDError
            // 
            lbIDError.AutoSize = true;
            lbIDError.ForeColor = Color.Red;
            lbIDError.Location = new Point(275, 97);
            lbIDError.Name = "lbIDError";
            lbIDError.Size = new Size(0, 20);
            lbIDError.TabIndex = 25;
            // 
            // lbTitleError
            // 
            lbTitleError.AutoSize = true;
            lbTitleError.ForeColor = Color.Red;
            lbTitleError.Location = new Point(275, 150);
            lbTitleError.Name = "lbTitleError";
            lbTitleError.Size = new Size(0, 20);
            lbTitleError.TabIndex = 26;
            // 
            // lbAuthorError
            // 
            lbAuthorError.AutoSize = true;
            lbAuthorError.ForeColor = Color.Red;
            lbAuthorError.Location = new Point(566, 92);
            lbAuthorError.Name = "lbAuthorError";
            lbAuthorError.Size = new Size(0, 20);
            lbAuthorError.TabIndex = 27;
            // 
            // lbQuantityError
            // 
            lbQuantityError.AutoSize = true;
            lbQuantityError.ForeColor = Color.Red;
            lbQuantityError.Location = new Point(566, 150);
            lbQuantityError.Name = "lbQuantityError";
            lbQuantityError.Size = new Size(0, 20);
            lbQuantityError.TabIndex = 28;
            // 
            // LibraryManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 504);
            Controls.Add(lbQuantityError);
            Controls.Add(lbAuthorError);
            Controls.Add(lbTitleError);
            Controls.Add(lbIDError);
            Controls.Add(btnLogout2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnCheckDmgbook);
            Controls.Add(btnCheckUserIn4);
            Controls.Add(btnCheckloan);
            Controls.Add(label7);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(cbCategory);
            Controls.Add(txbQuantity);
            Controls.Add(txbAuthor);
            Controls.Add(txbTitle);
            Controls.Add(txbBookID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "LibraryManagement";
            Text = "LibraryManagement";
            Load += LibraryManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txbBookID;
        private TextBox txbTitle;
        private TextBox txbAuthor;
        private TextBox txbQuantity;
        private ComboBox cbCategory;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCancel;
        private Label label7;
        private Button btnCheckloan;
        private Button btnCheckUserIn4;
        private Button btnCheckDmgbook;
        private Label label8;
        private Label label9;
        private Button btnLogout2;
        private Label lbIDError;
        private Label lbTitleError;
        private Label lbAuthorError;
        private Label lbQuantityError;
    }
}