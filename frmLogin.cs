using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EduAdminSys.connDB;
using EduAdminSys.frmStudt;
using EduAdminSys.frmTeach;
using EduAdminSys.frmMang;

namespace EduAdminSys
{

    public partial class frmLogin : Form
    {
        int role;                   //存储用户角色
        string userId, psw;         //存储用户名和密码
        string sql;
        private frmManager manager;
        private frmTeacher teacher;
        private frmStudent student;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            //判断用户是否输入了信息和选择角色
            if(userIdTextBox.Text=="" || pswTextBox.Text == "")
            {
                MessageBox.Show("请输入用户名和密码", "错误", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (TeacherRadBut.Checked == true)
            {
                role = 1;
            }
            else if (StudentRadBut.Checked == true)
            {
                role = 2;
            }
            else if (ManagerRadBut.Checked == true)
            {
                role = 3;
            }
            else
            {
                MessageBox.Show("请选择登陆角色", "注意", MessageBoxButtons.OK);
                return;
            }

            userId = userIdTextBox.Text;
            psw = pswTextBox.Text;

            //生成查询用户ID和密码的SQL语句
            sql = "SELECT * FROM tbLogin WHERE state=1 AND userid='" + userId + "'AND psw='" + psw + "'AND role=" + role;
            if (!loginDB(sql))
            {
                DialogResult result = MessageBox.Show("用户ID或密码错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    userIdTextBox.Text = "";
                    pswTextBox.Text = "";
                    return;
                }
            }
            //MessageBox.Show("用户ID：" + userId + "密码：" + psw, "调试", MessageBoxButtons.OKCancel);

            //根据用户选定的角色启动相应的窗口
            if (role == 1){
                teacher = new frmTeacher(userId);
                teacher.Show();
            }else if(role == 2){
                student = new frmStudent(userId);
                student.Show();
            }else if(role == 3){
                manager = new frmManager(userId);
                manager.Show();
            }
            this.Hide();                    //隐藏登陆界面
        }

        //取消按钮事件方法
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出登陆吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
                this.Dispose();//关闭窗体
        }

        //窗口关闭按钮事件方法
        /*private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出登陆吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }*/

        public bool loginDB(string sql)
        {
            //使用using语句确保关闭连接（参考[1]）
            using (SqlConnection conn = connDB.SqlHelper.MyConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();                        //建立连接
                    SqlDataReader r = cmd.ExecuteReader();
                    r.Read();
                    if (r.HasRows)                      //检查是否存在这一行数据
                    {
                        r.Close();                      //关闭SqlDataReader方法
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    DialogResult result = MessageBox.Show("当前无法登陆！", "无法登陆", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK) this.Close();
                }
            }
            return false;
        }
    }
}
