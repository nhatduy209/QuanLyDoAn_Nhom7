namespace Project_Management.Views
{
    partial class frmMainGUInd
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
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainGUInd));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnProgress = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnProject = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnGV = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnStudent = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.lbFirst = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.lbFirst.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(550, 0);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(390, 108);
            label3.TabIndex = 0;
            label3.Text = "Group 7";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 1050);
            this.panel1.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.BackgroundImage = global::Project_Management.Properties.Resources.graduate;
            this.panel13.Controls.Add(this.btnProgress);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 482);
            this.panel13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(8);
            this.panel13.Size = new System.Drawing.Size(393, 78);
            this.panel13.TabIndex = 3;
            // 
            // btnProgress
            // 
            this.btnProgress.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProgress.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.btnProgress.FlatAppearance.BorderSize = 0;
            this.btnProgress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(10)))), ((int)(((byte)(120)))));
            this.btnProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgress.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgress.Location = new System.Drawing.Point(107, 8);
            this.btnProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(278, 62);
            this.btnProgress.TabIndex = 3;
            this.btnProgress.Text = "Tiến độ";
            this.btnProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // panel14
            // 
            this.panel14.BackgroundImage = global::Project_Management.Properties.Resources.progress;
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(8, 8);
            this.panel14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(74, 62);
            this.panel14.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Project_Management.Properties.Resources.graduate;
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.btnProject);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 404);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(8);
            this.panel5.Size = new System.Drawing.Size(393, 78);
            this.panel5.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::Project_Management.Properties.Resources.project;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(8, 8);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(74, 62);
            this.panel9.TabIndex = 2;
            // 
            // btnProject
            // 
            this.btnProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.btnProject.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.btnProject.FlatAppearance.BorderSize = 0;
            this.btnProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(10)))), ((int)(((byte)(120)))));
            this.btnProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProject.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.btnProject.ForeColor = System.Drawing.Color.White;
            this.btnProject.Location = new System.Drawing.Point(107, 8);
            this.btnProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(278, 62);
            this.btnProject.TabIndex = 1;
            this.btnProject.Text = "Đồ án";
            this.btnProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProject.UseVisualStyleBackColor = false;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::Project_Management.Properties.Resources.graduate;
            this.panel7.Controls.Add(this.btnGV);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 326);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(8);
            this.panel7.Size = new System.Drawing.Size(393, 78);
            this.panel7.TabIndex = 2;
            // 
            // btnGV
            // 
            this.btnGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.btnGV.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.btnGV.FlatAppearance.BorderSize = 0;
            this.btnGV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(10)))), ((int)(((byte)(120)))));
            this.btnGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGV.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.btnGV.ForeColor = System.Drawing.Color.White;
            this.btnGV.Location = new System.Drawing.Point(107, 8);
            this.btnGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(278, 62);
            this.btnGV.TabIndex = 1;
            this.btnGV.Text = "Giáo viên";
            this.btnGV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGV.UseVisualStyleBackColor = false;
            this.btnGV.Click += new System.EventHandler(this.btnGV_Click);
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::Project_Management.Properties.Resources.teacher;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(8, 8);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(74, 62);
            this.panel8.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Project_Management.Properties.Resources.graduate;
            this.panel4.Controls.Add(this.btnStudent);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 248);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(8);
            this.panel4.Size = new System.Drawing.Size(393, 78);
            this.panel4.TabIndex = 2;
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.btnStudent.BackgroundImage = global::Project_Management.Properties.Resources.graduate;
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(10)))), ((int)(((byte)(120)))));
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Location = new System.Drawing.Point(107, 8);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(278, 62);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Sinh viên";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::Project_Management.Properties.Resources.graduate;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(8, 8);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(74, 62);
            this.panel6.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 248);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::Project_Management.Properties.Resources.flower;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel10.Location = new System.Drawing.Point(124, 49);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(120, 102);
            this.panel10.TabIndex = 1;
            this.panel10.Click += new System.EventHandler(this.panel10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group 7";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.ItemSize = new System.Drawing.Size(100, 30);
            this.tabMain.Location = new System.Drawing.Point(393, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1531, 72);
            this.tabMain.TabIndex = 5;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // lbFirst
            // 
            this.lbFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.lbFirst.Controls.Add(this.panel12);
            this.lbFirst.Controls.Add(this.panel11);
            this.lbFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFirst.Enabled = false;
            this.lbFirst.ForeColor = System.Drawing.Color.White;
            this.lbFirst.Location = new System.Drawing.Point(0, 0);
            this.lbFirst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbFirst.Name = "lbFirst";
            this.lbFirst.Size = new System.Drawing.Size(1924, 1050);
            this.lbFirst.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label5);
            this.panel12.Controls.Add(this.label4);
            this.panel12.Controls.Add(label3);
            this.panel12.Location = new System.Drawing.Point(636, 694);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1348, 368);
            this.panel12.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.label5.Location = new System.Drawing.Point(562, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 64);
            this.label5.TabIndex = 1;
            this.label5.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.label4.Location = new System.Drawing.Point(406, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 64);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = global::Project_Management.Properties.Resources.flower;
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel11.Location = new System.Drawing.Point(1180, 300);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(375, 385);
            this.panel11.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMainGUInd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbFirst);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainGUInd";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainGUInd_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmMainGUInd_MdiChildActivate);
            this.panel1.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.lbFirst.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGV;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.Panel lbFirst;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.Panel panel14;
    }
}



