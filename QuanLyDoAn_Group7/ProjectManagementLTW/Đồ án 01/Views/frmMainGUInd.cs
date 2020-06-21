using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Management.Models;


namespace Project_Management.Views
{
    public partial class frmMainGUInd : Form
    {
        frmManageProject formProject;
        frmManageInstructor formInstructor;
        frmManageStudent formStudent;
        frmManageProgress formProgress;

        public frmMainGUInd()
        {
            
            InitializeComponent();
            timer1.Start();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.lbFirst.Visible = false;
            if(this.formStudent is null || this.formStudent.IsDisposed)
            {
                this.formStudent = new frmManageStudent();
                this.formStudent.MdiParent = this;
                this.formStudent.Show();
            }
            else
            {
                this.formStudent.Select();
                this.formStudent.DisplayListView();
            }
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            this.lbFirst.Visible = false;
            if (this.formInstructor is null || this.formInstructor.IsDisposed)
            {
                this.formInstructor = new frmManageInstructor();
                this.formInstructor.MdiParent = this;
                this.formInstructor.Show();
            }
            else
            {
                this.formInstructor.Select();
                this.formInstructor.DisplayListGV();
            }
        }
        private void btnProject_Click(object sender, EventArgs e)
        {
            this.lbFirst.Visible = false;
            if(this.formProject is null || this.formProject.IsDisposed)
            {
                this.formProject = new frmManageProject();
                this.formProject.MdiParent = this;
                this.formProject.Show();
            }
            else
            {
                
                this.formProject.Select();
                this.formProject.DisplayListProject();

            }
        }

        private void frmMainGUInd_MdiChildActivate(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild == null)
            {
                return;
            }
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
            if(this.ActiveMdiChild.Tag == null)
            {
                TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                tp.Tag = this.ActiveMdiChild;
                tp.Parent = this.tabMain;
                this.tabMain.SelectedTab = tp;
                this.ActiveMdiChild.Tag = tp;
                this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.tabMain.SelectedTab != null && this.tabMain.SelectedTab.Tag !=null)
            {
                (this.tabMain.SelectedTab.Tag as Form).Select();
            }
            else
            {
                this.lbFirst.Visible = true;
            }
        }

        private void frmMainGUInd_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.lbFirst.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.lbFirst.Visible = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label4.Text = DateTime.Now.Date.ToLongDateString().ToString();
            this.label5.Text = DateTime.Now.ToLongTimeString().ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
           
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            this.lbFirst.Visible = true;
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            this.lbFirst.Visible = false;
            if (this.formProgress is null || this.formProgress.IsDisposed)
            {
                this.formProgress = new frmManageProgress();
                this.formProgress.MdiParent = this;
                this.formProgress.Show();
            }
            else
            {
                this.formProgress.Select();
                this.formProgress.DisplayProgress();
            }
        }
    }
}
