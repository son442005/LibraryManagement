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
    public partial class LibraryManagement : Form
    {
        SqlConnection connection;
        public LibraryManagement()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=LAPTOP-402M7NAC\\SQLEXPRESS;Database=LibraryManagement; Integrated Security = true;");
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

        public void GetCategories()
        {
            string query = "select * from Category";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            cbCategory.DataSource = tbl;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
        }
        private void LibraryManagement_Load(object sender, EventArgs e)
        {
            connection.Open();
            FillData();
            GetCategories();
        }

        private void btnLogout2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Dispose();
            }
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            int error = 0;
            string id = txbBookID.Text;
            if (id.Equals(""))
            {
                error = error + 1;
                lbIDError.Text = "ID can't be blank";
            }
            else
                lbIDError.Text = "";
            string title = txbTitle.Text;
            if (title.Equals(""))
            {
                error = error + 1;
                lbTitleError.Text = "Title can't be blank";
            }
            else
                lbTitleError.Text = "";

            string author = txbAuthor.Text;
            if (author.Equals(""))
            {
                error = error + 1;
                lbAuthorError.Text = "Author can't be blank";
            }
            else
                lbAuthorError.Text = "";


            string quantity = txbQuantity.Text;

            if (quantity.Equals(""))
            {
                error = error + 1;
                lbQuantityError.Text = "Quantity can't be blank";
            }
            else if (decimal.TryParse(txbQuantity.Text, out decimal number))
            {
                if (number <= 0)
                {
                    lbQuantityError.Text = "Invalid Value";
                }
                else
                {
                    string query = "select * from Books where BookID = @id";
                    connection.Open();
                    SqlCommand cmdcheck = new SqlCommand(query, connection);
                    cmdcheck.Parameters.Add("@id", SqlDbType.Int);
                    cmdcheck.Parameters["@id"].Value = id;
                    SqlDataReader reader = cmdcheck.ExecuteReader();
                    if (reader.Read())
                    {
                        error++;
                        lbIDError.Text = "This ID is existing, please choose another";
                    }
                    else
                    {
                        lbQuantityError.Text = "";
                    }
                    connection.Close();

                    string catid = cbCategory.SelectedValue.ToString();
                    if (error == 0)
                    {
                        string insert = "insert into Books values (@id, @title, @author, @cateid, @quantity)";
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(insert, connection);
                        cmd.Parameters.Add("@id", SqlDbType.Int);
                        cmd.Parameters["@id"].Value = id;
                        cmd.Parameters.Add("@title", SqlDbType.VarChar);
                        cmd.Parameters["@title"].Value = title;
                        cmd.Parameters.Add("@author", SqlDbType.VarChar);
                        cmd.Parameters["@author"].Value = author;
                        cmd.Parameters.Add("@cateid", SqlDbType.Int);
                        cmd.Parameters["@cateid"].Value = catid;
                        cmd.Parameters.Add("@quantity", SqlDbType.Int);
                        cmd.Parameters["@quantity"].Value = quantity;
                        cmd.ExecuteNonQuery();
                        FillData();

                    }

                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string update = "update Books set Title = @title, Author = @author, quantity = @quantity" +
                    " where BookID = @id";
                connection.Open();
                SqlCommand cmd = new SqlCommand(update, connection);
                cmd.Parameters.Add("@title", SqlDbType.VarChar);
                cmd.Parameters["@title"].Value = txbTitle.Text;
                cmd.Parameters.Add("@author", SqlDbType.VarChar);
                cmd.Parameters["@author"].Value = txbAuthor.Text;
                cmd.Parameters.Add("@quantity", SqlDbType.Int);
                cmd.Parameters["@quantity"].Value = txbQuantity.Text;
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = txbBookID.Text;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    FillData();

                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.Open();
                string delete = "delete from Books where BookID = @id";
                SqlCommand cmd = new SqlCommand(delete, connection);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = txbBookID.Text;
                cmd.ExecuteNonQuery();
                FillData();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txbBookID.Text = "";
            txbTitle.Text = "";
            txbAuthor.Text = "";
            cbCategory.SelectedIndex = 0;
            txbQuantity.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txbBookID.Text = row.Cells["BookID"].Value.ToString();
                txbTitle.Text = row.Cells["Title"].Value.ToString();
                txbAuthor.Text = row.Cells["Author"].Value.ToString();
                txbQuantity.Text = row.Cells["Quantity"].Value.ToString();
                cbCategory.SelectedValue = row.Cells["CategoryID"].Value.ToString();
            }
        }

        private void btnCheckloan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loans loans = new Loans();
            loans.ShowDialog();
            this.Dispose();

        }

        private void btnCheckUserIn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInformation userInformation = new UserInformation();
            userInformation.ShowDialog();
            this.Dispose();
        }

        private void btnCheckDmgbook_Click(object sender, EventArgs e)
        {
            this.Hide();
            DamagedBook damagedBook = new DamagedBook();
            damagedBook.ShowDialog();
            this.Dispose();
        }
    }
}
    

