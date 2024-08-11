using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ASM2_DB_Winform
{
    public partial class Loans : Form
    {
        SqlConnection connection;
        public Loans()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=LAPTOP-402M7NAC\\SQLEXPRESS;Database=LibraryManagement; Integrated Security = true;");
        }

        public void FillData()
        {
            string query = "select * from Loans";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            dataGridView1.DataSource = tbl;
            connection.Close();
        }

        private void Loans_Load(object sender, EventArgs e)
        {
            connection.Open();
            FillData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryManagement libraryManagement = new LibraryManagement();
            libraryManagement.ShowDialog();
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int error = 0;
            string loanID = txbLoanID.Text;
            string loanDateStr = txbLoandateStr.Text;
            string dueDateStr = txbDuedateStr.Text;
            string studentID = txbStudentID.Text;
            string bookID = txbBookID.Text;
            DateTime loanDate;
            DateTime dueDate;

            lbLoanIDError.Text = "";
            lbLoandateError.Text = "";
            lbDuedateError.Text = "";
            lbStudentIDError.Text = "";
            lbBookIDError.Text = "";

            if (loanID.Equals(""))
            {
                error++;
                lbLoanIDError.Text = "ID can't be blank";
            }

            if (loanDateStr.Equals(""))
            {
                error++;
                lbLoandateError.Text = "Loan Date can't be blank";
            }
            else
            {
                if (!DateTime.TryParse(loanDateStr, out loanDate))
                {
                    error++;
                    lbLoandateError.Text = "Loan Date is not valid. Please enter a valid date.";
                }
                else if (loanDate > DateTime.Now)
                {
                    error++;
                    lbLoandateError.Text = "Loan Date can't be in the future.";
                }
            }

            if (dueDateStr.Equals(""))
            {
                error++;
                lbDuedateError.Text = "Due Date can't be blank";
            }
            else
            {
                if (!DateTime.TryParse(dueDateStr, out dueDate))
                {
                    error++;
                    lbDuedateError.Text = "Due Date is not valid. Please enter a valid date.";
                }

            }

            if (studentID.Equals(""))
            {
                error++;
                lbStudentIDError.Text = "Student ID can't be blank";
            }

            if (bookID.Equals(""))
            {
                error++;
                lbBookIDError.Text = "Book ID can't be blank";
            }

            if (error == 0)
            {
                string query = "select * from Loans where LoanID = @id";
                connection.Open();
                SqlCommand cmdcheck = new SqlCommand(query, connection);
                cmdcheck.Parameters.Add("@id", SqlDbType.Int);
                cmdcheck.Parameters["@id"].Value = loanID;
                SqlDataReader reader = cmdcheck.ExecuteReader();
                if (reader.Read())
                {
                    error++;
                    lbLoanIDError.Text = "This ID already exists, please choose another";
                }
                connection.Close();
            }

            if (error == 0)
            {
                string insert = "insert into Loans (LoanID, LoanDate, DueDate, StudentID, BookID) values (@loanid, @loandate, @duedate, @studentid, @bookid)";
                connection.Open();
                SqlCommand cmd = new SqlCommand(insert, connection);
                cmd.Parameters.Add("@loanid", SqlDbType.Int);
                cmd.Parameters["@loanid"].Value = loanID;
                cmd.Parameters.Add("@loandate", SqlDbType.DateTime);
                cmd.Parameters["@loandate"].Value = DateTime.Parse(loanDateStr); 
                cmd.Parameters.Add("@duedate", SqlDbType.DateTime);
                cmd.Parameters["@duedate"].Value = DateTime.Parse(dueDateStr);
                cmd.Parameters.Add("@studentid", SqlDbType.Int);
                cmd.Parameters["@studentid"].Value = studentID;
                cmd.Parameters.Add("@bookid", SqlDbType.Int);
                cmd.Parameters["@bookid"].Value = bookID;
                cmd.ExecuteNonQuery();
                connection.Close();
                FillData();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DateTime loanDate;
                DateTime dueDate;

                bool isLoanDateValid = DateTime.TryParse(txbLoandateStr.Text, out loanDate);
                bool isDueDateValid = DateTime.TryParse(txbDuedateStr.Text, out dueDate);

                if (!isLoanDateValid)
                {
                    lbLoandateError.Text = "Loan Date is not valid. Please enter a valid date.";
                    return;
                }
                if (!isDueDateValid)
                {
                    lbDuedateError.Text = "Due Date is not valid. Please enter a valid date.";
                    return;
                }

                if (loanDate > DateTime.Now)
                {
                    lbLoandateError.Text = "Loan Date can't be in the future.";
                    return;
                }
                if (dueDate > DateTime.Now)
                {
                    lbDuedateError.Text = "Due date cannot be in the future.";
                    return;
                }

                string update = "update Loans set LoanDate = @loandate, DueDate = @duedate, StudentID = @studentid, BookID = @bookid where LoanID = @loanid";
                SqlCommand cmd = new SqlCommand(update, connection);
                cmd.Parameters.AddWithValue("@loandate", DateTime.Parse(txbLoandateStr.Text));
                cmd.Parameters.AddWithValue("@duedate", DateTime.Parse(txbDuedateStr.Text));
                cmd.Parameters.AddWithValue("@studentid", txbStudentID.Text);
                cmd.Parameters.AddWithValue("@bookid", txbBookID.Text);
                cmd.Parameters.AddWithValue("@loanid", txbLoanID.Text);
                connection.Open();
                int i = cmd.ExecuteNonQuery();
                connection.Close();
                if (i > 0)
                {
                    FillData();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txbLoanID.Text = row.Cells["LoanID"].Value.ToString();
                txbLoandateStr.Text = row.Cells["LoanDate"].Value.ToString();
                txbDuedateStr.Text = row.Cells["DueDate"].Value.ToString();
                txbStudentID.Text = row.Cells["StudentID"].Value.ToString();
                txbBookID.Text = row.Cells["BookID"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.Open();
                string delete = "delete from Loans where LoanID = @loanid";
                SqlCommand cmd = new SqlCommand(delete, connection);
                cmd.Parameters.Add("@loanid", SqlDbType.Int);
                cmd.Parameters["@loanid"].Value = txbBookID.Text;
                cmd.ExecuteNonQuery();
                FillData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txbLoanID.Text = "";
            txbLoandateStr.Text = "";
            txbDuedateStr.Text = "";
            txbStudentID.Text = "";
            txbBookID.Text = "";
        }
    }
}
