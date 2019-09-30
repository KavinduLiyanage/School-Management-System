using System;
using System.Collections;
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
    public partial class addParticipant_form : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
        public addParticipant_form()
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

        public void Display_Data()
        {
            OpenConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Participants";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewPar.DataSource = dt;
            CloseConnection();
        }


        public void Display_Combo()
        {
            comboBoxpar1.Items.Clear();
            OpenConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("select [Event ID] from Events where [Status]='To be held'");
            cmd.ExecuteNonQuery();
            CloseConnection();
            DataTable ddt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ddt);
            foreach (DataRow dr in ddt.Rows)
            {
                comboBoxpar1.Items.Add(dr["Event ID"]);
            }
            CloseConnection();
        }

        public void Display_ComboSearch()
        {
            comboBoxpar2.Items.Clear();
            OpenConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("select [Event ID] from Events where [Status]='To be held'");
            cmd.ExecuteNonQuery();
            CloseConnection();
            DataTable ddt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ddt);
            foreach (DataRow dr in ddt.Rows)
            {
                comboBoxpar2.Items.Add(dr["Event ID"]);
            }
            CloseConnection();
        }

        private void ResetRecords()
        {
            comboBoxpar1.Items.Clear();
            namePartextbox.Clear();
            radioButtonAcaPar.Checked = false;
            radioButtonNonAPar.Checked = false;
            radioButtonStudPar.Checked = false;
        }

        int ParticipantID;
        private void ViewParcell_click(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridViewPar.Rows[index];
            ParticipantID = Int32.Parse(selectRow.Cells[0].Value.ToString());
            comboBoxpar1.SelectedItem = selectRow.Cells[1].Value;
            namePartextbox.Text = selectRow.Cells[2].Value.ToString();
            string category = selectRow.Cells[3].Value.ToString();

            if (category.Equals("Academic"))
            {
                radioButtonAcaPar.Checked = true;
            }
            else if (category.Equals("Non Academic"))
            {
                radioButtonNonAPar.Checked = true;
            }
            else if (category.Equals("Student"))
            {
                radioButtonStudPar.Checked = true;
            }
        }

        private void AddParticipant_form_Load(object sender, EventArgs e)
        {
            Display_Combo();
            Display_ComboSearch();
            Display_Data();
        }

        String Category = "";
        private void RadioButtonAcaP_CheckedChanged(object sender, EventArgs e)
        {
            Category = "Academic";
        }

        private void radiobuttonNonAcP_Checkchanged(object sender, EventArgs e)
        {
            Category = "Non Academic";
        }

        private void radiobuttonstud_Checkchanged(object sender, EventArgs e)
        {
            Category = "Student";
        }

        private void back_click(object sender, EventArgs e)
        {
            EventDashboard form_back = new EventDashboard();
            this.Hide();
            form_back.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
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

        private void SearchParbtn_onClick(object sender, EventArgs e)
        {
            OpenConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Participants where  [Event ID]='" + comboBoxpar2.SelectedItem + "' ";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewPar.DataSource = dt;
            CloseConnection();
        }

        private void AddParbtn_Click(object sender, EventArgs e)
        {
            ArrayList errors = new ArrayList();
            Boolean eventID = true;
            Boolean parName = true;
            Boolean category = true;

            if (comboBoxpar1.SelectedIndex==-1)
            {
                eventID = false;
                errors.Add("please Add EventID");

            }
            if (namePartextbox.Text.Equals(""))
            {
                parName = false;
                errors.Add("please add Participant Name");
            }
            if (Category.Equals(""))
            {
                category = false;
                errors.Add("please enter Category");
            }

            string ErrorArr = "";
            foreach (Object ob in errors)
            {
                ErrorArr = ErrorArr + "\n" + ob;
            }


            if (eventID && parName && category)
            {
                OpenConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("set IDENTITY_INSERT ON");
                cmd.CommandText = ("insert into Participants([Event ID],[Name],[Category]) values ('" + comboBoxpar1.SelectedItem + "','" + namePartextbox.Text + "','" + Category + "')");
                cmd.ExecuteNonQuery();
                CloseConnection();
                this.ResetRecords();


                DialogResult dResult = MessageBox.Show("Add more Participants", "Record Inserted Successfully", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dResult == DialogResult.Yes)
                {

                    addParticipant_form AddPar = new addParticipant_form();
                    this.Hide();
                    AddPar.Show();
                }
            }
            else
            {
                MessageBox.Show(ErrorArr);
            }



        }

        private void ViewParbtn_onClick(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void DeleteParbtn_click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Are You Sure You Want To Delete?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dResult == DialogResult.Yes)
            {
                OpenConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "delete from Participants where [Participant ID] = '" + ParticipantID + "'";
                cmd.ExecuteNonQuery();
                CloseConnection();
                MessageBox.Show("Deleted Succesfully");
            }
        }

        private void UpdateparButton_onClick(object sender, EventArgs e)
        {
            ArrayList errors2 = new ArrayList();
            Boolean parName = true;
            Boolean category = true;

            
            if (namePartextbox.Text.Equals(""))
            {
                parName = false;
                errors2.Add("please add Participant Name");
            }
            if (Category.Equals(""))
            {
                category = false;
                errors2.Add("please enter Category");
            }

            string ErrorArr = "";
            foreach (Object ob in errors2)
            {
                ErrorArr = ErrorArr + "\n" + ob;
            }
            DialogResult dResult = MessageBox.Show("Are You Sure You Want To Update?", "Update!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dResult == DialogResult.Yes)
            {
                if (parName && category)
                {
                    OpenConnection();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("update Participants set [Event Id]='" + comboBoxpar1.SelectedItem + "', [Name] ='" + namePartextbox.Text + "', [Category]='" + Category + "' where [Participant ID]='" + ParticipantID + "'");
                    cmd.ExecuteNonQuery();
                    CloseConnection();
                    MessageBox.Show("Updated Succesfully");
                }
                else
                {
                    MessageBox.Show(ErrorArr);
                }
            }
        }

        
        private void checkbox_changed(object sender, EventArgs e)
        {
            
        }

        private void GenerateEventRepo_click(object sender, EventArgs e)
        {
            YearlyEventReport.YearlyEventReport evRepo = new YearlyEventReport.YearlyEventReport();
            this.Hide();
            evRepo.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            TeachersHome home = new TeachersHome();
            this.Hide();
            home.ShowDialog();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            CreateStudentAccount creAcc = new CreateStudentAccount();
            this.Hide();
            creAcc.ShowDialog();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            InventoryDashboard inveDash = new InventoryDashboard();
            this.Hide();
            inveDash.ShowDialog();
        }

        private void Button14_Click(object sender, EventArgs e)
        {

            ResourceManageHome newres = new ResourceManageHome();
            this.Hide();
            newres.ShowDialog();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            LibraryHome libHome = new LibraryHome();
            this.Hide();
            libHome.ShowDialog();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Notice_Dashboard nd = new Notice_Dashboard();
            this.Hide();
            nd.Show();
        }


    }
    }

