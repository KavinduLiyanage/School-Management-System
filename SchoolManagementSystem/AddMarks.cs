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
    public partial class AddMarks : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        public AddMarks()
        {
            InitializeComponent();

            //to get only year without month and date
            YearPicker.Format = DateTimePickerFormat.Custom;
            YearPicker.CustomFormat = "yyyy";
            YearPicker.ShowUpDown = true;
        }
       Connection o = new Connection();

        private void AddMarks_Load(object sender, EventArgs e)
        {
            //to give created method
            FillSubjectCombo();
            displayData();


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

         private void insertData() {

             try
             {
                 con.Open();
                 string qry = "INSERT INTO ExamMarks VALUES('" + tbRegNo.Text + "', @SubjectID ,'" + cbExam.Text + "','" + tbMark.Text + "','" + YearPicker.Value.Year + "')";


                 SqlCommand cmd = new SqlCommand(qry, o.con);

                 cmd.Parameters.AddWithValue("@SubjectID", cbSubName.SelectedValue);
                 cmd.ExecuteNonQuery();
                 cmd.Parameters.Clear();
                 MessageBox.Show("Record Inserted successfully!!");
                 con.Close();

                 AddMarks newAdd = new AddMarks();
                 this.Hide();
                 newAdd.ShowDialog();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("You have already inserted marks for this student or worong id!!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                 //MessageBox.Show(ex.Message);
             }

         }

        private void Button1_Click(object sender, EventArgs e)
        {
            //validations

             ArrayList errorArr1 = new ArrayList();

             Boolean regNo = true;
             Boolean subName = true;
             Boolean exam = true;
             Boolean mark = true;


             if (tbRegNo.Text.Equals(""))
             {
                 regNo = false;
                 errorArr1.Add("Please Enter student registration number!");
             }

             if (cbSubName.Text.Equals(""))
             {
                 subName = false;
                 errorArr1.Add("Please Enter subject name!");
             }

             if (cbExam.Text.Equals(""))
             {
                 exam = false;
                 errorArr1.Add("Please Enter exam term!");
             }

             if (tbMark.Text.Equals(""))
             {
                 mark = false;
                 errorArr1.Add("Please Enter marks!");
             }

             string arrayStr = "";
             foreach (Object obj in errorArr1)
             {
                 arrayStr = arrayStr + "\n" + obj;
             }

             if (regNo && subName && exam && mark)
             {
                 this.insertData();
             }
             else
             {
                 MessageBox.Show(arrayStr);
             }


        
        }

        public void displayData(string searchValue)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ExamMarks WHERE SID LIKE '%" + searchValue + "%'  OR  SubjectID LIKE '%" + searchValue + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewMarks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LbMarks_Click(object sender, EventArgs e)
        {

        }

        private void LbExam_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TbSubName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdateTimetableA_Click(object sender, EventArgs e)
        {

        }

        private void BtnTeachersHomeA_Click(object sender, EventArgs e)
        {
            TeachersHome Mm = new TeachersHome();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnManageMarksA_Click(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            this.Hide();
            Mm.ShowDialog();
        }

        

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void BtnUpdateDeleteMarksA_Click(object sender, EventArgs e)
        {

            UpdateORDeleteMarks ud = new UpdateORDeleteMarks();
            this.Hide();
            ud.ShowDialog();
        }

        private void BtnStudentResultsheetA_Click(object sender, EventArgs e)
        {

            StudentResultSheet stdRS = new StudentResultSheet();
            this.Hide();
            stdRS.ShowDialog();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClassResultSheetA_Click(object sender, EventArgs e)
        {
            ClassResultSheet clzRS = new ClassResultSheet();
            this.Hide();
            clzRS.ShowDialog();
        }

        private void BtnSectionResultSheetA_Click(object sender, EventArgs e)
        {

            SectionResultSheet secRS = new SectionResultSheet();
            this.Hide();
            secRS.ShowDialog();
        }

        private void BtnUpdateDeleteTimetableA_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            this.Hide();
            udtt.ShowDialog();
        }

        private void BtnManageTimetableA_Click(object sender, EventArgs e)
        {

            ViewTimetable vtt = new ViewTimetable();
            this.Hide();
            vtt.ShowDialog();
        }

        private void BtnAddTimetableA_Click(object sender, EventArgs e)
        {

            AddTimetable att = new AddTimetable();
            this.Hide();
            att.ShowDialog();
        }

        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        void FillSubjectCombo()
        {
            
            cbSubName.Items.Clear();

            DataSet ds = new DataSet();
            try
            {

                string query = "select * from Subject";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();

                da.Fill(ds);

                cbSubName.DataSource = ds.Tables[0];
                cbSubName.DisplayMember = "SubjectName";
                cbSubName.ValueMember = "SubjectID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
  

        }

        public void displayData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ExamMarks  ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewMarks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void TbRegNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbRegNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Please Enter Only Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }
        }

        private void TbMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && tbMark.Text.IndexOf('.') != -1)//this allow only one time to use decimale dot
            {
                e.Handled = true;
                return;
            }
            if (!(e.KeyChar <= '9'))
            {
               e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 46)//keychar == 8 is for backspace and keychar ==32 for spacebarand 46 for .
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Please Enter Only Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }
        }

        private void DataGridViewMarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridViewMarks_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            displayData(tbSearch.Text);
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void BtnStudentMHeader_Click(object sender, EventArgs e)
        {
            StudentManageHome smh = new StudentManageHome();
            this.Hide();
            smh.ShowDialog();
        }

        private void BtnInventoryMHeader_Click(object sender, EventArgs e)
        {
            InventoryDashboard ind = new InventoryDashboard();
            this.Hide();
            ind.ShowDialog();
        }

        private void BtnEventMHeader_Click(object sender, EventArgs e)
        {
            EventDashboard ed = new EventDashboard();
            this.Hide();
            ed.ShowDialog();
        }

        private void BtnResourseMHeader_Click(object sender, EventArgs e)
        {
            ResourceManageHome rmh = new ResourceManageHome();
            this.Hide();
            rmh.ShowDialog();
        }

        private void BtnLibraryMHeader_Click(object sender, EventArgs e)
        {
            LibraryHome lh = new LibraryHome();
            this.Hide();
            lh.ShowDialog();
        }

        private void BtnExamMheader_Click(object sender, EventArgs e)
        {
            TeachersHome th = new TeachersHome();
            this.Hide();
            th.ShowDialog();
        }

        private void BtnNoticeMHeader_Click(object sender, EventArgs e)
        {
            Notice_Dashboard nd = new Notice_Dashboard();
            this.Hide();
            nd.ShowDialog();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            tbRegNo.Text = "1122";
            cbSubName.Text = "Sinhala";
            cbExam.Text = "1st Term";
            tbMark.Text = "80";
            YearPicker.Text = "";

        }

        private void LbUserAM_Click(object sender, EventArgs e)
        {
            lbUserAM.Text = GetSetInfo.userName;
        }
    }
}
