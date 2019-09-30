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

namespace SchoolManagementSystem
{
    public partial class ManageItem : Form
    {
        protected string category;
        public ManageItem(string category)
        {
            InitializeComponent();
            catbox.Text = category;
            this.category = category;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStock add = new ManageStock(catbox.Text);
            add.Show();  
        }


        public void LoadData()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (category.Equals("View All Items"))
            {
                cmd.CommandText = "select * from [dbo].[Items]";
            }
            else {
                cmd.CommandText = "select * from [dbo].[Items] where [Category]='" + category + "'";
            }
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt1);
            dataGridView1.DataSource = dt1;

            UsrlinkLabel.Text = GetSetInfo.userName;
            con.Close();
        }

        private void Grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ManageItem_Load(object sender, EventArgs e)
        {
            LoadData();

            if (category.Equals("Laboratory Equipments")) {
                Categorybox.Text = "Laboratory Equipments";
            }

            else if (category.Equals("Moveable Infrastructures"))
            {
                Categorybox.Text = "Moveable Infrastructures";
            }

            else if (category.Equals("Sports Items"))
            {
                Categorybox.Text = "Sports Items";
            }

            else if (category.Equals("Music Instruments"))
            {
                Categorybox.Text = "Music Instruments";
            }

            else if (category.Equals("Teaching Aid"))
            {
                Categorybox.Text = "Teaching Aid";
            }

            else if (category.Equals("Cleaning Items"))
            {
                Categorybox.Text = "Cleaning Items";
            }

            else if (category.Equals("Stationary"))
            {
                Categorybox.Text = "Stationary";
            }

            else if (category.Equals("Electronic Items"))
            {
                Categorybox.Text = "Electronic Items";
            }
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
           //SqlConnection con = Connection.GetSqlConnection();
            con.Open();

            
                if (validation())
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure to add this item?", "Message", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                     var sqlQuery = "";
                        if (IfproductExist(con, nametext.Text))
                        {
                            sqlQuery = @"UPDATE [dbo].[Items]SET [Category] = '" + Categorybox.Text + "' ,[Discription] = '" + richDiscription.Text + "' WHERE [ItemName] = '" + nametext.Text + "'";
                        }
                         else
                         {
                             sqlQuery = @"INSERT INTO[dbo].[Items] VALUES('" + Categorybox.Text + "','" + nametext.Text + "','" + richDiscription.Text + "')";
                         }

                            //Insert product details to DB
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = sqlQuery;
                            cmd.ExecuteNonQuery();
                            con.Close();
                            LoadData();


                        btnsave.Text = "Add";
                        ResetRecords();

                        MessageBox.Show("Record inserted successfully...");
                        errorProvider1.Clear();
                    }
                }
     
        }

        private bool IfproductExist(SqlConnection con,String ProductName) {
            SqlDataAdapter sda = new SqlDataAdapter("select 1 from [Items] where [ItemName]='"+ProductName+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnsave.Text = "Update";
            Categorybox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            nametext.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            richDiscription.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void ResetRecords() {
            Categorybox.SelectedIndex = -1;
            nametext.Clear();
            richDiscription.Clear();
            btnsave.Text = "Add";
            nametext.Focus();


        }

        private void Nametext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void RichDiscription_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            ResetRecords();
        }

        private bool validation() {
            bool result =false;
            if (string.IsNullOrEmpty(nametext.Text)) {
                errorProvider1.Clear();
                errorProvider1.SetError(nametext, "Item Name Required.");
            }
            else if (Categorybox.SelectedIndex == -1)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(Categorybox, "Select Category.");
            }
            else if (string.IsNullOrEmpty(richDiscription.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(richDiscription, "Item Discription Required.");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            if (!string.IsNullOrEmpty(nametext.Text) && !string.IsNullOrEmpty(richDiscription.Text) && Categorybox.SelectedIndex > -1)
            {
                result = true;
            }
           
            return result;
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void NViewLeaveBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryDashboard add = new InventoryDashboard();
            add.Show();
        }

        private void NAddStaffBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStock add = new ManageStock(catbox.Text);
            add.Show();
        }

        private void NViewSalaryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeletedList list = new DeletedList();
            list.Show();
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage1 newHome = new HomePage1();
            this.Hide();
            newHome.ShowDialog();
        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [dbo].[Items] where ItemName like '%" + textSearch.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStock add = new ManageStock(catbox.Text);
            add.Show();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void NStaffHomeBtn_Click(object sender, EventArgs e)
        {
            InventoryItemReportGenerate rp = new InventoryItemReportGenerate();
            this.Hide();
            rp.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            InventoryProductReportGenerate rp = new InventoryProductReportGenerate();
            this.Hide();
            rp.Show();
        }

        private void BtnStudentMHeader_Click(object sender, EventArgs e)
        {
            StudentManageHome st = new StudentManageHome();
            this.Hide();
            st.Show();
        }

        private void BtnEventMHeader_Click(object sender, EventArgs e)
        {
            EventDashboard ev = new EventDashboard();
            this.Hide();
            ev.Show();
        }

        private void BtnResourseMHeader_Click(object sender, EventArgs e)
        {
            ResourceManageHome mg = new ResourceManageHome();
            this.Hide();
            mg.Show();
        }

        private void BtnLibraryMHeader_Click(object sender, EventArgs e)
        {
            LibraryHome lb = new LibraryHome();
            this.Hide();
            lb.Show();
        }

        private void BtnNoticeMHeader_Click(object sender, EventArgs e)
        {
            Notice_Dashboard note = new Notice_Dashboard();
            this.Hide();
            note.Show();
        }
    }
   
}
