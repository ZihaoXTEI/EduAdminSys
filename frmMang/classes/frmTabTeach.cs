using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EduAdminSys.connDB;

namespace EduAdminSys.frmMang.classes
{
    public partial class frmTabTeach : UserControl
    {
        string sqlStr, sqltb;
        string teachNo;
        DataTable dt = null;
        public frmTabTeach()
        {
            InitializeComponent();
            initialiComboxDepart();
            initialiComboxTitle();
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

        private void initialiComboxTitle()
        {
            string[] TITLE = { "讲师", "教授" ,"副教授"};
            comboxTitle1.Items.AddRange(TITLE);
            comboxTitle1.SelectedIndex = 0;
            comboxTitle2.Items.AddRange(TITLE);
            comboxTitle2.SelectedIndex = 0;
        }


        private void ButFind_Click(object sender, EventArgs e)
        {
            string sex, departno,title;
            SqlDataReader dr, dr2;
            if (txtboxTeachNo.Text == "")
            {
                MessageBox.Show("请输入工号再按查找按钮", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sqltb = "SELECT * FROM tbTeach WHERE teachno='" + txtboxTeachNo.Text.Trim() + "'";
            dr = new SqlOperate().GetRowData(sqltb);
            if (dr.Read() == false)
            {
                MessageBox.Show("未找到该工号的信息，请核对输入的工号是否正确", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                txtboxName1.Text = dr["teachname"].ToString();
                txtboxSalary.Text = dr["salary"].ToString();
                sex = dr["sex"].ToString();
                departno = dr["departno"].ToString();
                title = dr["title"].ToString();
                if (sex == "F") comboxSex1.SelectedIndex = 1;
                else comboxSex1.SelectedIndex = 0;
                if (title == "教授") comboxTitle1.SelectedIndex = 1;
                else if (title == "副教授") comboxTitle1.SelectedIndex = 2;
                else comboxTitle1.SelectedIndex = 0;
                //MessageBox.Show(dr["birth"].ToString(), "调试", MessageBoxButtons.OK);
                dtp.Value = DateTime.ParseExact(Convert.ToDateTime(dr["birth"]).ToString("yyyy-MM-dd"), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                sqltb = "SELECT departname FROM tbDepart WHERE departno='" + departno + "'";
                dr2 = new SqlOperate().GetRowData(sqltb);
                while (dr2.Read())
                {
                    txtboxDepartName.Text = dr2[0].ToString();
                }
            }

        }

        private void ButAddOne_Click_1(object sender, EventArgs e)
        {
            sqltb = "UPDATE tbTeach SET age=age+1";
            if (new SqlOperate().selectNum(sqltb) == -1)
            {
                MessageBox.Show("遇到未知错误，无法完成该项操作", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("增加成功", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButUpate_Click_1(object sender, EventArgs e)
        {
            string teachname, sex, birth, salary, title;
            int age;
            DateTime dt = DateTime.Now;
            if (txtboxTeachNo.Text == "")
            {
                MessageBox.Show("请输入工号和其他信息", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("确定修改这名教师的信息吗，该过程无法恢复？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            teachNo = txtboxTeachNo.Text;
            teachname = txtboxName1.Text.Trim();
            sex = comboxSex1.SelectedItem.ToString();
            if (sex == "男") sex = "M";
            else sex = "F";
            birth = dtp.Value.ToString("yyyy-MM-dd");                                       //从DateTimePicker中获取日期信息
            age = int.Parse(dt.ToString("yyyy")) - int.Parse(dtp.Value.ToString("yyyy"));   //获取年龄信息
            salary = txtboxSalary.Text;
            title = comboxTitle1.SelectedItem.ToString();
            sqltb = "UPDATE tbTeach SET teachname='" + teachname + "',sex='" + sex + "',birth='" + birth + "'," +
                "age="+age.ToString()+",salary="+salary+",title='"+title+"' WHERE teachno='" + teachNo + "'";
            if (new SqlOperate().selectNum(sqltb) == 1)
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("修改失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButInsert_Click_1(object sender, EventArgs e)
        {
            string teachname, sex, birth, departno, salary, title;
            int age;
            DateTime dt = DateTime.Now;
            if (txtboxNo.Text == "" || txtboxName2.Text == "" || comboxSex2.SelectedItem == null || dtpInput.Value == null)
            {
                MessageBox.Show("请输入工号和其他信息", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            teachname = txtboxName2.Text;
            sex = comboxSex2.SelectedItem.ToString();
            if (sex == "男") sex = "M";
            else sex = "F";
            birth = dtpInput.Value.ToString("yyyy-MM-dd");
            departno = comboxDepart.SelectedValue.ToString();
            age = int.Parse(dt.ToString("yyyy")) - int.Parse(dtpInput.Value.ToString("yyyy"));
            salary = txtboxSalary2.Text;
            title = comboxTitle2.SelectedItem.ToString();
            teachNo = txtboxNo.Text;

            sqltb = "INSERT INTO tbTeach VALUES('" + teachNo + "','" + teachname + "','" + sex + "','" + departno + "','" + title + "'," + age.ToString() + ",'" + birth + "'," + salary + ")";

            Console.WriteLine(sqltb);
            if (new SqlOperate().selectNum(sqltb) == 1)
            {
                sqltb = "INSERT INTO tbLogin VALUES('" + teachNo + "','000000',1,1)";
                if (new SqlOperate().selectNum(sqltb) == 1)
                {
                    MessageBox.Show("增加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            MessageBox.Show("增加失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ButDelete_Click_1(object sender, EventArgs e)
        {
            string teachno;
            if (txtboxTeachNo.Text == "")
            {
                MessageBox.Show("请输入工号", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("确定删除这名教师的信息吗，该过程无法恢复？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;
            teachno = txtboxTeachNo.Text;

            //调用删除方法
            if (deleteTeacher(teachno))
            {
                MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("删除失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboxDepart_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string no;
            DateTime dt = DateTime.Now;

            if (comboxDepart.SelectedValue.ToString() == "" || comboxDepart.SelectedValue == null) return;
            string departno = comboxDepart.SelectedValue.ToString();
            //MessageBox.Show(departno, "调试", MessageBoxButtons.OK);
            no = new SqlOperate().getLastNo(departno, "tbTeach");
            if (no == null) return;
            txtboxNo.Text = dt.ToString("yyyy")+no.Substring(4);
        }

        private bool deleteTeacher(string teachno)
        {
            try
            {

                sqltb = "UPDATE tbClass SET teachno=NULL' WHERE teachno='" + teachno + "'";
                new SqlOperate().selectNum(sqltb);

                sqltb = "UPDATE tbLogin set state=0 WHERE userid='" + teachno + "'";
                new SqlOperate().selectNum(sqltb);


                sqltb = "DELETE FROM tbTeach WHERE teachno='" + teachno + "'";
                new SqlOperate().selectNum(sqltb);



                return true;
            }
            catch (Exception exce)
            {
                return false;
            }
        }
    }
}
