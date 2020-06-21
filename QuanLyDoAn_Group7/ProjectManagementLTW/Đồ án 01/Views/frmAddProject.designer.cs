namespace Project_Management
{
    partial class frmAddProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProject));
            this.txbID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.txbProjectName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.listboxStudent = new System.Windows.Forms.ListBox();
            this.listboxResultStudent = new System.Windows.Forms.ListBox();
            this.listboxInstructor = new System.Windows.Forms.ListBox();
            this.listboxResultInstructor = new System.Windows.Forms.ListBox();
            this.txbInstructors = new System.Windows.Forms.RichTextBox();
            this.txbStudents = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbID
            // 
            this.txbID.BackColor = System.Drawing.Color.White;
            this.txbID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.ForeColor = System.Drawing.Color.Black;
            this.txbID.Location = new System.Drawing.Point(140, 192);
            this.txbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(428, 39);
            this.txbID.TabIndex = 35;
            this.txbID.Text = "Nhập mã đề tài";
            this.txbID.Click += new System.EventHandler(this.txbID_Click);
            this.txbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(136, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 31);
            this.label9.TabIndex = 34;
            this.label9.Text = "Mã đề tài";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(120)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(694, 716);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(225, 62);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(120)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(968, 716);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(225, 62);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbCourse
            // 
            this.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourse.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCourse.ForeColor = System.Drawing.Color.Black;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Items.AddRange(new object[] {
            "Chọn niên khóa",
            "2010 -  2011",
            "2011 - 2012",
            "2012 - 2013",
            "2013 - 2014",
            "2014 - 2015",
            "2015 - 2016",
            "2016 - 2017",
            "2017 - 2018",
            "2018 - 2019",
            "2019 - 2020"});
            this.cbCourse.Location = new System.Drawing.Point(766, 319);
            this.cbCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(427, 39);
            this.cbCourse.TabIndex = 26;
            this.cbCourse.SelectedIndexChanged += new System.EventHandler(this.cbCourse_SelectedIndexChanged);
            // 
            // cbSubject
            // 
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubject.ForeColor = System.Drawing.Color.Black;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Items.AddRange(new object[] {
            "Chọn môn"});
            this.cbSubject.Location = new System.Drawing.Point(765, 192);
            this.cbSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(427, 39);
            this.cbSubject.TabIndex = 25;
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // txbProjectName
            // 
            this.txbProjectName.BackColor = System.Drawing.Color.White;
            this.txbProjectName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProjectName.ForeColor = System.Drawing.Color.Black;
            this.txbProjectName.Location = new System.Drawing.Point(140, 318);
            this.txbProjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbProjectName.Name = "txbProjectName";
            this.txbProjectName.Size = new System.Drawing.Size(428, 39);
            this.txbProjectName.TabIndex = 22;
            this.txbProjectName.Text = "Nhập tên đề tài";
            this.txbProjectName.Click += new System.EventHandler(this.txbProjectName_Click);
            this.txbProjectName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbProjectName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(760, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "Niên khóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(759, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 31);
            this.label5.TabIndex = 19;
            this.label5.Text = "Môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(763, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "Giáo viên hướng dẫn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(136, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sinh viên thực hiện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(136, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên đề tài";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1328, 138);
            this.panel2.TabIndex = 20;
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = global::Project_Management.Properties.Resources.flower;
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel12.Location = new System.Drawing.Point(424, 31);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(88, 65);
            this.panel12.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(522, 31);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(380, 64);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "THÊM ĐỀ TÀI";
            // 
            // listboxStudent
            // 
            this.listboxStudent.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxStudent.FormattingEnabled = true;
            this.listboxStudent.ItemHeight = 31;
            this.listboxStudent.Location = new System.Drawing.Point(166, 515);
            this.listboxStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxStudent.Name = "listboxStudent";
            this.listboxStudent.Size = new System.Drawing.Size(425, 159);
            this.listboxStudent.TabIndex = 41;
            this.listboxStudent.Click += new System.EventHandler(this.listboxStudent_Click);
            // 
            // listboxResultStudent
            // 
            this.listboxResultStudent.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxResultStudent.FormattingEnabled = true;
            this.listboxResultStudent.ItemHeight = 31;
            this.listboxResultStudent.Location = new System.Drawing.Point(141, 515);
            this.listboxResultStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxResultStudent.Name = "listboxResultStudent";
            this.listboxResultStudent.Size = new System.Drawing.Size(426, 159);
            this.listboxResultStudent.TabIndex = 40;
            this.listboxResultStudent.Click += new System.EventHandler(this.listboxResultStudent_Click);
            this.listboxResultStudent.SelectedIndexChanged += new System.EventHandler(this.listboxResultStudent_SelectedIndexChanged);
            this.listboxResultStudent.DoubleClick += new System.EventHandler(this.listboxResultStudent_DoubleClick);
            // 
            // listboxInstructor
            // 
            this.listboxInstructor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxInstructor.FormattingEnabled = true;
            this.listboxInstructor.ItemHeight = 31;
            this.listboxInstructor.Location = new System.Drawing.Point(794, 513);
            this.listboxInstructor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxInstructor.Name = "listboxInstructor";
            this.listboxInstructor.Size = new System.Drawing.Size(425, 159);
            this.listboxInstructor.TabIndex = 43;
            this.listboxInstructor.Click += new System.EventHandler(this.listboxInstructor_Click);
            // 
            // listboxResultInstructor
            // 
            this.listboxResultInstructor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxResultInstructor.FormattingEnabled = true;
            this.listboxResultInstructor.ItemHeight = 31;
            this.listboxResultInstructor.Location = new System.Drawing.Point(766, 513);
            this.listboxResultInstructor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxResultInstructor.Name = "listboxResultInstructor";
            this.listboxResultInstructor.Size = new System.Drawing.Size(426, 159);
            this.listboxResultInstructor.TabIndex = 42;
            this.listboxResultInstructor.Click += new System.EventHandler(this.listboxResultInstructor_Click);
            this.listboxResultInstructor.SelectedIndexChanged += new System.EventHandler(this.listboxResultInstructor_SelectedIndexChanged);
            this.listboxResultInstructor.DoubleClick += new System.EventHandler(this.listboxResultInstructor_DoubleClick);
            // 
            // txbInstructors
            // 
            this.txbInstructors.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInstructors.ForeColor = System.Drawing.Color.Black;
            this.txbInstructors.Location = new System.Drawing.Point(765, 451);
            this.txbInstructors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbInstructors.Name = "txbInstructors";
            this.txbInstructors.Size = new System.Drawing.Size(427, 45);
            this.txbInstructors.TabIndex = 45;
            this.txbInstructors.Text = "Nhập mã giáo viên";
            this.txbInstructors.Click += new System.EventHandler(this.txbInstructors_Click);
            this.txbInstructors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbInstructors_KeyPress);
            // 
            // txbStudents
            // 
            this.txbStudents.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStudents.ForeColor = System.Drawing.Color.Black;
            this.txbStudents.Location = new System.Drawing.Point(141, 445);
            this.txbStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbStudents.Name = "txbStudents";
            this.txbStudents.Size = new System.Drawing.Size(427, 45);
            this.txbStudents.TabIndex = 44;
            this.txbStudents.Text = "Nhập mã số sinh viên";
            this.txbStudents.Click += new System.EventHandler(this.txbStudents_Click);
            this.txbStudents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbStudents_KeyPress);
            // 
            // frmAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1328, 919);
            this.Controls.Add(this.txbInstructors);
            this.Controls.Add(this.txbStudents);
            this.Controls.Add(this.listboxInstructor);
            this.Controls.Add(this.listboxResultInstructor);
            this.Controls.Add(this.listboxStudent);
            this.Controls.Add(this.listboxResultStudent);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.txbProjectName);
            this.Controls.Add(this.cbSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddProject";
            this.Load += new System.EventHandler(this.frmAddProject_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmAddProject_MdiChildActivate);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.TextBox txbProjectName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox listboxStudent;
        private System.Windows.Forms.ListBox listboxResultStudent;
        private System.Windows.Forms.ListBox listboxInstructor;
        private System.Windows.Forms.ListBox listboxResultInstructor;
        private System.Windows.Forms.RichTextBox txbInstructors;
        private System.Windows.Forms.RichTextBox txbStudents;
    }
}