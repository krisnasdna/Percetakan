﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percetakan
{
    internal class Koneksi
    {
        private static string connString;
        public static SqlConnection sqlConn;

        public static void buka()
        {
            connString = @"data source=(localdb)\percetakan; initial catalog=percetakan; integrated security = true";

            sqlConn = new SqlConnection(connString);
            if (sqlConn.State == System.Data.ConnectionState.Closed)
            {
                sqlConn.Open();
            }
        }

        public static void tutup()
        {
            if (sqlConn.State == System.Data.ConnectionState.Open)
            {
                sqlConn.Close();
            }
        }
    }
}
