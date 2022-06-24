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
    public partial class frmMangSelCou : UserControl
    {
        string sqlStr = "SELECT * FROM tbSelect";
        public frmMangSelCou()
        {
            InitializeComponent();
            new SqlOperate().BindDataGridView(dgvSeleCou, sqlStr);
        }

        private void TbSelectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbSelectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sQLDataSet);


        }

        private void Button1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("确定导入数据至成绩表中吗？该操作无法恢复。", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No) return;
            string sql = "SELECT stuno,classno FROM tbSelect WHERE states=2";
            if(new SqlOperate().setTBMark(sql))
            {
                MessageBox.Show("导入成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //删除提交后的tbSelect信息
                sql = "DELETE FROM tbSelect WHERE states=2";
                new SqlOperate().selectNum(sql);
                return;
            }
            else{
                MessageBox.Show("导入失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            sqlStr = "DELECT FROM tbSelect";
            if (new SqlOperate().selectNum(sqlStr) == 0)
            {
                MessageBox.Show("修改失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
