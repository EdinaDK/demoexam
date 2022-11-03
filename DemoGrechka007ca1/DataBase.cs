using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DemoGrechka007ca1
{
    internal  class DataBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=DBSRV\DEMO;Initial Catalog=ewqrew; Integrated Security=True");

            public void openConnection()
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            public void closeConnection()
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }

            }
            public SqlConnection getConnection()
            {
                return con;
            }


    }
}
