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
    public partial class frmInforQuerySelCou : UserControl
    {
        public string sqltb = "";
        private string sql = "SELECT * FROM ";
        private string sqlStr = "";
        DataTable dt = null;
        public frmInforQuerySelCou(string sqltb)
        {
            InitializeComponent();
            sqlStr = sql + sqltb;
            new SqlOperate().BindDataGridView(dgvselect, sqlStr);
            //Console.WriteLine(sqlStr);
            initicomboxDepart();

        }

        private void ButCheck_Click(object sender, EventArgs e)
        {
            if(radbutClass.Checked==true && txtboxCheck.Text != null)
            {
                sqlStr=sql+"tbSelect,tbClass WHERE tbSelect.classno=tbClass.classno AND tbClass.classname LIKE '"
                    + txtboxCheck.Text + "'";
            }
            else if(radbutStuNo.Checked==true && txtboxCheck.Text != null)
            {
                sqlStr = sql + "tbSelect WHERE stuno LIKE '" + txtboxCheck.Text + "'";
            }
            else if(radbutTeachNo.Checked==true && txtboxCheck.Text != null)
            {
                sqlStr = sql + "tbSelect WHERE classno IN(SELECT classno FROM tbClass WHERE teachno LIKE '" 
                    + txtboxCheck.Text + "')";
            }
            else
            {
                MessageBox.Show("请选择相应的选项和输入值", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //MessageBox.Show(sqlStr, "调试", MessageBoxButtons.OK);
            new SqlOperate().BindDataGridView(dgvselect, sqlStr);

        }

        private void initicomboxDepart()
        {
            sqlStr = "SELECT * FROM tbDepart ";
            dt = new SqlOperate().BindDataTable(sqlStr, "DEP");
            comboxDepart.DataSource = dt;
            comboxDepart.DisplayMember = "departname";
            comboxDepart.ValueMember = "departno";
        }

        private void ButScreen_Click(object sender, EventArgs e)
        {
            if (comboxDepart.SelectedValue == null) return;
            sqlStr = sql + "tbSelect WHERE classno IN(SELECT classno FROM tbClass WHERE departno='" 
                + comboxDepart.SelectedValue.ToString() + "')";

            //MessageBox.Show(sqlStr, "调试", MessageBoxButtons.OK);
            new SqlOperate().BindDataGridView(dgvselect, sqlStr);


        }

        private void ButRecovery_Click(object sender, EventArgs e)
        {
            sqlStr = "SELECT * FROM tbSelect";
            new SqlOperate().BindDataGridView(dgvselect, sqlStr);
        }
    }
}
