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
    public partial class frmMainSearch : Form
    {
        private int ID = 1;
        public frmMainSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.lstViewSearh.Items.Clear();
            
            frmSearchProject formSearchProject = new frmSearchProject();
            formSearchProject.ShowDialog();
            if (formSearchProject.project is null)
                return;
            List<Project> SearhPros = formSearchProject.project;

            foreach (var SearhPro in SearhPros)
            {
                ListViewItem infoPro = new ListViewItem(ID.ToString());
                infoPro.SubItems.Add(new ListViewItem.ListViewSubItem(infoPro, SearhPro.idProject.ToString()));
                infoPro.SubItems.Add(new ListViewItem.ListViewSubItem(infoPro, SearhPro.name.ToString()));
                string sStudent = "";
                foreach (Student st in SearhPro.listStudent)
                {
                    sStudent += st.name.ToString() + " ";
                }
                infoPro.SubItems.Add(new ListViewItem.ListViewSubItem(infoPro, sStudent));

                string sInstructor = "";
                foreach (Instructor gv in SearhPro.listInstructor)
                {
                    sInstructor += gv.name.ToString() + " ";
                }
                infoPro.SubItems.Add(new ListViewItem.ListViewSubItem(infoPro, sInstructor));
                infoPro.SubItems.Add(new ListViewItem.ListViewSubItem(infoPro, SearhPro.subject.ToString()));
                infoPro.SubItems.Add(new ListViewItem.ListViewSubItem(infoPro, SearhPro.course.ToString()));

                this.lstViewSearh.Items.Add(infoPro);
            }



        }
    }
}
