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

        int inControl_tabla_multi = 0;
        int inControl_b = 0;
        int inControl_t = 0;

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
            CargarBasesDeDatos(0);
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
            IniciarGestor();
        }

        private void lista_multi_DoubleClick(object sender, EventArgs e)
        {
            IniciarGestor();
        }

        private void btn_INICIOBD_Click(object sender, EventArgs e)
        {
            this.lb_BD.Visible = false;
            this.cb_BD.Visible = false;
            this.bt_Seleccionar_BD.Visible = true;
            inControl_tabla_multi = 0;
            CargarBasesDeDatos(0);
        }

        private void cb_BD_SelectedIndexChanged(object sender, EventArgs e)
        {
            stBase_de_datos = cb_BD.Text;
            CargarTablas();
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

        /***************************************************************
        NOMBRE:             CargarBasesDeDatos
        FECHA:		    24-08-2013
        CREADOR:     	    Zayda Hernandez          
        DESCRIPCIÓN         Es utilizado para cargar las Bases de Datos a diferentes componentes
        DETALLE:            Verifica que componente se desea actualizar. multiusos
        MODIFICACIÓN:       
        ***************************************************************/
        public void CargarBasesDeDatos(int inC)
        {

            string stCadena = "show databases;";
            try
            {
                CSQL.CONECTAR(stHost, stBase_de_datos, stUsuario, stContrasena);
                CSQL.conectarSQL.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = stCadena;
                string[] vector = stCadena.Split(' ');
                cmd.Connection = CSQL.conectarSQL;

                MySqlDataReader reader = cmd.ExecuteReader();
                if (inC == 0)
                {
                    lt_Multi_funcion.Items.Clear();
                }
                if (inC == 1)
                {
                    cb_BD.Items.Clear();
                }

                while (reader.Read())
                {
                    if (inC == 0)
                    {
                        lt_Multi_funcion.Items.Add(reader.GetString(0));
                    }
                    if (inC == 1)
                    {
                        cb_BD.Items.Add(reader.GetString(0));
                    }
                    inControl_b = 1;
                }
                if (inC == 0)
                {
                    if (inControl_b == 1)
                    {
                        lt_Multi_funcion.SetSelected(0, true);
                    }
                    else
                    {
                        lt_Multi_funcion.Items.Add("No existen Bases de Datos");
                        inControl_b = 0;
                    }
                }

            }

            catch (MySqlException ex)
            {
                tb_Resultados.Text = ("Error de sintaxis" + "\n" + ex);
                CSQL.conectarSQL.Close();
            }

            CSQL.conectarSQL.Close();
        }

        /***************************************************************
        NOMBRE:             CargarTablas          
        FECHA:		    24-08-2013
        CREADOR:     	    Zayda Hernandez          
        DESCRIPCIÓN         Carga el listado de la base de datos seleccionada
        DETALLE:            Se despliega en un componente espefico
        MODIFICACIÓN:       
        ***************************************************************/
        public void CargarTablas()
        {

            string stCadena = "show tables;";
            try
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = stCadena;
                string[] vector = stCadena.Split(' ');

                CSQL.CONECTAR(stHost, stBase_de_datos, stUsuario, stContrasena);
                CSQL.conectarSQL.Open();
                cmd.Connection = CSQL.conectarSQL;

                if ((vector[0] == "show"))
                {

                    MySqlDataReader reader = cmd.ExecuteReader();
                    lt_Multi_funcion.Items.Clear();

                    while (reader.Read())
                    {
                        lt_Multi_funcion.Items.Add(reader.GetString(0));
                        inControl_t = 1;
                    }
                    if (inControl_t == 1)
                    {
                        lt_Multi_funcion.SetSelected(0, true);
                        inControl_t = 0;
                    }
                    else
                    {
                        lt_Multi_funcion.Items.Add("No existen Tablas");
                        inControl_t = 0;
                    }

                }
            }

            catch (MySqlException ex)
            {
                tb_Resultados.Text = ("Error de sintaxis" + "\n" + ex);
                CSQL.conectarSQL.Close();
            }

            CSQL.conectarSQL.Close();
        }



        /***************************************************************
        NOMBRE:             IniciarGestor
        FECHA:		    26-08-2013
        CREADOR:     	    Zayda Hernandez      
        DESCRIPCIÓN         Inicia el Gestor de 
        DETALLE:            Al primer click BD y al segundo Tablas
        MODIFICACIÓN:       
        ***************************************************************/
        public void IniciarGestor()
        {
            if ((inControl_tabla_multi == 0) && (inControl_b == 1))
            {

                String stValor_tabla = lt_Multi_funcion.SelectedItem.ToString();
                stBase_de_datos = ""; stBase_de_datos = stBase_de_datos + stValor_tabla;
                inControl_tabla_multi = 1;
                this.lb_BD.Visible = true;
                this.cb_BD.Visible = true;
                this.bt_Seleccionar_BD.Visible = false;
                lt_Multi_funcion.Items.Clear();
                CargarBasesDeDatos(1);
                CargarTablas();
            }
            if (inControl_tabla_multi == 1)// Es una tabla
            {


            }
        }





    }


}


