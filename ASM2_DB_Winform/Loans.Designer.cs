namespace ASM2_DB_Winform
{
    partial class Loans
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
            btnBack = new Button();
            btnExit = new Button();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txbLoandateStr = new TextBox();
            txbDuedateStr = new TextBox();
            txbStudentID = new TextBox();
            txbBookID = new TextBox();
            label6 = new Label();
            txbLoanID = new TextBox();
            lbLoanIDError = new Label();
            lbLoandateError = new Label();
            lbDuedateError = new Label();
            lbStudentIDError = new Label();
            lbBookIDError = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(466, 5);
            label1.Name = "label1";
            label1.Size = new Size(138, 46);
            label1.TabIndex = 0;
            label1.Text = "Loans";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1070, 250);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(866, 469);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(966, 469);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(56, 471);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(396, 471);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(219, 471);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(554, 469);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 335);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 7;
            label2.Text = "Loan Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 397);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 8;
            label3.Text = "Due Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(554, 332);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 9;
            label4.Text = "Student ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(554, 397);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 10;
            label5.Text = "Book ID";
            // 
            // txbLoandateStr
            // 
            txbLoandateStr.Location = new Point(312, 332);
            txbLoandateStr.Name = "txbLoandateStr";
            txbLoandateStr.Size = new Size(222, 27);
            txbLoandateStr.TabIndex = 11;
            // 
            // txbDuedateStr
            // 
            txbDuedateStr.Location = new Point(312, 394);
            txbDuedateStr.Name = "txbDuedateStr";
            txbDuedateStr.Size = new Size(225, 27);
            txbDuedateStr.TabIndex = 12;
            // 
            // txbStudentID
            // 
            txbStudentID.Location = new Point(655, 332);
            txbStudentID.Name = "txbStudentID";
            txbStudentID.Size = new Size(225, 27);
            txbStudentID.TabIndex = 13;
            // 
            // txbBookID
            // 
            txbBookID.Location = new Point(655, 393);
            txbBookID.Name = "txbBookID";
            txbBookID.Size = new Size(225, 27);
            txbBookID.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 339);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 15;
            label6.Text = "Loan ID";
            // 
            // txbLoanID
            // 
            txbLoanID.Location = new Point(108, 336);
            txbLoanID.Name = "txbLoanID";
            txbLoanID.Size = new Size(71, 27);
            txbLoanID.TabIndex = 16;
            // 
            // lbLoanIDError
            // 
            lbLoanIDError.AutoSize = true;
            lbLoanIDError.Location = new Point(108, 366);
            lbLoanIDError.Name = "lbLoanIDError";
            lbLoanIDError.Size = new Size(0, 20);
            lbLoanIDError.TabIndex = 17;
            // 
            // lbLoandateError
            // 
            lbLoandateError.AutoSize = true;
            lbLoandateError.Location = new Point(312, 362);
            lbLoandateError.Name = "lbLoandateError";
            lbLoandateError.Size = new Size(0, 20);
            lbLoandateError.TabIndex = 18;
            // 
            // lbDuedateError
            // 
            lbDuedateError.AutoSize = true;
            lbDuedateError.Location = new Point(312, 424);
            lbDuedateError.Name = "lbDuedateError";
            lbDuedateError.Size = new Size(0, 20);
            lbDuedateError.TabIndex = 19;
            // 
            // lbStudentIDError
            // 
            lbStudentIDError.AutoSize = true;
            lbStudentIDError.Location = new Point(655, 362);
            lbStudentIDError.Name = "lbStudentIDError";
            lbStudentIDError.Size = new Size(0, 20);
            lbStudentIDError.TabIndex = 20;
            // 
            // lbBookIDError
            // 
            lbBookIDError.AutoSize = true;
            lbBookIDError.Location = new Point(655, 424);
            lbBookIDError.Name = "lbBookIDError";
            lbBookIDError.Size = new Size(0, 20);
            lbBookIDError.TabIndex = 21;
            // 
            // Loans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 512);
            Controls.Add(lbBookIDError);
            Controls.Add(lbStudentIDError);
            Controls.Add(lbDuedateError);
            Controls.Add(lbLoandateError);
            Controls.Add(lbLoanIDError);
            Controls.Add(txbLoanID);
            Controls.Add(label6);
            Controls.Add(txbBookID);
            Controls.Add(txbStudentID);
            Controls.Add(txbDuedateStr);
            Controls.Add(txbLoandateStr);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Loans";
            Text = "Loans";
            Load += Loans_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnBack;
        private Button btnExit;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCancel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txbLoandateStr;
        private TextBox txbDuedateStr;
        private TextBox txbStudentID;
        private TextBox txbBookID;
        private Label label6;
        private TextBox txbLoanID;
        private Label lbLoanIDError;
        private Label lbLoandateError;
        private Label lbDuedateError;
        private Label lbStudentIDError;
        private Label lbBookIDError;
    }
}