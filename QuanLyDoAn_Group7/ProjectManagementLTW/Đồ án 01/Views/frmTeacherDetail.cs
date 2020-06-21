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
    public partial class frmInstructorDetail : Form
    {
        public frmInstructorDetail(Instructor ins)
        {
            InitializeComponent();
            txtBirthday.Text = ins.birthday.ToShortDateString().ToString();
            txtGender.Text = ins.gender;
            txtAddress.Text = ins.address;
            txtIdInstructor.Text = ins.id;
            txtPhone.Text = ins.phone;
            txtName.Text = ins.name;

            rbSubject.Text = ins.subject.Replace('-','\n');
        }

        private void frmInstructorDetail_Load(object sender, EventArgs e)
        {
           
        }
    }
}
