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

namespace EduAdminSys.frmMang
{
    public partial class frmStatiTeach : UserControl
    {
        public string rangeStr = "";
        private string sqlStr = "";
        DataTable dt = null;
        public frmStatiTeach()
        {
            InitializeComponent();

            //初始化GroupBox3和中GroupBox4的comboBox控件
            initialiComboxAge();
            initialiComboxSex();
            initialiComboxSalary();
        }


        /***初始化comboBox控件***/
        private void initialiComboxSex()
        {
            string[] SEX = { "男", "女" };
            comboxSex.Items.AddRange(SEX);
            comboxSex.SelectedIndex = 0;
        }

        private void initialiComboxAge()
        {
            sqlStr = "SELECT DISTINCT age FROM tbTeach";
            dt = new SqlOperate().BindDataTable(sqlStr, "TEACHAGE");
            comboxAge.DataSource = dt;
            comboxAge.DisplayMember = "age";
            comboxAge.ValueMember = "age";
        }


        private void initialiComboxSalary()
        {
            sqlStr = "SELECT DISTINCT salary FROM tbTeach";
            dt = new SqlOperate().BindDataTable(sqlStr, "SALARY");
            comboxSalary.DataSource = dt;
            comboxSalary.DisplayMember = "salary";
            comboxSalary.ValueMember = "salary";
        }
        /******/

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
            sqlStr = "SELECT DISTINCT tbTeach.departno,tbDepart.departname FROM " +
                "tbTeach,tbDepart WHERE tbTeach.departno=tbDepart.departno";
            dt = new SqlOperate().BindDataTable(sqlStr, "TD");
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
            sqlStr = "SELECT coursename FROM tbCourse";
            dt = new SqlOperate().BindDataTable(sqlStr, "COUNAME");
            comboxRange.DataSource = dt;
            comboxRange.DisplayMember = "coursename";
            comboxRange.ValueMember = "coursename";
        }

        private void ButNumStati_Click(object sender, EventArgs e)
        {

            string charaStr = null;
            if (radbutDepart.Checked==true && comboxRange.SelectedValue != null)
            {
                rangeStr = " departno='" + comboxRange.SelectedValue.ToString() + "'";
            }
            else if(radbutCourse.Checked==true && comboxRange.SelectedValue != null)
            {
                rangeStr = "tbTeach.teachno IN(SELECT tbClass.teachno FROM tbClass,tbCourse WHERE "
                    +"tbClass.courseno=tbCourse.courseno AND tbCourse.coursename='"+comboxRange.SelectedValue.ToString()+"')";
            }


            string sex = comboxSex.SelectedItem.ToString();
            if (sex == "男") sex = "M";
            else sex = "F";
            if(chkboxSex.Checked==true && comboxSex.SelectedItem != null)
            {
                if(chkboxAge.Checked==true && comboxAge.SelectedValue != null)
                {
                    charaStr = " sex='" + sex + "'AND age='" + comboxAge.SelectedValue.ToString() + "'";
                }
                else
                {
                    charaStr = " sex='" + sex + "'";
                }
            }
            else if (chkboxAge.Checked == true && comboxAge.SelectedValue != null)
            {
                charaStr = " age='" + comboxAge.SelectedValue.ToString() + "'";
            }


            if (chkboxAge.Checked == false && chkboxSex.Checked == false  && rangeStr.Equals(""))
            {
                sqlStr = "SELECT COUNT(*) FROM tbTeach";
            }
            else if (charaStr != null && rangeStr.Equals(""))
            {
                sqlStr = "SELECT COUNT(*) FROM tbTeach WHERE " + charaStr;
            }
            else if (charaStr != null && !rangeStr.Equals(""))
            {
                sqlStr = "SELECT COUNT(*) FROM tbTeach WHERE " + charaStr + " AND " + rangeStr;
            }
            else
            {
                sqlStr = "SELECT COUNT(*) FROM tbTeach WHERE " + rangeStr;
            }

            //MessageBox.Show(sqlStr, "调试", MessageBoxButtons.OK);
            txtboxNum.Text = (new SqlOperate().HumanNum(sqlStr)).ToString();

        }

        private void ButSalary_Click(object sender, EventArgs e)
        {
            if (radbutDepart.Checked == true && comboxRange.SelectedValue != null)
            {
                rangeStr = " departno='" + comboxRange.SelectedValue.ToString() + "'";
            }
            else if (radbutCourse.Checked == true)
            {
                MessageBox.Show("请选择“全校”或“院系”其中一个选项", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string salarystr = comboxSalary.SelectedValue.ToString();
            if (!rangeStr.Equals(""))
                sqlStr = "SELECT COUNT(*) FROM tbTeach WHERE salary=" + salarystr + " AND " + rangeStr ;
            else
                sqlStr = "SELECT COUNT(*) FROM tbTeach WHERE salary=" + salarystr;

            //MessageBox.Show(sqlStr, "调试", MessageBoxButtons.OK);
            txtboxSalary.Text = (new SqlOperate().HumanNum(sqlStr)).ToString();
        }
    }


}
