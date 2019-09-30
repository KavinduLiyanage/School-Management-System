namespace SchoolManagementSystem
{
    partial class StudentAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAppointment));
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLogOutHeader = new System.Windows.Forms.Button();
            this.UsrlinkLabel = new System.Windows.Forms.LinkLabel();
            this.NHomeBtn = new System.Windows.Forms.Button();
            this.NViewStudentBtn = new System.Windows.Forms.Button();
            this.NAddStudentBtn = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTName = new System.Windows.Forms.TextBox();
            this.lbRegNo = new System.Windows.Forms.Label();
            this.lbMarks = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.btnMake = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.YearPicker = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgPanel = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SkyBlue;
            this.panel5.Controls.Add(this.btnLogOutHeader);
            this.panel5.Location = new System.Drawing.Point(17, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1228, 92);
            this.panel5.TabIndex = 54;
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
            // UsrlinkLabel
            // 
            this.UsrlinkLabel.AutoSize = true;
            this.UsrlinkLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UsrlinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrlinkLabel.Location = new System.Drawing.Point(61, 272);
            this.UsrlinkLabel.Name = "UsrlinkLabel";
            this.UsrlinkLabel.Size = new System.Drawing.Size(180, 25);
            this.UsrlinkLabel.TabIndex = 52;
            this.UsrlinkLabel.TabStop = true;
            this.UsrlinkLabel.Text = "Kavindu Sandeepa";
            // 
            // NHomeBtn
            // 
            this.NHomeBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NHomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NHomeBtn.ForeColor = System.Drawing.Color.Red;
            this.NHomeBtn.Location = new System.Drawing.Point(16, 14);
            this.NHomeBtn.Name = "NHomeBtn";
            this.NHomeBtn.Size = new System.Drawing.Size(235, 35);
            this.NHomeBtn.TabIndex = 30;
            this.NHomeBtn.Text = "Home";
            this.NHomeBtn.UseVisualStyleBackColor = false;
            this.NHomeBtn.Click += new System.EventHandler(this.NHomeBtn_Click);
            // 
            // NViewStudentBtn
            // 
            this.NViewStudentBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NViewStudentBtn.Location = new System.Drawing.Point(16, 91);
            this.NViewStudentBtn.Name = "NViewStudentBtn";
            this.NViewStudentBtn.Size = new System.Drawing.Size(235, 35);
            this.NViewStudentBtn.TabIndex = 29;
            this.NViewStudentBtn.Text = "Add Appointment";
            this.NViewStudentBtn.UseVisualStyleBackColor = false;
            this.NViewStudentBtn.Click += new System.EventHandler(this.NViewStudentBtn_Click);
            // 
            // NAddStudentBtn
            // 
            this.NAddStudentBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NAddStudentBtn.Location = new System.Drawing.Point(16, 55);
            this.NAddStudentBtn.Name = "NAddStudentBtn";
            this.NAddStudentBtn.Size = new System.Drawing.Size(235, 35);
            this.NAddStudentBtn.TabIndex = 25;
            this.NAddStudentBtn.Text = "View Marks";
            this.NAddStudentBtn.UseVisualStyleBackColor = false;
            this.NAddStudentBtn.Click += new System.EventHandler(this.NAddStudentBtn_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonPanel.Controls.Add(this.button3);
            this.ButtonPanel.Controls.Add(this.NHomeBtn);
            this.ButtonPanel.Controls.Add(this.button1);
            this.ButtonPanel.Controls.Add(this.NViewStudentBtn);
            this.ButtonPanel.Controls.Add(this.NAddStudentBtn);
            this.ButtonPanel.Location = new System.Drawing.Point(17, 330);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(260, 335);
            this.ButtonPanel.TabIndex = 51;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Location = new System.Drawing.Point(16, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 35);
            this.button3.TabIndex = 32;
            this.button3.Text = "Reports";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(16, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 35);
            this.button1.TabIndex = 29;
            this.button1.Text = "Edit Appointment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtTName);
            this.panel2.Controls.Add(this.lbRegNo);
            this.panel2.Controls.Add(this.lbMarks);
            this.panel2.Controls.Add(this.lbYear);
            this.panel2.Controls.Add(this.btnMake);
            this.panel2.Controls.Add(this.txtReason);
            this.panel2.Controls.Add(this.YearPicker);
            this.panel2.Location = new System.Drawing.Point(344, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 449);
            this.panel2.TabIndex = 55;
            // 
            // txtTName
            // 
            this.txtTName.Location = new System.Drawing.Point(381, 78);
            this.txtTName.Name = "txtTName";
            this.txtTName.Size = new System.Drawing.Size(207, 22);
            this.txtTName.TabIndex = 5;
            // 
            // lbRegNo
            // 
            this.lbRegNo.AutoSize = true;
            this.lbRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegNo.Location = new System.Drawing.Point(158, 80);
            this.lbRegNo.Name = "lbRegNo";
            this.lbRegNo.Size = new System.Drawing.Size(119, 20);
            this.lbRegNo.TabIndex = 0;
            this.lbRegNo.Text = "Teacher Name";
            // 
            // lbMarks
            // 
            this.lbMarks.AutoSize = true;
            this.lbMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarks.Location = new System.Drawing.Point(184, 141);
            this.lbMarks.Name = "lbMarks";
            this.lbMarks.Size = new System.Drawing.Size(66, 20);
            this.lbMarks.TabIndex = 3;
            this.lbMarks.Text = "Reason";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.Location = new System.Drawing.Point(170, 214);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(97, 20);
            this.lbYear.TabIndex = 4;
            this.lbYear.Text = "Select Date";
            // 
            // btnMake
            // 
            this.btnMake.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMake.Location = new System.Drawing.Point(299, 289);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(130, 50);
            this.btnMake.TabIndex = 11;
            this.btnMake.Text = "Make";
            this.btnMake.UseVisualStyleBackColor = false;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(381, 131);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(207, 46);
            this.txtReason.TabIndex = 6;
            // 
            // YearPicker
            // 
            this.YearPicker.CustomFormat = "";
            this.YearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.YearPicker.Location = new System.Drawing.Point(381, 212);
            this.YearPicker.Name = "YearPicker";
            this.YearPicker.Size = new System.Drawing.Size(207, 22);
            this.YearPicker.TabIndex = 8;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(573, 121);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(304, 38);
            this.label25.TabIndex = 57;
            this.label25.Text = "Make Appointment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // imgPanel
            // 
            this.imgPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imgPanel.Location = new System.Drawing.Point(17, 104);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(260, 220);
            this.imgPanel.TabIndex = 50;
            this.imgPanel.TabStop = false;
            // 
            // StudentAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsrlinkLabel);
            this.Controls.Add(this.imgPanel);
            this.Controls.Add(this.ButtonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentAppointment";
            this.Load += new System.EventHandler(this.StudentAppointment_Load);
            this.panel5.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLogOutHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel UsrlinkLabel;
        private System.Windows.Forms.PictureBox imgPanel;
        private System.Windows.Forms.Button NHomeBtn;
        private System.Windows.Forms.Button NViewStudentBtn;
        private System.Windows.Forms.Button NAddStudentBtn;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTName;
        private System.Windows.Forms.Label lbRegNo;
        private System.Windows.Forms.Label lbMarks;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.DateTimePicker YearPicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button3;
    }
}