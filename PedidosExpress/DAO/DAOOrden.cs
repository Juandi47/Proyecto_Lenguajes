﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using System.Data.SqlClient;

namespace DAO
{
    public class DAOOrden
    {

        SqlConnection conexion = new SqlConnection(DAO.Properties.Settings.Default.ConnectionString);
        string query;



    }
}
