namespace Project_Management.Views
{
    partial class frmManageProgress
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listViewProgress = new System.Windows.Forms.ListView();
            this.clSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clIDProject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clProjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cllistStudent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFinishTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSubmitTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbtimedown = new System.Windows.Forms.Label();
            this.radNotFinished = new System.Windows.Forms.RadioButton();
            this.radFinished = new System.Windows.Forms.RadioButton();
            this.lbProjectName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timedown = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 236);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = global::Project_Management.Properties.Resources.flower;
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel12.Location = new System.Drawing.Point(484, 37);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(92, 76);
            this.panel12.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(583, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(769, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "THÔNG TIN TIẾN ĐỘ ĐỀ TÀI";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 173);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 63);
            this.panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(484, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(493, 33);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(369, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm kiếm";
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(10)))), ((int)(((byte)(120)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 63);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Báo cáo";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listViewProgress
            // 
            this.listViewProgress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clSTT,
            this.clIDProject,
            this.clProjectName,
            this.cllistStudent,
            this.clStartTime,
            this.clFinishTime,
            this.clSubmitTime});
            this.listViewProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProgress.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProgress.FullRowSelect = true;
            this.listViewProgress.GridLines = true;
            this.listViewProgress.HideSelection = false;
            this.listViewProgress.Location = new System.Drawing.Point(35, 37);
            this.listViewProgress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewProgress.Name = "listViewProgress";
            this.listViewProgress.Size = new System.Drawing.Size(1191, 401);
            this.listViewProgress.TabIndex = 1;
            this.listViewProgress.UseCompatibleStateImageBehavior = false;
            this.listViewProgress.View = System.Windows.Forms.View.Details;
            this.listViewProgress.SelectedIndexChanged += new System.EventHandler(this.listViewProgress_SelectedIndexChanged);
            // 
            // clSTT
            // 
            this.clSTT.Text = "STT";
            this.clSTT.Width = 50;
            // 
            // clIDProject
            // 
            this.clIDProject.Text = "Mã đồ án";
            this.clIDProject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clIDProject.Width = 150;
            // 
            // clProjectName
            // 
            this.clProjectName.Text = "Tên đồ án";
            this.clProjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clProjectName.Width = 200;
            // 
            // cllistStudent
            // 
            this.cllistStudent.Text = "Danh sách sinh viên";
            this.cllistStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cllistStudent.Width = 230;
            // 
            // clStartTime
            // 
            this.clStartTime.Text = "Thời gian bắt đầu";
            this.clStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clStartTime.Width = 150;
            // 
            // clFinishTime
            // 
            this.clFinishTime.Text = "Thời gian kết thúc";
            this.clFinishTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clFinishTime.Width = 150;
            // 
            // clSubmitTime
            // 
            this.clSubmitTime.Text = "Thời gian nộp";
            this.clSubmitTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clSubmitTime.Width = 150;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.listViewProgress);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 236);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.panel3.Size = new System.Drawing.Size(1261, 475);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbtimedown);
            this.panel4.Controls.Add(this.radNotFinished);
            this.panel4.Controls.Add(this.radFinished);
            this.panel4.Controls.Add(this.lbProjectName);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(35, 392);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(1191, 46);
            this.panel4.TabIndex = 2;
            // 
            // lbtimedown
            // 
            this.lbtimedown.AutoSize = true;
            this.lbtimedown.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbtimedown.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.lbtimedown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.lbtimedown.Location = new System.Drawing.Point(275, 10);
            this.lbtimedown.Name = "lbtimedown";
            this.lbtimedown.Size = new System.Drawing.Size(101, 38);
            this.lbtimedown.TabIndex = 4;
            this.lbtimedown.Text = "label4";
            // 
            // radNotFinished
            // 
            this.radNotFinished.Dock = System.Windows.Forms.DockStyle.Right;
            this.radNotFinished.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNotFinished.ForeColor = System.Drawing.Color.White;
            this.radNotFinished.Location = new System.Drawing.Point(815, 10);
            this.radNotFinished.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radNotFinished.Name = "radNotFinished";
            this.radNotFinished.Size = new System.Drawing.Size(210, 26);
            this.radNotFinished.TabIndex = 3;
            this.radNotFinished.TabStop = true;
            this.radNotFinished.Text = "Không hoàn thành";
            this.radNotFinished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radNotFinished.UseVisualStyleBackColor = true;
            // 
            // radFinished
            // 
            this.radFinished.Dock = System.Windows.Forms.DockStyle.Right;
            this.radFinished.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFinished.ForeColor = System.Drawing.Color.White;
            this.radFinished.Location = new System.Drawing.Point(1025, 10);
            this.radFinished.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radFinished.Name = "radFinished";
            this.radFinished.Size = new System.Drawing.Size(156, 26);
            this.radFinished.TabIndex = 3;
            this.radFinished.TabStop = true;
            this.radFinished.Text = "Hoàn thành";
            this.radFinished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radFinished.UseVisualStyleBackColor = true;
            // 
            // lbProjectName
            // 
            this.lbProjectName.AutoSize = true;
            this.lbProjectName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbProjectName.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProjectName.ForeColor = System.Drawing.Color.White;
            this.lbProjectName.Location = new System.Drawing.Point(174, 10);
            this.lbProjectName.Name = "lbProjectName";
            this.lbProjectName.Size = new System.Drawing.Size(101, 38);
            this.lbProjectName.TabIndex = 1;
            this.lbProjectName.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên đồ án:";
            // 
            // timedown
            // 
            this.timedown.Interval = 10;
            this.timedown.Tick += new System.EventHandler(this.timedown_Tick);
            // 
            // frmManageProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1261, 711);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmManageProgress";
            this.Text = "Quản lý tiến độ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewProgress;
        private System.Windows.Forms.ColumnHeader clSTT;
        private System.Windows.Forms.ColumnHeader clIDProject;
        private System.Windows.Forms.ColumnHeader clProjectName;
        private System.Windows.Forms.ColumnHeader cllistStudent;
        private System.Windows.Forms.ColumnHeader clStartTime;
        private System.Windows.Forms.ColumnHeader clFinishTime;
        private System.Windows.Forms.ColumnHeader clSubmitTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbProjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radNotFinished;
        private System.Windows.Forms.RadioButton radFinished;
        private System.Windows.Forms.Label lbtimedown;
        private System.Windows.Forms.Timer timedown;
    }
}