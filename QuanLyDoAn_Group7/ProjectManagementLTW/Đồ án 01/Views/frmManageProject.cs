﻿using Project_Management.Controllers;
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

namespace Project_Management.Views
{
    public partial class frmManageProject : Form
    {
        private int STT;

        public frmManageProject()
        {
            InitializeComponent();
            STT = this.lstProject.Items.Count + 1;

        }

        public void DisplayListProject()
        {
            
            this.lstProject.Items.Clear();
            STT = 1;
            List<Project> listProject = ProjectController.getAllProject();

            foreach (Project item in listProject)
            {
                ListViewItem proj = new ListViewItem(STT.ToString());
                proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, item.idProject.ToString()));
                proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, item.name.ToString()));

                string sStudent = ""; 
                foreach (Student st in item.listStudent)
                {
                    sStudent += st.name.ToString() + " ";
                }
                proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, sStudent));


                string sInstructor = "";
                foreach (Instructor gv in item.listInstructor)
                {
                    sInstructor += gv.name.ToString() + " ";
                }
                proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, sInstructor));

                proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, item.subject.ToString()));
                proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, item.course.ToString()));

                this.lstProject.Items.Add(proj);
                STT++;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Progress pro = new Progress();
            // Dùng form frmProject chứ năng thêm
            frmAddProject add = new frmAddProject();
            add.ShowDialog();

            //Nếu cancel (project.a=idProject == null) thì return
            if (add.project.idProject == null)
                return;

            //gán giá trị cho progress
            pro.idProject = add.project.idProject;
            pro.Name = add.project.name;
            pro.listStudent = null;
            pro.dateStart = add.project.dateStart.Value;
            pro.finishTime = add.project.dateEnd.Value;
            pro.mark = 0;
            pro.submitTime = DateTime.Now.Date;
            pro.finished = false;
            
            //add progress
            ProgressController.AddProgress(pro);
            //add project
            ProjectController.AddProject(add.project);

            // Hiển thị lên listview
            ListViewItem proj = new ListViewItem(STT.ToString());
            proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, add.project.idProject.ToString()));
            proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, add.project.name.ToString()));

            // listStudent
            string sStudent = "";
            foreach (Student st in add.project.listStudent)
            {
                sStudent += st.name.ToString() + " ";
            }
            proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, sStudent));

            // listInstructor
            string sInstructor = "";
            foreach (Instructor gv in add.project.listInstructor)
            {
                sInstructor += gv.name.ToString() + " ";
            }
            proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, sInstructor));
            proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, add.project.subject.ToString()));
            proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, add.project.course.ToString()));

            this.lstProject.Items.Add(proj);
            STT++;
        }

        private void frmManageProject_Load(object sender, EventArgs e)
        {
            
            DisplayListProject();
        }

        private void lstProject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Chức năng sửa 
            if (this.lstProject.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn đối tượng !", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Duyệt trên list Project với mã tương ứng
            Project p = new Project();
            p = ProjectController.GetProject(this.lstProject.SelectedItems[0].SubItems[1].Text);
            ICollection<Student> editStudent = p.listStudent;

            frmAddProject edit = new frmAddProject(ref p);
            edit.ShowDialog();

            if (edit.edit == true)
            {
                // Dùng database ( tìm index, cập nhật)
                ProjectController.Update(edit.project,this.lstProject.SelectedItems[0].SubItems[1].Text);
                
                // Hiển thị trên listview
                ListViewItem proj = new ListViewItem(this.lstProject.SelectedItems[0].SubItems[0].Text.ToString());
                proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, edit.project.idProject.ToString()));
                proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, edit.project.name.ToString()));

                // getlist student của project , dùng database chuyển sang str để hiển thị trên 1 ô
                string sStudent = "";
                foreach (Student st in edit.project.listStudent)
                {
                    sStudent += st.name.ToString() + " ";
                }
                proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, sStudent));
                string sInstructor = "";
                foreach (Instructor gv in edit.project.listInstructor)
                {
                    sInstructor += gv.name.ToString() + " ";
                }
                proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, sInstructor));
                proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, edit.project.subject.ToString()));
                proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, edit.project.course.ToString()));

                this.lstProject.Items[this.lstProject.SelectedItems[0].Index] = proj;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if(this.lstProject.SelectedIndices.Count==0)
            {
                MessageBox.Show("Bạn chưa chọn đối tượng ?", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa đối tượng?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {
                return;
            }
            //this.listProject.RemoveAt(this.lstProject.SelectedItems[0].Index);
           
            ProjectController.Delete(this.lstProject.SelectedItems[0].SubItems[1].Text);
            this.lstProject.Items.RemoveAt(this.lstProject.SelectedItems[0].Index);
            DisplayListProject();
        }

        private void frmManageProject_MdiChildActivate(object sender, EventArgs e)
        {

        }

        private void btnProjectDetail_Click(object sender, EventArgs e)
        {
            if (this.lstProject.SelectedItems.Count == 0)
                return;
            Project proj = ProjectController.GetProject(this.lstProject.SelectedItems[0].SubItems[1].Text);
            frmProjectDetail frmDetail = new frmProjectDetail(proj);
            frmDetail.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(this.txbSearch.Text.Trim()== "Nhập mã đề tài")
            {
                this.txbSearch.Clear();
            }
            if(e.KeyChar=='\b' && this.txbSearch.Text.Length==1)
            {
                this.txbSearch.Text = "Nhập mã đề tài";
            }
        }

        private void txbSearch_Click(object sender, EventArgs e)
        {
            if (this.txbSearch.Text.Trim() == "Nhập mã đề tài")
            {
                this.txbSearch.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txbSearch.Text.Trim() == "")
                {
                    DisplayListProject();
                }
                else
                {
                    this.lstProject.Items.Clear();
                    List<Project> lProject = ProjectController.Search(this.txbSearch.Text.Trim());

                    foreach (Project item in lProject)
                    {
                        ListViewItem proj = new ListViewItem(STT.ToString());
                        proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, item.idProject.ToString()));
                        proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, item.name.ToString()));
                        string sStudent = "";
                        foreach (Student st in item.listStudent)
                        {
                            sStudent += st.name.ToString() + "\n";
                        }
                        proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, sStudent));
                        string sInstructor = "";
                        foreach (Instructor gv in item.listInstructor)
                        {
                            sInstructor += gv.name.ToString() + "\n";
                        }
                        proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, sInstructor));

                        proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, item.subject.ToString()));
                        proj.SubItems.Add(new ListViewItem.ListViewSubItem(proj, item.course.ToString()));

                        this.lstProject.Items.Add(proj);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Không tìm thấy", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DisplayListProject();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
