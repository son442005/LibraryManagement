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
    public partial class BookList : Form
    {
        SqlConnection connection;
        public BookList()
        {
            InitializeComponent();
            connection = new SqlConnection("Server =  LAPTOP-402M7NAC\\SQLEXPRESS; Database = LibraryManagement; Integrated Security = true;");
        }

        public void FillData()
        {
            string query = "select * from Books";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            dataGridView1.DataSource = tbl;
            connection.Close();
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            connection.Open();
            GetCategories();
            FillData();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string bookTitle = txbTitle.Text.Trim();

            int categoryId = (int)cbCate.SelectedValue;

            string query = @"
            SELECT BookID, Title, Author, CategoryID, Quantity
            FROM Books
            WHERE Title LIKE @Title AND CategoryID = @CategoryID";


            using (SqlCommand command = new SqlCommand(query, connection))
            {
                 command.Parameters.AddWithValue("@Title", "%" + bookTitle + "%");  
                 command.Parameters.AddWithValue("@CategoryID", categoryId);
                 SqlDataAdapter adapter = new SqlDataAdapter(command);
                 DataTable dataTable = new DataTable();
                 adapter.Fill(dataTable);
                 dataGridView1.DataSource = dataTable;
            }
            

        }
        public void GetCategories()
        {
            string query = "SELECT CategoryID, CategoryName FROM Category";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            cbCate.DataSource = tbl;
            cbCate.DisplayMember = "CategoryName";
            cbCate.ValueMember = "CategoryID";
        }
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
