namespace Project_Management.Views
{
    partial class frmEditProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditProgress));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnComplete = new System.Windows.Forms.RadioButton();
            this.rbtnNotComplete = new System.Windows.Forms.RadioButton();
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.dpEnd = new System.Windows.Forms.DateTimePicker();
            this.dpSubmitted = new System.Windows.Forms.DateTimePicker();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbReportTimes = new System.Windows.Forms.ComboBox();
            this.rbComment = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1088, 114);
            this.panel2.TabIndex = 21;
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = global::Project_Management.Properties.Resources.flower;
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel12.Location = new System.Drawing.Point(244, 29);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(88, 65);
            this.panel12.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(344, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(576, 64);
            this.label10.TabIndex = 9;
            this.label10.Text = "THÔNG TIN TIẾN ĐỘ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã đồ án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(178, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên đồ án";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(585, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Thời gian bắt đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(585, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "Thời gian kết thúc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(585, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 28);
            this.label6.TabIndex = 22;
            this.label6.Text = "Thời gian nộp";
            // 
            // rbtnComplete
            // 
            this.rbtnComplete.AutoSize = true;
            this.rbtnComplete.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnComplete.ForeColor = System.Drawing.Color.White;
            this.rbtnComplete.Location = new System.Drawing.Point(312, 702);
            this.rbtnComplete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rbtnComplete.Name = "rbtnComplete";
            this.rbtnComplete.Size = new System.Drawing.Size(156, 32);
            this.rbtnComplete.TabIndex = 23;
            this.rbtnComplete.TabStop = true;
            this.rbtnComplete.Text = "Hoàn thành";
            this.rbtnComplete.UseVisualStyleBackColor = true;
            // 
            // rbtnNotComplete
            // 
            this.rbtnNotComplete.AutoSize = true;
            this.rbtnNotComplete.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNotComplete.ForeColor = System.Drawing.Color.White;
            this.rbtnNotComplete.Location = new System.Drawing.Point(591, 702);
            this.rbtnNotComplete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rbtnNotComplete.Name = "rbtnNotComplete";
            this.rbtnNotComplete.Size = new System.Drawing.Size(224, 32);
            this.rbtnNotComplete.TabIndex = 23;
            this.rbtnNotComplete.TabStop = true;
            this.rbtnNotComplete.Text = "Không hoàn thành";
            this.rbtnNotComplete.UseVisualStyleBackColor = true;
            // 
            // dpStart
            // 
            this.dpStart.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpStart.Location = new System.Drawing.Point(590, 192);
            this.dpStart.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(301, 34);
            this.dpStart.TabIndex = 24;
            this.dpStart.ValueChanged += new System.EventHandler(this.dpStart_ValueChanged);
            // 
            // dpEnd
            // 
            this.dpEnd.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpEnd.Location = new System.Drawing.Point(590, 308);
            this.dpEnd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(301, 34);
            this.dpEnd.TabIndex = 24;
            // 
            // dpSubmitted
            // 
            this.dpSubmitted.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpSubmitted.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpSubmitted.Location = new System.Drawing.Point(590, 412);
            this.dpSubmitted.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dpSubmitted.Name = "dpSubmitted";
            this.dpSubmitted.Size = new System.Drawing.Size(301, 34);
            this.dpSubmitted.TabIndex = 24;
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(183, 192);
            this.txbID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(290, 34);
            this.txbID.TabIndex = 26;
            this.txbID.Text = "Nhập mã đồ án";
            this.txbID.Click += new System.EventHandler(this.txbID_Click);
            this.txbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(183, 309);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(290, 34);
            this.txbName.TabIndex = 26;
            this.txbName.Text = "Nhập tên đồ án";
            this.txbName.Click += new System.EventHandler(this.txbName_Click);
            this.txbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbName_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(10)))), ((int)(((byte)(120)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(249, 765);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(225, 62);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.btnCanel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCanel.FlatAppearance.BorderSize = 0;
            this.btnCanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(10)))), ((int)(((byte)(120)))));
            this.btnCanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanel.ForeColor = System.Drawing.Color.White;
            this.btnCanel.Location = new System.Drawing.Point(591, 765);
            this.btnCanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(225, 62);
            this.btnCanel.TabIndex = 27;
            this.btnCanel.Text = "Cancel";
            this.btnCanel.UseVisualStyleBackColor = false;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(190, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "Báo cáo";
            // 
            // cbReportTimes
            // 
            this.cbReportTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReportTimes.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReportTimes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbReportTimes.FormattingEnabled = true;
            this.cbReportTimes.Items.AddRange(new object[] {
            "Thêm lần báo cáo"});
            this.cbReportTimes.Location = new System.Drawing.Point(184, 412);
            this.cbReportTimes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbReportTimes.Name = "cbReportTimes";
            this.cbReportTimes.Size = new System.Drawing.Size(289, 39);
            this.cbReportTimes.TabIndex = 29;
            this.cbReportTimes.SelectedIndexChanged += new System.EventHandler(this.cbReportTimes_SelectedIndexChanged);
            // 
            // rbComment
            // 
            this.rbComment.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbComment.Location = new System.Drawing.Point(184, 465);
            this.rbComment.Name = "rbComment";
            this.rbComment.Size = new System.Drawing.Size(289, 95);
            this.rbComment.TabIndex = 30;
            this.rbComment.Text = "Nhập nhận xét";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(586, 474);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 27);
            this.label7.TabIndex = 31;
            this.label7.Text = "Điểm";
            // 
            // txtMark
            // 
            this.txtMark.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMark.Location = new System.Drawing.Point(591, 509);
            this.txtMark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(300, 39);
            this.txtMark.TabIndex = 32;
            this.txtMark.TextChanged += new System.EventHandler(this.txtMark_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(586, 577);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 27);
            this.label8.TabIndex = 31;
            this.label8.Text = "Link nộp bài";
            // 
            // txtSource
            // 
            this.txtSource.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(591, 617);
            this.txtSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(300, 39);
            this.txtSource.TabIndex = 32;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(333, 566);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(140, 38);
            this.btnDel.TabIndex = 38;
            this.btnDel.Text = "Xóa báo cáo";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // frmEditProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1088, 880);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbComment);
            this.Controls.Add(this.cbReportTimes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.dpSubmitted);
            this.Controls.Add(this.dpEnd);
            this.Controls.Add(this.dpStart);
            this.Controls.Add(this.rbtnNotComplete);
            this.Controls.Add(this.rbtnComplete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmEditProgress";
            this.Text = "Thông tin tiến độ";
            this.Load += new System.EventHandler(this.frmEditProgress_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtnComplete;
        private System.Windows.Forms.RadioButton rbtnNotComplete;
        private System.Windows.Forms.DateTimePicker dpStart;
        private System.Windows.Forms.DateTimePicker dpEnd;
        private System.Windows.Forms.DateTimePicker dpSubmitted;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbReportTimes;
        private System.Windows.Forms.RichTextBox rbComment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnDel;
    }
}