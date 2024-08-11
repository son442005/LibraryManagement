namespace ASM2_DB_Winform
{
    partial class DamagedBook
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
            dataGridView1 = new DataGridView();
            btnInsert = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnBack = new Button();
            btnExit3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txbBookID = new TextBox();
            txbTitle = new TextBox();
            txbDateStr = new TextBox();
            txbAuthor = new TextBox();
            txbDescription = new TextBox();
            cbCategory = new ComboBox();
            lbBookIDError = new Label();
            lbTitleError = new Label();
            lbAuthorError = new Label();
            lbDescriptionError = new Label();
            lbDateError = new Label();
            lbCategoryError = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(416, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 35);
            label1.TabIndex = 0;
            label1.Text = "Damaged Book";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1073, 264);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(30, 473);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(539, 473);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(363, 473);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(195, 473);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(872, 473);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit3
            // 
            btnExit3.Location = new Point(972, 473);
            btnExit3.Name = "btnExit3";
            btnExit3.Size = new Size(94, 29);
            btnExit3.TabIndex = 7;
            btnExit3.Text = "Exit";
            btnExit3.UseVisualStyleBackColor = true;
            btnExit3.Click += btnExit3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 333);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 8;
            label2.Text = "Book ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 400);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 9;
            label3.Text = "Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 333);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 10;
            label4.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(326, 400);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 11;
            label5.Text = "Date Damaged";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(634, 400);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 12;
            label6.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(634, 333);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 13;
            label7.Text = "Description";
            // 
            // txbBookID
            // 
            txbBookID.Location = new Point(108, 330);
            txbBookID.Name = "txbBookID";
            txbBookID.Size = new Size(125, 27);
            txbBookID.TabIndex = 14;
            // 
            // txbTitle
            // 
            txbTitle.Location = new Point(108, 397);
            txbTitle.Name = "txbTitle";
            txbTitle.Size = new Size(199, 27);
            txbTitle.TabIndex = 15;
            // 
            // txbDateStr
            // 
            txbDateStr.Location = new Point(443, 397);
            txbDateStr.Name = "txbDateStr";
            txbDateStr.Size = new Size(176, 27);
            txbDateStr.TabIndex = 16;
            // 
            // txbAuthor
            // 
            txbAuthor.Location = new Point(443, 330);
            txbAuthor.Name = "txbAuthor";
            txbAuthor.Size = new Size(176, 27);
            txbAuthor.TabIndex = 17;
            // 
            // txbDescription
            // 
            txbDescription.Location = new Point(725, 330);
            txbDescription.Name = "txbDescription";
            txbDescription.Size = new Size(305, 27);
            txbDescription.TabIndex = 18;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(725, 397);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(189, 28);
            cbCategory.TabIndex = 19;
            // 
            // lbBookIDError
            // 
            lbBookIDError.AutoSize = true;
            lbBookIDError.Location = new Point(108, 360);
            lbBookIDError.Name = "lbBookIDError";
            lbBookIDError.Size = new Size(0, 20);
            lbBookIDError.TabIndex = 20;
            // 
            // lbTitleError
            // 
            lbTitleError.AutoSize = true;
            lbTitleError.Location = new Point(108, 427);
            lbTitleError.Name = "lbTitleError";
            lbTitleError.Size = new Size(0, 20);
            lbTitleError.TabIndex = 21;
            // 
            // lbAuthorError
            // 
            lbAuthorError.AutoSize = true;
            lbAuthorError.Location = new Point(444, 363);
            lbAuthorError.Name = "lbAuthorError";
            lbAuthorError.Size = new Size(0, 20);
            lbAuthorError.TabIndex = 22;
            // 
            // lbDescriptionError
            // 
            lbDescriptionError.AutoSize = true;
            lbDescriptionError.Location = new Point(727, 362);
            lbDescriptionError.Name = "lbDescriptionError";
            lbDescriptionError.Size = new Size(0, 20);
            lbDescriptionError.TabIndex = 23;
            // 
            // lbDateError
            // 
            lbDateError.AutoSize = true;
            lbDateError.Location = new Point(445, 431);
            lbDateError.Name = "lbDateError";
            lbDateError.Size = new Size(0, 20);
            lbDateError.TabIndex = 24;
            // 
            // lbCategoryError
            // 
            lbCategoryError.AutoSize = true;
            lbCategoryError.Location = new Point(726, 430);
            lbCategoryError.Name = "lbCategoryError";
            lbCategoryError.Size = new Size(0, 20);
            lbCategoryError.TabIndex = 25;
            // 
            // DamagedBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 514);
            Controls.Add(lbCategoryError);
            Controls.Add(lbDateError);
            Controls.Add(lbDescriptionError);
            Controls.Add(lbAuthorError);
            Controls.Add(lbTitleError);
            Controls.Add(lbBookIDError);
            Controls.Add(cbCategory);
            Controls.Add(txbDescription);
            Controls.Add(txbAuthor);
            Controls.Add(txbDateStr);
            Controls.Add(txbTitle);
            Controls.Add(txbBookID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnExit3);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnInsert);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "DamagedBook";
            Text = "DamagedBook";
            Load += DamagedBook_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnInsert;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnBack;
        private Button btnExit3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txbBookID;
        private TextBox txbTitle;
        private TextBox txbDateStr;
        private TextBox txbAuthor;
        private TextBox txbDescription;
        private ComboBox cbCategory;
        private Label lbBookIDError;
        private Label lbTitleError;
        private Label lbAuthorError;
        private Label lbDescriptionError;
        private Label lbDateError;
        private Label lbCategoryError;
    }
}