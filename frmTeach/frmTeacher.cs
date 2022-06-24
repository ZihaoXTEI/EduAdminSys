using EduAdminSys.connDB;
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

namespace EduAdminSys.frmTeach
{
    public partial class frmTeacher : Form
    {
        private static string teachno = "";
        private frmTeachPersInfor teachPersInfor;
        private frmTeachCourse teachCourse;
        private frmTeachRegisMark teachRegisMark;
        private frmTeachSelCourses teachSelCourses;
        private frmTeachStudInfor teachStudInfor;
       
        public frmTeacher(string teachNo)
        {
            InitializeComponent();
            teachno = teachNo;
            teachPersInfor = new frmTeachPersInfor(teachno);
            teachCourse = new frmTeachCourse(teachno);
            teachStudInfor = new frmTeachStudInfor(teachno);
            teachSelCourses = new frmTeachSelCourses(teachno);
            teachRegisMark = new frmTeachRegisMark(teachno);
            setToolStatus();
        }

        private void 个人资料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teachPersInfor.Show();
            panel.Controls.Clear();
            panel.Controls.Add(teachPersInfor);
        }

        private void 担任课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teachCourse.Show();
            panel.Controls.Clear();
            panel.Controls.Add(teachCourse);
        }

        private void 学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teachStudInfor.Show();
            panel.Controls.Clear();
            panel.Controls.Add(teachStudInfor);
        }

        private void 选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teachSelCourses.Show();
            panel.Controls.Clear();
            panel.Controls.Add(teachSelCourses);
        }

        private void 登记成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teachRegisMark.Show();
            panel.Controls.Clear();
            panel.Controls.Add(teachRegisMark);
        }

        //初始化状态栏方法
        private void setToolStatus()
        {
            string sqlStr = "SELECT * FROM tbTeach WHERE teachno='" + teachno + "'";
            SqlDataReader dr = new SqlOperate().GetRowData(sqlStr);
            while (dr.Read())
            {
                DateTime dt = DateTime.Now;
                toolStatusTeachno.Text = "工号：" + dr["teachno"].ToString();
                toolStatusTeachname.Text = "姓名：" + dr["teachname"].ToString();
                toolStatusTime.Text = "登陆时间：" + dt.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
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
            frmPasswordSet pswset = new frmPasswordSet(teachno);
            pswset.ShowDialog();
        }

        private void FrmTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出程序吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
