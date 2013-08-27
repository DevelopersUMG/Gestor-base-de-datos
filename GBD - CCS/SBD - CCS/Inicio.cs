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

        public String stHost = "";
        public String stBase_de_datos = "";
        public String stUsuario = "";
        public String stContrasena = "";



        ConexionSQL CSQL = new ConexionSQL();


        public Inicio(string stx, string sty, string stz)
        {
            stUsuario = stx;
            stContrasena = sty;
            stHost = stz;

            InitializeComponent();
            lt_Multi_funcion.SetSelected(0, true);
            tm_Estado_BD.Start();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB_Examinar obX = new TB_Examinar();
            obX.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            VerificarEstado();
        }

        private void btn_NUEVATABLA_Click(object sender, EventArgs e)
        {
            TB_Crear obX = new TB_Crear();
            obX.Show();
        }

        private void btn_RELACIONES_Click(object sender, EventArgs e)
        {
            TB_Relacion obX = new TB_Relacion(stHost, stBase_de_datos, stUsuario, stContrasena);
            obX.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lb_Mensaje_error.Text = ("Coneccion a: " + stHost + " con: " + stUsuario);
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login obX = new Login();
            obX.Show();
        }

        private void btn_EXAMINAR_Click(object sender, EventArgs e)
        {
            ExaminarTabla();
        }

        private void btn_ELIMINAR_Click(object sender, EventArgs e)
        {
            EliminarTabla();
        }


        private void btn_EJECUTAR_Click(object sender, EventArgs e)
        {

        }

        private void btn_SELECCIONARBD_Click(object sender, EventArgs e)
        {

        }

        private void lista_multi_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btn_INICIOBD_Click(object sender, EventArgs e)
        {

        }

        private void cb_BD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        /***************************************************************
        NOMBRE:             VerificarEstado
        FECHA:              21-08-2013 
        CREADOR:            Enrique Magnani
        DESCRIPCIÓN         Verificar el estado actual de la BD y lo despliega en la barra inferior
        DETALLE:            Proceso ejecutado por un hijo
        MODIFICACIÓN:       25-08-2013
        ***************************************************************/
        public void VerificarEstado()
        {
            Rutear obX = new Rutear();
            try
            {
                CSQL.CONECTAR(stHost, stBase_de_datos, stUsuario, stContrasena);
                CSQL.conectarSQL.Open();
                pb_Estado.Image = Image.FromFile(obX.RUTA("yc", ".png", "IMG"));
                tm_Estado_BD.Interval = (1000);
                CSQL.conectarSQL.Close();
            }
            catch (MySqlException ex)
            {
                pb_Estado.Image = Image.FromFile(obX.RUTA("nc", ".png", "IMG"));
                tm_Estado_BD.Interval = (5000);
                CSQL.conectarSQL.Close();
            }
        }


        public void ExaminarTabla()
        {
            String Tabla = lt_Multi_funcion.SelectedItem.ToString();
            if (Tabla != "")
            {

                TB_Examinar obX = new TB_Examinar();
                obX.Asignar(Tabla);
                obX.Show();
            }
            else
            {
                lb_Mensaje_error.Text = ("Seleccione una tabla");



            }

        }

        /***************************************************************
        NOMBRE:             EliminarTabla
        FECHA:              17-08-2013 
        CREADOR:            Enrique Magnani
        DESCRIPCIÓN         Realiza la manipulacion de consola en SQL directamente
        DETALLE:            Trabaja por Parametros
        MODIFICACIÓN:       
        ***************************************************************/
        public void EliminarTabla()
        {
            string stTabla = lt_Multi_funcion.SelectedItem.ToString();
            DialogResult dialogResult = MessageBox.Show("Desea eliminar la tabla: " + stTabla + " de la base de datos?", "Eliminar Tabla", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {



                lt_Multi_funcion.Items.Remove(stTabla);


            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }







    }


}


