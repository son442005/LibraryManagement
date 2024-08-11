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
    public partial class DamagedBook : Form
    {
        SqlConnection connection;
        public DamagedBook()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=LAPTOP-402M7NAC\\SQLEXPRESS;Database=LibraryManagement; Integrated Security = true;");
        }
        public void FillData()
        {
            string query = "select * from DamagedBooks";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            dataGridView1.DataSource = tbl;
            connection.Close();
        }
        public void GetCategories()
        {
            string query = "select CategoryID, CategoryName from Category";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            cbCategory.DataSource = tbl;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
        }

        private void DamagedBook_Load(object sender, EventArgs e)
        {
            connection.Open();
            FillData();
            GetCategories();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int error = 0;
            string bookid = txbBookID.Text;
            string title = txbTitle.Text;
            string author = txbAuthor.Text;
            string description = txbDescription.Text;
            string dateStr = txbDateStr.Text;

            lbBookIDError.Text = "";
            lbTitleError.Text = "";
            lbAuthorError.Text = "";
            lbDescriptionError.Text = "";
            lbDateError.Text = "";

            if (string.IsNullOrWhiteSpace(bookid))
            {
                error++;
                lbBookIDError.Text = "ID can't be blank";
            }
            if (string.IsNullOrWhiteSpace(title))
            {
                error++;
                lbTitleError.Text = "Title can't be blank";
            }
            if (string.IsNullOrWhiteSpace(author))
            {
                error++;
                lbAuthorError.Text = "Author can't be blank";
            }
            if (string.IsNullOrWhiteSpace(description))
            {
                error++;
                lbDescriptionError.Text = "Description can't be blank";
            }
            if (string.IsNullOrWhiteSpace(dateStr))
            {
                error++;
                lbDateError.Text = "DateDamaged can't be blank";
            }
            else
            {
                DateTime date;
                if (!DateTime.TryParse(dateStr, out date))
                {
                    error++;
                    lbDateError.Text = "Invalid date format";
                }
                else if (date > DateTime.Now)
                {
                    error++;
                    lbDateError.Text = "DateDamaged can't be in the future";
                }
            }

            if (error > 0)
            {
                return; 
            }

            string catid = cbCategory.SelectedValue.ToString();
            if (error == 0)
            {
                string insert = "insert into DamagedBooks ( BookID, BookTitle, Author, DateDamaged, DamageDescription, CategoryID) values ( @bookid, @title, @author, @date, @description, @cateid)";
                connection.Open();
                SqlCommand cmd = new SqlCommand(insert, connection);


                cmd.Parameters.Add("@bookid", SqlDbType.Int);
                cmd.Parameters["@bookid"].Value = bookid;
                cmd.Parameters.Add("@title", SqlDbType.VarChar);
                cmd.Parameters["@title"].Value = title;
                cmd.Parameters.Add("@author", SqlDbType.VarChar);
                cmd.Parameters["@author"].Value = author;
                cmd.Parameters.Add("@description", SqlDbType.VarChar);
                cmd.Parameters["@description"].Value = description;
                cmd.Parameters.Add("@cateid", SqlDbType.Int);
                cmd.Parameters["@cateid"].Value = catid;
                cmd.Parameters.Add("@date", SqlDbType.DateTime);
                cmd.Parameters["@date"].Value = dateStr;
                cmd.ExecuteNonQuery();
                connection.Close();
                FillData();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int bookId;
                int categoryId;
                DateTime dateDamaged;

                bool isBookIdValid = int.TryParse(txbBookID.Text, out bookId);
                bool isCategoryIdValid = int.TryParse(cbCategory.SelectedValue?.ToString(), out categoryId);
                bool isDateValid = DateTime.TryParse(txbDateStr.Text, out dateDamaged);

                bool hasError = false;

                if (!isBookIdValid)
                {
                    lbBookIDError.Text = "Invalid Book ID.";
                    hasError = true;
                }
                if (!isCategoryIdValid)
                {
                    lbCategoryError.Text = "Invalid Category ID.";
                    hasError = true;
                }
                if (!isDateValid || dateDamaged > DateTime.Now)
                {
                    lbDateError.Text = "Invalid Date. Date must be a valid date and cannot be in the future.";
                    hasError = true;
                }

                if (hasError)
                {
                    return;
                }

                string update = "UPDATE DamagedBooks SET BookTitle = @title, Author = @author, DateDamaged = @date, " +
                                "DamageDescription = @description, CategoryID = @catid WHERE BookID = @bookid";

                using (SqlConnection connection = new SqlConnection("Server=LAPTOP-402M7NAC\\SQLEXPRESS; Database=LibraryManagement; Integrated Security=true;"))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(update, connection))
                    {
                        cmd.Parameters.Add("@bookid", SqlDbType.Int).Value = bookId;
                        cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = txbTitle.Text;
                        cmd.Parameters.Add("@author", SqlDbType.VarChar).Value = txbAuthor.Text;
                        cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = txbDescription.Text;
                        cmd.Parameters.Add("@catid", SqlDbType.Int).Value = categoryId;
                        cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = dateDamaged;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txbBookID.Text = row.Cells["BookID"].Value.ToString();
                txbTitle.Text = row.Cells["BookTitle"].Value.ToString();
                txbAuthor.Text = row.Cells["Author"].Value.ToString();
                txbDateStr.Text = row.Cells["DateDamaged"].Value.ToString();
                txbDescription.Text = row.Cells["DamageDescription"].Value.ToString();
                cbCategory.SelectedValue = row.Cells["CategoryID"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.Open();
                string delete = "delete from DamagedBooks where BookID = @id";
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
            txbDescription.Text = "";
            txbDateStr.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryManagement libraryManagement = new LibraryManagement();
            libraryManagement.ShowDialog();
            this.Dispose();
        }

        private void btnExit3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
