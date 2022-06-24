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
    public partial class frmInforQueryStud : UserControl
    {
        public string sqltb = "";
        private string sql = "SELECT * FROM ";
        private string sqlStr = "";
        private DataTable dt = null;
        public frmInforQueryStud(string sqltb)
        {
            InitializeComponent();
            sqlStr = sql + sqltb;
            new SqlOperate().BindDataGridView(dgvstud, sqlStr);

            //初始化comboxAge控件
            string sqlAge = "SELECT DISTINCT age FROM tbStudent";
            dt = new SqlOperate().BindDataTable(sqlAge, "studAge");
            comboxAge.DataSource = dt;
            comboxAge.DisplayMember = "age";
            comboxAge.ValueMember = "age";

            initialiComboxDepart();     //初始化comboxDepart控件
            initialiComboxSex();        //初始化comboxSex控件

        }

        private void TbStudentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbStudentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        //查找按钮方法
        private void ButCheck_Click(object sender, EventArgs e)
        {
            if(radbutNo.Checked==true && txtboxCheck.Text != null)
            {
                sqlStr = sql + "tbStudent WHERE stuno LIKE '%"+ txtboxCheck.Text + "%'";
                new SqlOperate().BindDataGridView(dgvstud, sqlStr);
            }
            else if(radbutName.Checked==true && txtboxCheck.Text != null)
            {
                sqlStr = sql + "tbStudent WHERE stuname LIKE'%" + txtboxCheck.Text + "%'";
                new SqlOperate().BindDataGridView(dgvstud, sqlStr);
            }
            else
            {
                MessageBox.Show("请输入信息", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //恢复学生表方法
        private void ButRecovery_Click(object sender, EventArgs e)
        {
            sqlStr = "SELECT * FROM tbStudent";
            new SqlOperate().BindDataGridView(dgvstud, sqlStr);
        }

        //筛选按钮方法
        private void ButScreen_Click(object sender, EventArgs e)
        {
            string sqlStr = null;
            string selAge = comboxSex.SelectedItem.ToString();
            if (selAge == "男") selAge = "M";
            else selAge = "F";
            if (chkboxAge.Checked==true && comboxAge.SelectedValue != null)
            {
                if (chkboxDepart.Checked == true && comboxDepart.SelectedValue != null)
                {
                    if(chkboxSex.Checked==true && comboxSex.SelectedItem != null)
                    {
                        sqlStr = sql + " tbStudent WHERE age=" + comboxAge.SelectedValue.ToString() + " and departno='" +
                            comboxDepart.SelectedValue.ToString() + "' and sex='" + selAge + "'";
                    }
                    else
                    {
                        sqlStr = sql + " tbStudent WHERE age=" + comboxAge.SelectedValue.ToString() + " and departno='" +
                                comboxDepart.SelectedValue.ToString() + "'";
                    }
                }
                else
                {
                    if(chkboxSex.Checked == true && comboxSex.SelectedItem != null)
                    {
                        sqlStr = sql + " tbStudent WHERE age=" + comboxAge.SelectedValue.ToString() + 
                            " and sex='" + selAge + "'";
                    }
                    else
                    {
                        sqlStr = sql + " tbStudent WHERE age=" + comboxAge.SelectedValue.ToString();
                    }
                }
            }
            else
            {
                if (chkboxDepart.Checked == true && comboxDepart.SelectedValue != null)
                {
                    if(chkboxSex.Checked == true && comboxSex.SelectedItem != null)
                    {
                        sqlStr = sql + " tbStudent WHERE  departno='" +comboxDepart.SelectedValue.ToString() +
                            "' and sex='" + selAge + "'";
                    }
                    else
                    {
                        sqlStr = sql + " tbStudent WHERE  departno='" + comboxDepart.SelectedValue.ToString() + "'";
                    }
                }
                else
                {
                    if (chkboxSex.Checked == true && comboxSex.SelectedItem != null)
                    {
                        sqlStr = sql + " tbStudent WHERE sex='" + selAge + "'";
                    }
                }
            }
            if (sqlStr == null)
            {
                MessageBox.Show("请勾选相应的选项", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            new SqlOperate().BindDataGridView(dgvstud, sqlStr);
        }

        //初始化comboxDepart控件方法
        private void initialiComboxDepart()
        {
            sqlStr = "SELECT DISTINCT tbStudent.departno,tbDepart.departname FROM " +
                    "tbStudent,tbDepart WHERE tbStudent.departno=tbDepart.departno";
            dt = new SqlOperate().BindDataTable(sqlStr, "SD");
            comboxDepart.DataSource = dt;
            comboxDepart.DisplayMember = "departname";
            comboxDepart.ValueMember = "departno";
        }

        //初始化comboxSex控件方法
        private void initialiComboxSex()
        {
            string[] SEX = { "男", "女" };
            comboxSex.Items.AddRange(SEX);
            comboxSex.SelectedIndex = 0;
        }
    }
}
