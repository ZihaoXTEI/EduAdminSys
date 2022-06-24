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
    public partial class frmTeachStudInfor : UserControl
    {
        private String sqlStr, teachno, markRange;
        private DataTable dt = null;
        public frmTeachStudInfor(string teachno)
        {
            InitializeComponent();
            this.teachno = teachno;
            //initiComboxSort();
            initiComboxClass();
            initiComboxMarkLevel();
            Recovery();
        }

        private void ButEnter_Click(object sender, EventArgs e)
        {
            string sqltb;
            Recovery();
            getMarkRange();
            if (chkboxClass.Checked==true && comboxClass.SelectedValue != null)
            {
                if(chkboxMarkLevel.Checked==true && comboxLevel.SelectedItem != null)
                {
                    sqltb = " AND classname='" + comboxClass.SelectedValue.ToString() + "'" + markRange;
                }
                else
                    sqltb = " AND classname='" + comboxClass.SelectedValue.ToString() + "'";
            }
            else
            {
                if (chkboxMarkLevel.Checked == true && comboxLevel.SelectedItem != null)
                {
                    sqltb = markRange;
                }
                else
                {
                    MessageBox.Show("请选择相应的选择", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            sqlStr = sqlStr + sqltb;
            //MessageBox.Show(sqlStr, "调试", MessageBoxButtons.OK);
            new SqlOperate().BindDataGridView(dgvStuInfo, sqlStr);
        }

        private void ButCheck_Click(object sender, EventArgs e)
        {
            Recovery();
            string sqltb = txtboxStuNum.Text;
            if (sqltb == "") {
                MessageBox.Show("请输入相应的值", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sqlStr = sqlStr + " AND stuno LIKE '%" + sqltb + "%'";
            //MessageBox.Show(sqlStr, "调试", MessageBoxButtons.OK);
            new SqlOperate().BindDataGridView(dgvStuInfo, sqlStr);

        }

        private void ButRecovery_Click(object sender, EventArgs e)
        {
            Recovery();
        }

        private void RadbutMarkASC_CheckedChanged(object sender, EventArgs e)
        {
            string sort = " ORDER BY mark ASC";
            new SqlOperate().BindDataGridView(dgvStuInfo, sqlStr + sort);
        }

        private void RadbutMarkDESC_CheckedChanged(object sender, EventArgs e)
        {
            string sort = " ORDER BY mark DESC";
            new SqlOperate().BindDataGridView(dgvStuInfo, sqlStr + sort);
        }

        private void Recovery()
        {
            sqlStr= "SELECT stuno,stuname,classname,mark,bukao,studepart FROM Stud_ClassAndMark_View WHERE teachno='" + teachno + "'";
            new SqlOperate().BindDataGridView(dgvStuInfo, sqlStr);
        }

        private void initiComboxClass()
        {
            sqlStr = "SELECT classno,classname FROM Class_DetailedInfor_View WHERE teachno='" + teachno + "'";
            dt = new SqlOperate().BindDataTable(sqlStr, "SD");
            comboxClass.DataSource = dt;
            comboxClass.DisplayMember = "classname";
            comboxClass.ValueMember = "classname";
            comboxClassStati.DataSource = dt;
            comboxClassStati.DisplayMember = "classname";
            comboxClassStati.ValueMember = "classname";

        }

        private void ButStati_Click(object sender, EventArgs e)
        {
            if(comboxClassStati.SelectedValue == null)
            {
                MessageBox.Show("请选择相应的选择", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string classname = comboxClassStati.SelectedValue.ToString();
            string sqlstr = "SELECT * FROM Class_Stati_View WHERE classname='" + classname + "'";

            SqlDataReader dr = new SqlOperate().GetRowData(sqlstr);
            while (dr.Read())
            {
                txtboxAvg.Text = dr[1].ToString();
                txtboxMaxMark.Text = dr[2].ToString();
                txtboxMinMark.Text = dr[3].ToString();
            }

            txtboxExceNum.Text = getNum(classname, "BETWEEN 90 AND 100");
            txtboxPassNum.Text = getNum(classname, "BETWEEN 60 AND 100");
            txtboxFailNum.Text = getNum(classname, "BETWEEN 0 AND 59");

        }

        private void initiComboxMarkLevel()
        {
            string[] SmarkLevel = { "优秀(90~100)", "良好(80~89)", "及格(60~79)", "不及格(60以下)" };
            comboxLevel.Items.AddRange(SmarkLevel);
            comboxLevel.SelectedIndex = 0;
        }

        private void getMarkRange()
        {
            markRange = "";
            if (comboxLevel.SelectedItem == null) return;
            markRange = comboxLevel.SelectedItem.ToString();
            if (markRange == "优秀(90~100)") markRange = " AND mark BETWEEN 90 AND 100 ";
            else if (markRange == "良好(80~89)") markRange = " AND mark BETWEEN 80 AND 89 ";
            else if (markRange == "及格(60~79)") markRange = " AND mark BETWEEN 60 AND 79 ";
            else markRange = " AND mark BETWEEN 0 AND 59";
        }

        private string getNum(string classname,string markRange)
        {
            string sqlstr = "SELECT COUNT(stuno) FROM Stud_DetailedInfor_View WHERE classname='"+ classname + "' AND mark "+ markRange + " GROUP BY classname";
            int num = new SqlOperate().HumanNum(sqlstr);
            return num.ToString();
        }
    }
}
