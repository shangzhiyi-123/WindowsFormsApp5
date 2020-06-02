using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp5
{
    class DB
    {
        private const string CONNECTION_STRING = "Data Source=DESKTOP-O4UJ4O1;Initial Catalog=MySchool;Trusted_Connection=SSPI";
        public SqlDataReader GetSqlDataReader(string sql)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
