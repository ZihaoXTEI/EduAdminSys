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

namespace EduAdminSys.frmMang.classes
{
    public partial class frmTabStu : UserControl
    {
        string sqlStr, sqltb;
        string stuNo;
        DataTable dt = null;
        public frmTabStu()
        {
            InitializeComponent();
            initialiComboxDepart();
            initialiComboxSex();
        }

        private void initialiComboxDepart()
        {
            sqlStr = "SELECT * FROM tbDepart";
            dt = new SqlOperate().BindDataTable(sqlStr, "DEP");
            comboxDepart.DataSource = dt;
            comboxDepart.DisplayMember = "departname";
            comboxDepart.ValueMember = "departno";
        }

        private void initialiComboxSex()
        {
            string[] SEX = { "男", "女" };
            comboxSex1.Items.AddRange(SEX);
            comboxSex1.SelectedIndex = 0;
            comboxSex2.Items.AddRange(SEX);
            comboxSex2.SelectedIndex = 0;
        }

        private void ButDelete_Click(object sender, EventArgs e)
        {
            string stuno;
            if (txtboxStuNo.Text == "")
            {
                MessageBox.Show("请输入学号", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("确定删除这名学生的信息吗，该过程无法恢复？","询问", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;
            stuno = txtboxStuNo.Text;

            //调用删除方法
            if (deleteStudent(stuno))
            {
                MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("删除失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButUpate_Click(object sender, EventArgs e)
        {
            string stuname, sex, birth;
            int age;
            DateTime dt = DateTime.Now;
            if (txtboxStuNo.Text == "")
            {
                MessageBox.Show("请输入学号和其他信息", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("确定修改这名学生的信息吗，该过程无法恢复？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            stuNo = txtboxStuNo.Text;
            stuname = txtboxName1.Text.Trim();
            sex = comboxSex1.SelectedItem.ToString();
            if (sex == "男") sex = "M";
            else sex = "F";
            birth = dtp.Value.ToString("yyyy-MM-dd");                                       //从DateTimePicker中获取日期信息
            age = int.Parse(dt.ToString("yyyy")) - int.Parse(dtp.Value.ToString("yyyy"));   //获取年龄信息
            
            sqltb = "UPDATE tbStudent SET stuname='" + stuname + "',sex='" + sex + "',age="+age.ToString()+",birth='" + birth + "'" +
                " WHERE stuno='" + stuNo + "'";
            if(new SqlOperate().selectNum(sqltb) == 1)
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("修改失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButAddOne_Click(object sender, EventArgs e)
        {
            sqltb = "UPDATE tbStudent SET age=age+1";
            if (new SqlOperate().selectNum(sqltb) == 0)
            {
                MessageBox.Show("遇到未知错误，无法完成该项操作", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("增加成功", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButInsert_Click(object sender, EventArgs e)
        {
            string stuname, sex, birth, departno;
            int age;
            DateTime dt = DateTime.Now;
            if (txtboxNo.Text == "" || txtboxName2.Text=="" || comboxSex2.SelectedItem ==null || dtpInput.Value == null)
            {
                MessageBox.Show("请选择院系，以及输入其他信息", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }           
            stuname = txtboxName2.Text;
            sex = comboxSex2.SelectedItem.ToString();
            if (sex == "男") sex = "M";
            else sex = "F";
            birth = dtpInput.Value.ToString("yyyy-MM-dd");
            departno = comboxDepart.SelectedValue.ToString();
            age = int.Parse(dt.ToString("yyyy")) - int.Parse(dtpInput.Value.ToString("yyyy"));
            stuNo = txtboxNo.Text;
            sqltb = "INSERT INTO tbStudent VALUES('" + stuNo + "','" + stuname + "','" + sex + "','" + departno + "'," + age.ToString() + ",'" + birth + "')";
            //Console.WriteLine(sqltb);
            if (new SqlOperate().selectNum(sqltb) == 1)
            {
                sqltb = "INSERT INTO tbLogin VALUES('" + stuNo + "','000000',1,2)";
                if (new SqlOperate().selectNum(sqltb) == 1)
                {
                    MessageBox.Show("增加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            MessageBox.Show("增加失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButFind_Click(object sender, EventArgs e)
        {
            string sex, departno, birth;
            SqlDataReader dr, dr2;
            if (txtboxStuNo.Text == "")
            {
                MessageBox.Show("请输入学号再按查找按钮", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sqltb = "SELECT * FROM tbStudent WHERE stuno='" + txtboxStuNo.Text.Trim() + "'";
            dr = new SqlOperate().GetRowData(sqltb);
            if (dr.Read() == false)
            {
                MessageBox.Show("未找到该工号的信息，请核对输入的工号是否正确", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                txtboxName1.Text = dr["stuname"].ToString();
                sex = dr["sex"].ToString();
                departno = dr["departno"].ToString();
                if (sex == "F") comboxSex1.SelectedIndex = 1;
                else comboxSex1.SelectedIndex = 0;
                //MessageBox.Show(dr["birth"].ToString(), "调试", MessageBoxButtons.OK);
                dtp.Value = DateTime.ParseExact(Convert.ToDateTime(dr["birth"]).ToString("yyyy-MM-dd"), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                sqltb = "SELECT departname FROM tbDepart WHERE departno='"+ departno + "'";
                dr2 = new SqlOperate().GetRowData(sqltb);
                while (dr2.Read())
                {
                    txtboxDepartName.Text = dr2[0].ToString();
                }
            }

        }

        private void ComboxDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboxDepart.SelectedValue.ToString() == "" || comboxDepart.SelectedValue== null) return;
            string departno = comboxDepart.SelectedValue.ToString();
            //MessageBox.Show(departno, "调试", MessageBoxButtons.OK);
            txtboxNo.Text = new SqlOperate().getLastNo(departno, "tbStudent");

        }

        private bool deleteStudent(string stuno)
        {
            try
            {
                sqltb = "UPDATE tbClass set stunum=stunum-1 WHERE classno IN(SELECT classno FROM tbMark WHERE stuno=" + stuno + "')";
                new SqlOperate().selectNum(sqltb);

                sqltb = "UPDATE tbClass set stunum=stunum-1 WHERE classno IN(SELECT classno FROM tbSelect WHERE stuno=" + stuno + "')";
                new SqlOperate().selectNum(sqltb);

                sqltb = "DELETE FROM tbMark WHERE stuno='" + stuno + "'";
                new SqlOperate().selectNum(sqltb);

                sqltb = "DELETE FROM tbSelect WHERE stuno='" + stuno + "'";
                new SqlOperate().selectNum(sqltb);

                sqltb = "UPDATE tbLogin set state=0 WHERE userid='" + stuno + "'";
                new SqlOperate().selectNum(sqltb);

                sqltb = "DELETE FROM tbStudent WHERE stuno='" + stuno + "'";
                new SqlOperate().selectNum(sqltb);

                return true;
            }
            catch(Exception exce)
            {
                return false;
            }
        }
    }



}
