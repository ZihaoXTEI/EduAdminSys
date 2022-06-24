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
    public partial class frmStudMark : UserControl
    {
        private static string stuno="";
        string sqlStr = "";

        public frmStudMark(string stuNo)
        {
            InitializeComponent();
            stuno = stuNo;
            Recovery();
        }

        private void TbMarkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbMarkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sQLDataSet);

        }

        private void ButEnter1_Click(object sender, EventArgs e)
        {
            string str="";
            Recovery();
            if (chkboxPass.Checked == true)
            {
                if (chkboxBukao.Checked == true)
                {
                    str = " AND mark>60 AND bukao>60";
                }
                else
                {
                    str = " AND mark>60";
                }              
            }
            else
            {
                if (chkboxBukao.Checked == true)
                {
                    str = " AND bukao>0";
                }
                else
                {
                    MessageBox.Show("请选择相应的选项", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            sqlStr = sqlStr + str;
            new SqlOperate().BindDataGridView(dgvStuMark, sqlStr);

        }

        private void ButCancel2_Click(object sender, EventArgs e)
        {
            Recovery();
        }


        private void Recovery()
        {
            /*参考SQL语句
            string ssqlStr = "SELECT tbCourse.courseno,coursename,tbMark.mark,tbMark.bukao,tbCourse.credit,departname,tbTeach.teachname " +
                "FROM tbCourse, tbMark, tbDepart, tbTeach, tbClass " +
                "WHERE tbCourse.courseno=tbClass.courseno AND tbClass.classno= tbMark.classno " +
                 "AND tbClass.departno=tbDepart.departno " +
                "AND tbTeach.teachno=tbClass.teachno AND tbMark.stuno= '" + stuno + "'";*/
            sqlStr = "SELECT courseno,coursename,mark,bukao,credit,departname,teachname FROM STCCD WHERE stuno= '" + stuno + "'";
            new SqlOperate().BindDataGridView(dgvStuMark, sqlStr);
        }

        private void ButEnter2_Click(object sender, EventArgs e)
        {
            string str = "";
            Recovery();
            if (radbutExcellent.Checked == true)
            {
                str = " AND mark>=90";
            }
            else if (radbutGood.Checked == true)
            {
                str = " AND mark BETWEEN 80 AND 89";
            }
            else if (radbutPass.Checked == true)
            {
                str = " AND mark BETWEEN 60 AND 79";
            }
            else if (radbutFail.Checked == true)
            {
                str = " AND mark <60";
            }
            else
            {
                MessageBox.Show("请选择相应的选项", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sqlStr = sqlStr + str;
            new SqlOperate().BindDataGridView(dgvStuMark, sqlStr);

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Recovery();
            sqlStr = sqlStr + "ORDER BY Mark ASC";
            new SqlOperate().BindDataGridView(dgvStuMark, sqlStr);
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Recovery();
            sqlStr = sqlStr + "ORDER BY Mark DESC";
            new SqlOperate().BindDataGridView(dgvStuMark, sqlStr);
        }
    }
}
