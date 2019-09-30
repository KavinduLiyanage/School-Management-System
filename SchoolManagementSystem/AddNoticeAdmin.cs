using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace SchoolManagementSystem
{
    public partial class addNotice : Form
    {
       
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
        
        public addNotice()
        {
            InitializeComponent();
        }

        public bool OpenConnection()
        {
            try
            {
                conn.Open();
                
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error has occured"+e);
                return false;
            }
        }
        public bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error has occured"+e);
                return false;
            }
        }

        public void ResetRecords()
        {
            richTextBox1.Clear();
           
        }

        public void Display_Data()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from Notices ";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        public void Display_Combo()
        {
            comboBox1.Items.Clear();
            OpenConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("select distinct [Expiration Date] from Notices");
            cmd.ExecuteNonQuery();
            CloseConnection();
            DataTable ddt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ddt);
            foreach (DataRow dr in ddt.Rows)
            {
                comboBox1.Items.Add(dr["Expiration Date"]);
            }
            CloseConnection();
        }

        private void AddNotice_Load(object sender, EventArgs e)
        {
            Display_Data();
            Display_Combo();
        }

        string Category="";
        private void RadioButtonNonAca_CheckedChanged(object sender, EventArgs e)
        {
            Category = "Non Academic";
        }
        private void RadioButtonAcadem_CheckedChanged(object sender, EventArgs e)
        {
            Category = "Academic";
        }

        private void AddNotice_Click(object sender, EventArgs e)
        {
            ArrayList error2 = new ArrayList();
            Boolean NoticeCat = true;
            Boolean Details = true;
            if (Category.Equals(""))
            {
                NoticeCat = false;
                error2.Add("please Add Notice Category");

            }
            if (richTextBox1.Text.Equals(""))
            {
                Details = false;
                error2.Add("please add Details");
            }

            string errorArr2 = "";
            foreach (Object ob in error2)
            {
                errorArr2 = errorArr2 + "\n" + ob;
            }

            if (NoticeCat && Details)
            {
                OpenConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("set IDENTITY_INSERT ON");
                cmd.CommandText = ("insert into Notices( [Published Date] ,[Expiration Date], [Category],[Details]) values('" + dateTimePicker1.Value.ToString() + "','" + dateTimePicker2.Value.ToString() + "','" + Category + "','" + richTextBox1.Text + "')");
                cmd.ExecuteNonQuery();
                CloseConnection();
                ResetRecords();
                DialogResult dResult = MessageBox.Show("Add more Notices", "Record Inserted Successfully", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dResult == DialogResult.Yes)
                {
                    addNotice Addnotice = new addNotice();
                    this.Hide();
                    Addnotice.Show();
                }
            }
            else
            {
                MessageBox.Show(errorArr2);
            }


        }

        private void ViewNotice_Click(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void SearchNotice_Click(object sender, EventArgs e)
        {
            OpenConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Notices where  [Expiration Date]='" + comboBox1.SelectedItem + "' ";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            CloseConnection();
        }

       

        private void Back_Click(object sender, EventArgs e)
        {
            Notice_Dashboard form_back = new Notice_Dashboard();
            this.Hide();
            form_back.Show();
        }

        int noticeID;
        private void viewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            noticeID = Int32.Parse(selectRow.Cells[0].Value.ToString());
            string Startdate = selectRow.Cells[1].Value.ToString();
            try
            {
                DateTime sDate = Convert.ToDateTime(Startdate);
                dateTimePicker1.Value = new System.DateTime(sDate.Year, sDate.Month, sDate.Day, 0, 0, 0, 0);
            }
            catch (Exception)
            {
                DateTime newdate = DateTime.Now;
                dateTimePicker1.Value = new System.DateTime(newdate.Year, newdate.Month, newdate.Day, 0, 0, 0, 0);
            }

            string Expiredate= selectRow.Cells[2].Value.ToString();
            try
            {
                DateTime eDate = Convert.ToDateTime(Expiredate);
                dateTimePicker2.Value = new System.DateTime(eDate.Year, eDate.Month, eDate.Day, 0, 0, 0, 0);
            }
            catch (Exception)
            {
                DateTime newdate1 = DateTime.Now;
                dateTimePicker2.Value = new System.DateTime(newdate1.Year, newdate1.Month, newdate1.Day, 0, 0, 0, 0);
            }

            string category = selectRow.Cells[3].Value.ToString();

            if (category.Equals("Academic"))
            {
                radioButtonAcadem.Checked = true;
            }
            else if (category.Equals("Non Academic"))
            {
               radioButtonNonAca.Checked = true;
            }

           richTextBox1.Text = selectRow.Cells[4].Value.ToString();
        }

        private void DeleteNotice_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Are You Sure You Want To Delete?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dResult == DialogResult.Yes)
            {
                OpenConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "delete from Notices where [Notice Id] = '" + noticeID + "'";
                cmd.ExecuteNonQuery();
                CloseConnection();
                MessageBox.Show("Deleted Succesfully");
            }
        }

        private void UpdateNoticebtn_Click(object sender, EventArgs e)
        {
            ArrayList error2 = new ArrayList();
            Boolean NoticeCat = true;
            Boolean Details = true;
            if (Category.Equals(""))
            {
                NoticeCat = false;
                error2.Add("please Add Notice Category");

            }
            if (richTextBox1.Text.Equals(""))
            {
                Details = false;
                error2.Add("please add Details");
            }

            string errorArr2 = "";
            foreach (Object ob in error2)
            {
                errorArr2 = errorArr2 + "\n" + ob;
            }
            DialogResult dResult = MessageBox.Show("Are You Sure You Want To Update?", "Update!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dResult == DialogResult.Yes)
            {
                if (NoticeCat && Details)
                {
                    OpenConnection();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("update notices set [Published Date]='" + dateTimePicker1.Value.ToString() + "',[Expiration Date]='" + dateTimePicker2.Value.ToString() + "',[Category]='" + Category + "', [Details] ='" + richTextBox1.Text + "' where [Notice Id]='" + noticeID + "'");
                    cmd.ExecuteNonQuery();
                    CloseConnection();
                    MessageBox.Show("Updated Succesfully");
                }
                else
                {
                    MessageBox.Show(errorArr2);
                }
            }
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

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
