using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace EduAdminSys.connDB
{
    class SqlOperate
    {
        private SqlConnection conn = connDB.SqlHelper.MyConnection();

        //执行各种Sql语句，返回成功的条数
        public int selectNum(string selectSql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectSql, conn);
                int i = (int)cmd.ExecuteNonQuery();  //返回成功的条数
                //Console.WriteLine(i);
                conn.Close();
                return i;

            }
            catch (Exception ex)
            { return -1; }
        }

        //查找指定数据表的人数
        public int HumanNum(string statiSql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(statiSql, conn);
                //int i= (int)cmd.ExecuteScalar();
                int i = int.Parse(cmd.ExecuteScalar().ToString());
                conn.Close();
                return i;
            }
            catch (Exception ex)
            {
                return 0; }
        }

        //绑定DataGridView控件
        public void BindDataGridView(DataGridView dgv, string sql)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            ds.Dispose();
            conn.Close();
        }

        //获取数据源
        public DataTable BindDataTable(string sqlstr,string tableName)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlstr, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, tableName);   //columeName指定表名
            DataTable dt = ds.Tables[tableName];
            conn.Close();
            return dt;
        }

        //获取一行数据
        public SqlDataReader GetRowData(string sqlstr)
        {
            conn.Open();
            SqlCommand command = new SqlCommand(sqlstr, conn);
            SqlDataReader read = command.ExecuteReader();
            return read;
        }


        //存储tbMark表
        public bool setTBMark(string sqlstr)
        {
            string insertSql, markno, temp;
            int num = 0;
            List<string> classnos = new List<string>();
            List<string> stunos = new List<string>();
            SqlCommand cmd = null;
            SqlDataAdapter sda = new SqlDataAdapter(sqlstr, conn);
            conn.Open();
            DataSet ds = new DataSet();
            sda.Fill(ds, "tbselect");            //columeName指定表名
            DataTable dt = ds.Tables["tbselect"];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                stunos.Add(dt.Rows[i][0].ToString());
                classnos.Add(dt.Rows[i][1].ToString());
            }
            
            try
            {
                for (int i = 0; i < stunos.Count; i++) {
                    temp = stunos[i];
                    if (!temp.Equals(stunos[i]))
                    {
                        num = 1;
                    }
                    else { num++; }
                    markno = stunos[i].Substring(8) + num.ToString("0000");
                    insertSql = "INSERT INTO tbMark VALUES('" + markno + "','" + stunos[i] + "','" + classnos[i] + "',0,-1)";
                    //Console.WriteLine(insertSql);
                    cmd = new SqlCommand(insertSql, conn);
                    cmd.ExecuteNonQuery();


                }
            }catch(Exception exx)
            {
                return false;
            }
            return true;
        }


        //返回编号最后一个值并且+1
        public string getLastNo(string departno,string tbname)
        {
            string No = "";
            string sqltb = "SELECT * FROM " + tbname + " WHERE departno='" + departno + "'";
            //Console.WriteLine(sqltb);
            try{
                SqlDataReader dr = new SqlOperate().GetRowData(sqltb);
                while (dr.Read())
                {
                    No = dr[0].ToString();
                }
                //Console.WriteLine(No+"----");
                return (long.Parse(No) + 1).ToString();
            }catch(Exception e)
            {
                return null;
            }
        }



    }
}
