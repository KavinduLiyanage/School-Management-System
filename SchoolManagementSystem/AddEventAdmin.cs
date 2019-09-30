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
    public partial class AddEventform : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
        public AddEventform()
        {
            InitializeComponent();
        }

        private void BtnExamMheader_Click(object sender, EventArgs e)
        {
            TeachersHome home = new TeachersHome();
            this.Hide();
            home.ShowDialog();
        }

        private void BtnStudentMHeader_Click(object sender, EventArgs e)
        {
            CreateStudentAccount creAcc = new CreateStudentAccount();
            this.Hide();
            creAcc.ShowDialog();
        }

        private void BtnInventoryMHeader_Click(object sender, EventArgs e)
        {
            InventoryDashboard inveDash = new InventoryDashboard();
            this.Hide();
            inveDash.ShowDialog();
        }

        private void BtnLibraryMHeader_Click(object sender, EventArgs e)
        {
            LibraryHome libHome = new LibraryHome();
            this.Hide();
            libHome.ShowDialog();
        }

        private void BtnNoticeMHeader_Click(object sender, EventArgs e)
        {
            Notice_Dashboard nd = new Notice_Dashboard();
            this.Hide();
            nd.Show();
        }

        private void BtnResourseMHeader_Click(object sender, EventArgs e)
        {
            ResourceManageHome newres = new ResourceManageHome();
            this.Hide();
            newres.ShowDialog();
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
                MessageBox.Show("Error has occured" + e);
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
                MessageBox.Show("Error has occured" + e);
                return false;
            }
        }

        private void ResetRecords()
        {
            textBoxName.Clear();
            textBoxvenue.Clear();
            textBoxTime.Clear();
        }

        public void Display_Data()
        {
            OpenConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Events";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            CloseConnection();
            ResetRecords();
            
                
        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void AddEvent_click(object sender, EventArgs e)
        {
            ArrayList error1 = new ArrayList();
            Boolean eventName = true;
            Boolean eventVenue = true;
            Boolean time = true;
            Boolean status = true;
            if (textBoxName.Text.Equals(""))
            {
                eventName = false;
                error1.Add("please Add Event Name");

            }
            if (textBoxvenue.Text.Equals(""))
            {
                eventVenue = false;
                error1.Add("please add Venue");
            }
            if (textBoxTime.Text.Equals(""))
            {
                time = false;
                error1.Add("please add time");
            }
            if (comboBoxStat.SelectedIndex == -1)
            {
                status = false;
                error1.Add("please add status");
            }

            string errorArr1 = "";
            foreach (Object ob in error1)
            {
                errorArr1 = errorArr1 + "\n" + ob;
            }

            if (eventName && eventVenue && time&& status)
            {
                OpenConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("set IDENTITY_INSERT ON");
                cmd.CommandText = ("insert into Events([Event Name], [Event Date], [Event Venue],[Time],[Status]) values ('" + textBoxName.Text + "','" + dateTimePicker1.Value.ToString() + "','" + textBoxvenue.Text + "','" + textBoxTime.Text + "','"+comboBoxStat.SelectedItem+"')");
                cmd.ExecuteNonQuery();
                CloseConnection();



                DialogResult dResult = MessageBox.Show("Add more Events", "Record Inserted Successfully", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dResult == DialogResult.Yes)
                {
                    AddEventform Addevent = new AddEventform();
                    this.Hide();
                    Addevent.Show();
                }
            }
            else
            {
                MessageBox.Show(errorArr1);
            }

        }

        private void ViewEvent_click(object sender, EventArgs e)
        {
            Display_Data();
            
        }
        private void SearchEvent_click(object sender, EventArgs e)
        {
            OpenConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Events where  [Event Name] like '%" + textBoxSearch.Text + "%' ";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            CloseConnection();
        }

        private void AddEventform_Load(object sender, EventArgs e)
        {
            Display_Data();
        }

        int EventId;
        private void ViewEvent_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            EventId = Int32.Parse(selectRow.Cells[0].Value.ToString());
            textBoxName.Text = selectRow.Cells[1].Value.ToString();

            string commenceDate = selectRow.Cells[2].Value.ToString();
            try
            {
                DateTime eDate = Convert.ToDateTime(commenceDate);
                dateTimePicker1.Value = new System.DateTime(eDate.Year, eDate.Month, eDate.Day, 0, 0, 0, 0);
            }
            catch (Exception)
            {
                DateTime newdate1 = DateTime.Now;
                dateTimePicker1.Value = new System.DateTime(newdate1.Year, newdate1.Month, newdate1.Day, 0, 0, 0, 0);
            }

            textBoxvenue.Text = selectRow.Cells[3].Value.ToString();
            textBoxTime.Text = selectRow.Cells[4].Value.ToString();
            comboBoxStat.SelectedItem = selectRow.Cells[5].Value.ToString();
        }

        private void UpdateNoticebtn_Click(object sender, EventArgs e)
        {
            ArrayList error1 = new ArrayList();
            Boolean eventName = true;
            Boolean eventVenue = true;
            Boolean time = true;
            
            if (textBoxName.Text.Equals(""))
            {
                eventName = false;
                error1.Add("please Add Event Name");

            }
            if (textBoxvenue.Text.Equals(""))
            {
                eventVenue = false;
                error1.Add("please add Venue");
            }
            if (textBoxTime.Text.Equals(""))
            {
                time = false;
                error1.Add("please add time");
            }
            
            string errorArr1 = "";
            foreach (Object ob in error1)
            {
                errorArr1 = errorArr1 + "\n" + ob;
            }

            DialogResult dResult = MessageBox.Show("Are You Sure You Want To Update?", "Update!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dResult == DialogResult.Yes)
            {
                if (eventName && eventVenue && time)
                {
                    OpenConnection();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("update Events set [Event Name]='" + textBoxName.Text + "', [Event Date] ='" + dateTimePicker1.Value.ToString() + "',[Event Venue]='" + textBoxvenue.Text + "',  [Time]='" + textBoxTime.Text + "',[Status]='"+comboBoxStat.SelectedItem +"' where [Event ID]='" + EventId + "'");
                    cmd.ExecuteNonQuery();
                    CloseConnection();
                    MessageBox.Show("Updated Succesfully");
                    ResetRecords();
                }
                else
                {
                    MessageBox.Show(errorArr1);
                }
            }
        }

        private void DeleteEvent_click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Are You Sure You Want To Delete?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dResult == DialogResult.Yes)
            {
                OpenConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "delete from Events where [Event ID]= '" + EventId + "'";
                cmd.ExecuteNonQuery();
                CloseConnection();
                MessageBox.Show("Deleted Succesfully");
                ResetRecords();
            }
        }

        private void Back_e_click(object sender, EventArgs e)
        {
            EventDashboard form_back = new EventDashboard();
            this.Hide();
            form_back.Show();
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

        private void TextBoxTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeKeypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GenerateEventReport_click(object sender, EventArgs e)
        {
            YearlyEventReport.YearlyEventReport evRepo = new YearlyEventReport.YearlyEventReport();
            this.Hide();
            evRepo.Show();
        }

        
    }
}
//end line