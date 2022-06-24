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

namespace EduAdminSys.frmStudt
{
    public partial class frmStudPersInfor : UserControl
    {
        private static string stuno;
        private string sqlStr;
        public frmStudPersInfor(string stuNo)
        {
            InitializeComponent();
            stuno = stuNo;
            stuPerInfor();
            stuStuInfor();
        }

        private void stuPerInfor()
        {
            string sex, departname="";
            sqlStr = "SELECT * FROM tbStudent WHERE stuno='" + stuno + "'";
            SqlDataReader dr = new SqlOperate().GetRowData(sqlStr);
            while (dr.Read())
            {
                //绑定textbox控件为学生表数据
                txtboxNo.Text = dr["stuno"].ToString();
                txtboxName.Text = dr["stuname"].ToString();
                txtboxAge.Text = dr["age"].ToString();
                txtboxBirth.Text = dr["birth"].ToString();
                sex = dr["sex"].ToString();
                if (sex == "M") sex = "男";
                else sex = "女";
                txtboxSex.Text = sex;
                departname = dr["departno"].ToString();
            }
            sqlStr = "SELECT * FROM tbDepart WHERE departno='" + departname + "'";
            //MessageBox.Show(sqlStr, "调试", MessageBoxButtons.OK);
            dr = new SqlOperate().GetRowData(sqlStr);
            while (dr.Read())
            {
                txtboxDepart.Text = dr["departname"].ToString();
            }
        }

        private void stuStuInfor()
        {
            sqlStr = "SELECT * FROM Stu_Stati_View WHERE stuno='" + stuno + "'";
            SqlDataReader dr = new SqlOperate().GetRowData(sqlStr);
            while (dr.Read())
            {              
                txtboxCredit.Text = dr["totalcredit"].ToString();
                txtboxCourses.Text = dr["coursenum"].ToString();
            }

            sqlStr = "SELECT * FROM Stu_PassCourse_View WHERE stuno='" + stuno + "'";
            dr = new SqlOperate().GetRowData(sqlStr);
            while (dr.Read())
            {
                txtboxPass.Text = dr["coursenum"].ToString();
                txtboxFinishCredit.Text = dr["totalcredit"].ToString();
            }

            sqlStr = "SELECT * FROM Stu_FailCourse_View WHERE stuno='" + stuno + "'";
            dr = new SqlOperate().GetRowData(sqlStr);
            while (dr.Read())
            {
                txtboxUnPass.Text = dr["coursenum"].ToString();
            }
        }
    }
}
