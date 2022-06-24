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
    public partial class frmInforQueryCourse : UserControl
    {
        public string sqltb = "";
        private string sql = "SELECT * FROM ";
        private string sqlStr = "";
        DataTable dt = null;
        public frmInforQueryCourse(string sqltb)
        {
            InitializeComponent();
            sqlStr = sql + sqltb;
            new SqlOperate().BindDataGridView(dgvcourse, sqlStr);
            //初始化comboBox控件
            initialiComboxCouHour();
            initialiComboxCredit();
            initialiComboxDepartNo();
        }

        private void TbCourseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbCourseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sQLDataSet);

        }

        //查找按钮事件方法
        private void ButCheck_Click(object sender, EventArgs e)
        {
            if(radbutCouNo.Checked==true && txtboxCheck.Text != null)
            {
                sqltb = txtboxCheck.Text;
                sqlStr = sql + "tbCourse WHERE courseno LIKE '%" + sqltb + "%'";
                new SqlOperate().BindDataGridView(dgvcourse, sqlStr);
            }
            else if(radbutCouName.Checked==true && txtboxCheck.Text != null)
            {
                sqltb = txtboxCheck.Text;
                sqlStr = sql + "tbCourse WHERE coursename LIKE '%" + sqltb + "%'";
                new SqlOperate().BindDataGridView(dgvcourse, sqlStr);
            }
            else
            {
                MessageBox.Show("请输入信息", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void ButScreen_Click(object sender, EventArgs e)
        {
            string sqlStr = null;
            string sqlCouHour = comboxCouHour.SelectedItem.ToString();
            if (sqlCouHour == "30~39课时") sqlCouHour = "couhour<40";
            else if (sqlCouHour == "40~49课时") sqlCouHour = "couhour BETWEEN 40 AND 49";
            else sqlCouHour = "couhour >49";
            if (chkboxCouHour.Checked == true && comboxCouHour.SelectedItem != null)
            {
                if (chkboxDepartNo.Checked == true && comboxDepartNo.SelectedValue != null)
                {
                    if (chkboxCredit.Checked == true && comboxCredit.SelectedValue != null)
                    {
                        sqlStr = sql + " tbCourse WHERE " + sqlCouHour + " and departno='" +
                            comboxDepartNo.SelectedValue.ToString() + "' and credit=" + comboxCredit.SelectedValue.ToString();
                    }
                    else
                    {
                        sqlStr = sql + " tbCourse WHERE " + sqlCouHour + " and departno='" +
                                comboxDepartNo.SelectedValue.ToString() + "'";
                    }
                }
                else
                {
                    if (chkboxCredit.Checked == true && comboxCredit.SelectedValue != null)
                    {
                        sqlStr = sql + " tbCourse WHERE " + sqlCouHour +
                            " and credit=" + comboxCredit.SelectedValue.ToString() ;
                    }
                    else
                    {
                        sqlStr = sql + " tbCourse WHERE " + sqlCouHour;
                    }
                }
            }
            else
            {
                if (chkboxDepartNo.Checked == true && comboxDepartNo.SelectedValue != null)
                {
                    if (chkboxCredit.Checked == true && comboxCredit.SelectedValue != null)
                    {
                        sqlStr = sql + " tbCourse WHERE  departno='" + comboxDepartNo.SelectedValue.ToString() +
                            "' and credit=" + comboxCredit.SelectedValue.ToString();
                    }
                    else
                    {
                        sqlStr = sql + " tbCourse WHERE  departno='" + comboxDepartNo.SelectedValue.ToString() + "'";
                    }
                }
                else
                {
                    if (chkboxCredit.Checked == true && comboxCredit.SelectedValue != null)
                    {
                        sqlStr = sql + " tbCourse WHERE credit=" + comboxCredit.SelectedValue.ToString();
                    }
                }
            }


            if (sqlStr == null)
            {
                MessageBox.Show("请勾选相应的选项", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //MessageBox.Show(sqlStr, "调试", MessageBoxButtons.OK);
            new SqlOperate().BindDataGridView(dgvcourse, sqlStr);

        }

        //恢复按钮事件
        private void ButRecovery_Click(object sender, EventArgs e)
        {
            sqlStr = "SELECT * FROM tbCourse";
            new SqlOperate().BindDataGridView(dgvcourse, sqlStr);
        }

        //以下方法初始化筛选GroupBox中的comboBox
        private void initialiComboxCouHour()
        {
            string[] COUHOUR = { "30~39课时", "40~49课时","50~60课时" };
            comboxCouHour.Items.AddRange(COUHOUR);
            comboxCouHour.SelectedIndex = 0;
        }

        private void initialiComboxCredit()
        {
            sqlStr = "SELECT DISTINCT credit FROM tbCourse";
            dt = new SqlOperate().BindDataTable(sqlStr, "CRDEIT");
            comboxCredit.DataSource = dt;
            comboxCredit.DisplayMember = "credit";
            comboxCredit.ValueMember = "credit";
        }

        private void initialiComboxDepartNo()
        {
            sqlStr = "SELECT DISTINCT tbCourse.departno,tbDepart.departname FROM " +
                    "tbCourse,tbDepart WHERE tbCourse.departno=tbDepart.departno";
            dt = new SqlOperate().BindDataTable(sqlStr, "COD");
            comboxDepartNo.DataSource = dt;
            comboxDepartNo.DisplayMember = "departname";
            comboxDepartNo.ValueMember = "departno";
        }

        private void initialiComboxCouType()
        {
            sqlStr = "SELECT DISTINCT coutype FROM tbCourse";
            dt = new SqlOperate().BindDataTable(sqlStr, "COUTYPE");
        }
    }
}
