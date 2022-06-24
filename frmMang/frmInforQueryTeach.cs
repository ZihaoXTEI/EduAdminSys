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
    public partial class frmInforQueryTeach : UserControl
    {
        public string sqltb = "";
        private string sql = "SELECT * FROM ";
        private string sqlStr = "";
        DataTable dt = null;
        public frmInforQueryTeach(string sqltb)
        {
            InitializeComponent();
            sqlStr = sql + sqltb;
            screenTitle();
            new SqlOperate().BindDataGridView(dgvteach, sqlStr);
        }

        private void TbTeachBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbTeachBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ButCheck_Click(object sender, EventArgs e)
        {
            if (radbutNo.Checked == true && textboxNo.Text != null)
            {
                string selItem = textboxNo.Text;
                sqlStr = sql + "tbTeach WHERE teachno LIKE '%" + selItem + "%'";
                new SqlOperate().BindDataGridView(dgvteach, sqlStr);
            }
            else if (radbutName.Checked==true && textboxName.Text!=null)
            {
                string selItem = textboxName.Text;
                sqlStr = sql + "tbTeach WHERE teachname LIKE '%" + selItem + "%'";
                new SqlOperate().BindDataGridView(dgvteach, sqlStr);
            }
            else{
                MessageBox.Show("请输入信息", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //MessageBox.Show(sqlStr, sql, MessageBoxButtons.OK);

        }

        private void ButScreen_Click(object sender, EventArgs e)
        {
            
            if (radButType.Checked==true && comboxScreen.SelectedValue != null)
            {
                string selItem = comboxScreen.SelectedValue.ToString();
                sqlStr = sql + "tbTeach WHERE title='" + selItem + "'";
                new SqlOperate().BindDataGridView(dgvteach, sqlStr);

            }
            else if(radButDeprat.Checked==true && comboxScreen.SelectedValue != null)
            {
                string selItem = comboxScreen.SelectedValue.ToString();
                sqlStr = sql + "tbTeach WHERE departno='" + selItem + "'";
                new SqlOperate().BindDataGridView(dgvteach, sqlStr);
            }
            else if(radbutSex.Checked==true && comboxScreen.SelectedItem != null)
            {
                string selItem = comboxScreen.SelectedItem.ToString();
                if (selItem == "男") selItem = "M";
                else selItem = "F";
                //MessageBox.Show(selItem, selItem, MessageBoxButtons.OK);
                sqlStr = sql + "tbTeach WHERE sex='" + selItem + "'";
                new SqlOperate().BindDataGridView(dgvteach, sqlStr);
            }
            else
            {
                MessageBox.Show("请选择相应的选项", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void RadButType_CheckedChanged(object sender, EventArgs e)
        {
            screenTitle();
        }

        private void screenTitle()
        {
            if (comboxScreen.Items.Count > 0)
            {
                comboxScreen.DataSource = null;
                comboxScreen.Items.Clear();
            }
            string sqlString = "SELECT DISTINCT title FROM tbTeach";
            dt = new SqlOperate().BindDataTable(sqlString, "teachertitle");
            comboxScreen.DataSource = dt;
            comboxScreen.DisplayMember = "title";
            comboxScreen.ValueMember = "title";
        }

        private void RadButDeprat_CheckedChanged(object sender, EventArgs e)
        {
            if (comboxScreen.Items.Count > 0)
            {
                comboxScreen.DataSource = null;
                comboxScreen.Items.Clear();
            }
            sqlStr = "SELECT DISTINCT tbTeach.departno,tbDepart.departname FROM " +
                "tbTeach,tbDepart WHERE tbTeach.departno=tbDepart.departno";
            dt = new SqlOperate().BindDataTable(sqlStr, "TD");
            comboxScreen.DataSource = dt;
            comboxScreen.DisplayMember = "departname";
            comboxScreen.ValueMember = "departno";
        }

        private void RadbutSex_CheckedChanged(object sender, EventArgs e)
        {
            if (comboxScreen.Items.Count > 0)
            {
                comboxScreen.DataSource = null;
                comboxScreen.Items.Clear();
            }
            string[] SEX = { "男", "女" };
            comboxScreen.Items.AddRange(SEX);
            comboxScreen.SelectedIndex = 0;
        }

        private void ButRecovery_Click(object sender, EventArgs e)
        {
            sqlStr = "SELECT * FROM tbTeach";
            new SqlOperate().BindDataGridView(dgvteach, sqlStr);
        }
    }
}
