using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduAdminSys.connDB;

namespace EduAdminSys.frmStudt
{
    public partial class frmStudent : Form
    {
        private static string stuno;
        public frmStudPersInfor studPersInfor;
        public frmStudSeleCourses studSeleCourses;
        public frmStudMark studMark;
        public frmStudCourses studCourses;
        public frmStudCancelCou cancelCou;

        public frmStudent(string stuNo)
        {
            InitializeComponent();
            stuno = stuNo;
            setToolStatus();

        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studPersInfor = new frmStudPersInfor(stuno);
            studPersInfor.Show();
            panel.Controls.Clear();
            panel.Controls.Add(studPersInfor);
        }

        private void 已选修课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studCourses = new frmStudCourses(stuno);
            studCourses.Show();
            panel.Controls.Clear();
            panel.Controls.Add(studCourses);
        }

        private void 考试成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studMark = new frmStudMark(stuno);
            studMark.Show();
            panel.Controls.Clear();
            panel.Controls.Add(studMark);
        }

        private void 未进入课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cancelCou = new frmStudCancelCou(stuno);
            cancelCou.Show();
            panel.Controls.Clear();
            panel.Controls.Add(cancelCou);
        }

        private void setToolStatus()
        {
            string sqlStr = "SELECT * FROM tbStudent WHERE stuno='" + stuno + "'";
            SqlDataReader dr = new SqlOperate().GetRowData(sqlStr);
            while (dr.Read())
            {
                DateTime dt = DateTime.Now;
                toolStatusStuno.Text = "学号：" + dr["stuno"].ToString();
                toolStatusStuname.Text = "姓名：" + dr["stuname"].ToString();
                toolStatusTime.Text = "登陆时间：" + dt.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        private void 退出程序ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出程序吗？", "确认退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout fa = new frmAbout();
            fa.ShowDialog();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPasswordSet pswset = new frmPasswordSet(stuno);
            pswset.ShowDialog();
        }

        private void 选修课程ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            studSeleCourses = new frmStudSeleCourses(stuno);
            studSeleCourses.Show();
            panel.Controls.Clear();
            panel.Controls.Add(studSeleCourses);
        }

        private void FrmStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出登陆吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
