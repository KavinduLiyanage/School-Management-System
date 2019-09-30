namespace SchoolManagementSystem
{
    partial class AddMarks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMarks));
            this.lbRegNo = new System.Windows.Forms.Label();
            this.lbSubName = new System.Windows.Forms.Label();
            this.lbExam = new System.Windows.Forms.Label();
            this.lbMarks = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.tbRegNo = new System.Windows.Forms.TextBox();
            this.tbMark = new System.Windows.Forms.TextBox();
            this.YearPicker = new System.Windows.Forms.DateTimePicker();
            this.cbExam = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateDeleteTimetableA = new System.Windows.Forms.Button();
            this.btnSectionResultSheetA = new System.Windows.Forms.Button();
            this.btnClassResultSheetA = new System.Windows.Forms.Button();
            this.btnStudentResultsheetA = new System.Windows.Forms.Button();
            this.btnUpdateDeleteMarksA = new System.Windows.Forms.Button();
            this.btnAddTimetableA = new System.Windows.Forms.Button();
            this.btnManageTimetableA = new System.Windows.Forms.Button();
            this.btnManageMarksA = new System.Windows.Forms.Button();
            this.btnTeachersHomeA = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbSubName = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewMarks = new System.Windows.Forms.DataGridView();
            this.btnImageAM = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbUserAM = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLogOutHeader = new System.Windows.Forms.Button();
            this.btnNoticeMHeader = new System.Windows.Forms.Button();
            this.btnExamMheader = new System.Windows.Forms.Button();
            this.btnLibraryMHeader = new System.Windows.Forms.Button();
            this.btnStudentMHeader = new System.Windows.Forms.Button();
            this.btnResourseMHeader = new System.Windows.Forms.Button();
            this.btnInventoryMHeader = new System.Windows.Forms.Button();
            this.btnEventMHeader = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRegNo
            // 
            this.lbRegNo.AutoSize = true;
            this.lbRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegNo.Location = new System.Drawing.Point(11, 42);
            this.lbRegNo.Name = "lbRegNo";
            this.lbRegNo.Size = new System.Drawing.Size(163, 20);
            this.lbRegNo.TabIndex = 0;
            this.lbRegNo.Text = "Registration Number";
            this.lbRegNo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lbSubName
            // 
            this.lbSubName.AutoSize = true;
            this.lbSubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubName.Location = new System.Drawing.Point(10, 93);
            this.lbSubName.Name = "lbSubName";
            this.lbSubName.Size = new System.Drawing.Size(114, 20);
            this.lbSubName.TabIndex = 1;
            this.lbSubName.Text = "Subject Name";
            // 
            // lbExam
            // 
            this.lbExam.AutoSize = true;
            this.lbExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExam.Location = new System.Drawing.Point(11, 151);
            this.lbExam.Name = "lbExam";
            this.lbExam.Size = new System.Drawing.Size(101, 20);
            this.lbExam.TabIndex = 2;
            this.lbExam.Text = "Select exam";
            this.lbExam.Click += new System.EventHandler(this.LbExam_Click);
            // 
            // lbMarks
            // 
            this.lbMarks.AutoSize = true;
            this.lbMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarks.Location = new System.Drawing.Point(13, 210);
            this.lbMarks.Name = "lbMarks";
            this.lbMarks.Size = new System.Drawing.Size(100, 20);
            this.lbMarks.TabIndex = 3;
            this.lbMarks.Text = "Enter Marks";
            this.lbMarks.Click += new System.EventHandler(this.LbMarks_Click);
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.Location = new System.Drawing.Point(13, 262);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(88, 20);
            this.lbYear.TabIndex = 4;
            this.lbYear.Text = "Enter Year";
            // 
            // tbRegNo
            // 
            this.tbRegNo.Location = new System.Drawing.Point(193, 42);
            this.tbRegNo.Name = "tbRegNo";
            this.tbRegNo.Size = new System.Drawing.Size(186, 22);
            this.tbRegNo.TabIndex = 5;
            this.tbRegNo.TextChanged += new System.EventHandler(this.TbRegNo_TextChanged);
            this.tbRegNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbRegNo_KeyPress);
            // 
            // tbMark
            // 
            this.tbMark.Location = new System.Drawing.Point(193, 208);
            this.tbMark.Name = "tbMark";
            this.tbMark.Size = new System.Drawing.Size(186, 22);
            this.tbMark.TabIndex = 6;
            this.tbMark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbMark_KeyPress);
            // 
            // YearPicker
            // 
            this.YearPicker.CustomFormat = "yyyy";
            this.YearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.YearPicker.Location = new System.Drawing.Point(193, 260);
            this.YearPicker.Name = "YearPicker";
            this.YearPicker.Size = new System.Drawing.Size(186, 22);
            this.YearPicker.TabIndex = 8;
            // 
            // cbExam
            // 
            this.cbExam.FormattingEnabled = true;
            this.cbExam.Items.AddRange(new object[] {
            "1st Term",
            "2nd Term",
            "3rd Term"});
            this.cbExam.Location = new System.Drawing.Point(193, 151);
            this.cbExam.Name = "cbExam";
            this.cbExam.Size = new System.Drawing.Size(186, 24);
            this.cbExam.TabIndex = 9;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(44, 394);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(130, 50);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(91, 18);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(403, 22);
            this.tbSearch.TabIndex = 12;
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(23, 18);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(62, 20);
            this.lbSearch.TabIndex = 13;
            this.lbSearch.Text = "Search";
            this.lbSearch.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 220);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnUpdateDeleteTimetableA);
            this.panel1.Controls.Add(this.btnSectionResultSheetA);
            this.panel1.Controls.Add(this.btnClassResultSheetA);
            this.panel1.Controls.Add(this.btnStudentResultsheetA);
            this.panel1.Controls.Add(this.btnUpdateDeleteMarksA);
            this.panel1.Controls.Add(this.btnAddTimetableA);
            this.panel1.Controls.Add(this.btnManageTimetableA);
            this.panel1.Controls.Add(this.btnManageMarksA);
            this.panel1.Controls.Add(this.btnTeachersHomeA);
            this.panel1.Location = new System.Drawing.Point(12, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 335);
            this.panel1.TabIndex = 15;
            // 
            // btnUpdateDeleteTimetableA
            // 
            this.btnUpdateDeleteTimetableA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdateDeleteTimetableA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDeleteTimetableA.Location = new System.Drawing.Point(11, 292);
            this.btnUpdateDeleteTimetableA.Name = "btnUpdateDeleteTimetableA";
            this.btnUpdateDeleteTimetableA.Size = new System.Drawing.Size(235, 35);
            this.btnUpdateDeleteTimetableA.TabIndex = 20;
            this.btnUpdateDeleteTimetableA.Text = "Update / DeleteTimetable";
            this.btnUpdateDeleteTimetableA.UseVisualStyleBackColor = false;
            this.btnUpdateDeleteTimetableA.Click += new System.EventHandler(this.BtnUpdateDeleteTimetableA_Click);
            // 
            // btnSectionResultSheetA
            // 
            this.btnSectionResultSheetA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSectionResultSheetA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSectionResultSheetA.Location = new System.Drawing.Point(11, 184);
            this.btnSectionResultSheetA.Name = "btnSectionResultSheetA";
            this.btnSectionResultSheetA.Size = new System.Drawing.Size(235, 35);
            this.btnSectionResultSheetA.TabIndex = 20;
            this.btnSectionResultSheetA.Text = "Section ResultSheet";
            this.btnSectionResultSheetA.UseVisualStyleBackColor = false;
            this.btnSectionResultSheetA.Click += new System.EventHandler(this.BtnSectionResultSheetA_Click);
            // 
            // btnClassResultSheetA
            // 
            this.btnClassResultSheetA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClassResultSheetA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassResultSheetA.Location = new System.Drawing.Point(11, 148);
            this.btnClassResultSheetA.Name = "btnClassResultSheetA";
            this.btnClassResultSheetA.Size = new System.Drawing.Size(235, 35);
            this.btnClassResultSheetA.TabIndex = 19;
            this.btnClassResultSheetA.Text = "Class ResultSheet";
            this.btnClassResultSheetA.UseVisualStyleBackColor = false;
            this.btnClassResultSheetA.Click += new System.EventHandler(this.BtnClassResultSheetA_Click);
            // 
            // btnStudentResultsheetA
            // 
            this.btnStudentResultsheetA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnStudentResultsheetA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentResultsheetA.Location = new System.Drawing.Point(11, 112);
            this.btnStudentResultsheetA.Name = "btnStudentResultsheetA";
            this.btnStudentResultsheetA.Size = new System.Drawing.Size(235, 35);
            this.btnStudentResultsheetA.TabIndex = 19;
            this.btnStudentResultsheetA.Text = "Student ResultSheet";
            this.btnStudentResultsheetA.UseVisualStyleBackColor = false;
            this.btnStudentResultsheetA.Click += new System.EventHandler(this.BtnStudentResultsheetA_Click);
            // 
            // btnUpdateDeleteMarksA
            // 
            this.btnUpdateDeleteMarksA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdateDeleteMarksA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDeleteMarksA.Location = new System.Drawing.Point(11, 76);
            this.btnUpdateDeleteMarksA.Name = "btnUpdateDeleteMarksA";
            this.btnUpdateDeleteMarksA.Size = new System.Drawing.Size(235, 35);
            this.btnUpdateDeleteMarksA.TabIndex = 19;
            this.btnUpdateDeleteMarksA.Text = "Update Marks / Delete Marks";
            this.btnUpdateDeleteMarksA.UseVisualStyleBackColor = false;
            this.btnUpdateDeleteMarksA.Click += new System.EventHandler(this.BtnUpdateDeleteMarksA_Click);
            // 
            // btnAddTimetableA
            // 
            this.btnAddTimetableA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddTimetableA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTimetableA.Location = new System.Drawing.Point(11, 256);
            this.btnAddTimetableA.Name = "btnAddTimetableA";
            this.btnAddTimetableA.Size = new System.Drawing.Size(235, 35);
            this.btnAddTimetableA.TabIndex = 21;
            this.btnAddTimetableA.Text = "Add Timetable";
            this.btnAddTimetableA.UseVisualStyleBackColor = false;
            this.btnAddTimetableA.Click += new System.EventHandler(this.BtnAddTimetableA_Click);
            // 
            // btnManageTimetableA
            // 
            this.btnManageTimetableA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnManageTimetableA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTimetableA.Location = new System.Drawing.Point(11, 220);
            this.btnManageTimetableA.Name = "btnManageTimetableA";
            this.btnManageTimetableA.Size = new System.Drawing.Size(235, 35);
            this.btnManageTimetableA.TabIndex = 22;
            this.btnManageTimetableA.Text = "Get Timetable";
            this.btnManageTimetableA.UseVisualStyleBackColor = false;
            this.btnManageTimetableA.Click += new System.EventHandler(this.BtnManageTimetableA_Click);
            // 
            // btnManageMarksA
            // 
            this.btnManageMarksA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnManageMarksA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMarksA.Location = new System.Drawing.Point(11, 40);
            this.btnManageMarksA.Name = "btnManageMarksA";
            this.btnManageMarksA.Size = new System.Drawing.Size(235, 35);
            this.btnManageMarksA.TabIndex = 17;
            this.btnManageMarksA.Text = "Manage Marks";
            this.btnManageMarksA.UseVisualStyleBackColor = false;
            this.btnManageMarksA.Click += new System.EventHandler(this.BtnManageMarksA_Click);
            // 
            // btnTeachersHomeA
            // 
            this.btnTeachersHomeA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTeachersHomeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachersHomeA.Location = new System.Drawing.Point(11, 3);
            this.btnTeachersHomeA.Name = "btnTeachersHomeA";
            this.btnTeachersHomeA.Size = new System.Drawing.Size(235, 35);
            this.btnTeachersHomeA.TabIndex = 17;
            this.btnTeachersHomeA.Text = "Teachers Home";
            this.btnTeachersHomeA.UseVisualStyleBackColor = false;
            this.btnTeachersHomeA.Click += new System.EventHandler(this.BtnTeachersHomeA_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cbSubName);
            this.panel2.Controls.Add(this.tbRegNo);
            this.panel2.Controls.Add(this.lbRegNo);
            this.panel2.Controls.Add(this.lbSubName);
            this.panel2.Controls.Add(this.lbExam);
            this.panel2.Controls.Add(this.lbMarks);
            this.panel2.Controls.Add(this.lbYear);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.tbMark);
            this.panel2.Controls.Add(this.cbExam);
            this.panel2.Controls.Add(this.YearPicker);
            this.panel2.Location = new System.Drawing.Point(296, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 514);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // cbSubName
            // 
            this.cbSubName.FormattingEnabled = true;
            this.cbSubName.Items.AddRange(new object[] {
            "Sinhala",
            "Mathematics",
            "English",
            "Science"});
            this.cbSubName.Location = new System.Drawing.Point(193, 93);
            this.cbSubName.Name = "cbSubName";
            this.cbSubName.Size = new System.Drawing.Size(186, 24);
            this.cbSubName.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.dataGridViewMarks);
            this.panel3.Controls.Add(this.tbSearch);
            this.panel3.Controls.Add(this.lbSearch);
            this.panel3.Location = new System.Drawing.Point(703, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 512);
            this.panel3.TabIndex = 18;
            // 
            // dataGridViewMarks
            // 
            this.dataGridViewMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarks.Location = new System.Drawing.Point(19, 64);
            this.dataGridViewMarks.Name = "dataGridViewMarks";
            this.dataGridViewMarks.RowHeadersWidth = 51;
            this.dataGridViewMarks.RowTemplate.Height = 24;
            this.dataGridViewMarks.Size = new System.Drawing.Size(495, 427);
            this.dataGridViewMarks.TabIndex = 14;
            this.dataGridViewMarks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMarks_CellClick);
            this.dataGridViewMarks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMarks_CellContentClick);
            // 
            // btnImageAM
            // 
            this.btnImageAM.Location = new System.Drawing.Point(51, 131);
            this.btnImageAM.Name = "btnImageAM";
            this.btnImageAM.Size = new System.Drawing.Size(174, 135);
            this.btnImageAM.TabIndex = 15;
            this.btnImageAM.Text = "button1";
            this.btnImageAM.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(51, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // lbUserAM
            // 
            this.lbUserAM.AutoSize = true;
            this.lbUserAM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbUserAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserAM.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbUserAM.Location = new System.Drawing.Point(59, 283);
            this.lbUserAM.Name = "lbUserAM";
            this.lbUserAM.Size = new System.Drawing.Size(155, 25);
            this.lbUserAM.TabIndex = 20;
            this.lbUserAM.Text = "Ashani Malsha";
            this.lbUserAM.Click += new System.EventHandler(this.LbUserAM_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SkyBlue;
            this.panel5.Controls.Add(this.btnLogOutHeader);
            this.panel5.Controls.Add(this.btnNoticeMHeader);
            this.panel5.Controls.Add(this.btnExamMheader);
            this.panel5.Controls.Add(this.btnLibraryMHeader);
            this.panel5.Controls.Add(this.btnStudentMHeader);
            this.panel5.Controls.Add(this.btnResourseMHeader);
            this.panel5.Controls.Add(this.btnInventoryMHeader);
            this.panel5.Controls.Add(this.btnEventMHeader);
            this.panel5.Location = new System.Drawing.Point(12, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1228, 92);
            this.panel5.TabIndex = 44;
            // 
            // btnLogOutHeader
            // 
            this.btnLogOutHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogOutHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOutHeader.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogOutHeader.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogOutHeader.Location = new System.Drawing.Point(1078, 20);
            this.btnLogOutHeader.Name = "btnLogOutHeader";
            this.btnLogOutHeader.Size = new System.Drawing.Size(145, 50);
            this.btnLogOutHeader.TabIndex = 25;
            this.btnLogOutHeader.Text = "Log Out";
            this.btnLogOutHeader.UseVisualStyleBackColor = true;
            this.btnLogOutHeader.Click += new System.EventHandler(this.BtnLogOutHeader_Click);
            // 
            // btnNoticeMHeader
            // 
            this.btnNoticeMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNoticeMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoticeMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnNoticeMHeader.Location = new System.Drawing.Point(927, 21);
            this.btnNoticeMHeader.Name = "btnNoticeMHeader";
            this.btnNoticeMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnNoticeMHeader.TabIndex = 23;
            this.btnNoticeMHeader.Text = "Notice Management";
            this.btnNoticeMHeader.UseVisualStyleBackColor = false;
            this.btnNoticeMHeader.Click += new System.EventHandler(this.BtnNoticeMHeader_Click);
            // 
            // btnExamMheader
            // 
            this.btnExamMheader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExamMheader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamMheader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnExamMheader.Location = new System.Drawing.Point(21, 19);
            this.btnExamMheader.Name = "btnExamMheader";
            this.btnExamMheader.Size = new System.Drawing.Size(145, 50);
            this.btnExamMheader.TabIndex = 1;
            this.btnExamMheader.Text = "Exam Management";
            this.btnExamMheader.UseVisualStyleBackColor = false;
            this.btnExamMheader.Click += new System.EventHandler(this.BtnExamMheader_Click);
            // 
            // btnLibraryMHeader
            // 
            this.btnLibraryMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLibraryMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnLibraryMHeader.Location = new System.Drawing.Point(776, 21);
            this.btnLibraryMHeader.Name = "btnLibraryMHeader";
            this.btnLibraryMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnLibraryMHeader.TabIndex = 22;
            this.btnLibraryMHeader.Text = " Library Management";
            this.btnLibraryMHeader.UseVisualStyleBackColor = false;
            this.btnLibraryMHeader.Click += new System.EventHandler(this.BtnLibraryMHeader_Click);
            // 
            // btnStudentMHeader
            // 
            this.btnStudentMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStudentMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnStudentMHeader.Location = new System.Drawing.Point(172, 20);
            this.btnStudentMHeader.Name = "btnStudentMHeader";
            this.btnStudentMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnStudentMHeader.TabIndex = 18;
            this.btnStudentMHeader.Text = "Student Management";
            this.btnStudentMHeader.UseVisualStyleBackColor = false;
            this.btnStudentMHeader.Click += new System.EventHandler(this.BtnStudentMHeader_Click);
            // 
            // btnResourseMHeader
            // 
            this.btnResourseMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnResourseMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResourseMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnResourseMHeader.Location = new System.Drawing.Point(625, 20);
            this.btnResourseMHeader.Name = "btnResourseMHeader";
            this.btnResourseMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnResourseMHeader.TabIndex = 21;
            this.btnResourseMHeader.Text = "Resourse Management";
            this.btnResourseMHeader.UseVisualStyleBackColor = false;
            this.btnResourseMHeader.Click += new System.EventHandler(this.BtnResourseMHeader_Click);
            // 
            // btnInventoryMHeader
            // 
            this.btnInventoryMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInventoryMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnInventoryMHeader.Location = new System.Drawing.Point(323, 20);
            this.btnInventoryMHeader.Name = "btnInventoryMHeader";
            this.btnInventoryMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnInventoryMHeader.TabIndex = 19;
            this.btnInventoryMHeader.Text = "Inventory Management";
            this.btnInventoryMHeader.UseVisualStyleBackColor = false;
            this.btnInventoryMHeader.Click += new System.EventHandler(this.BtnInventoryMHeader_Click);
            // 
            // btnEventMHeader
            // 
            this.btnEventMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEventMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnEventMHeader.Location = new System.Drawing.Point(474, 20);
            this.btnEventMHeader.Name = "btnEventMHeader";
            this.btnEventMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnEventMHeader.TabIndex = 20;
            this.btnEventMHeader.Text = "Event Management";
            this.btnEventMHeader.UseVisualStyleBackColor = false;
            this.btnEventMHeader.Click += new System.EventHandler(this.BtnEventMHeader_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(214, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "Demo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // AddMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lbUserAM);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnImageAM);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddMarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.Load += new System.EventHandler(this.AddMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRegNo;
        private System.Windows.Forms.Label lbSubName;
        private System.Windows.Forms.Label lbExam;
        private System.Windows.Forms.Label lbMarks;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.TextBox tbRegNo;
        private System.Windows.Forms.TextBox tbMark;
        private System.Windows.Forms.DateTimePicker YearPicker;
        private System.Windows.Forms.ComboBox cbExam;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTeachersHomeA;
        private System.Windows.Forms.Button btnManageMarksA;
        private System.Windows.Forms.Button btnAddTimetableA;
        private System.Windows.Forms.Button btnManageTimetableA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewMarks;
        private System.Windows.Forms.Button btnUpdateDeleteMarksA;
        private System.Windows.Forms.Button btnStudentResultsheetA;
        private System.Windows.Forms.Button btnClassResultSheetA;
        private System.Windows.Forms.Button btnSectionResultSheetA;
        private System.Windows.Forms.Button btnUpdateDeleteTimetableA;
        private System.Windows.Forms.Button btnImageAM;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbUserAM;
        private System.Windows.Forms.ComboBox cbSubName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLogOutHeader;
        private System.Windows.Forms.Button btnNoticeMHeader;
        private System.Windows.Forms.Button btnExamMheader;
        private System.Windows.Forms.Button btnLibraryMHeader;
        private System.Windows.Forms.Button btnStudentMHeader;
        private System.Windows.Forms.Button btnResourseMHeader;
        private System.Windows.Forms.Button btnInventoryMHeader;
        private System.Windows.Forms.Button btnEventMHeader;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
    }
}