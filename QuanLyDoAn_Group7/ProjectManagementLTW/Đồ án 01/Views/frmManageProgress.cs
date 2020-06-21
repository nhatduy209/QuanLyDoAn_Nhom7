using Project_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Management.Controllers;
namespace Project_Management.Views
{
    public partial class frmManageProgress : Form
    {
        int id;
        List<Progress> listProgress;
        int STT;
        public TimeSpan timeDown;
        public frmManageProgress()
        {
            InitializeComponent();
            DisplayProgress();
        }

        public void DisplayProgress()
        {
            this.listViewProgress.Items.Clear();
            int STT = 1;
            List<Progress> listProgress = ProgressController.getAllProgress();
            foreach (Progress item in listProgress)
            {
                ListViewItem progress = new ListViewItem(STT.ToString());
                progress.SubItems.Add(new ListViewItem.ListViewSubItem(progress, item.idProject.ToString()));
                progress.SubItems.Add(new ListViewItem.ListViewSubItem(progress, item.Name.ToString()));


                Project p = ProjectController.GetProject(item.idProject);
                string sStudent = "";
                foreach (Student st in p.listStudent)
                {
                    sStudent += st.name.ToString() + "\n";
                }
                progress.SubItems.Add(new ListViewItem.ListViewSubItem(progress, sStudent));

                progress.SubItems.Add(new ListViewItem.ListViewSubItem(progress, item.dateStart.ToShortDateString()));//Ngày bắt đầu
                progress.SubItems.Add(new ListViewItem.ListViewSubItem(progress, item.finishTime.ToShortDateString()));//Ngày kết thúc
                if (item.finished == true)
                    progress.SubItems.Add(new ListViewItem.ListViewSubItem(progress, item.submitTime.ToString()));//Ngày nộp
                else
                    progress.SubItems.Add(new ListViewItem.ListViewSubItem(progress, ""));//Ngày nộp
                listViewProgress.Items.Add(progress);
                STT++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.listViewProgress.SelectedItems.Count == 0)
                return;

            Progress pro = new Progress();

            listProgress = ProgressController.getAllProgress();
            foreach(Progress item in listProgress)
            {
                if (item.idProject.ToString() == this.listViewProgress.SelectedItems[0].SubItems[1].Text)
                { 
                    pro = item; 
                    break;
                }
            }

            frmEditProgress formAdd = new frmEditProgress(pro);
            formAdd.ShowDialog();

            if(formAdd.edit == true)
            {
                for (int i = 0; i < this.listViewProgress.Items.Count; i++)
                {
                    if (listViewProgress.Items[i].SubItems[1].Text == pro.idProject)
                    {
                        STT = i + 1;
                        break;
                    }
                }
                ListViewItem Pr = new ListViewItem(STT.ToString());
                Pr.SubItems.Add(new ListViewItem.ListViewSubItem(Pr, pro.idProject.ToString()));
                Pr.SubItems.Add(new ListViewItem.ListViewSubItem(Pr, pro.Name.ToString()));

                Project p = ProjectController.GetProject(pro.idProject);
                string sStudent = "";
                foreach (Student st in p.listStudent)
                {
                    sStudent += st.name.ToString() + "\n";
                }
                Pr.SubItems.Add(new ListViewItem.ListViewSubItem(Pr, sStudent));

                Pr.SubItems.Add(new ListViewItem.ListViewSubItem(Pr, pro.dateStart.ToShortDateString()));//Ngày bắt đầu
                Pr.SubItems.Add(new ListViewItem.ListViewSubItem(Pr, pro.finishTime.ToShortDateString()));//Ngày kết thúc
                if (pro.finished == true)
                    Pr.SubItems.Add(new ListViewItem.ListViewSubItem(Pr, pro.submitTime.ToString()));//Ngày nộp
                else
                    Pr.SubItems.Add(new ListViewItem.ListViewSubItem(Pr, ""));//Ngày nộp

                //Update
                ProgressController.UpdateProgress(pro);
                this.listViewProgress.Items[this.listViewProgress.SelectedItems[0].Index] = Pr;

                // cập nhật lại cho project tương ứng
                List<Project> listProject = new List<Project>();
                listProject = ProjectController.getAllProject();
                Project proj = new Project();
                foreach (Project item in listProject)
                {
                    if (item.idProject == pro.idProject)
                    {
                        proj = item;
                        proj.dateStart = pro.dateStart;
                        proj.dateEnd = pro.finishTime;
                        proj.mark = pro.mark;
                        proj.source = formAdd.source;
                        ProjectController.UpdateProject(proj);
                        break;
                    }
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listViewProgress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewProgress.SelectedItems.Count == 0)
                return;
            Progress pro = new Progress();
            listProgress = ProgressController.getAllProgress();
            foreach (Progress item in listProgress)
            {
                if (item.idProject.ToString() == this.listViewProgress.SelectedItems[0].SubItems[1].Text)
                    pro = item;
            }
            if (pro.finished == true)
                this.radFinished.Checked = true;
            else
                this.radNotFinished.Checked = true;
            this.lbProjectName.Text = pro.Name.ToString();
            timeDown = pro.finishTime - DateTime.Now;
            this.timedown.Start();
        }

        private void timedown_Tick(object sender, EventArgs e)
        {
            if (timeDown.TotalDays < 1)
                this.lbtimedown.Text = "Time remaining: " + timeDown.Hours.ToString() + " hours";
            else if (timeDown.TotalHours < 1)
            {
                this.lbtimedown.Text = "Time remaining: " + timeDown.Minutes.ToString() + " minutes";
                this.lbtimedown.ForeColor = Color.Red;
            }
            else if (timeDown.TotalMinutes < 1)
            {
                this.lbtimedown.Text = "Time remaining: " + timeDown.Seconds.ToString() + " seconds";
                this.lbtimedown.ForeColor = Color.Red;
            }
            else
                this.lbtimedown.Text = "Time remaining: " + timeDown.Days.ToString() + " days";
        }
    }
}
