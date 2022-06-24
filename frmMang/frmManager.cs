using EduAdminSys.frmMang.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduAdminSys.connDB;


namespace EduAdminSys.frmMang
{
    public partial class frmManager : Form
    {
        static private string userid;
        public string username;
        public frmInforQuery inforQuery;
        public frmInforQueryTeach inforQueryTeach;
        public frmInforQueryStud inforQueryStud;
        public frmInforQueryMark inforQueryMark;
        public frmInforQueryClass inforQueryClass;
        public frmInforQueryCourse inforQueryCourse;
        public frmStatiStud statiStud;
        public frmStatiTeach statiTeach;
        public frmStatiMark statiMark;
        public frmInforQuerySelCou inforQuerySelCou;
        public frmMangClass mangClass;
        public frmMangSelCou mangSelCou;
        public frmMangTable mangTable;
        string menuItemText;
        public frmManager(string userId)
        {
            InitializeComponent();
            userid = userId;
            DateTime dt = DateTime.Now;
            toolStatusTime.Text = "         登陆时间：" + dt.ToString("yyyy-MM-dd HH:mm:ss");
        }

        static public string getUserId()
        {
            return userid;
        }

        private void 院系信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemText = 院系信息ToolStripMenuItem.Text;
            inforQuery = new frmInforQuery("tbDepart");
            inforQuery.Show();
            //inforQuery.sqltb = "tbDepart";
            panel.Controls.Clear();
            panel.Controls.Add(inforQuery);
        }

        private void 教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inforQueryTeach = new frmInforQueryTeach("tbTeach");
            inforQueryTeach.Show();        
            panel.Controls.Clear();
            panel.Controls.Add(inforQueryTeach);
        }

        private void 学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inforQueryStud = new frmInforQueryStud("tbStudent");
            inforQueryStud.Show();
            panel.Controls.Clear();
            panel.Controls.Add(inforQueryStud);
        }

        private void 课程信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inforQueryCourse = new frmInforQueryCourse("tbCourse");
            inforQueryCourse.Show();
            panel.Controls.Clear();
            panel.Controls.Add(inforQueryCourse);
        }

        private void 成绩信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inforQueryMark = new frmInforQueryMark("tbMark");
            inforQueryMark.Show();
            panel.Controls.Clear();
            panel.Controls.Add(inforQueryMark);
        }

        private void 任课信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inforQueryClass = new frmInforQueryClass("tbClass");
            inforQueryClass.Show();
            panel.Controls.Clear();
            panel.Controls.Add(inforQueryClass);
        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出登陆吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                //this.Dispose();
                Application.Exit();
            }
        }

        private void 学生信息统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statiStud = new frmStatiStud();
            statiStud.Show();
            panel.Controls.Clear();
            panel.Controls.Add(statiStud);
        }

        private void 分数查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statiTeach = new frmStatiTeach();
            statiTeach.Show();
            panel.Controls.Clear();
            panel.Controls.Add(statiTeach);
        }

        private void 成绩信息统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statiMark = new frmStatiMark();
            statiMark.Show();
            panel.Controls.Clear();
            panel.Controls.Add(statiMark);
        }

        private void 选课信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            inforQuerySelCou = new frmInforQuerySelCou("tbSelect");
            inforQuerySelCou.Show();
            panel.Controls.Clear();
            panel.Controls.Add(inforQuerySelCou);

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout fa = new frmAbout();
            fa.ShowDialog();
        }

        private void 修改管理员密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPasswordSet pswset = new frmPasswordSet(userid);
            pswset.ShowDialog();
        }

        private void 任课管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mangClass = new frmMangClass();
            mangClass.Show();
            panel.Controls.Clear();
            panel.Controls.Add(mangClass);
        }

        private void 选课管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mangSelCou = new frmMangSelCou();
            mangSelCou.Show();
            panel.Controls.Clear();
            panel.Controls.Add(mangSelCou);
        }

        private void 信息增删改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mangTable = new frmMangTable();
            mangTable.ShowDialog();
        }

        private void FrmManager_FormClosing(object sender, FormClosingEventArgs e)
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

        private void 设置开课状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "DELETE FROM tbSelect";
                new SqlOperate().selectNum(sqlStr);

                sqlStr = "UPDATE tbClass SET stunum=0,teachno=NULL";
                new SqlOperate().selectNum(sqlStr);
            }catch(Exception ee)
            {
                MessageBox.Show("出现错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("设置选课状态成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }
    }
}
