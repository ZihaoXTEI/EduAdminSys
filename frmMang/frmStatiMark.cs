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

namespace EduAdminSys.frmMang
{
    public partial class frmStatiMark : UserControl
    {
        private string rangeStr = "";
        private string sexStr = null;
        private string sqlStr = "";
        private string markType = "mark";
        DataTable dt = null;
        public frmStatiMark()
        {
            InitializeComponent();

            initialiComboxSex();
        }


        private void initialiComboxSex()
        {
            string[] SEX = { "男", "女" };
            comboxSex.Items.AddRange(SEX);
            comboxSex.SelectedIndex = 0;
        }

        private void RadbutSchool_CheckedChanged(object sender, EventArgs e)
        {
            comboxRange.Enabled = false;
            rangeStr = "";
        }

        private void RadbutDepart_CheckedChanged(object sender, EventArgs e)
        {
            comboxRange.Enabled = true;
            if (comboxRange.Items.Count > 0)
            {
                comboxRange.DataSource = null;
                comboxRange.Items.Clear();
            }
            sqlStr = "SELECT * FROM tbDepart";
            dt = new SqlOperate().BindDataTable(sqlStr, "DPNAME");
            comboxRange.DataSource = dt;
            comboxRange.DisplayMember = "departname";
            comboxRange.ValueMember = "departno";
        }

        private void RadbutCourse_CheckedChanged(object sender, EventArgs e)
        {
            comboxRange.Enabled = true;
            if (comboxRange.Items.Count > 0)
            {
                comboxRange.DataSource = null;
                comboxRange.Items.Clear();
            }
            sqlStr = "SELECT * FROM tbCourse";
            dt = new SqlOperate().BindDataTable(sqlStr, "COUNAME");
            comboxRange.DataSource = dt;
            comboxRange.DisplayMember = "coursename";
            comboxRange.ValueMember = "courseno";
        }

        private void RadbutClass_CheckedChanged(object sender, EventArgs e)
        {
            comboxRange.Enabled = true;
            if (comboxRange.Items.Count > 0)
            {
                comboxRange.DataSource = null;
                comboxRange.Items.Clear();
            }
            sqlStr = "SELECT * FROM tbClass";
            dt = new SqlOperate().BindDataTable(sqlStr, "CLASSNAME");
            comboxRange.DataSource = dt;
            comboxRange.DisplayMember = "classname";
            comboxRange.ValueMember = "classno";
        }

        private void ButExcellent_Click(object sender, EventArgs e)
        {
            createRangeStrAndSexStr();
            string markRange = ">=90";
            createSqlStr(markRange, markType);

            //MessageBox.Show(sqlStr, "调试", MessageBoxButtons.OK);
            txtboxReuslt.Text = (new SqlOperate().HumanNum(sqlStr)).ToString();

        }

        private void ButGood_Click(object sender, EventArgs e)
        {
            createRangeStrAndSexStr();
            string markRange = " BETWEEN 80 AND 89";
            createSqlStr(markRange, markType);

            //MessageBox.Show(sqlStr, "调试", MessageBoxButtons.OK);
            txtboxReuslt.Text = (new SqlOperate().HumanNum(sqlStr)).ToString();
        }

        private void ButPass_Click(object sender, EventArgs e)
        {
            createRangeStrAndSexStr();
            string markRange = " BETWEEN 60 AND 79";
            createSqlStr(markRange, markType);

            //MessageBox.Show(sqlStr, "调试", MessageBoxButtons.OK);
            txtboxReuslt.Text = (new SqlOperate().HumanNum(sqlStr)).ToString();
        }

        private void ButFail_Click(object sender, EventArgs e)
        {
            createRangeStrAndSexStr();
            string markRange = " BETWEEN 0 AND 59";
            createSqlStr(markRange, markType);

            //MessageBox.Show(sqlStr, "调试", MessageBoxButtons.OK);
            txtboxReuslt.Text = (new SqlOperate().HumanNum(sqlStr)).ToString();
        }
        private void ButEnter_Click(object sender, EventArgs e)
        {
            if(txtboxMax.Text==null || txtboxMin.Text == null)
            {
                MessageBox.Show("请输入数字", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!isNumber()) {
                MessageBox.Show("请输入数字", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string minNum = txtboxMin.Text;
            string maxNum = txtboxMax.Text;
            createRangeStrAndSexStr();
            string markRange = " BETWEEN " + minNum + " AND " + maxNum;
            createSqlStr(markRange, markType);

            MessageBox.Show(sqlStr, "调试", MessageBoxButtons.OK);
            txtboxReuslt.Text = (new SqlOperate().HumanNum(sqlStr)).ToString();
        }


        public void createRangeStrAndSexStr()
        {
            if(radbutDepart.Checked==true && comboxRange.SelectedValue != null)
            {
                rangeStr = " AND depart='" + comboxRange.SelectedValue.ToString() + "'";
            }
            else if(radbutCourse.Checked==true && comboxRange.SelectedValue != null)
            {
                /*SqlDataReader dr = new SqlOperate().GetRowData("SELECT courseno FROM tbCourse WHERE coursename='" +
                    comboxRange.SelectedValue.ToString() + "'");
                if (dr.Read())
                {
                    rangeStr = " courseno='" + dr[0].ToString() + "'";
                }
                dr.Close();*/
                rangeStr = " AND classno IN(SELECT tbClass.classno FROM tbClass WHERE courseno='" +
                    comboxRange.SelectedValue.ToString() + "')";
            }
            else if(radbutClass.Checked==true && comboxRange.SelectedValue != null)
            {
                rangeStr = " AND classno='" + comboxRange.SelectedValue.ToString() + "'";
            }

            if(chkboxSex.Checked==true && comboxSex.SelectedItem != null)
            {
                string sex = comboxSex.SelectedItem.ToString();
                if (sex == "男") sex = "M";
                else sex = "F";
                sexStr = " AND stuno IN(SELECT tbStudent.stuno FROM tbStudent WHERE sex='" + sex + "')";
            }

            if (chkboxBukao.Checked == true)
            {
                markType = "bukao";
            }
            else
                markType = "mark";
        }

        public void createSqlStr(string markRange,string marktype)
        {
            sqlStr = "SELECT COUNT(*) FROM tbMark WHERE "+ marktype + markRange;

            if (chkboxSex.Checked == false && rangeStr.Equals(""))
            {
            }
            else if (sexStr != null && rangeStr.Equals(""))
            {
                sqlStr = sqlStr + sexStr;
            }
            else if (sexStr != null && !rangeStr.Equals(""))
            {
                sqlStr = sqlStr + sexStr + rangeStr;
            }
            else
            {
                sqlStr = sqlStr + rangeStr;
            }
            
        }


        //判断输入是否为整形数字
        public bool isNumber()
        {
            try
            {
                int min = int.Parse(txtboxMin.Text);
                int max = int.Parse(txtboxMax.Text);
            }
            catch (FormatException e)
            {
                return false;
            }
            return true;
        }

    }
}
