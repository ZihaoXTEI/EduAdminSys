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
    public partial class frmTeachRegisMark : UserControl
    {
        private String sqlStr, teachno, stuNo, className;
        private DataTable dt;
        public frmTeachRegisMark(string teachno)
        {
            InitializeComponent();
            this.teachno = teachno;
            Recovery();
            initiComboxClass();
        }

        //初始化班级名称下列选项框
        private void initiComboxClass()
        {
            string sqlstr = "SELECT DISTINCT classname FROM Stud_DetailedInfor_View WHERE teachno='" + teachno + "'";
            dt = new SqlOperate().BindDataTable(sqlstr, "SD");
            comboxClass.DataSource = dt;
            comboxClass.DisplayMember = "classname";
            comboxClass.ValueMember = "classname";
        }

        //筛选按钮事件方法
        private void ButScreen_Click(object sender, EventArgs e)
        {
            //Recovery();
            string strClass;
            if(comboxClass.SelectedValue != null)
            {
                strClass = " AND classname='" + comboxClass.SelectedValue.ToString() + "'";
            }
            else
            {
                MessageBox.Show("请选择相应的值", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //MessageBox.Show(sqlStr + strClass, "调试", MessageBoxButtons.OK);
            new SqlOperate().BindDataGridView(dgvRegisMark, sqlStr + strClass);
        }

        //查找按钮事件方法
        private void ButCheck_Click(object sender, EventArgs e)
        {
            //Recovery();
            string strStuNo;
            if(txtboxCheck.Text == "")
            {
                MessageBox.Show("请输入相应的值", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            strStuNo = " AND stuno LIKE '%" + txtboxCheck.Text + "%'";
            new SqlOperate().BindDataGridView(dgvRegisMark, sqlStr + strStuNo);

        }

        private void ButRecovery_Click(object sender, EventArgs e)
        {
            Recovery();
        }

        //录入按钮事件方法
        private void ButRegister_Click(object sender, EventArgs e)
        {
            string insertStr, bukao;
            double i;
            if(txtboxId.Text=="" || txtboxMark.Text == "")
            {
                MessageBox.Show("请选择相应的学生或输入成绩", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                i = Double.Parse(txtboxMark.Text);
                if(i>100 || i < 0)
                {
                    MessageBox.Show("请输入合法的成绩信息，分数在0~100分之间", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }catch(Exception exc)
            {
                MessageBox.Show("请输入合法的成绩信息", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtboxBukao.Text == "") bukao = "-1";
            else {
                bukao = txtboxBukao.Text;
                try
                {
                    i = Double.Parse(bukao);
                    if (i <0 || i > 100)
                    {
                        MessageBox.Show("请输入合法的成绩信息，分数在0~100分之间", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch(Exception exce)
                {
                    MessageBox.Show("请输入合法的成绩信息", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            insertStr = "SELECT * FROM tbClass WHERE classname='" + className + "'";
            SqlDataReader dr = new SqlOperate().GetRowData(insertStr);
            while (dr.Read())
            {
                className = dr[0].ToString();
            }
            dr.Close();
            insertStr = "UPDATE tbMark SET mark=" + txtboxMark.Text + ",bukao=" + bukao + " WHERE stuno='" + stuNo + "' AND classno='" + className + "'";
            //MessageBox.Show(insertStr, "调试", MessageBoxButtons.OK);
            if(new SqlOperate().selectNum(insertStr) == 0)
            {
                labTip.Text = "录入失败！";
            }
            else
                labTip.Text = "录入成功！";
        }

        private void DgvRegisMark_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string str, sex;
            //获得当前选中的行 
            int rowindex = e.RowIndex;
            try
            {
                //获得当前行的第0列的值 
                txtboxId.Text = dgvRegisMark.Rows[rowindex].Cells[0].Value.ToString();
                stuNo = txtboxId.Text;
                //获得当前行的第1列的值 
                txtboxName.Text = dgvRegisMark.Rows[rowindex].Cells[1].Value.ToString();
                //获得当前行的第3列的值 
                txtboxClassName.Text = dgvRegisMark.Rows[rowindex].Cells[2].Value.ToString();
                className = txtboxClassName.Text;
                str = "SELECT sex FROM tbStudent WHERE stuno='" + stuNo + "'";
                SqlDataReader dr = new SqlOperate().GetRowData(str);
                while (dr.Read())
                {
                    sex = dr[0].ToString();
                    if (sex == "M") sex = "男";
                    else sex = "女";
                    txtboxSex.Text = sex;
                }
                dr.Close();
            }
            catch (Exception ex) { }


        }

        private void Recovery()
        {
            sqlStr = "SELECT stuno,stuname,classname,mark,bukao FROM Stud_DetailedInfor_View WHERE teachno='" + teachno + "'";
            new SqlOperate().BindDataGridView(dgvRegisMark, sqlStr);
        }
    }


}
