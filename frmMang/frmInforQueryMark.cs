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
    public partial class frmInforQueryMark : UserControl
    {
        public string markRange = "";
        private string sql = "SELECT * FROM ";
        private string sqlStr = "";
        DataTable dt = null;
        public frmInforQueryMark(string sqltb)
        {
            InitializeComponent();
            sqlStr = sql + sqltb;
            new SqlOperate().BindDataGridView(dgvmark, sqlStr);
            initialiComboxLevel();

        }

        private void TbMarkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbMarkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        //初始化comboxSex控件方法
        private void initialiComboxLevel()
        {
            string[] SmarkLevel = { "优秀(90~100)", "良好(80~89)","及格(60~79)","不及格(60以下)" };
            comboxLevel.Items.AddRange(SmarkLevel);
            comboxLevel.SelectedIndex = 0;
        }

        private void ButCheck_Click(object sender, EventArgs e)
        {
            if(radbutNo.Checked==true && txtboxCheck.Text != null)
            {
                sqlStr = sql + "tbMark WHERE stuno LIKE '%"+ txtboxCheck.Text + "%'";
                new SqlOperate().BindDataGridView(dgvmark, sqlStr);
            }
            else if(radbutClass.Checked==true && txtboxCheck.Text != null){
                sqlStr = sql + "tbMark WHERE tbMark.classno IN(SELECT tbClass.classno FROM" +
                    " tbClass WHERE classname LIKE '%" + txtboxCheck.Text + "%')";
                //MessageBox.Show(sqlStr, "调试", MessageBoxButtons.OK);
                new SqlOperate().BindDataGridView(dgvmark, sqlStr);
            }
            else
            {
                MessageBox.Show("请输入信息", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ButScreen_Click(object sender, EventArgs e)
        {
            getMarkRange();
            if (chkboxBukao.Checked == true)
            {
                if(chkboxLevel.Checked==true && comboxLevel.SelectedItem != null)
                {
                    sqlStr = sql + " tbMark WHERE bukao" + markRange;
                }
                else
                    sqlStr = sql + " tbMark WHERE bukao BETWEEN 0 AND 100";
            }
            else
            {
                if (chkboxLevel.Checked == true && comboxLevel.SelectedItem != null)
                {
                    sqlStr = sql + " tbMark WHERE mark" + markRange;
                }
                else
                    sqlStr = sql + " tbMark WHERE mark BETWEEN 0 AND 100";
            }

            new SqlOperate().BindDataGridView(dgvmark, sqlStr);
        }


        private void getMarkRange()
        {
            if (comboxLevel.SelectedItem == null) return;
            markRange = comboxLevel.SelectedItem.ToString();
            if (markRange == "优秀(90~100)") markRange = " BETWEEN 90 AND 100 ";
            else if (markRange == "良好(80~89)") markRange = " BETWEEN 80 AND 89 ";
            else if (markRange == "及格(60~79)") markRange = " BETWEEN 60 AND 79 ";
            else markRange = "BETWEEN 0 AND 59";
        }
    }
}
