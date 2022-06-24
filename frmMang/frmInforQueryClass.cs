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

    public partial class frmInforQueryClass : UserControl
    {
        public string sqltb = "";
        private string sql = "SELECT * FROM ";
        private string sqlStr = "";
        DataTable dt = null;
        public frmInforQueryClass(string sqltb)
        {
            InitializeComponent();
            initialiComboxes();
            sqlStr = sql + sqltb;
            new SqlOperate().BindDataGridView(dgvclass, sqlStr);
        }

        private void TbClassBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClassBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ButCheck_Click(object sender, EventArgs e)
        {
            if(radbutClass.Checked==true && txtboxCheck.Text != null)
            {
                sqlStr = sql + "tbClass WHERE classname LIKE '%"+ txtboxCheck.Text + "%'";
                new SqlOperate().BindDataGridView(dgvclass, sqlStr);
            }
            else if(radbutTeachNo.Checked==true && txtboxCheck.Text != null)
            {
                sqlStr = sql + "tbClass WHERE teachno LIKE '%" + txtboxCheck.Text + "%'";
                new SqlOperate().BindDataGridView(dgvclass, sqlStr);
            }
            else
            {
                MessageBox.Show("请输入信息", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //初始化控件
        private void initialiComboxes()
        {
            if (comboxScreen.Items.Count > 0)
            {
                comboxScreen.DataSource = null;
                comboxScreen.Items.Clear();
            }
            sqlStr = "SELECT DISTINCT tbStudent.departno,tbDepart.departname FROM " +
                 "tbStudent,tbDepart WHERE tbStudent.departno=tbDepart.departno";
            dt = new SqlOperate().BindDataTable(sqlStr, "SD");
            comboxScreen.DataSource = dt;
            comboxScreen.DisplayMember = "departname";
            comboxScreen.ValueMember = "departno";
        }

        private void RadbutClassStates_CheckedChanged(object sender, EventArgs e)
        {
            if (comboxScreen.Items.Count > 0)
            {
                comboxScreen.DataSource = null;
                comboxScreen.Items.Clear();
            }
            string[] STATES = { "开课", "休课" ,"选课"};
            comboxScreen.Items.AddRange(STATES);
            comboxScreen.SelectedIndex = 0;
        }

        private void RadbutDeprat_CheckedChanged(object sender, EventArgs e)
        {
            initialiComboxes();
        }

        private void ButSort_Click(object sender, EventArgs e)
        {
            if (radbutSortASC.Checked == true)
            {
                sqlStr = sql + "tbClass ORDER BY stunum ASC";
                new SqlOperate().BindDataGridView(dgvclass, sqlStr);
            }
            else if (radbutSortDESC.Checked == true)
            {
                sqlStr = sql + "tbClass ORDER BY stunum DESC";
                new SqlOperate().BindDataGridView(dgvclass, sqlStr);
            }
            else
            {
                MessageBox.Show("请勾选相应的选项", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ButScreen_Click(object sender, EventArgs e)
        {
            if(radbutDeprat.Checked==true && comboxScreen.SelectedValue != null)
            {
                sqlStr = sql + "tbClass WHERE departno='"+ comboxScreen.SelectedValue .ToString()+ "'";
                new SqlOperate().BindDataGridView(dgvclass, sqlStr);
            }
            else if (radbutClassStates.Checked==true && comboxScreen.SelectedItem != null) 
            {
                sqltb = comboxScreen.SelectedItem.ToString();
                if (sqltb == "开课") sqltb = "1";
                else if (sqltb == "休课") sqltb = "2";
                else if (sqltb == "选课") sqltb = "3";
                sqlStr = sql + "tbClass WHERE states=" + sqltb;
                new SqlOperate().BindDataGridView(dgvclass, sqlStr);

            }
            else
            {
                MessageBox.Show("请勾选相应的选项", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ButRecover_Click(object sender, EventArgs e)
        {
            sqlStr = "SELECT * FROM tbClass";
            new SqlOperate().BindDataGridView(dgvclass, sqlStr);
        }
    }
}
