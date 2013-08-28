using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace SBD___CCS
{
    public class ConexionSQL
    {

        public MySqlConnection conectarSQL = new MySqlConnection();
        public String connectionString;

        public DataSet ds;  //JP

        public string txConexGlobal = "Server=localhost;Uid=root;Port=3306";  //JP

        public MySqlConnection cnn;  //JP
        
        
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
    
         /*--------------------------------------------
           Nombre:         Mostrar
           Autor:          Jaime Pérez
           fecha:          18ago2013
           Detalle:        Permite gestionar la conexión en la BD
           Modificación:   implementación inicial
            * 
           //--------------------------------------*/

        public void mostrar(string sql) //version2
        {
            cnn = new MySqlConnection(txConexGlobal);
            try
            {
                //cnn = new MySqlConnection(cnx);
                cnn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, cnn);
                ds = new DataSet();
                da.Fill(ds);
                cnn.Close();
            }
            catch (MySqlException Msq)
            {
                MessageBox.Show("Error de Base de datos\n" + Msq.ErrorCode.ToString() + "\n" + Msq.Message, "Error de SQL");
                Application.Exit();
            }
        }
        }
    }

