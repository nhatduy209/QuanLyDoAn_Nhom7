namespace Project_Management
{
    partial class frmAddGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddGV));
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.dpBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.listboxSubject = new System.Windows.Forms.ListBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(174, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Giảng Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(177, 291);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Điện Thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(726, 409);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Môn Phụ Trách";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(726, 279);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 31);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày Sinh";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(183, 225);
            this.txbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(386, 39);
            this.txbName.TabIndex = 10;
            this.txbName.Text = "Nhập tên giảng viên";
            this.txbName.Click += new System.EventHandler(this.txbName_Click);
            this.txbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbName_KeyPress);
            // 
            // txbPhone
            // 
            this.txbPhone.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhone.Location = new System.Drawing.Point(183, 346);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(386, 39);
            this.txbPhone.TabIndex = 12;
            this.txbPhone.Text = "Nhập số điện thoại";
            this.txbPhone.Click += new System.EventHandler(this.txbPhone_Click);
            this.txbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPhone_KeyPress);
            // 
            // dpBirthday
            // 
            this.dpBirthday.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpBirthday.Location = new System.Drawing.Point(732, 346);
            this.dpBirthday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpBirthday.Name = "dpBirthday";
            this.dpBirthday.Size = new System.Drawing.Size(362, 39);
            this.dpBirthday.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(10)))), ((int)(((byte)(120)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(869, 712);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(225, 62);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Thêm";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(10)))), ((int)(((byte)(120)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(610, 712);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(225, 62);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Hủy";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 114);
            this.panel1.TabIndex = 19;
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = global::Project_Management.Properties.Resources.flower;
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel12.Location = new System.Drawing.Point(297, 29);
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
            this.lblName.Location = new System.Drawing.Point(394, 29);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(636, 64);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "THÔNG TIN GIÁO VIÊN";
            // 
            // listboxSubject
            // 
            this.listboxSubject.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxSubject.FormattingEnabled = true;
            this.listboxSubject.ItemHeight = 31;
            this.listboxSubject.Location = new System.Drawing.Point(732, 543);
            this.listboxSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxSubject.Name = "listboxSubject";
            this.listboxSubject.Size = new System.Drawing.Size(362, 128);
            this.listboxSubject.TabIndex = 21;
            this.listboxSubject.DoubleClick += new System.EventHandler(this.listboxSubject_DoubleClick);
            // 
            // cbSubject
            // 
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Items.AddRange(new object[] {
            "Chọn các môn học"});
            this.cbSubject.Location = new System.Drawing.Point(732, 483);
            this.cbSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(362, 39);
            this.cbSubject.TabIndex = 20;
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Chọn giới tính",
            "Nam",
            "Nữ"});
            this.cbGender.Location = new System.Drawing.Point(180, 483);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(386, 39);
            this.cbGender.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(177, 409);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 31);
            this.label13.TabIndex = 22;
            this.label13.Text = "Giới tính:";
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(732, 206);
            this.txbID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(362, 39);
            this.txbID.TabIndex = 25;
            this.txbID.Text = "Nhập mã giáo viên";
            this.txbID.Click += new System.EventHandler(this.txbID_Click);
            this.txbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(737, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã giáo viên";
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.Location = new System.Drawing.Point(180, 596);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(386, 39);
            this.txbAddress.TabIndex = 27;
            this.txbAddress.Text = "Nhập địa chỉ";
            this.txbAddress.Click += new System.EventHandler(this.txbAddress_Click);
            this.txbAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAddress_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(177, 543);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "Địa chỉ";
            // 
            // frmAddGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1294, 875);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listboxSubject);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dpBirthday);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.DateTimePicker dpBirthday;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox listboxSubject;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label3;
    }
}