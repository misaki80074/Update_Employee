using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace updateEmployee
{
    internal class Employee
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        string connString {  get; set; }

        public Employee(string connStr)
        {
            connString = connStr;

            conn = new SqlConnection(connStr);
            cmd = new SqlCommand();
            adapter = new SqlDataAdapter();
        }

        public DataTable Select(string sqlText)
        {
            cmd.CommandText = sqlText;
            cmd.Connection = conn;
            adapter.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
