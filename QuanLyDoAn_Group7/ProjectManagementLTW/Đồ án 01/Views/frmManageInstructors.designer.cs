namespace Project_Management.Views
{
    partial class frmManageInstructor
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
            this.lstInstructor = new System.Windows.Forms.ListView();
            this.clSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cBirthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearchGV = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTeacherDetail = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnDeleteGV = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEditGV = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddGV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstInstructor
            // 
            this.lstInstructor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clSTT,
            this.cID,
            this.cName,
            this.cGender,
            this.cBirthday,
            this.cPhone,
            this.cSubject});
            this.lstInstructor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstInstructor.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInstructor.FullRowSelect = true;
            this.lstInstructor.GridLines = true;
            this.lstInstructor.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstInstructor.HideSelection = false;
            this.lstInstructor.Location = new System.Drawing.Point(45, 46);
            this.lstInstructor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstInstructor.Name = "lstInstructor";
            this.lstInstructor.Size = new System.Drawing.Size(1365, 485);
            this.lstInstructor.TabIndex = 1;
            this.lstInstructor.UseCompatibleStateImageBehavior = false;
            this.lstInstructor.View = System.Windows.Forms.View.Details;
            this.lstInstructor.SelectedIndexChanged += new System.EventHandler(this.LstviewDataGV_SelectedIndexChanged);
            // 
            // clSTT
            // 
            this.clSTT.Text = "STT";
            this.clSTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clSTT.Width = 91;
            // 
            // cID
            // 
            this.cID.Text = "Mã Giáo Viên";
            this.cID.Width = 123;
            // 
            // cName
            // 
            this.cName.Text = "Tên ";
            this.cName.Width = 223;
            // 
            // cGender
            // 
            this.cGender.Text = "Giới tính";
            // 
            // cBirthday
            // 
            this.cBirthday.Text = "Ngày Sinh";
            this.cBirthday.Width = 150;
            // 
            // cPhone
            // 
            this.cPhone.Text = "Số điện thoại";
            this.cPhone.Width = 150;
            // 
            // cSubject
            // 
            this.cSubject.Text = "Môn phụ trách";
            this.cSubject.Width = 188;
            // 
            // txtSearchGV
            // 
            this.txtSearchGV.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchGV.Location = new System.Drawing.Point(767, 23);
            this.txtSearchGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchGV.Name = "txtSearchGV";
            this.txtSearchGV.Size = new System.Drawing.Size(459, 33);
            this.txtSearchGV.TabIndex = 2;
            this.txtSearchGV.Text = "Nhập mã GV";
            this.txtSearchGV.Click += new System.EventHandler(this.txtSearchGV_Click);
            this.txtSearchGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchGV_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 295);
            this.panel1.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = global::Project_Management.Properties.Resources.flower;
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel12.Location = new System.Drawing.Point(633, 46);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(118, 95);
            this.panel12.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(776, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 69);
            this.label1.TabIndex = 7;
            this.label1.Text = "THÔNG TIN GIÁO VIÊN";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.panel6.Controls.Add(this.btnAll);
            this.panel6.Controls.Add(this.btnSearch);
            this.panel6.Controls.Add(this.btnTeacherDetail);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.txtSearchGV);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 217);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1455, 78);
            this.panel6.TabIndex = 6;
            // 
            // btnAll
            // 
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(10)))), ((int)(((byte)(120)))));
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(1256, 5);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(150, 78);
            this.btnAll.TabIndex = 16;
            this.btnAll.Text = "Tất cả";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(10)))), ((int)(((byte)(120)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(600, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 78);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnTeacherDetail
            // 
            this.btnTeacherDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTeacherDetail.FlatAppearance.BorderSize = 0;
            this.btnTeacherDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(10)))), ((int)(((byte)(120)))));
            this.btnTeacherDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherDetail.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherDetail.ForeColor = System.Drawing.Color.White;
            this.btnTeacherDetail.Location = new System.Drawing.Point(450, 0);
            this.btnTeacherDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTeacherDetail.Name = "btnTeacherDetail";
            this.btnTeacherDetail.Size = new System.Drawing.Size(150, 78);
            this.btnTeacherDetail.TabIndex = 11;
            this.btnTeacherDetail.Text = "Chi tiết";
            this.btnTeacherDetail.UseVisualStyleBackColor = true;
            this.btnTeacherDetail.Click += new System.EventHandler(this.btnTeacherDetail_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnDeleteGV);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(300, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(150, 78);
            this.panel7.TabIndex = 9;
            // 
            // btnDeleteGV
            // 
            this.btnDeleteGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.btnDeleteGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteGV.FlatAppearance.BorderSize = 0;
            this.btnDeleteGV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(10)))), ((int)(((byte)(120)))));
            this.btnDeleteGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGV.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteGV.Location = new System.Drawing.Point(0, 0);
            this.btnDeleteGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteGV.Name = "btnDeleteGV";
            this.btnDeleteGV.Size = new System.Drawing.Size(150, 78);
            this.btnDeleteGV.TabIndex = 4;
            this.btnDeleteGV.Text = "Xóa ";
            this.btnDeleteGV.UseVisualStyleBackColor = false;
            this.btnDeleteGV.Click += new System.EventHandler(this.btnDeleteGV_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnEditGV);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(150, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 78);
            this.panel5.TabIndex = 8;
            // 
            // btnEditGV
            // 
            this.btnEditGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.btnEditGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditGV.FlatAppearance.BorderSize = 0;
            this.btnEditGV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(10)))), ((int)(((byte)(120)))));
            this.btnEditGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGV.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditGV.Location = new System.Drawing.Point(0, 0);
            this.btnEditGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditGV.Name = "btnEditGV";
            this.btnEditGV.Size = new System.Drawing.Size(150, 78);
            this.btnEditGV.TabIndex = 5;
            this.btnEditGV.Text = "Sửa";
            this.btnEditGV.UseVisualStyleBackColor = false;
            this.btnEditGV.Click += new System.EventHandler(this.btnEditGV_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddGV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 78);
            this.panel3.TabIndex = 7;
            // 
            // btnAddGV
            // 
            this.btnAddGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.btnAddGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddGV.FlatAppearance.BorderSize = 0;
            this.btnAddGV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(10)))), ((int)(((byte)(120)))));
            this.btnAddGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGV.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddGV.Location = new System.Drawing.Point(0, 0);
            this.btnAddGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddGV.Name = "btnAddGV";
            this.btnAddGV.Size = new System.Drawing.Size(150, 78);
            this.btnAddGV.TabIndex = 3;
            this.btnAddGV.Text = "Thêm";
            this.btnAddGV.UseVisualStyleBackColor = false;
            this.btnAddGV.Click += new System.EventHandler(this.btnAddGV_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.lstInstructor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(45, 46, 45, 46);
            this.panel2.Size = new System.Drawing.Size(1455, 577);
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 295);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1455, 577);
            this.panel4.TabIndex = 8;
            // 
            // frmManageInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 872);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmManageInstructor";
            this.Text = "Giảng Viên Phụ Trách Đồ Án";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGV_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmManageInstructor_MdiChildActivate);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchGV;
        private System.Windows.Forms.ListView lstInstructor;
        private System.Windows.Forms.ColumnHeader cID;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cBirthday;
        private System.Windows.Forms.ColumnHeader cPhone;
        private System.Windows.Forms.ColumnHeader cSubject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditGV;
        private System.Windows.Forms.Button btnDeleteGV;
        private System.Windows.Forms.Button btnAddGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader clSTT;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTeacherDetail;
        private System.Windows.Forms.ColumnHeader cGender;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnSearch;
    }
}

