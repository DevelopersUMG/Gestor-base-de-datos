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
       
        public String HO = "";
        public String US = "";
        public String CO = "";
        public Inicio(string x,string y,string z)
        {
            US = x;
                CO=y;
                HO = z;
            InitializeComponent();
            lista_multi.SetSelected(0, true);// inicioseleccionando algo
            timer1.Start();
        }



        private void button1_Click(object sender, EventArgs e)
        {
          
            conectartodo();
        }

      


        MySqlConnection conec = new MySqlConnection();
        String connectionString;

        public void conectartodo()
        {



            try
            {
                connectionString = "Server=127.0.0.1; Database=bd_4taluna;Uid=root; Pwd=";
                conec.ConnectionString = connectionString;
                conec.Open();
             
                Console.WriteLine("Conectado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de conexion");
            }

        }




        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB_Examinar x = new TB_Examinar();
            x.Show();
        }



        public void ESTADO() {

            Rutear x = new Rutear();
            try
            {
                connectionString = "Server=" + HO + "; Database=;Uid=" + US + "; Pwd=" + CO + "";
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

        public void MODIFICAR()
        {
            String Tabla = lista_multi.SelectedItem.ToString();
            if (Tabla != "")
            {

                TB_Examinar x = new TB_Examinar();
                x.Asignar(Tabla);
                x.Show();
            }
            else
            {
                lbl_MSJERROR.Text = ("Seleccione una tabla");



            }
        
       }
        public void ELIMINAR() {
            String Tabla = lista_multi.SelectedItem.ToString();
            DialogResult dialogResult = MessageBox.Show("Desea eliminar la tabla: " + Tabla + " de la base de datos?", "Eliminar Tabla", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {



                lista_multi.Items.Remove(Tabla);


            }
            else if (dialogResult == DialogResult.No)
            {
            
            }
        
        }
        public void IniciarGBD()
        {
            this.lbl_BD.Visible = true;
            this.cmb_BD.Visible = true;
            this.btn_SELECCIONARBD.Visible = false;
           lista_multi.Items.Clear();
           RefrescarListamulti();
        }

        public void RefrescarListamulti() {


            lista_multi.Items.Add("Proveedores");
            lista_multi.Items.Add("Clientes");
            lista_multi.Items.Add("Productos");

            lista_multi.SetSelected(0, true);//Posicionar en el primer elemento
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void btn_NUEVATABLA_Click(object sender, EventArgs e)
        {
            TB_Crear x = new TB_Crear();
            x.Show();
          
        }

        private void btn_RELACIONES_Click(object sender, EventArgs e)
        {
            TB_Relacion x = new TB_Relacion();
            x.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
            lbl_MSJERROR.Text=("Coneccion a: "+HO+" con: "+US);
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login x = new Login();
            x.Show();
        }

        private void btn_EXAMINAR_Click(object sender, EventArgs e)
        {
            MODIFICAR();
        }

        private void btn_ELIMINAR_Click(object sender, EventArgs e)
        {
            ELIMINAR();
        }

        private void btn_SELECCIONARBD_Click(object sender, EventArgs e)
        {
            IniciarGBD();
        }

       
      

       

   



    }


}


