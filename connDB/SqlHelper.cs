using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EduAdminSys.connDB
{
    class SqlHelper
    {
        static private string conString = "server=localhost;uid=xtei;pwd=2019;database=mydb";
        //SqlConnection conn = new SqlConnection(conString);

        public static SqlConnection MyConnection()
        {
            return new SqlConnection(conString);
        }
    }

}
