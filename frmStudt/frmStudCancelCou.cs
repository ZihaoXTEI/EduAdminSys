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

namespace EduAdminSys.frmStudt
{
    public partial class frmStudCancelCou : UserControl
    {
        private string stuno,sqlStr = "";
        public frmStudCancelCou(String stuNo)
        {
            InitializeComponent();
            this.stuno = stuNo;
        }

        private void FrmStudCancelCou_Load(object sender, EventArgs e)
        {
            sqlStr = "SELECT classno,classname,credit,couhour,coutype,departname FROM Class_DetailedInfor_View WHERE classno IN(" +
                "SELECT classno FROM tbSelect WHERE states=3 AND stuno='" + stuno + "')";
            new SqlOperate().BindDataGridView(dgvCanCou, sqlStr);
        }
    }
}
