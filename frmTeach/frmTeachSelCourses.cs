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

namespace EduAdminSys.frmTeach
{
    public partial class frmTeachSelCourses : UserControl
    {
        private string teachNo = "", departNo = "";
        string sqlStr = "", sqltb = "";
        DataTable dt = null;
        public frmTeachSelCourses(string teachNo)
        {
            InitializeComponent();
            this.teachNo = teachNo;
            departNo = getDepartNo();
            Recovery();
            initiComboxClass();
            initiTxtboxCoutClass();
            listBox.Items.Add("班级名称             课时");
        }

        //恢复信息表按钮事件方法
        private void ButRecovery_Click(object sender, EventArgs e)
        {
            Recovery();
        }

        //查找按钮事件方法
        private void ButCheck_Click(object sender, EventArgs e)
        {
            Recovery();
            string classname;
            if (txtboxCheck.Text == "")
            {
                MessageBox.Show("请输入查找的信息", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            classname = " AND classname LIKE '%" + txtboxCheck.Text + "%'";
            new SqlOperate().BindDataGridView(dgvSeleClass, sqlStr + classname);
        }


        //恢复信息表的方法
        private void Recovery()
        {
            sqlStr = "SELECT classno,classname,couhour,coutype FROM " +
                "tbClass,tbCourse WHERE tbClass.courseno=tbCourse.courseno AND tbClass.teachno IS NULL AND states=3 AND tbClass.departno='" + departNo + "'";
            new SqlOperate().BindDataGridView(dgvSeleClass, sqlStr);
        }

        //确认按钮事件方法
        private void ButJoin_Click(object sender, EventArgs e)
        {
            string classno;
            if (comboxClass.SelectedValue == null)
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

        //DataGridView中选择按钮事件方法
        private void DgvSeleCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认选择这门课吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            if (dgvSeleClass.Columns[e.ColumnIndex].Name == "join")
            {
                if (dgvSeleClass.CurrentRow == null)
                {
                    MessageBox.Show("发生未知错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string classno = dgvSeleClass.CurrentRow.Cells["classno"].Value.ToString();
                if (!joinCourse(classno)) return;
                setListBox_DGV();
            }
        }

        //初始化班级名称下拉选项框方法
        private void initiComboxClass()
        {
            sqltb = "SELECT classno,classname FROM tbClass,tbCourse WHERE "+
                "tbClass.courseno=tbCourse.courseno AND tbClass.teachno IS NULL AND states=3 AND tbClass.departno='" + departNo + "'";
            dt = new SqlOperate().BindDataTable(sqltb, "CCN");
            comboxClass.DataSource = dt;
            comboxClass.DisplayMember = "classname";
            comboxClass.ValueMember = "classno";
        }

        //将选课信息写入数据库方法
        private bool joinCourse(string classno)
        {
            //检查该班级是否有教师选择
            sqltb = "SELECT classno FROM tbClass WHERE teachno IS NULL AND classno='" + classno + "'";
            SqlDataReader dr = new SqlOperate().GetRowData(sqltb);
            if (!dr.Read()) {
                MessageBox.Show("该课程已被选择", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //执行提交操作
            if (submit(classno))
            {
                MessageBox.Show("选课成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                initiTxtboxCoutClass();
                initiComboxClass();
                return true;
            }
            else
            {
                MessageBox.Show("选课失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        //提交选课信息方法
        private bool submit(string classno)
        {
            sqltb = "UPDATE tbClass SET teachno='" + teachNo + "' WHERE classno='" + classno + "'";
            int i;
            try
            {
                i = new SqlOperate().selectNum(sqltb);
                if (i == 1)
                {
                    return true;
                }
            }
            catch (Exception E)
            {
                return false;
            }
            return false;
        }

        //设置已选课程数方法
        private void initiTxtboxCoutClass()
        {
            int i;
            sqltb = "SELECT COUNT(*) FROM tbClass WHERE teachno='" + teachNo + "'";
            try
            {
                i = new SqlOperate().HumanNum(sqltb);
                txtboxCoutClass.Text = i.ToString();
            }
            catch (Exception EXC)
            {
                txtboxCoutClass.Text = "无法显示";
            }
        }

        //设置ListBox方法
        private void setListBox_DGV()
        {
            if (dgvSeleClass.CurrentRow != null)
            {
                string classname = dgvSeleClass.CurrentRow.Cells["classname"].Value.ToString();
                string couhour = dgvSeleClass.CurrentRow.Cells["couhour"].Value.ToString();
                listBox.Items.Add(classname + "       " + couhour);
            }
        }

        //设置ListBox方法
        private void setListBox_BUT(string classno)
        {
            sqltb = "SELECT classname,couhour FROM tbClass,tbCourse WHERE tbCourse.courseno=tbClass.courseno AND classno='" + classno + "'";
            SqlDataReader dr = new SqlOperate().GetRowData(sqltb);
            while (dr.Read())
            {
                listBox.Items.Add(dr["classname"].ToString() + "      " + dr["couhour"].ToString());
            }
        }


        //获取教师所在院校
        private string getDepartNo()
        {
            sqltb = "SELECT departno FROM tbTeach WHERE teachno='" + teachNo + "'";
            SqlDataReader dr = new SqlOperate().GetRowData(sqltb);
            while (dr.Read()) { return dr["departno"].ToString(); }
            return "";
        }
    }
}
