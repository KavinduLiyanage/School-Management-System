namespace SchoolManagementSystem
{
    partial class ViewTimetable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTimetable));
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewTimeTable = new System.Windows.Forms.DataGridView();
            this.lbTimetableIDATT = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbTerm = new System.Windows.Forms.ComboBox();
            this.lbGradeATT = new System.Windows.Forms.Label();
            this.lbTermATT = new System.Windows.Forms.Label();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSectionResultSheetGTT = new System.Windows.Forms.Button();
            this.btnAddMarksGTT = new System.Windows.Forms.Button();
            this.btnClassResultSheetGTT = new System.Windows.Forms.Button();
            this.btnUpdateTimetableGTT = new System.Windows.Forms.Button();
            this.btnAddTimetableGTT = new System.Windows.Forms.Button();
            this.btnStudentResultSheetGTT = new System.Windows.Forms.Button();
            this.btnUpdateDeleteGTT = new System.Windows.Forms.Button();
            this.btnManageMarksGTT = new System.Windows.Forms.Button();
            this.btnTeachersHomeGTT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.crystalReportViewer3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnDisplayGTT = new System.Windows.Forms.Button();
            this.btnGetReportGTT = new System.Windows.Forms.Button();
            this.lbUserGT = new System.Windows.Forms.Label();
            this.btnimgGT = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLogOutHeader = new System.Windows.Forms.Button();
            this.btnNoticeMHeader = new System.Windows.Forms.Button();
            this.btnExamMheader = new System.Windows.Forms.Button();
            this.btnLibraryMHeader = new System.Windows.Forms.Button();
            this.btnStudentMHeader = new System.Windows.Forms.Button();
            this.btnResourseMHeader = new System.Windows.Forms.Button();
            this.btnInventoryMHeader = new System.Windows.Forms.Button();
            this.btnEventMHeader = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimeTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.tbSearch);
            this.panel3.Controls.Add(this.dataGridViewTimeTable);
            this.panel3.Controls.Add(this.lbTimetableIDATT);
            this.panel3.Location = new System.Drawing.Point(292, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 374);
            this.panel3.TabIndex = 35;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(134, 18);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(337, 22);
            this.tbSearch.TabIndex = 15;
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // dataGridViewTimeTable
            // 
            this.dataGridViewTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimeTable.Location = new System.Drawing.Point(14, 49);
            this.dataGridViewTimeTable.Name = "dataGridViewTimeTable";
            this.dataGridViewTimeTable.RowHeadersWidth = 51;
            this.dataGridViewTimeTable.RowTemplate.Height = 24;
            this.dataGridViewTimeTable.Size = new System.Drawing.Size(457, 317);
            this.dataGridViewTimeTable.TabIndex = 14;
            // 
            // lbTimetableIDATT
            // 
            this.lbTimetableIDATT.AutoSize = true;
            this.lbTimetableIDATT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimetableIDATT.Location = new System.Drawing.Point(23, 18);
            this.lbTimetableIDATT.Name = "lbTimetableIDATT";
            this.lbTimetableIDATT.Size = new System.Drawing.Size(104, 20);
            this.lbTimetableIDATT.TabIndex = 13;
            this.lbTimetableIDATT.Text = "Timetable ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.cbTerm);
            this.panel2.Controls.Add(this.lbGradeATT);
            this.panel2.Controls.Add(this.lbTermATT);
            this.panel2.Controls.Add(this.cbGrade);
            this.panel2.Location = new System.Drawing.Point(292, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 174);
            this.panel2.TabIndex = 34;
            // 
            // cbTerm
            // 
            this.cbTerm.FormattingEnabled = true;
            this.cbTerm.Items.AddRange(new object[] {
            "1st Term",
            "2nd Term",
            "3rd Term"});
            this.cbTerm.Location = new System.Drawing.Point(177, 38);
            this.cbTerm.Name = "cbTerm";
            this.cbTerm.Size = new System.Drawing.Size(200, 24);
            this.cbTerm.TabIndex = 17;
            // 
            // lbGradeATT
            // 
            this.lbGradeATT.AutoSize = true;
            this.lbGradeATT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGradeATT.Location = new System.Drawing.Point(82, 87);
            this.lbGradeATT.Name = "lbGradeATT";
            this.lbGradeATT.Size = new System.Drawing.Size(55, 20);
            this.lbGradeATT.TabIndex = 16;
            this.lbGradeATT.Text = "Grade";
            // 
            // lbTermATT
            // 
            this.lbTermATT.AutoSize = true;
            this.lbTermATT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTermATT.Location = new System.Drawing.Point(80, 44);
            this.lbTermATT.Name = "lbTermATT";
            this.lbTermATT.Size = new System.Drawing.Size(48, 20);
            this.lbTermATT.TabIndex = 0;
            this.lbTermATT.Text = "Term";
            // 
            // cbGrade
            // 
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12 Bio",
            "12 Maths",
            "12 Commerce",
            "12 Art",
            "13 Bio",
            "13 Maths",
            "13 Commerce",
            "13 Art"});
            this.cbGrade.Location = new System.Drawing.Point(177, 84);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(200, 24);
            this.cbGrade.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSectionResultSheetGTT);
            this.panel1.Controls.Add(this.btnAddMarksGTT);
            this.panel1.Controls.Add(this.btnClassResultSheetGTT);
            this.panel1.Controls.Add(this.btnUpdateTimetableGTT);
            this.panel1.Controls.Add(this.btnAddTimetableGTT);
            this.panel1.Controls.Add(this.btnStudentResultSheetGTT);
            this.panel1.Controls.Add(this.btnUpdateDeleteGTT);
            this.panel1.Controls.Add(this.btnManageMarksGTT);
            this.panel1.Controls.Add(this.btnTeachersHomeGTT);
            this.panel1.Location = new System.Drawing.Point(14, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 335);
            this.panel1.TabIndex = 32;
            // 
            // btnSectionResultSheetGTT
            // 
            this.btnSectionResultSheetGTT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSectionResultSheetGTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSectionResultSheetGTT.Location = new System.Drawing.Point(11, 220);
            this.btnSectionResultSheetGTT.Name = "btnSectionResultSheetGTT";
            this.btnSectionResultSheetGTT.Size = new System.Drawing.Size(235, 35);
            this.btnSectionResultSheetGTT.TabIndex = 31;
            this.btnSectionResultSheetGTT.Text = "Section ResultSheet";
            this.btnSectionResultSheetGTT.UseVisualStyleBackColor = false;
            this.btnSectionResultSheetGTT.Click += new System.EventHandler(this.BtnSectionResultSheetGTT_Click);
            // 
            // btnAddMarksGTT
            // 
            this.btnAddMarksGTT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddMarksGTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMarksGTT.Location = new System.Drawing.Point(11, 76);
            this.btnAddMarksGTT.Name = "btnAddMarksGTT";
            this.btnAddMarksGTT.Size = new System.Drawing.Size(235, 35);
            this.btnAddMarksGTT.TabIndex = 23;
            this.btnAddMarksGTT.Text = "Add Marks";
            this.btnAddMarksGTT.UseVisualStyleBackColor = false;
            this.btnAddMarksGTT.Click += new System.EventHandler(this.BtnAddMarksGTT_Click);
            // 
            // btnClassResultSheetGTT
            // 
            this.btnClassResultSheetGTT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClassResultSheetGTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassResultSheetGTT.Location = new System.Drawing.Point(11, 185);
            this.btnClassResultSheetGTT.Name = "btnClassResultSheetGTT";
            this.btnClassResultSheetGTT.Size = new System.Drawing.Size(235, 35);
            this.btnClassResultSheetGTT.TabIndex = 20;
            this.btnClassResultSheetGTT.Text = "Class Resultsheet";
            this.btnClassResultSheetGTT.UseVisualStyleBackColor = false;
            this.btnClassResultSheetGTT.Click += new System.EventHandler(this.BtnClassResultSheetGTT_Click);
            // 
            // btnUpdateTimetableGTT
            // 
            this.btnUpdateTimetableGTT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdateTimetableGTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTimetableGTT.Location = new System.Drawing.Point(11, 292);
            this.btnUpdateTimetableGTT.Name = "btnUpdateTimetableGTT";
            this.btnUpdateTimetableGTT.Size = new System.Drawing.Size(235, 35);
            this.btnUpdateTimetableGTT.TabIndex = 19;
            this.btnUpdateTimetableGTT.Text = "Update / Delete Timetable";
            this.btnUpdateTimetableGTT.UseVisualStyleBackColor = false;
            this.btnUpdateTimetableGTT.Click += new System.EventHandler(this.BtnUpdateTimetableGTT_Click);
            // 
            // btnAddTimetableGTT
            // 
            this.btnAddTimetableGTT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddTimetableGTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTimetableGTT.Location = new System.Drawing.Point(11, 256);
            this.btnAddTimetableGTT.Name = "btnAddTimetableGTT";
            this.btnAddTimetableGTT.Size = new System.Drawing.Size(235, 35);
            this.btnAddTimetableGTT.TabIndex = 21;
            this.btnAddTimetableGTT.Text = "Add Timetable";
            this.btnAddTimetableGTT.UseVisualStyleBackColor = false;
            this.btnAddTimetableGTT.Click += new System.EventHandler(this.BtnAddTimetableGTT_Click);
            // 
            // btnStudentResultSheetGTT
            // 
            this.btnStudentResultSheetGTT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnStudentResultSheetGTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentResultSheetGTT.Location = new System.Drawing.Point(11, 148);
            this.btnStudentResultSheetGTT.Name = "btnStudentResultSheetGTT";
            this.btnStudentResultSheetGTT.Size = new System.Drawing.Size(235, 35);
            this.btnStudentResultSheetGTT.TabIndex = 18;
            this.btnStudentResultSheetGTT.Text = "Student Resultsheet";
            this.btnStudentResultSheetGTT.UseVisualStyleBackColor = false;
            this.btnStudentResultSheetGTT.Click += new System.EventHandler(this.BtnStudentResultSheetGTT_Click);
            // 
            // btnUpdateDeleteGTT
            // 
            this.btnUpdateDeleteGTT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdateDeleteGTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDeleteGTT.Location = new System.Drawing.Point(11, 112);
            this.btnUpdateDeleteGTT.Name = "btnUpdateDeleteGTT";
            this.btnUpdateDeleteGTT.Size = new System.Drawing.Size(235, 35);
            this.btnUpdateDeleteGTT.TabIndex = 18;
            this.btnUpdateDeleteGTT.Text = "Update Marks / Delete Marks";
            this.btnUpdateDeleteGTT.UseVisualStyleBackColor = false;
            this.btnUpdateDeleteGTT.Click += new System.EventHandler(this.BtnUpdateDeleteGTT_Click);
            // 
            // btnManageMarksGTT
            // 
            this.btnManageMarksGTT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnManageMarksGTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMarksGTT.Location = new System.Drawing.Point(11, 40);
            this.btnManageMarksGTT.Name = "btnManageMarksGTT";
            this.btnManageMarksGTT.Size = new System.Drawing.Size(235, 35);
            this.btnManageMarksGTT.TabIndex = 17;
            this.btnManageMarksGTT.Text = "Manage Marks";
            this.btnManageMarksGTT.UseVisualStyleBackColor = false;
            this.btnManageMarksGTT.Click += new System.EventHandler(this.BtnManageMarksGTT_Click);
            // 
            // btnTeachersHomeGTT
            // 
            this.btnTeachersHomeGTT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTeachersHomeGTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachersHomeGTT.Location = new System.Drawing.Point(11, 3);
            this.btnTeachersHomeGTT.Name = "btnTeachersHomeGTT";
            this.btnTeachersHomeGTT.Size = new System.Drawing.Size(235, 35);
            this.btnTeachersHomeGTT.TabIndex = 17;
            this.btnTeachersHomeGTT.Text = "Teachers Home";
            this.btnTeachersHomeGTT.UseVisualStyleBackColor = false;
            this.btnTeachersHomeGTT.Click += new System.EventHandler(this.BtnTeachersHomeGTT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(14, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 220);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.crystalReportViewer3);
            this.panel4.Controls.Add(this.crystalReportViewer2);
            this.panel4.Controls.Add(this.crystalReportViewer1);
            this.panel4.Location = new System.Drawing.Point(802, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 476);
            this.panel4.TabIndex = 36;
            // 
            // crystalReportViewer3
            // 
            this.crystalReportViewer3.ActiveViewIndex = -1;
            this.crystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer3.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer3.Name = "crystalReportViewer3";
            this.crystalReportViewer3.Size = new System.Drawing.Size(448, 476);
            this.crystalReportViewer3.TabIndex = 2;
            this.crystalReportViewer3.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(448, 476);
            this.crystalReportViewer2.TabIndex = 1;
            this.crystalReportViewer2.Load += new System.EventHandler(this.CrystalReportViewer2_Load);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(448, 476);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // btnDisplayGTT
            // 
            this.btnDisplayGTT.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDisplayGTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayGTT.Location = new System.Drawing.Point(844, 606);
            this.btnDisplayGTT.Name = "btnDisplayGTT";
            this.btnDisplayGTT.Size = new System.Drawing.Size(130, 50);
            this.btnDisplayGTT.TabIndex = 37;
            this.btnDisplayGTT.Text = "Display";
            this.btnDisplayGTT.UseVisualStyleBackColor = false;
            this.btnDisplayGTT.Click += new System.EventHandler(this.BtnDisplayGTT_Click);
            // 
            // btnGetReportGTT
            // 
            this.btnGetReportGTT.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGetReportGTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetReportGTT.Location = new System.Drawing.Point(1051, 606);
            this.btnGetReportGTT.Name = "btnGetReportGTT";
            this.btnGetReportGTT.Size = new System.Drawing.Size(130, 50);
            this.btnGetReportGTT.TabIndex = 38;
            this.btnGetReportGTT.Text = "Get Timetable";
            this.btnGetReportGTT.UseVisualStyleBackColor = false;
            this.btnGetReportGTT.Click += new System.EventHandler(this.BtnGetReportGTT_Click);
            // 
            // lbUserGT
            // 
            this.lbUserGT.AutoSize = true;
            this.lbUserGT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbUserGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserGT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbUserGT.Location = new System.Drawing.Point(67, 281);
            this.lbUserGT.Name = "lbUserGT";
            this.lbUserGT.Size = new System.Drawing.Size(155, 25);
            this.lbUserGT.TabIndex = 39;
            this.lbUserGT.Text = "Ashani Malsha";
            this.lbUserGT.Click += new System.EventHandler(this.LbUserGT_Click);
            // 
            // btnimgGT
            // 
            this.btnimgGT.Location = new System.Drawing.Point(57, 134);
            this.btnimgGT.Name = "btnimgGT";
            this.btnimgGT.Size = new System.Drawing.Size(174, 135);
            this.btnimgGT.TabIndex = 40;
            this.btnimgGT.Text = "button1";
            this.btnimgGT.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
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
            this.panel5.Location = new System.Drawing.Point(15, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1235, 92);
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
            // 
            // ViewTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnimgGT);
            this.Controls.Add(this.lbUserGT);
            this.Controls.Add(this.btnGetReportGTT);
            this.Controls.Add(this.btnDisplayGTT);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ViewTimetable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewTimetable";
            this.Load += new System.EventHandler(this.ViewTimetable_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimeTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewTimeTable;
        private System.Windows.Forms.Label lbTimetableIDATT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbGradeATT;
        private System.Windows.Forms.Label lbTermATT;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSectionResultSheetGTT;
        private System.Windows.Forms.Button btnAddMarksGTT;
        private System.Windows.Forms.Button btnClassResultSheetGTT;
        private System.Windows.Forms.Button btnUpdateTimetableGTT;
        private System.Windows.Forms.Button btnAddTimetableGTT;
        private System.Windows.Forms.Button btnStudentResultSheetGTT;
        private System.Windows.Forms.Button btnUpdateDeleteGTT;
        private System.Windows.Forms.Button btnManageMarksGTT;
        private System.Windows.Forms.Button btnTeachersHomeGTT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDisplayGTT;
        private System.Windows.Forms.Button btnGetReportGTT;
        private System.Windows.Forms.Label lbUserGT;
        private System.Windows.Forms.Button btnimgGT;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLogOutHeader;
        private System.Windows.Forms.Button btnNoticeMHeader;
        private System.Windows.Forms.Button btnExamMheader;
        private System.Windows.Forms.Button btnLibraryMHeader;
        private System.Windows.Forms.Button btnStudentMHeader;
        private System.Windows.Forms.Button btnResourseMHeader;
        private System.Windows.Forms.Button btnInventoryMHeader;
        private System.Windows.Forms.Button btnEventMHeader;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbTerm;
    }
}