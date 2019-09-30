namespace SchoolManagementSystem
{
    partial class ViewStudentMarks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentMarks));
            this.btnLogOutHeader = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsrlinkLabel = new System.Windows.Forms.LinkLabel();
            this.imgPanel = new System.Windows.Forms.PictureBox();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NHomeBtn = new System.Windows.Forms.Button();
            this.NAddStudentBtn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPanel)).BeginInit();
            this.ButtonPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SkyBlue;
            this.panel5.Controls.Add(this.btnLogOutHeader);
            this.panel5.Location = new System.Drawing.Point(17, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1228, 92);
            this.panel5.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // UsrlinkLabel
            // 
            this.UsrlinkLabel.AutoSize = true;
            this.UsrlinkLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UsrlinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrlinkLabel.Location = new System.Drawing.Point(61, 272);
            this.UsrlinkLabel.Name = "UsrlinkLabel";
            this.UsrlinkLabel.Size = new System.Drawing.Size(180, 25);
            this.UsrlinkLabel.TabIndex = 47;
            this.UsrlinkLabel.TabStop = true;
            this.UsrlinkLabel.Text = "Kavindu Sandeepa";
            // 
            // imgPanel
            // 
            this.imgPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imgPanel.Location = new System.Drawing.Point(17, 104);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(260, 220);
            this.imgPanel.TabIndex = 45;
            this.imgPanel.TabStop = false;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonPanel.Controls.Add(this.button3);
            this.ButtonPanel.Controls.Add(this.button1);
            this.ButtonPanel.Controls.Add(this.button2);
            this.ButtonPanel.Controls.Add(this.NHomeBtn);
            this.ButtonPanel.Controls.Add(this.NAddStudentBtn);
            this.ButtonPanel.Location = new System.Drawing.Point(17, 330);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(260, 335);
            this.ButtonPanel.TabIndex = 46;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Location = new System.Drawing.Point(16, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 35);
            this.button3.TabIndex = 31;
            this.button3.Text = "Reports";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(16, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 35);
            this.button1.TabIndex = 31;
            this.button1.Text = "Edit Appointment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Location = new System.Drawing.Point(16, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 35);
            this.button2.TabIndex = 32;
            this.button2.Text = "Add Appointment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
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
            // NAddStudentBtn
            // 
            this.NAddStudentBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NAddStudentBtn.Location = new System.Drawing.Point(16, 54);
            this.NAddStudentBtn.Name = "NAddStudentBtn";
            this.NAddStudentBtn.Size = new System.Drawing.Size(235, 35);
            this.NAddStudentBtn.TabIndex = 25;
            this.NAddStudentBtn.Text = "View Marks";
            this.NAddStudentBtn.UseVisualStyleBackColor = false;
            this.NAddStudentBtn.Click += new System.EventHandler(this.NAddStudentBtn_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(367, 17);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(168, 38);
            this.TitleLabel.TabIndex = 23;
            this.TitleLabel.Text = "My Marks";
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.btnInsert);
            this.ContentPanel.Controls.Add(this.TitleLabel);
            this.ContentPanel.Location = new System.Drawing.Point(280, 104);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(962, 560);
            this.ContentPanel.TabIndex = 50;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(327, 225);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(241, 50);
            this.btnInsert.TabIndex = 42;
            this.btnInsert.Text = "Get Marks Report";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // ViewStudentMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsrlinkLabel);
            this.Controls.Add(this.imgPanel);
            this.Controls.Add(this.ButtonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewStudentMarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStudentMarks";
            this.Load += new System.EventHandler(this.ViewStudentMarks_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPanel)).EndInit();
            this.ButtonPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOutHeader;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel UsrlinkLabel;
        private System.Windows.Forms.PictureBox imgPanel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button NHomeBtn;
        private System.Windows.Forms.Button NAddStudentBtn;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button button3;
    }
}