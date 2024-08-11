namespace ASM2_DB_Winform
{
    partial class UserInformation
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
            btnInsert = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnBack = new Button();
            btnExit = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txbID = new TextBox();
            txbName = new TextBox();
            txbPhone = new TextBox();
            txbAddress = new TextBox();
            lbIDError = new Label();
            lbNameError = new Label();
            lbAddressError = new Label();
            lbPhoneError = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(40, 456);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(555, 456);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(391, 456);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(219, 456);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(876, 474);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(976, 474);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1084, 248);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(411, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 35);
            label1.TabIndex = 7;
            label1.Text = "User information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 311);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 8;
            label2.Text = "Student ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(544, 377);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 9;
            label3.Text = "Student Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 377);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 10;
            label4.Text = "Student Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(544, 311);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 11;
            label5.Text = "Student Address";
            // 
            // txbID
            // 
            txbID.Location = new Point(173, 308);
            txbID.Name = "txbID";
            txbID.Size = new Size(314, 27);
            txbID.TabIndex = 12;
            // 
            // txbName
            // 
            txbName.Location = new Point(173, 374);
            txbName.Name = "txbName";
            txbName.Size = new Size(314, 27);
            txbName.TabIndex = 13;
            // 
            // txbPhone
            // 
            txbPhone.Location = new Point(663, 374);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(314, 27);
            txbPhone.TabIndex = 14;
            // 
            // txbAddress
            // 
            txbAddress.Location = new Point(663, 308);
            txbAddress.Name = "txbAddress";
            txbAddress.Size = new Size(314, 27);
            txbAddress.TabIndex = 14;
            // 
            // lbIDError
            // 
            lbIDError.AutoSize = true;
            lbIDError.Location = new Point(173, 338);
            lbIDError.Name = "lbIDError";
            lbIDError.Size = new Size(0, 20);
            lbIDError.TabIndex = 15;
            // 
            // lbNameError
            // 
            lbNameError.AutoSize = true;
            lbNameError.Location = new Point(173, 404);
            lbNameError.Name = "lbNameError";
            lbNameError.Size = new Size(0, 20);
            lbNameError.TabIndex = 16;
            // 
            // lbAddressError
            // 
            lbAddressError.AutoSize = true;
            lbAddressError.Location = new Point(663, 338);
            lbAddressError.Name = "lbAddressError";
            lbAddressError.Size = new Size(0, 20);
            lbAddressError.TabIndex = 17;
            // 
            // lbPhoneError
            // 
            lbPhoneError.AutoSize = true;
            lbPhoneError.Location = new Point(663, 404);
            lbPhoneError.Name = "lbPhoneError";
            lbPhoneError.Size = new Size(0, 20);
            lbPhoneError.TabIndex = 18;
            // 
            // UserInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 515);
            Controls.Add(lbPhoneError);
            Controls.Add(lbAddressError);
            Controls.Add(lbNameError);
            Controls.Add(lbIDError);
            Controls.Add(txbAddress);
            Controls.Add(txbPhone);
            Controls.Add(txbName);
            Controls.Add(txbID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnInsert);
            Name = "UserInformation";
            Text = "UserInformation";
            Load += UserInformation_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsert;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnBack;
        private Button btnExit;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txbID;
        private TextBox txbName;
        private TextBox txbPhone;
        private TextBox txbAddress;
        private Label lbIDError;
        private Label lbNameError;
        private Label lbAddressError;
        private Label lbPhoneError;
    }
}