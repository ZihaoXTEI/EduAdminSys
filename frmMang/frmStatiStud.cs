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

    public partial class frmStatiStud : UserControl
    {
        public string rangeStr = "";
        private string sqlStr = "";
        DataTable dt = null;
        public frmStatiStud()
        {
            InitializeComponent();

            //初始化GroupBox3中的comboBox控件
            initialiComboxAge();
            initialiComboxSex();
            initialiComboxYear();
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
            sqlStr = "SELECT DISTINCT age FROM tbStudent";
            dt = new SqlOperate().BindDataTable(sqlStr, "AGE");
            comboxAge.DataSource = dt;
            comboxAge.DisplayMember = "age";
            comboxAge.ValueMember = "age";
        }

        private void initialiComboxYear()
        {
            string[] YEAR = { "2015", "2016", "2017","2018" };
            comboxYear.Items.AddRange(YEAR);
            comboxYear.SelectedIndex = 0;
        }
        /******/


        /****Groupbox1中的radiobutton事件方法***/
        private void RadbutDepart_CheckedChanged(object sender, EventArgs e)
        {
            comboxRange.Enabled = true;
            if (comboxRange.Items.Count > 0)
            {
                comboxRange.DataSource = null;
                comboxRange.Items.Clear();
            }
            sqlStr = "SELECT DISTINCT tbStudent.departno,tbDepart.departname FROM " +
        "tbStudent,tbDepart WHERE tbStudent.departno=tbDepart.departno";
            dt = new SqlOperate().BindDataTable(sqlStr, "SD");
            comboxRange.DataSource = dt;
            comboxRange.DisplayMember = "departname";
            comboxRange.ValueMember = "departno";
        }

        private void RadbutSchol_CheckedChanged(object sender, EventArgs e)
        {
            comboxRange.Enabled = false;
            rangeStr = "";
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
        /****/

        private void ButEnter_Click(object sender, EventArgs e)
        {
            string charaStr = null;
            if (radbutDepart.Checked==true && comboxRange.SelectedValue != null)
            {
                rangeStr = "departno='" + comboxRange.SelectedValue.ToString() + "'";
            }
            else if(radbutCourse.Checked==true && comboxRange.SelectedValue != null)
            {
                rangeStr= "tbStudent.stuno IN(SELECT tbMark.stuno FROM tbMark WHERE classno IN(" +
                        "SELECT classno FROM tbClass, tbCourse WHERE tbClass.courseno = "+
                   "tbCourse.courseno AND tbCourse.coursename='"+ comboxRange.SelectedValue + "'))";
            }
            else if(radbutClass.Checked==true && comboxRange.SelectedValue != null)
            {
                rangeStr = "tbStudent.stuno IN(SELECT tbMark.stuno FROM tbMark,tbClass WHERE tbMark.classno=tbClass.classno AND tbClass.classname='"+ comboxRange.SelectedValue.ToString() + "')";
            }


            //GroupBox2中comboBox事件逻辑
            string sex = comboxSex.SelectedItem.ToString();
            string year = comboxYear.SelectedItem.ToString();
            if (sex == "男") sex = "M";
            else sex = "F";

            if (chkboxAge.Checked == true && comboxAge.SelectedValue != null)
            {
                if (chkboxYear.Checked == true && comboxYear.SelectedItem != null)
                {
                    if (chkboxSex.Checked == true && comboxSex.SelectedItem != null)
                    {
                        charaStr = " age=" + comboxAge.SelectedValue.ToString() + " and stuno LIKE '%" +
                            year + "%' and sex='" + sex + "'";
                    }
                    else
                    {
                        charaStr = " age=" + comboxAge.SelectedValue.ToString() + " and stuno LIKE '%" +
                                year + "%'";
                    }
                }
                else
                {
                    if (chkboxSex.Checked == true && comboxSex.SelectedItem != null)
                    {
                        charaStr = " age=" + comboxAge.SelectedValue.ToString() +
                            " and sex='" + sex + "'";
                    }
                    else
                    {
                        charaStr = " age=" + comboxAge.SelectedValue.ToString();
                    }
                }
            }
            else
            {
                if (chkboxYear.Checked == true && comboxYear.SelectedItem != null)
                {
                    if (chkboxSex.Checked == true && comboxSex.SelectedItem != null)
                    {
                        charaStr = " stuno LIKE '%" + year +
                            "%' and sex='" + sex + "'";
                    }
                    else
                    {
                        charaStr = " stuno LIKE '%" + year + "%'";
                    }
                }
                else
                {
                    if (chkboxSex.Checked == true && comboxSex.SelectedItem != null)
                    {
                        charaStr =  " sex='" + sex + "'";
                    }
                }
            }

            if(chkboxAge.Checked==false && chkboxSex.Checked==false && chkboxYear.Checked==false && rangeStr.Equals(""))
            {
                sqlStr = "SELECT COUNT(*) FROM tbStudent";
            }
            else if(charaStr != null && rangeStr.Equals(""))
            {
                sqlStr = "SELECT COUNT(*) FROM tbStudent WHERE " + charaStr ;
            }
            else if(charaStr != null  && !rangeStr.Equals(""))
            {
                sqlStr = "SELECT COUNT(*) FROM tbStudent WHERE " + charaStr + " AND " + rangeStr;
            }
            else
            {
                sqlStr = "SELECT COUNT(*) FROM tbStudent WHERE "  + rangeStr;
            }

            //MessageBox.Show(sqlStr, "调试", MessageBoxButtons.OK);
            txtboxNum.Text=(new SqlOperate().HumanNum(sqlStr)).ToString()+" 人";
        }
        
    }
}
