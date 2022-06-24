using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduAdminSys.frmMang.classes
{
    public partial class frmMangTable : Form
    {
        private frmTabStu tabStu;
        private frmTabTeach tabTeach;
        private frmTabLogin tabLogin;
        private frmTabCourse tabCourse;
        public frmMangTable()
        {
            InitializeComponent();
        }

        private void 学生表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabStu = new frmTabStu();
            tabStu.Show();
            panel.Controls.Clear();
            panel.Controls.Add(tabStu);
        }

        private void 教师表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabTeach = new frmTabTeach();
            tabTeach.Show();
            panel.Controls.Clear();
            panel.Controls.Add(tabTeach);
        }

        private void 退出界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 登录表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabLogin = new frmTabLogin();
            tabLogin.Show();
            panel.Controls.Clear();
            panel.Controls.Add(tabLogin);
        }

        private void 课程表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabCourse = new frmTabCourse();
            tabCourse.Show();
            panel.Controls.Clear();
            panel.Controls.Add(tabCourse);
        }
    }
}
