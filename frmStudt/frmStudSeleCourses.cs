using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduAdminSys.connDB;
using System.Data.SqlClient;

namespace EduAdminSys.frmStudt
{
    public partial class frmStudSeleCourses : UserControl
    {
        private string stuNo = "";
        string sqlStr = "", sqltb = "";
        DataTable dt = null;
        public frmStudSeleCourses(string stuNo)
        {
            InitializeComponent();
            this.stuNo = stuNo;
            Recovery();
            initiComboxClass();
            initiLabCredit();
            listBox.Items.Add("班级名称         学分");
        }


        //恢复信息表的方法
        private void Recovery()
        {
            sqlStr = "SELECT classno,classname,credit,couhour,coutype,teachname,stunum,departname FROM " +
                "Class_DetailedInfor_View WHERE stunum<=60 AND states=3";
            new SqlOperate().BindDataGridView(dgvSeleCourse, sqlStr);
        }

        private void ButCheck_Click(object sender, EventArgs e)
        {
            Recovery();
            string classname;
            if (txtboxClassName.Text == "")
            {
                MessageBox.Show("请输入查找的信息", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            classname = " AND classname LIKE '%" + txtboxClassName.Text + "%'";
            new SqlOperate().BindDataGridView(dgvSeleCourse, sqlStr + classname);
        }

        //检查选择的课程是否已经存在
        private bool isExist(string classno)
        {
            sqltb = "SELECT * FROM tbSelect WHERE classno='" + classno + "' AND stuno='" + stuNo + "'";
            SqlDataReader dr = new SqlOperate().GetRowData(sqltb);
            while (dr.Read()) { return true; }

            sqltb = "SELECT * FROM tbSelect WHERE classno IN(SELECT classno FROM tbClass WHERE courseno IN(" +
                "SELECT courseno FROM Class_DetailedInfor_View WHERE classno='" + classno + "'))";
            dr = new SqlOperate().GetRowData(sqltb);
            while (dr.Read()) { return true; }
            return false;
        }

        private void ButtEnter_Click(object sender, EventArgs e)
        {
            string classno;
            if(comboxClass.SelectedValue == null)
            {
                MessageBox.Show("请选择班级", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("确认选择这门课吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            classno = comboxClass.SelectedValue.ToString();
            if (!joinCourse(classno)) return;
            setListBox_BUT(classno);


        }

        private void DgvSeleCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvSeleCourse.Columns[e.ColumnIndex].Name == "Join")
            {
                DialogResult result = MessageBox.Show("确认选择这门课吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;

                if (dgvSeleCourse.CurrentRow == null)
                {
                    MessageBox.Show("发生未知错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string classno = dgvSeleCourse.CurrentRow.Cells["classno"].Value.ToString();
                if (!joinCourse(classno)) return;
                setListBox_DGV();
            }
        }


        //加入按钮方法
        private bool joinCourse(string classno)
        {
            //检查是否已经选择相同课程的班级
            if (isExist(classno))
            {
                MessageBox.Show("你已经选择了与此班级相同课程内容的其他班级，请选择其他课程的班级", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //检查人数是否符合要求
            if (isNumber(classno))
            {
                MessageBox.Show("当前这门课已经有60人选择，请选择其他课程的班级", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //检查学分是否超过200
            if (isCredit(classno))
            {
                MessageBox.Show("你选修的学分已经超过200分，不能再选修其他课程或你选择的此门课程的学分" +
                    "与已选修的课程学分相加超过200分，请重新选择", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //执行提交操作
            if (submit(classno))
            {
                MessageBox.Show("选课成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                initiLabCredit();
                return true;
            }
            else
            {
                MessageBox.Show("选课失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //提交选课信息方法
        private bool submit(string classno)
        {
            string selectno = new CreateNo().getSelectNo();  //获取随机数
            int i;
            sqltb = "INSERT INTO tbSelect VALUES('" + selectno + "','" + stuNo + "','" + classno + "',1)";
            //Console.WriteLine(sqltb);
            try
            {
                i=new SqlOperate().selectNum(sqltb);
               //Console.WriteLine(i);
                if (i == 1)
                {
                    sqltb = "UPDATE tbClass SET stunum=stunum+1 WHERE classno='"+classno+"'";
                   // Console.WriteLine(sqltb);
                    i = new SqlOperate().selectNum(sqltb);
                   // Console.WriteLine("3");
                    if (i == 1)
                    {
                        Console.WriteLine("_____");
                        return true;
                    }
                }
            }catch(Exception E)
            {
                return false;
            }
            return false;
        }

        //检查人数是否符合要求
        private bool isNumber(string classno)
        {
            int i;
            sqltb = "SELECT COUNT(*) FROM tbSelect WHERE classno='" + classno + "'";
            try
            {
                i = new SqlOperate().selectNum(sqltb);
                if (i <50)
                {
                    return false;
                }
            }
            catch (Exception E)
            {
                return true;
            }
            return true;
        }

        //检查学分是否超过200
        private bool isCredit(string classno)
        {
            int m, n;
            sqltb = "SELECT SUM(credit) FROM tbClass,tbCourse WHERE tbClass.courseno=tbCourse.courseno AND tbClass.classno IN(" +
            "SELECT classno FROM tbSelect WHERE stuno='" + stuNo + "')";
            try
            {
                m = new SqlOperate().HumanNum(sqltb);
                if (m >= 120)
                {
                    return true;
                }
                sqlStr = "SELECT SUM(credit) FROM Class_DetailedInfor_View WHERE classno='" + classno + "'";
                n = new SqlOperate().HumanNum(sqltb);
                if (n + m >= 120)
                {
                    return true;
                }

            }
            catch(Exception E)
            {
                return true;
            }
            return false;
        }

        private void initiComboxClass()
        {
            sqltb = "SELECT classno,classname FROM Class_DetailedInfor_View";
            dt = new SqlOperate().BindDataTable(sqltb, "CDV");
            comboxClass.DataSource = dt;
            comboxClass.DisplayMember = "classname";
            comboxClass.ValueMember = "classno";
        }

        private void ButRecovery_Click(object sender, EventArgs e)
        {
            Recovery();
        }

        private void initiLabCredit()
        {
            int i;
            sqltb = "SELECT SUM(credit) FROM Class_DetailedInfor_View WHERE Class_DetailedInfor_View.classno IN(" +
                "SELECT classno FROM tbSelect WHERE stuno='" + stuNo + "')";
            try
            {
                i = new SqlOperate().HumanNum(sqltb);
                txtboxCredit.Text = i.ToString();
            }
            catch (Exception EXC)
            {
                txtboxCredit.Text = "无法显示";
            }
        }


        private void setListBox_DGV()
        {
            if(dgvSeleCourse.CurrentRow != null)
            {
                string classname = dgvSeleCourse.CurrentRow.Cells["classname"].Value.ToString();
                string credit = dgvSeleCourse.CurrentRow.Cells["credit"].Value.ToString();
                listBox.Items.Add(classname + "       " + credit);
            }
        }

        private void setListBox_BUT(string classno)
        {
            sqltb = "SELECT classname,credit FROM Class_DetailedInfor_View WHERE classno='" + classno + "'";
            SqlDataReader dr = new SqlOperate().GetRowData(sqltb);
            while (dr.Read()) {
                listBox.Items.Add(dr["classname"].ToString()+"      "+ dr["credit"].ToString());
            }
        }


    }
}
