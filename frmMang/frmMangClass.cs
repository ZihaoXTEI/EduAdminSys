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
    public partial class frmMangClass : UserControl
    {
        private string sqlStr, sqltb;
        private string classno, departno;
        public frmMangClass()
        {
            InitializeComponent();
            Recovery();
            initiComboxTeachNo();
        }

        private void TbClassBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClassBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sQLDataSet);

        }


        private void Recovery()
        {
            sqlStr = "SELECT * FROM tbClass";
            new SqlOperate().BindDataGridView(dgvMangClass, sqlStr);
        }

        private void RadbutLess15_CheckedChanged(object sender, EventArgs e)
        {
            Recovery();
            sqltb = " WHERE stunum<15";
            new SqlOperate().BindDataGridView(dgvMangClass, sqlStr + sqltb);
        }

        private void RadbutRecovery_CheckedChanged(object sender, EventArgs e)
        {
            Recovery();
        }

        private void RadbutNULL_CheckedChanged(object sender, EventArgs e)
        {
            Recovery();
            sqltb = " WHERE teachno IS NULL";
            new SqlOperate().BindDataGridView(dgvMangClass, sqlStr + sqltb);
        }

        private void ButUpate_Click(object sender, EventArgs e)
        {
            //Recovery();
            if(label.Text =="" || txtboxClassno.Text=="" || comboxTeachNo.SelectedValue == null)
            {
                MessageBox.Show("请在信息表中选择相应的班级名称", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string teachno = comboxTeachNo.SelectedValue.ToString();
            sqlStr = " UPDATE tbClass SET teachno='" + teachno + "' WHERE classno='" + classno + "'";
            if (new SqlOperate().selectNum(sqlStr) == 0)
            {
                MessageBox.Show("修改失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



        }

        private void ButClassOpen_Click(object sender, EventArgs e)
        {
            //Recovery();
            if (label.Text == "" || txtboxClassno.Text == "" || comboxTeachNo.SelectedValue == null)
            {
                MessageBox.Show("请在信息表中选择相应的班级名称", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sqlStr = " UPDATE tbClass SET states=1 WHERE stunum>=15 AND classno='" + classno + "'";
            if (new SqlOperate().selectNum(sqlStr) == 0)
            {
                MessageBox.Show("设置失败，人数未达到开课要求", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sqlStr = " UPDATE tbSelect SET states=2 WHERE classno='" + classno + "'";
            if (new SqlOperate().selectNum(sqlStr) == 0)
            {
                MessageBox.Show("设置失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //回滚操作
                sqlStr = " UPDATE tbClass SET states=3 WHERE stunum>=15 AND classno='" + classno + "'";
                new SqlOperate().selectNum(sqlStr);
                return;
            }
            MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
            
        }

        private void ButClassSele_Click(object sender, EventArgs e)
        {
            if (label.Text == "" || txtboxClassno.Text == "" || comboxTeachNo.SelectedValue == null)
            {
                MessageBox.Show("请在信息表中选择相应的班级名称", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sqlStr = " UPDATE tbClass SET states=3，teachno=NULL,stunum=0 WHERE classno='" + classno + "'";
            if (new SqlOperate().selectNum(sqlStr) == 0)
            {
                MessageBox.Show("修改失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (txtboxClassname.Text == "" || txtboxClassno.Text == "")
            {
                MessageBox.Show("请在信息表中选择相应的班级", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sqlStr = " UPDATE tbClass SET states=2 WHERE classno='" + classno + "'";
            if (new SqlOperate().selectNum(sqlStr) == 0)
            {
                MessageBox.Show("修改失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            sqlStr= " UPDATE tbSelect SET states=3 WHERE classno='" + classno + "'";
            if (new SqlOperate().selectNum(sqlStr) == 0)
            {
                MessageBox.Show("修改失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            
        }

        private void ButAllClassSele_Click(object sender, EventArgs e)
        {
            sqlStr = " UPDATE tbClass SET states=3，teachno=NULL,stunum=0";
            if (new SqlOperate().selectNum(sqlStr) == 0)
            {
                MessageBox.Show("修改失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void ButAllClassOpen_Click(object sender, EventArgs e)
        {
            sqlStr = " UPDATE tbClass SET states=1 WHERE stunum>=15 AND teachno IS NOT NULL";
            if (new SqlOperate().selectNum(sqlStr) == 0)
            {
                MessageBox.Show("修改失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sqlStr = " UPDATE tbSelect SET states=2 WHERE classno IN(SELECT classno FROM tbClass WHERE states=1)";
            if (new SqlOperate().selectNum(sqlStr) == 0)
            {
                MessageBox.Show("修改失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //回滚操作
                sqlStr = " UPDATE tbClass SET states=3 WHERE stunum>=15 AND teachno IS NOT NULL";
                new SqlOperate().selectNum(sqlStr);
                return;
            }
            MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
            
        }

        private void ButDeleteTeachNo_Click(object sender, EventArgs e)
        {
            sqlStr = " UPDATE tbClass SET teachno=NULL";
            if (new SqlOperate().selectNum(sqlStr) == 0)
            {
                MessageBox.Show("修改失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void ButDeleteStunum_Click(object sender, EventArgs e)
        {
            sqlStr = " UPDATE tbClass SET stunum=0";
            if (new SqlOperate().selectNum(sqlStr) == 0)
            {
                MessageBox.Show("修改失败,将学生人数置0失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sqlStr = "DELETE FROM tbSelect";
            if (new SqlOperate().selectNum(sqlStr) == 0)
            {
                MessageBox.Show("修改失败，无法删除tbSelect表中信息，或表中内容已为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        private void DgvMangClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            try
            {
                //获得当前行的第0列的值 
                txtboxClassno.Text = dgvMangClass.Rows[rowindex].Cells[0].Value.ToString();
                classno = txtboxClassno.Text;
                //获得当前行的第1列的值 
                txtboxClassname.Text = dgvMangClass.Rows[rowindex].Cells[1].Value.ToString();
                //获得当前行的第6列的值 
                departno = dgvMangClass.Rows[rowindex].Cells[6].Value.ToString();

                string sqlstr = "SELECT teachno FROM tbTeach WHERE departno='" + departno + "'";
                //Console.WriteLine(sqlstr);
                if (comboxTeachNo.Items.Count > 0)
                {
                    comboxTeachNo.DataSource = null;
                    comboxTeachNo.Items.Clear();
                }

                DataTable dt = new SqlOperate().BindDataTable(sqlstr, "TNOD");
                comboxTeachNo.DataSource = dt;
                comboxTeachNo.DisplayMember = "teachno";
                comboxTeachNo.ValueMember = "teachno";

            }
            catch (Exception ex) { }
        }

        private void initiComboxTeachNo()
        {
            if (comboxTeachNo.Items.Count > 0)
            {
                comboxTeachNo.DataSource = null;
                comboxTeachNo.Items.Clear();
            }

            string sqlstr = "SELECT teachno FROM tbTeach";
            DataTable dt = new SqlOperate().BindDataTable(sqlstr, "TNO");
            comboxTeachNo.DataSource = dt;
            comboxTeachNo.DisplayMember = "teachno";
            comboxTeachNo.ValueMember = "teachno";
        }
    }
}
