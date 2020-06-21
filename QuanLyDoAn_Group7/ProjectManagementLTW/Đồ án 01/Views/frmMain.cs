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
    public partial class frmMain : Form
    {
        frmMainGUInd Mainform;
        Dictionary<string,List<String>> faculty = new Dictionary<string, List<string>>();
        public frmMain()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Mainform = new frmMainGUInd();
            Mainform.ShowDialog();
        }

        private void btnMainExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnFindMain_Click(object sender, EventArgs e)
        {
            frmMainSearch formSearch = new frmMainSearch();
            formSearch.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmSettings formSetting = new frmSettings();
            formSetting.ShowDialog();
        }
    }
}
