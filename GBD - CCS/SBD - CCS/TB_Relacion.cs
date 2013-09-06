﻿using System;
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
    public partial class TB_Relacion : Form
    {
        public String stHost = "";
        public String stBase_de_datos = "";
        public String stUsuario = "";
        public String stContrasena = "";

        int inA = 0;//1 iniciado//2
        int inB = 0;
        int inControl_c = 0;
        int inControl_t = 0;
        public String stAlter1 = "";
        ConexionSQL CSQL = new ConexionSQL();


        public TB_Relacion(string H,string B,string U,string C)
        {
            InitializeComponent();
            AsignarBase(H,B,U,C);
        }
        
        private void TB_Relacion_Load(object sender, EventArgs e)
        {
            CargarTablas();
        }

        private void btn_AB_Click(object sender, EventArgs e)
        {
            CargarCampos(2, cb_B.Text);
            CrearRelacion(1, cb_A.Text, cb_B.Text, lt_A.SelectedItem.ToString());
            CargarCampos(1, cb_A.Text);
            EjecutarRelacionSQL(cb_B.Text, lt_A.SelectedItem.ToString(), cb_A.Text, 2);
            VerificarEstadodelquery();
        }

        private void btn_BA_Click(object sender, EventArgs e)
        {
            CargarCampos(1, cb_A.Text);
            CrearRelacion(2, cb_B.Text, cb_A.Text, lt_B.SelectedItem.ToString());
            CargarCampos(2, cb_B.Text);
            EjecutarRelacionSQL(cb_A.Text, lt_B.SelectedItem.ToString(), cb_B.Text, 1);
            VerificarEstadodelquery();
        }

        private void cmb_A_SelectedIndexChanged(object sender, EventArgs e)
        {
            CSQL.conectarSQL.Close();
            CargarCampos(1, cb_A.Text);
            CargarCampos(2, cb_B.Text);
            tb_Query.Clear();
            VerificarEstadodelquery();
        }

        private void cmb_B_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CSQL.conectarSQL.Close();
            CargarCampos(1, cb_A.Text);
            CargarCampos(2, cb_B.Text);
            tb_Query.Clear();
            VerificarEstadodelquery();
        }

        public void AsignarBase(string H, string B, string U, string C)
        {
            stHost = ""; stBase_de_datos = ""; stUsuario = ""; stContrasena = "";
            stHost = H; stBase_de_datos = B; stUsuario = U; stContrasena = C;
        }

        /***************************************************************
        NOMBRE:             VerificarPrimaryKey
        FECHA:              
        CREADOR:            
        DESCRIPCIÓN         
        DETALLE:            
        MODIFICACIÓN:       
        ***************************************************************/
        public int VerificarPrimaryKey(string st_Tabla_destino)
        {
            int x = 0;

            string stCadena = "select * from " + st_Tabla_destino + ";";
            try
            {
                CSQL.CONECTAR(stHost, stBase_de_datos, stUsuario, stContrasena);
                CSQL.conectarSQL.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = stCadena;
               
                cmd.Connection = CSQL.conectarSQL;
               
                    Console.WriteLine("SHOW TABLES");

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                       
                    }

            }

            catch (MySqlException ex)
            {
                CSQL.conectarSQL.Close();
            }

            CSQL.conectarSQL.Close();
            return x;
        }

        /***************************************************************
        NOMBRE:             CrearRelacion
        FECHA:              
        CREADOR:            
        DESCRIPCIÓN         
        DETALLE:            
        MODIFICACIÓN:       
        ***************************************************************/
        public void CrearRelacion(int inOpc, string st_Tabla_origen, string st_Tabla_destino, string stForeingkey)
        {
            // validaciones pendientes no exista ya la relacion
            int f = (VerificarPrimaryKey(st_Tabla_destino));



                string stCadena = "";
                stCadena = "ALTER TABLE " + (st_Tabla_destino) + " ADD CONSTRAINT ADST FOREIGN KEY (" + stForeingkey + ") REFERENCES " + st_Tabla_origen + " (" + stForeingkey + ");";
                tb_Query.Text = (stCadena);
                
                try
                {
                    CSQL.CONECTAR(stHost, stBase_de_datos, stUsuario, stContrasena);
                CSQL.conectarSQL.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = stCadena;
                string[] vector = stCadena.Split(' ');
                cmd.Connection = CSQL.conectarSQL;
                // cmd.ExecuteNonQuery();

               
                CSQL.conectarSQL.Close();

                }
                catch (MySqlException ex)
                {
                // txt_RESULTADOS.Text = ("Error de sintaxis" + "\n" + ex);
                CSQL.conectarSQL.Close();
                }
                switch (inOpc)
                {
                    case 1:
                        lt_B.Items.Add(lt_A.SelectedItem.ToString());
                        lb_A.Text = ("1");
                        lb_B.Text = ("n");
                        break;
                    case 2:
                        lt_A.Items.Add(lt_B.SelectedItem.ToString());
                        lb_A.Text = ("n");
                        lb_B.Text = ("1");
                        break;
                }


        }

        /***************************************************************
        NOMBRE:             CargarCampos
        FECHA:              05-09-2013
        CREADOR:            Enrique Magnani            
        DESCRIPCIÓN         
        DETALLE:            
        MODIFICACIÓN:       
        ***************************************************************/
        public void CargarCampos(int inOpc, string stTabla)
        {
            string stCadena = "describe " + stTabla + ";";
            try
            {
                CSQL.CONECTAR(stHost, stBase_de_datos, stUsuario, stContrasena);
                CSQL.conectarSQL.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = stCadena;
               
                cmd.Connection = CSQL.conectarSQL;
               
                   
                    MySqlDataReader reader = cmd.ExecuteReader();

                    switch (inOpc)
                    {
                        case 1: lt_A.Items.Clear();
                            inA = 1;
                            break;
                        case 2: lt_B.Items.Clear();
                            inB = 1;
                            break;
                    }
                    
                while (reader.Read())
                    {
                        switch (inOpc)
                        {
                            case 1: lt_A.Items.Add(reader.GetString(0));
                                break;
                            case 2: lt_B.Items.Add(reader.GetString(0));
                                break;
                        }
                        inControl_c = 1;
                    }
                if (inControl_c == 1)
                    {
                        switch (inOpc)
                        {
                            case 1: lt_A.SetSelected(0, true);
                                break;
                            case 2: lt_B.SetSelected(0, true);
                                break;
                        }
                        inControl_c = 0;
                    }
                    else
                    {
                        switch (inOpc)
                        {
                            case 1: lt_A.SetSelected(0, true);
                                cb_A.Items.Add("No existen Campos");
                                break;
                            case 2: lt_B.SetSelected(0, true);
                                cb_B.Items.Add("No existen Campos");
                                break;
                        }
                        inControl_c = 0;
                    }
            }
            catch (MySqlException ex)
            {
                 CSQL.conectarSQL.Close();
            }
            CSQL.conectarSQL.Close();
        }

        /***************************************************************
        NOMBRE:             CargarTablas
        FECHA:              23-08-2013
        CREADOR:            Enrique Magnani
        DESCRIPCIÓN         Carga tablas en los combobox
        DETALLE:            Su funcion es de suma importancia
        MODIFICACIÓN:       
        ***************************************************************/
        public void CargarTablas()
        {

            string stCadena = "show tables;";
            try
            {
                CSQL.CONECTAR(stHost, stBase_de_datos, stUsuario, stContrasena);
                CSQL.conectarSQL.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = stCadena;
               
                cmd.Connection = CSQL.conectarSQL;
               


                    MySqlDataReader reader = cmd.ExecuteReader();
              
                            cb_A.Items.Clear();
                            cb_B.Items.Clear();
                

                    while (reader.Read())
                    {

                       
                                cb_A.Items.Add(reader.GetString(0));
                                cb_B.Items.Add(reader.GetString(0));


                                inControl_t = 1;
                    }
                    if (inControl_t == 1)
                    {

                      
                        this.cb_A.SelectedIndex++;
                        this.cb_B.SelectedIndex++;



                        inControl_t = 0;
                    }
                    else
                    {
                        cb_A.Items.Add("No existen Tablas");
                        cb_B.Items.Add("No existen Tablas");
                        this.cb_A.SelectedIndex++;
                        this.cb_B.SelectedIndex++;

                        inControl_t = 0;
                    }

                
            }

            catch (MySqlException ex)
            {
                 CSQL.conectarSQL.Close();
            }
            
            CSQL.conectarSQL.Close();
        }


        /***************************************************************
        NOMBRE:             VerificarDatos
        FECHA:              05-09-2013
        CREADOR:            Enrique Magnani            
        DESCRIPCIÓN         
        DETALLE:            
        MODIFICACIÓN:       
        ***************************************************************/
        public string VerificarDatos(string stquery2, string stprimarykey)
        {
            string stDatos = "";

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = stquery2;
                string[] vector = stquery2.Split(' ');

                CSQL.CONECTAR(stHost, stBase_de_datos, stUsuario, stContrasena);
                CSQL.conectarSQL.Open();
                cmd.Connection = CSQL.conectarSQL;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString(0) == stprimarykey)
                    {
                        stDatos = stDatos + reader.GetString(0) + " " + reader.GetString(1) + "    NOT NULL;";
                        //Console.WriteLine("Query: " + stDatos);


                    }
                }
            }
            catch (MySqlException ex)
            {
                // tb_Resultados.Text = ("Error de sintaxis" + "\n" + ex);
                CSQL.conectarSQL.Close();
            }
            return stDatos;
        }

        /***************************************************************
        NOMBRE:             EjecutarRelacionSQL
        FECHA:              04-09-2013
        CREADOR:            Enrique Magnani            
        DESCRIPCIÓN         
        DETALLE:            
        MODIFICACIÓN:       
        ***************************************************************/
        public void EjecutarRelacionSQL(string sttablaB, string stllaveforanea, string sttablaA, int inOp)
        {

            string stquery = "DESCRIBE ";
            stquery = stquery + sttablaB;

            string stquery2 = "DESCRIBE ";
            stquery2 = stquery2 + sttablaA;
            string stDatos = "ALTER TABLE " + sttablaB + " ADD ";
            stDatos = stDatos + (VerificarDatos(stquery2, stllaveforanea));
            stAlter1 = "";
            stAlter1 = stAlter1 + stDatos;
            CSQL.conectarSQL.Close();
            //Console.WriteLine("SQL/ "+stDatos);
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = stquery;
                string[] vector = stquery.Split(' ');

                CSQL.CONECTAR(stHost, stBase_de_datos, stUsuario, stContrasena);
                CSQL.conectarSQL.Open();
                cmd.Connection = CSQL.conectarSQL;





                if ((vector[0] == "DESCRIBE") || (vector[0] == "show"))
                {

                    MySqlDataReader reader = cmd.ExecuteReader();
                    //Console.WriteLine("PRUEBA: ");
                    int inRelacion = 0;
                    while (reader.Read())
                    {
                        // string select = "";
                        if ((reader.GetString(0) == stllaveforanea) && (sttablaB != sttablaA))
                        {
                            tb_Query.Clear();
                            tb_Query.AppendText("Ya existe la relacion");
                            inRelacion = 1;
                        }
                        //select = select + (reader.GetString(1)) + "\t";



                    }
                    if (inRelacion == 1)
                    {
                        // Console.WriteLine("Ya existe la relacion");
                        CargarCampos(inOp, sttablaB);//sttablaA,int inOp
                    }

                }
            }
            catch (MySqlException ex)
            {
                // tb_Resultados.Text = ("Error de sintaxis" + "\n" + ex);
                CSQL.conectarSQL.Close();
            }
        }

        /***************************************************************
        NOMBRE:             VerificarEstadodelquery
        FECHA:              04-09-2013
        CREADOR:            Enrique Magnani            
        DESCRIPCIÓN         
        DETALLE:            
        MODIFICACIÓN:       
        ***************************************************************/
        public void VerificarEstadodelquery()
        {

            if ((tb_Query.Text == "Ya existe la relacion") || (tb_Query.Text == ""))
            {
                bt_Ejecutar.Enabled = false;
            }
            else
            {
                bt_Ejecutar.Enabled = true;
            }
        }
        public void EjecutarQuery()
        {
            string stB = (tb_Query.Text);
            string stC = stAlter1;

            Console.WriteLine("SQL/ " + stC);
            Console.WriteLine("SQL/ " + stB);
            CSQL.conectarSQL.Close();
            try
            {
                CSQL.CONECTAR(stHost, stBase_de_datos, stUsuario, stContrasena);
                CSQL.conectarSQL.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = stC;
                cmd.Connection = CSQL.conectarSQL;

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandText = stB;
                cmd2.Connection = CSQL.conectarSQL;


                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                CSQL.conectarSQL.Close();
                MessageBox.Show("COn exito", "Realizado con exito");

            }
            catch (MySqlException ex)
            {
                CSQL.conectarSQL.Close();
            }



        }

        private void lt_B_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_Ejecutar_Click(object sender, EventArgs e)
        {
            EjecutarQuery();
        }

      
      

      

 


        

       
     

        
       
      

        
    }
}
