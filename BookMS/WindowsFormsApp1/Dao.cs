﻿using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            string str = @"Data Source=LAPTOP-5290VHVE;Initial Catalog = BookDB ; Intergrated Security = True";
             sc = new SqlConnection(str);
            sc.Open();
            return sc;
        }
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }
        public int Execute (string sql)
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }
        public void DaoClose()
        {
            sc.Close();
        }
    }
}
