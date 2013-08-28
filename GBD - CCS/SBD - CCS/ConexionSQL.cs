using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace SBD___CCS
{
    public class ConexionSQL
    {

        public MySqlConnection conectarSQL = new MySqlConnection();
        public String connectionString;
        
        
        public void CONECTAR(string HO,string BD,string US,string CO) { 
        
        
        try
            {
                connectionString = "Server=" + HO + "; Database="+BD+";Uid=" + US + "; Pwd=" + CO + "";
                conectarSQL.ConnectionString = connectionString;
            }
        catch (MySqlException ex)
        {
           
        }
        }
    }
}
