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

namespace EduAdminSys.frmTeach
{
    public partial class frmTeachPersInfor : UserControl
    {
        private static string teachno;
        private string sqlStr;
        public frmTeachPersInfor(string teachNo)
        {
            InitializeComponent();
            teachno = teachNo;
            teachPerInfor();

        }

        private void teachPerInfor()
        {
            string sex, departname = "";
            sqlStr = "SELECT * FROM tbTeach WHERE teachno='" + teachno + "'";
            SqlDataReader dr = new SqlOperate().GetRowData(sqlStr);
            while (dr.Read())
            {
                txtboxId.Text = dr[0].ToString();
                txtboxName.Text = dr[1].ToString();
                txtboxTitle.Text = dr[4].ToString();
                txtboxAge.Text = dr[5].ToString();
                txtboxBirth.Text = dr[6].ToString();
                txtboxSalary.Text = dr[7].ToString();

                sex = dr[2].ToString();
                if (sex == "M") sex = "男";
                else sex = "女";
                txtboxSex.Text = sex;
                departname = dr[3].ToString();
            }
            sqlStr = "SELECT * FROM tbDepart WHERE departno='" + departname + "'";
            dr = new SqlOperate().GetRowData(sqlStr);
            //MessageBox.Show(sqlStr, "调试", MessageBoxButtons.OK);
            while (dr.Read())
            {
                txtboxDepart.Text = dr[1].ToString();
            }
        }

    }
}
