using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduAdminSys.frmMang.classes;
using EduAdminSys.connDB;

namespace EduAdminSys.frmMang
{
    public partial class frmInforQuery : UserControl
    {
        //private string[] comboxText = new[] { "院系信息","教师信息","学生信息","成绩成绩","课程信息" };
        //private string[] comboxValue = new[] {"tbDepart","tbTeach","tbStudent","tbMark","tbCourse" };
        public string sqltb = "";
        private string sql = "SELECT * FROM ";
        private string sqlStr = "";

        public frmInforQuery(string sqltb)
        {
            InitializeComponent();
            sqlStr = sql + sqltb;
            comboxChoiceTable.DataSource = new SqlOperate().BindDataTable(sqlStr,"depart");
            comboxChoiceTable.DisplayMember = "departno";
            comboxChoiceTable.ValueMember = "departno";
            new SqlOperate().BindDataGridView(dgv, sqlStr);

        }

        private void ButEnter_Click(object sender, EventArgs e)
        {
            if (comboxChoiceTable.SelectedValue != null)
            {
                string selItem = comboxChoiceTable.SelectedValue.ToString();
                sqlStr = sql + "tbDepart WHERE departno='" + selItem + "'";
                new SqlOperate().BindDataGridView(dgv, sqlStr);
            }
        }

        private void ButRecovery_Click(object sender, EventArgs e)
        {
            sqlStr = "SELECT * FROM tbDepart";
            new SqlOperate().BindDataGridView(dgv, sqlStr);
        }
    }
}
