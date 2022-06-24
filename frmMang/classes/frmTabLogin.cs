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

namespace EduAdminSys.frmMang.classes
{
    public partial class frmTabLogin : UserControl
    {
        private string sqlStr = "SELECT * FROM tbLogin";
        public frmTabLogin()
        {
            InitializeComponent();
            new SqlOperate().BindDataGridView(dgvLogin, sqlStr);
            initiComboxRole();

        }

        private void initiComboxRole()
        {
            string[] ROLE = { "教师", "学生","管理员" };
            comboxRole.Items.AddRange(ROLE);
            comboxRole.SelectedIndex = 0;
        }

        private void DgvLogin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string role;
            txtboxID.Text= dgvLogin.CurrentRow.Cells[0].Value.ToString();
            txtboxPSW.Text = dgvLogin.CurrentRow.Cells[1].Value.ToString();
            role= dgvLogin.CurrentRow.Cells[2].Value.ToString();
            if (role == "1") comboxRole.SelectedIndex = 0; 
            else if (role == "2") comboxRole.SelectedIndex = 1; 
            else comboxRole.SelectedIndex = 2; 

        }

        private void ButUpdate_Click(object sender, EventArgs e)
        {
            if (txtboxID.Text == "" || txtboxPSW.Text == "")
            {
                MessageBox.Show("请在左侧信息表中选择相应的用户或输入密码", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!isRight(txtboxPSW.Text))
            {
                MessageBox.Show("密码只能由大小写英文字符和数字组成", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("确定修改吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            string role = comboxRole.SelectedItem.ToString();
            if (role == "教师") role = "1";
            else if (role == "学生") role = "2";
            else role = "3";

            string sqltb = "UPDATE tbLogin SET psw='" + txtboxPSW.Text + "',role=" + role + " WHERE userid='" + txtboxID.Text + "'";
            try
            {
                int i = new SqlOperate().selectNum(sqltb);
                if (i == 1)
                {
                    MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }catch(Exception exp)
            {
                MessageBox.Show("修改失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("修改失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private bool isRight(string newpsw)
        {
            for (int i = 0; i < newpsw.Length; i++)
            {
                if ((newpsw[i] >= 48 && newpsw[i] <= 57) || (newpsw[i] >= 65 && newpsw[i] <= 90) || (newpsw[i] >= 97 && newpsw[i] <= 122))
                    return true;
            }
            return false;
        }

        private void ButDelete_Click(object sender, EventArgs e)
        {
            if (txtboxID.Text == "" )
            {
                MessageBox.Show("请在左侧信息表中选择相应的用户", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("确定删除吗？此操作无法恢复。", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            string sqltb = "UPDATE tbLogin SET states=0 WHERE userid='" + txtboxID.Text + "'";
            try
            {
                int i = new SqlOperate().selectNum(sqltb);
                if (i == 1)
                {
                    MessageBox.Show("删除成功，已将状态改为冻结", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("删除失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("删除失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }
}
