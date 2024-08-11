using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM2_DB_Winform
{
    public partial class Manage : Form
    {
        SqlConnection connection;
        public Manage()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=LAPTOP-402M7NAC\\SQLEXPRESS; Database = LibraryManagement; Integrated Security = true;");
        }

        private void btnCheckCate_Click(object sender, EventArgs e)
        {
            string query = @"
                    SELECT TOP 1
                        c.CategoryName,
                        COUNT(b.BookID) AS NumberOfBooksBorrowed
                    FROM
                        Loans br
                    JOIN
                        Books b ON br.BookID = b.BookID
                    JOIN
                        Category c ON b.CategoryID = c.CategoryID
                    GROUP BY
                        c.CategoryName
                    ORDER BY
                        NumberOfBooksBorrowed DESC;
                ";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    string categoryName = row["CategoryName"].ToString();
                    string numberOfBooksBorrowed = row["NumberOfBooksBorrowed"].ToString();

                    lbCate.Text = $"Category: {categoryName} - Number of Books Borrowed: {numberOfBooksBorrowed}";
                }
                else
                {
                    lbCate.Text = "No data available.";
                }
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Dispose();
            }
        }

        private void btnCheckBorrower_Click(object sender, EventArgs e)
        {
            string query = @"
                    SELECT TOP 1
                        r.StudentName,
                        COUNT(b.BookID) AS NumberOfBooksBorrowed
                    FROM
                        Loans br
                    JOIN
                        Students r ON br.StudentID = r.StudentID
                    JOIN
                        Books b ON br.BookID = b.BookID
                    GROUP BY
                        r.StudentName
                    ORDER BY
                        NumberOfBooksBorrowed DESC;
                ";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    string studentName = row["StudentName"].ToString();
                    string numberOfBooksBorrowed = row["NumberOfBooksBorrowed"].ToString();

                    lbBorrower.Text = $"Most borrower: {studentName} - Number of Books Borrowed: {numberOfBooksBorrowed}";
                }
                else
                {
                    lbBorrower.Text = "No data available.";
                }
            }

        }

        private void btnCheckread_Click(object sender, EventArgs e)
        {
            string query = @"
                    SELECT TOP 1
                        DATEPART(YEAR, LoanDate) AS Year,
                        DATEPART(MONTH, LoanDate) AS Month,
                        COUNT(DISTINCT StudentID) AS NumberOfReaders
                    FROM
                        Loans
                    GROUP BY
                        DATEPART(YEAR, LoanDate),
                        DATEPART(MONTH, LoanDate)
                    ORDER BY
                        NumberOfReaders DESC;
                ";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    string year = row["Year"].ToString();
                    string month = row["Month"].ToString();
                    string numberOfReaders = row["NumberOfReaders"].ToString();

                    lbRead.Text = $"Month: {month}/{year} - Number of Readers: {numberOfReaders}";
                }
                else
                {
                    lbRead.Text = "No data available.";
                }
            }
        }
    }
}
