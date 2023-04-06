﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestock.DAL
{
    public class conexao
    {
        SqlConnection con = new SqlConnection();
            public conexao()
        {
            con.ConnectionString = @"Data Source=FNAC;Initial Catalog=""Projeto Gestock"";Integrated Security=True";
        }
        public SqlConnection conectar()
        {
            if(con.State== System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
