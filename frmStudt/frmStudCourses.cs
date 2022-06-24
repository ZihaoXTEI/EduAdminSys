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

namespace EduAdminSys.frmStudt
{
    public partial class frmStudCourses : UserControl
    {
        private static string stuNo = "";
        string sqlStr = "", sqltb = "";
        DataTable dt = null;
        public frmStudCourses(string stuno)
        {
            InitializeComponent();
            stuNo = stuno;
            Recovery();
        }

        private void Recovery()
        {
            sqlStr = "SELECT courseno,coursename,classname,coutype,couhour,credit,departname,teachname FROM STCCD WHERE stuno='" + stuNo + "'";
            new SqlOperate().BindDataGridView(dgvCourse, sqlStr);
        }

        private void RadbutCouType_CheckedChanged(object sender, EventArgs e)
        {
            if (comboxScreen.Items.Count > 0)
            {
                comboxScreen.DataSource = null;
                comboxScreen.Items.Clear();
            }
            sqlStr = "SELECT DISTINCT coutype FROM tbCourse";
            dt = new SqlOperate().BindDataTable(sqlStr, "COUTYPE");
            comboxScreen.DataSource = dt;
            comboxScreen.DisplayMember = "coutype";
            comboxScreen.ValueMember = "coutype";
        }

        private void RadbutCouHour_CheckedChanged(object sender, EventArgs e)
        {
            if (comboxScreen.Items.Count > 0)
            {
                comboxScreen.DataSource = null;
                comboxScreen.Items.Clear();
            }
            string[] CREDIT = { "30~39课时", "40~49课时", "50~60课时" };
            comboxScreen.Items.AddRange(CREDIT);
            comboxScreen.SelectedIndex = 0;
        }

        private void RadbutCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (comboxScreen.Items.Count > 0)
            {
                comboxScreen.DataSource = null;
                comboxScreen.Items.Clear();
            }
            sqlStr = "SELECT DISTINCT credit FROM tbCourse";
            dt = new SqlOperate().BindDataTable(sqlStr, "CRDEIT");
            comboxScreen.DataSource = dt;
            comboxScreen.DisplayMember = "credit";
            comboxScreen.ValueMember = "credit";
        }

        private void ButEnterS_Click(object sender, EventArgs e)
        {
            Recovery();
            if(radbutCouType.Checked==true && comboxScreen.SelectedValue != null)
            {
                sqltb = " AND coutype='" + comboxScreen.SelectedValue.ToString() + "'";
            }
            else if(radbutCredit.Checked==true && comboxScreen.SelectedValue != null)
            {
                sqltb = " AND credit=" + comboxScreen.SelectedValue.ToString();
            }
            else if(radbutCouHour.Checked==true && comboxScreen.SelectedItem != null)
            {
                sqltb = comboxScreen.SelectedItem.ToString();
                if (sqltb == "30~39课时") sqltb = " AND couhour<40";
                else if (sqltb == "40~49课时") sqltb = "AND couhour BETWEEN 40 AND 49";
                else sqltb = " AND couhour >49";
            }
            else
            {
                MessageBox.Show("请勾选相应的选项", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sqlStr = sqlStr + sqltb;
            new SqlOperate().BindDataGridView(dgvCourse, sqlStr);
        }

        private void ButEnterC_Click(object sender, EventArgs e)
        {
            Recovery();
            if (radbutCouName.Checked==true && txtboxCheck.Text != "")
            {
                sqltb = " AND coursename LIKE '%" + txtboxCheck.Text + "%'";
            }
            else if(radbutTeachName.Checked==true && txtboxCheck.Text != "")
            {
                sqltb = " AND teachname LIKE '%" + txtboxCheck.Text + "%'";
            }
            else
            {
                MessageBox.Show("请选择相应的选项或输入值", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sqlStr = sqlStr + sqltb;
            new SqlOperate().BindDataGridView(dgvCourse, sqlStr);
        }
    }
}
