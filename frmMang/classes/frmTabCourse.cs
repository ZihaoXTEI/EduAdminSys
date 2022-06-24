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

namespace EduAdminSys.frmMang.classes
{
    public partial class frmTabCourse : UserControl
    {
        string sqlStr, sqltb;
        string courseNo;
        DataTable dt = null;
        public frmTabCourse()
        {
            InitializeComponent();
            initiComboxDepart();
            initiComboxCouType();
            initiComboxCredit();
            initiComboxClass();
        }


        //初始化一系列combobox控件
        private void initiComboxDepart()
        {
            sqlStr = "SELECT * FROM tbDepart";
            dt = new SqlOperate().BindDataTable(sqlStr, "DEP");
            comboxDepart2.DataSource = dt;
            comboxDepart2.DisplayMember = "departname";
            comboxDepart2.ValueMember = "departno";
            comboxDepart2.SelectedIndex = 0;
        }

        private void initiComboxCouType()
        {
            sqlStr = "SELECT DISTINCT coutype FROM tbCourse";
            dt = new SqlOperate().BindDataTable(sqlStr, "DEP");
            comboxCouType2.DataSource = dt;
            comboxCouType2.DisplayMember = "coutype";
            comboxCouType2.ValueMember = "coutype";
        }

        private void initiComboxCredit()
        {
            string[] CREDIT = { "3", "3.5","4","4.5","5","5.5","6","6.5","7","7.5","8","8.5","9","9.5","10" };
            comboxCredit2.Items.AddRange(CREDIT);
            comboxCredit2.SelectedIndex = 0;
        }

        private void ButCheck_Click(object sender, EventArgs e)
        {
            if (txtboxCouName1.Text == "")
            {
                MessageBox.Show("请输入课程名称再查找", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string courseno, couhour;
            sqlStr = "SELECT * FROM tbCourse WHERE coursename='" + txtboxCouName1.Text + "'";
            SqlDataReader dr = new SqlOperate().GetRowData(sqlStr);
            if (dr.Read() == false)
            {
                MessageBox.Show("未找到任何结果，请确认输入名称是否正确", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtboxCouHour1.Text = "";
                txtboxCouType.Text = "";
                txtboxCredit.Text = "";
                txtboxDepart.Text = "";
                return;
            }
            else
            {
                txtboxCouHour1.Text = dr["couhour"].ToString();
                txtboxCouType.Text = dr["coutype"].ToString();
                txtboxCredit.Text = dr["credit"].ToString();
                txtboxDepart.Text = dr["departno"].ToString();
                courseNo = dr["courseno"].ToString();
                txtboxCouHour1.Text = dr["couhour"].ToString();
                //comboxCredit1.va
            }

            sqlStr = "SELECT COUNT(*) FROM tbClass WHERE courseno='" + courseNo + "'";
            txtboxClassNum.Text = new SqlOperate().HumanNum(sqlStr).ToString();

        }

        private void initiComboxClass()
        {
            string[] HOUR = { "1", "2", "3", "4", "5", "6" };
            comboxClass2.Items.AddRange(HOUR);
            comboxClass2.SelectedIndex = 0;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (txtboxCouName2.Text == "" || txtboxCouHour2.Text == "" || comboxClass2.SelectedItem == null || comboxCouType2.SelectedValue == null || comboxCredit2.SelectedItem == null || comboxDepart2.SelectedValue == null)
            {
                MessageBox.Show("请将信息填写完整", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string departno, credit, couhour, coutype, couname, courseno, classnum, classno, classname;
            int num = 1;
            departno = comboxDepart2.SelectedValue.ToString();
            credit = comboxCredit2.SelectedItem.ToString();
            coutype = comboxCouType2.SelectedValue.ToString();
            couname = txtboxCouName2.Text.Trim();
            if (!isCourseNameUNIQUE(couname)) return;
            courseno = new SqlOperate().getLastNo(departno, "tbCourse");
            classnum = comboxClass2.SelectedItem.ToString();
            couhour = txtboxCouHour2.Text.Trim();
            if (!isCouHour(couhour)) return;
            sqlStr = "INSERT INTO tbCourse VALUES('" + courseno + "','" + couname + "'," + couhour + ",'" + coutype + "'," + credit + ",'" + departno + "')";
            //Console.WriteLine(sqlStr);
            if (new SqlOperate().selectNum(sqlStr) == 1)
            {
                try
                {
                    for (int u = 0; u < int.Parse(classnum); num++,u++)
                    {
                        classno = courseno + num.ToString("000");
                        classname = couname + num.ToString() + "班";
                        sqlStr = "INSERT INTO tbClass VALUES('" + classno + "','" + classname + "',3,0,'" + courseno + "','" + departno + "',NULL)";
                        //Console.WriteLine(sqlStr);
                        new SqlOperate().selectNum(sqlStr);
                    }
                }catch(Exception cpt)
                {
                    MessageBox.Show("无法创建", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            }
            else
            {
                MessageBox.Show("无法创建", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            MessageBox.Show("增加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ComboxDepart2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departno = comboxDepart2.SelectedValue.ToString();
            txtboxCourseNo.Text = new SqlOperate().getLastNo(departno, "tbCourse");
        }

        private void ButUpdate_Click(object sender, EventArgs e)
        {
            if (txtboxCouHour1.Text == "")
            {
                MessageBox.Show("请将信息填写完整", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!isCouHour(txtboxCouHour1.Text.Trim())) return;

            sqlStr = "UPDATE tbCourse SET couhour='" + txtboxCouHour1.Text.Trim() + "' WHERE courseno='" + courseNo + "'";
            //Console.WriteLine(sqlStr);
            if (new SqlOperate().selectNum(sqlStr) == 1)
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MessageBox.Show("修改失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //检查输入的课时是否正确
        private bool isCouHour(string couhour)
        {
            int hour;
            try
            {
                hour = int.Parse(couhour);
                if(hour>=20 && hour <= 60)
                {
                    return true;
                }
                MessageBox.Show("请输入正确的范围，课时应在20~60节", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ept)
            {
                MessageBox.Show("请输入正确的数字", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }


        private bool isCourseNameUNIQUE(string name)
        {
            string sqltb = "SELECT coursename FROM tbCourse";
            List<string> coursenames = new List<string>();
            int i;
            Console.WriteLine(sqltb);
            DataTable dt = new SqlOperate().BindDataTable(sqltb, "tbTeamp");
            for (i = 0; i < dt.Rows.Count; i++)
            {
                coursenames.Add(dt.Rows[i][0].ToString());
            }

            for (i = 0; i < coursenames.Count; i++)
            {
                if (name.Equals(coursenames[i]))
                {
                    MessageBox.Show("已存在相同名称的课程名，无法创建新的课程", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dt.Clear();
                    return false;
                }
            }
            dt.Clear(); 
            return true;
        }

    }
}
