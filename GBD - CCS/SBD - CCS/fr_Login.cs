using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SBD___CCS
{
    public partial class fr_Login : Form
    {

        ConexionSQL CSQL = new ConexionSQL();
        public fr_Login()
        {
            InitializeComponent();
        }

        private void btn_INGRESAR_Click(object sender, EventArgs e)
        {

            if ((VerificarInicio()) == 1)
            {
                Console.WriteLine("Existe conexion");
                
                fr_Inicio x = new fr_Inicio(tb_Usuario.Text, tb_Contrasena.Text, tb_Host.Text);
                x.Show();
                this.Hide();
            }
            if ((VerificarInicio()) == 0)
            {
                
                Console.WriteLine("Existe conexion");
                
                MessageBox.Show("No existe un servidor de bases de datos disponible", "Error Fatal");


            }
            
           
            
           
            
        }


        public int VerificarInicio()
        {
            int inConectividad = 0;
            try
            {

                CSQL.CONECTAR(tb_Host.Text, "", tb_Usuario.Text, tb_Contrasena.Text);
                CSQL.conectarSQL.Open();

                inConectividad = 1;
                CSQL.conectarSQL.Close();
            }
            catch (MySqlException ex)
            {

                CSQL.conectarSQL.Close();
                inConectividad = 0;
            }
            return inConectividad;
        }

      
      
    }
}
