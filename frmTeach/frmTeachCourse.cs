using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EduAdminSys.connDB;

namespace EduAdminSys.frmTeach
{
    public partial class frmTeachCourse : UserControl
    {
        private String sqlStr, teachno;
        public frmTeachCourse(string teachno)
        {
            InitializeComponent();
            this.teachno = teachno;
            initiComboxSort();
            Recovery();
        }

        //查找按钮事件方法
        private void ButCheck_Click(object sender, EventArgs e)
        {
            Recovery();
            if (txtboxCheck.Text != "")
            {
                string classname = txtboxCheck.Text;
                sqlStr = sqlStr + " AND classname LIKE '%" + classname + "%'";
                new SqlOperate().BindDataGridView(dgvcourse, sqlStr);
            }
            else
            {
                MessageBox.Show("请输入值", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        //排序按钮事件方法
        private void ButSort_Click(object sender, EventArgs e)
        {
            Recovery();
            string sort = comboxSort.SelectedItem.ToString();
            if (sort == "升序") sort = "ASC";
            else sort = "DESC";
            if(radbutCouHour.Checked==true)
            {
                sqlStr = sqlStr + " ORDER BY couhour " + sort;
            }
            else if (radbutStunum.Checked == true)
            {
                sqlStr = sqlStr + " ORDER BY stunum " + sort;
            }
            else
            {
                MessageBox.Show("请选择相应的选项", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            new SqlOperate().BindDataGridView(dgvcourse, sqlStr);
        }

        //恢复信息表按钮事件方法
        private void ButRecovery_Click(object sender, EventArgs e)
        {
            Recovery();
        }

        //恢复信息表方法
        private void Recovery()
        {
            sqlStr = "SELECT classno,classname,stunum,couhour,coutype FROM Class_DetailedInfor_View WHERE teachno='" + teachno + "'";
            new SqlOperate().BindDataGridView(dgvcourse, sqlStr);
        }

        //初始化排序下拉选项框
        private void initiComboxSort()
        {
            string[] SORT= { "升序", "降序" };
            comboxSort.Items.AddRange(SORT);
            comboxSort.SelectedIndex = 0;
        }
    }
}
