using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CrearBDSQLITE;
using MySql.Data.MySqlClient;
using System.Resources;
using ArchivoRuta;


namespace SBD___CCS
{
    public partial class Inicio : Form
    {
       // public String BD = "";
        public String HO = "";
        public String US = "";
        public String CO = "";
        public Inicio(string x,string y,string z)
        {
            US = x;
                CO=y;
                HO = z;
            InitializeComponent();
            listBox1.SetSelected(0, true);// inicioseleccionando algo
            timer1.Start();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //string nombre = textBox1.Text;
            // CrearBDX x = new CrearBDX();
            //x.CrearBD(textBox1.Text);
            conectartodo();
        }

        // Declaramos las variables:


        MySqlConnection conec = new MySqlConnection();
        String connectionString;

        public void conectartodo()
        {



            try
            {
                connectionString = "Server=127.0.0.1; Database=bd_4taluna;Uid=root; Pwd=";
                conec.ConnectionString = connectionString;
                conec.Open();
                /* CadenaDeConexion = "Server=localhost;"
                                + "Port=3307;"
                                + "Database=mysql_ifxperu;"
                                + "Uid=root;"
                                + "Password=";*/
                // Conectar();
                Console.WriteLine("Conectado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de conexion");
            }

        }




        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLgrafico x = new SQLgrafico();
            x.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MODIFICAR();
         
        }




        public void MODIFICAR()
        {
            String Casa = listBox1.SelectedItem.ToString();
            if (Casa != "")
            {

                SQLgrafico x = new SQLgrafico();
                x.Asignar(Casa);
                x.Show();
            }
            else
            {
                lbl_MSJERROR.Text = ("Seleccione una tabla");



            }
        
       }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Rutear x = new Rutear();
            try
            {
                connectionString = "Server="+HO+"; Database=;Uid="+US+"; Pwd="+CO+"";
                conec.ConnectionString = connectionString;
                conec.Open();
                pct_SIGNAL.Image = Image.FromFile(x.RUTA("conect", ".png", "IMG"));
                conec.Close();
            }
            catch (MySqlException ex)
            {
                pct_SIGNAL.Image = Image.FromFile(x.RUTA("noconect", ".png", "IMG"));
                conec.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
  //beta jajajaj :D       //FormACerrar newform = (FormACerrar)Application.OpenForms["Form…
//newform.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
        






    }


}


