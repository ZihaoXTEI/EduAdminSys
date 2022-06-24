using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduAdminSys.connDB;

namespace EduAdminSys
{
    public partial class frmPasswordSet : Form
    {
        static private string userid;
        private string sqlStr;
        public frmPasswordSet(string userId)
        {
            InitializeComponent();
            userid = userId;
        }

        private void ButCancel_Click(object sender, EventArgs e)
        {
            
            DialogResult result =MessageBox.Show("确认放弃修改吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void ButEnter_Click(object sender, EventArgs e)
        {
            if(txtboxOldPSW.Text == null || txtboxNewPSW.Text == null || txtboxCheckPSW.Text == null)
            {
                MessageBox.Show("请在相应的输入框输入值", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string oldpsw = txtboxOldPSW.Text;
            string newpsw = txtboxNewPSW.Text;
            string checkpsw = txtboxCheckPSW.Text;

            sqlStr = "SELECT * FROM tbLogin WHERE userid='" + userid + "' AND psw='" + oldpsw + "'";
            if(!(new SqlOperate().HumanNum(sqlStr) == 1))
            {
                MessageBox.Show("输入的旧密码不正确，请重新输入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxOldPSW.Text = "";
                txtboxNewPSW.Text = "";
                txtboxCheckPSW.Text = "";
                return;
            }

            if(!newpsw.Equals(checkpsw))
            {
                MessageBox.Show("输入的两个新密码不相同，请重新输入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxOldPSW.Text = "";
                txtboxNewPSW.Text = "";
                txtboxCheckPSW.Text = "";
                return;
            }

            if (!(isRight(newpsw)))
            {
                MessageBox.Show("输入的新密码不符合要求，请重新输入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxOldPSW.Text = "";
                txtboxNewPSW.Text = "";
                txtboxCheckPSW.Text = "";
                return;
            }


            sqlStr = "UPDATE tbLogin SET psw='" + newpsw + "' WHERE userid='" + userid + "'";
            if(new SqlOperate().selectNum(sqlStr) == 0)
            {
                MessageBox.Show("修改失败，当前无法修改", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxOldPSW.Text = "";
                txtboxNewPSW.Text = "";
                txtboxCheckPSW.Text = "";
                return;
            }
            else
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtboxOldPSW.Text = "";
                txtboxNewPSW.Text = "";
                txtboxCheckPSW.Text = "";
                return;
            }

        }

        //判断输入的新密码是否符合要求（英文大小字母和数字）
        private bool isRight(string newpsw)
        {
            for(int i = 0; i < newpsw.Length; i++)
            {
                if ((newpsw[i] >= 48 && newpsw[i] <= 57) || (newpsw[i] >= 65 && newpsw[i] <= 90) || (newpsw[i] >= 97 && newpsw[i] <= 122))
                    return true;
            }
            return false;
        }

        private void FrmPasswordSet_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出密码修改吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
