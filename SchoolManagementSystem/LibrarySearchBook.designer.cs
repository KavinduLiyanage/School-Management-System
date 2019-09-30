namespace SchoolManagementSystem
{
    partial class LibrarySearchBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarySearchBook));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLogOutHeader = new System.Windows.Forms.Button();
            this.btnNoticeMHeader = new System.Windows.Forms.Button();
            this.btnExamMheader = new System.Windows.Forms.Button();
            this.btnLibraryMHeader = new System.Windows.Forms.Button();
            this.btnStudentMHeader = new System.Windows.Forms.Button();
            this.btnResourseMHeader = new System.Windows.Forms.Button();
            this.btnInventoryMHeader = new System.Windows.Forms.Button();
            this.btnEventMHeader = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.NHomeBtn = new System.Windows.Forms.Button();
            this.NViewStaffBtn = new System.Windows.Forms.Button();
            this.NViewLeaveBtn = new System.Windows.Forms.Button();
            this.NViewSalaryBtn = new System.Windows.Forms.Button();
            this.NAddStaffBtn = new System.Windows.Forms.Button();
            this.NStaffHomeBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsrlinkLabel = new System.Windows.Forms.LinkLabel();
            this.subLabel2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(433, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(494, 161);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(202, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 161);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Book Name";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.textBox7);
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Controls.Add(this.textBox5);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(201, 274);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(726, 252);
            this.panel4.TabIndex = 4;
            this.panel4.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(428, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 36);
            this.button3.TabIndex = 13;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(164, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(516, 137);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(130, 20);
            this.textBox7.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(516, 90);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(130, 20);
            this.textBox6.TabIndex = 10;
            this.textBox6.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(516, 41);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(164, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(164, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(409, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(405, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Publisher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Edition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "ISBN";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Name";
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
            this.panel5.Location = new System.Drawing.Point(0, 1);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(921, 75);
            this.panel5.TabIndex = 44;
            // 
            // btnLogOutHeader
            // 
            this.btnLogOutHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogOutHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOutHeader.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogOutHeader.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogOutHeader.Location = new System.Drawing.Point(808, 16);
            this.btnLogOutHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOutHeader.Name = "btnLogOutHeader";
            this.btnLogOutHeader.Size = new System.Drawing.Size(109, 41);
            this.btnLogOutHeader.TabIndex = 25;
            this.btnLogOutHeader.Text = "Log Out";
            this.btnLogOutHeader.UseVisualStyleBackColor = true;
            // 
            // btnNoticeMHeader
            // 
            this.btnNoticeMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNoticeMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoticeMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnNoticeMHeader.Location = new System.Drawing.Point(695, 17);
            this.btnNoticeMHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnNoticeMHeader.Name = "btnNoticeMHeader";
            this.btnNoticeMHeader.Size = new System.Drawing.Size(109, 41);
            this.btnNoticeMHeader.TabIndex = 23;
            this.btnNoticeMHeader.Text = "Notice Management";
            this.btnNoticeMHeader.UseVisualStyleBackColor = false;
            // 
            // btnExamMheader
            // 
            this.btnExamMheader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExamMheader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamMheader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnExamMheader.Location = new System.Drawing.Point(16, 15);
            this.btnExamMheader.Margin = new System.Windows.Forms.Padding(2);
            this.btnExamMheader.Name = "btnExamMheader";
            this.btnExamMheader.Size = new System.Drawing.Size(109, 41);
            this.btnExamMheader.TabIndex = 1;
            this.btnExamMheader.Text = "Exam Management";
            this.btnExamMheader.UseVisualStyleBackColor = false;
            // 
            // btnLibraryMHeader
            // 
            this.btnLibraryMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLibraryMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnLibraryMHeader.Location = new System.Drawing.Point(582, 17);
            this.btnLibraryMHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnLibraryMHeader.Name = "btnLibraryMHeader";
            this.btnLibraryMHeader.Size = new System.Drawing.Size(109, 41);
            this.btnLibraryMHeader.TabIndex = 22;
            this.btnLibraryMHeader.Text = " Library Management";
            this.btnLibraryMHeader.UseVisualStyleBackColor = false;
            // 
            // btnStudentMHeader
            // 
            this.btnStudentMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStudentMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnStudentMHeader.Location = new System.Drawing.Point(129, 16);
            this.btnStudentMHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudentMHeader.Name = "btnStudentMHeader";
            this.btnStudentMHeader.Size = new System.Drawing.Size(109, 41);
            this.btnStudentMHeader.TabIndex = 18;
            this.btnStudentMHeader.Text = "Student Management";
            this.btnStudentMHeader.UseVisualStyleBackColor = false;
            // 
            // btnResourseMHeader
            // 
            this.btnResourseMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnResourseMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResourseMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnResourseMHeader.Location = new System.Drawing.Point(469, 16);
            this.btnResourseMHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnResourseMHeader.Name = "btnResourseMHeader";
            this.btnResourseMHeader.Size = new System.Drawing.Size(109, 41);
            this.btnResourseMHeader.TabIndex = 21;
            this.btnResourseMHeader.Text = "Resourse Management";
            this.btnResourseMHeader.UseVisualStyleBackColor = false;
            // 
            // btnInventoryMHeader
            // 
            this.btnInventoryMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInventoryMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnInventoryMHeader.Location = new System.Drawing.Point(242, 16);
            this.btnInventoryMHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventoryMHeader.Name = "btnInventoryMHeader";
            this.btnInventoryMHeader.Size = new System.Drawing.Size(109, 41);
            this.btnInventoryMHeader.TabIndex = 19;
            this.btnInventoryMHeader.Text = "Inventory Management";
            this.btnInventoryMHeader.UseVisualStyleBackColor = false;
            // 
            // btnEventMHeader
            // 
            this.btnEventMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEventMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnEventMHeader.Location = new System.Drawing.Point(356, 16);
            this.btnEventMHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventMHeader.Name = "btnEventMHeader";
            this.btnEventMHeader.Size = new System.Drawing.Size(109, 41);
            this.btnEventMHeader.TabIndex = 20;
            this.btnEventMHeader.Text = "Event Management";
            this.btnEventMHeader.UseVisualStyleBackColor = false;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonPanel.Controls.Add(this.NHomeBtn);
            this.ButtonPanel.Controls.Add(this.NViewStaffBtn);
            this.ButtonPanel.Controls.Add(this.NViewLeaveBtn);
            this.ButtonPanel.Controls.Add(this.NViewSalaryBtn);
            this.ButtonPanel.Controls.Add(this.NAddStaffBtn);
            this.ButtonPanel.Controls.Add(this.NStaffHomeBtn);
            this.ButtonPanel.Location = new System.Drawing.Point(1, 256);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(195, 272);
            this.ButtonPanel.TabIndex = 46;
            // 
            // NHomeBtn
            // 
            this.NHomeBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NHomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NHomeBtn.ForeColor = System.Drawing.Color.Red;
            this.NHomeBtn.Location = new System.Drawing.Point(8, 5);
            this.NHomeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NHomeBtn.Name = "NHomeBtn";
            this.NHomeBtn.Size = new System.Drawing.Size(176, 28);
            this.NHomeBtn.TabIndex = 24;
            this.NHomeBtn.Text = "Home";
            this.NHomeBtn.UseVisualStyleBackColor = false;
            this.NHomeBtn.Click += new System.EventHandler(this.NHomeBtn_Click);
            // 
            // NViewStaffBtn
            // 
            this.NViewStaffBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NViewStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NViewStaffBtn.Location = new System.Drawing.Point(8, 93);
            this.NViewStaffBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NViewStaffBtn.Name = "NViewStaffBtn";
            this.NViewStaffBtn.Size = new System.Drawing.Size(176, 28);
            this.NViewStaffBtn.TabIndex = 23;
            this.NViewStaffBtn.Text = "Issue Books";
            this.NViewStaffBtn.UseVisualStyleBackColor = false;
            this.NViewStaffBtn.Click += new System.EventHandler(this.NViewStaffBtn_Click);
            // 
            // NViewLeaveBtn
            // 
            this.NViewLeaveBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NViewLeaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NViewLeaveBtn.Location = new System.Drawing.Point(8, 152);
            this.NViewLeaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NViewLeaveBtn.Name = "NViewLeaveBtn";
            this.NViewLeaveBtn.Size = new System.Drawing.Size(176, 28);
            this.NViewLeaveBtn.TabIndex = 18;
            this.NViewLeaveBtn.Text = "Reports";
            this.NViewLeaveBtn.UseVisualStyleBackColor = false;
            // 
            // NViewSalaryBtn
            // 
            this.NViewSalaryBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NViewSalaryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NViewSalaryBtn.Location = new System.Drawing.Point(8, 123);
            this.NViewSalaryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NViewSalaryBtn.Name = "NViewSalaryBtn";
            this.NViewSalaryBtn.Size = new System.Drawing.Size(176, 28);
            this.NViewSalaryBtn.TabIndex = 18;
            this.NViewSalaryBtn.Text = "Return Books";
            this.NViewSalaryBtn.UseVisualStyleBackColor = false;
            this.NViewSalaryBtn.Click += new System.EventHandler(this.NViewSalaryBtn_Click);
            // 
            // NAddStaffBtn
            // 
            this.NAddStaffBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NAddStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAddStaffBtn.Location = new System.Drawing.Point(8, 64);
            this.NAddStaffBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NAddStaffBtn.Name = "NAddStaffBtn";
            this.NAddStaffBtn.Size = new System.Drawing.Size(176, 28);
            this.NAddStaffBtn.TabIndex = 17;
            this.NAddStaffBtn.Text = "View Books";
            this.NAddStaffBtn.UseVisualStyleBackColor = false;
            // 
            // NStaffHomeBtn
            // 
            this.NStaffHomeBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NStaffHomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NStaffHomeBtn.Location = new System.Drawing.Point(8, 34);
            this.NStaffHomeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NStaffHomeBtn.Name = "NStaffHomeBtn";
            this.NStaffHomeBtn.Size = new System.Drawing.Size(176, 28);
            this.NStaffHomeBtn.TabIndex = 17;
            this.NStaffHomeBtn.Text = "Add Books";
            this.NStaffHomeBtn.UseVisualStyleBackColor = false;
            this.NStaffHomeBtn.Click += new System.EventHandler(this.NStaffHomeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 99);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // UsrlinkLabel
            // 
            this.UsrlinkLabel.AutoSize = true;
            this.UsrlinkLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UsrlinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrlinkLabel.Location = new System.Drawing.Point(28, 212);
            this.UsrlinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsrlinkLabel.Name = "UsrlinkLabel";
            this.UsrlinkLabel.Size = new System.Drawing.Size(137, 20);
            this.UsrlinkLabel.TabIndex = 47;
            this.UsrlinkLabel.TabStop = true;
            this.UsrlinkLabel.Text = "Kavishka Ransara";
            // 
            // subLabel2
            // 
            this.subLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.subLabel2.Location = new System.Drawing.Point(0, 76);
            this.subLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.subLabel2.Name = "subLabel2";
            this.subLabel2.Size = new System.Drawing.Size(195, 179);
            this.subLabel2.TabIndex = 45;
            this.subLabel2.TabStop = false;
            // 
            // LibrarySearchBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsrlinkLabel);
            this.Controls.Add(this.subLabel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LibrarySearchBook";
            this.Text = "search";
            this.Load += new System.EventHandler(this.LibrarySearchBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subLabel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLogOutHeader;
        private System.Windows.Forms.Button btnNoticeMHeader;
        private System.Windows.Forms.Button btnExamMheader;
        private System.Windows.Forms.Button btnLibraryMHeader;
        private System.Windows.Forms.Button btnStudentMHeader;
        private System.Windows.Forms.Button btnResourseMHeader;
        private System.Windows.Forms.Button btnInventoryMHeader;
        private System.Windows.Forms.Button btnEventMHeader;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button NHomeBtn;
        private System.Windows.Forms.Button NViewStaffBtn;
        private System.Windows.Forms.Button NViewLeaveBtn;
        private System.Windows.Forms.Button NViewSalaryBtn;
        private System.Windows.Forms.Button NAddStaffBtn;
        private System.Windows.Forms.Button NStaffHomeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel UsrlinkLabel;
        private System.Windows.Forms.PictureBox subLabel2;
    }
}