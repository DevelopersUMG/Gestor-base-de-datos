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
using System.Data.SQLite;
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

        int inEstadoIns = 0;  //verificar estado de transacción: 0:navegación 1=inserción, 2=edición JP
        int inFilaAct;  //controla la fila actual JP

        ConexionSQL CSQL = new ConexionSQL();


        public Inicio(string stx, string sty, string stz)
        {
            stUsuario = stx;
            stContrasena = sty;
            stHost = stz;
            string sentencia="Inicio de sesion";
            InitializeComponent();
            lt_Multi_funcion.SetSelected(0, true);
            tm_Estado_BD.Start();
            RegistroDeActividadEnBitacora(stUsuario, sentencia);
            CargarBasesDeDatos();
        }

        /*--------------------------------------------
         Nombre:         Regresar formato a fila
         Autor:          Jaime Pérez
         fecha:          22ago2013
         Detalle:        vuelve el formato de la fila normal
         Modificación:   implementación inicial
          * 
         //--------------------------------------*/
        public void RegresarFormatoFila()//int inTipo_transac)
        {
            this.dgTabla.CurrentRow.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgTabla.CurrentRow.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
        }

        /*--------------------------------------------
         Nombre:         Manejar DML 
         Autor:          Jaime Pérez
         fecha:          20ago2013
         Detalle:        permitirá manejar las transacciones realizadas con los datagrid
         Modificación:   implementación inicial
          * 
        //--------------------------------------*/
        public void ManejarDML()//int inTipo_transac)
        {
            int inColumnas = dgTabla.ColumnCount;
            string stSQLins1;
            string stSQLins2;

            //MessageBox.Show("columns: "+inColumnas);
            switch (inEstadoIns)
            {
                case 0:
                    break;
                case 1: //inserta filas
                    stSQLins1 = "insert into " + lt_Multi_funcion.Text + "(" + dgTabla.Columns[0].HeaderText;
                    stSQLins2 = " values('" + dgTabla.CurrentRow.Cells[0].Value;

                    for (int inCont = 1; inCont < inColumnas; inCont++)
                    {
                        stSQLins1 += ", " + dgTabla.Columns[inCont].HeaderText;
                        stSQLins2 += "', '" + dgTabla.CurrentRow.Cells[inCont].Value;
                    }

                    stSQLins1 += ") ";
                    stSQLins2 += "')";
                    inEstadoIns = 0;
                    MessageBox.Show("Resultado: " + stSQLins1 + "\n" + stSQLins2);

                    // dgDatos.txConexGlobal = "Server=localhost;Database=" + this.cmb_BD.Text + ";Uid=root;Port=3306";

                    CSQL.mostrar(stSQLins1 + " " + stSQLins2, stHost, stBase_de_datos, stUsuario, stContrasena);
                    RegresarFormatoFila();
                    break;

                case 2:  //actualiza registros
                    stSQLins1 = "update " + lt_Multi_funcion.Text + " set " + dgTabla.Columns[0].HeaderText + " = '" + dgTabla.CurrentRow.Cells[0].Value + "'";

                    for (int inCont = 1; inCont < inColumnas; inCont++)
                    {
                        stSQLins1 += ", " + dgTabla.Columns[inCont].HeaderText + " = '" + dgTabla.CurrentRow.Cells[inCont].Value + "'";

                    }

                    stSQLins1 += " where " + dgTabla.Columns[0].HeaderText + " = '" + dgTabla.CurrentRow.Cells[0].Value + "'";

                    inEstadoIns = 0;
                    MessageBox.Show("Resultado: " + stSQLins1);

                    // dgDatos.txConexGlobal = "Server=localhost;Database=" + this.cmb_BD.Text + ";Uid=root;Port=3306";

                    CSQL.mostrar(stSQLins1, stHost, stBase_de_datos, stUsuario, stContrasena);

                    RegresarFormatoFila();

                    break;

                case 3:
                    stSQLins1 = "delete from " + lt_Multi_funcion.Text + " where " + dgTabla.Columns[0].HeaderText + " = '" + dgTabla.CurrentRow.Cells[0].Value + "'"; ;
                    MessageBox.Show(stSQLins1);
                    CSQL.mostrar(stSQLins1, stHost, stBase_de_datos, stUsuario, stContrasena);
                    RegresarFormatoFila();
                    break;

                default:
                    MessageBox.Show("Error de Operación SQL.\nNo es posible determinar el tipo de transacción");
                    break;
            }


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

            this.dgTabla.AutoResizeColumnHeadersHeight();


            try
            {
                CSQL.mostrar("show databases", stHost, stBase_de_datos, stUsuario, stContrasena);
                cb_BD.DataSource = CSQL.ds.Tables[0].DefaultView;

                cb_BD.ValueMember = CSQL.ds.Tables[0].Columns[0].ColumnName;
                cb_BD.ResetText();

                cb_BD.Show();
                cb_BD.Text = "";


            }
            catch (MySqlException Msq)  //captura errores de SQL JP
            {
                MessageBox.Show("Error de consulta\n" + Msq.ErrorCode.ToString(), "Error de SQL");
                Application.Exit();
            }

            catch (Exception Exc) //Captura errores en la aplicación JP
            {
                MessageBox.Show("Error de aplicación\n" + Exc.Message, "Error de aplicación");
                Application.Exit();
            }
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
            tb_Resultados.Text = ("");
            EjecutarConsolaSQL(tb_Consola_query.Text);
        }

        private void btn_SELECCIONARBD_Click(object sender, EventArgs e)
        {
            IniciarGestor();
        }

        private void btn_INICIOBD_Click(object sender, EventArgs e)
        {
            CargarBasesDeDatos();
        }

        private void cb_BD_SelectedIndexChanged(object sender, EventArgs e)
        {
         // stBase_de_datos = cb_BD.Text;
         // CargarTablas();
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
            CSQL.conectarSQL.Close();
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
        NOMBRE:             RegistroDeActividadEnBitacora
        FECHA:		        05-09-2013
        CREADOR:     	    Zayda Hernandez          
        DESCRIPCIÓN         
        DETALLE:            
        MODIFICACIÓN:       
        ***************************************************************/
        public void RegistroDeActividadEnBitacora(string usuario, string sentencia)
        {
            String archivobd;
            archivobd = "C:/Users/Zayda/Dropbox/CCS - ADST/Bitacora/Bitacora";
            string insercion;
            string consulta;
            int idb;
            int ANUM=0;
            SQLiteCommand sntc;
            SQLiteCommand snt;
            SQLiteConnection conexion;
            SQLiteDataReader datos;
            conexion = new SQLiteConnection("Data Source=" + archivobd + ".sqlite;Version=3;New=False;Compress=True;");
            conexion.Open();
                        
            try
            {
                consulta = "SELECT * FROM BITACORA;";
                sntc = new SQLiteCommand(consulta, conexion);
                datos = sntc.ExecuteReader();
                Console.WriteLine("UInicio de qhile");
                while (datos.Read())
                {

                    idb = Convert.ToInt32(datos[0]);
                    Console.WriteLine("----------------<<<< dcsdfcsdcf>>>>" + idb);
                    while (ANUM <= idb)
                    {
                        if (ANUM < idb)
                        {
                            ANUM = idb;
                            
                        }
                        ANUM++;
                    }
                }

                insercion = "INSERT INTO BITACORA VALUES  (" + ANUM + ",'" + usuario + "',datetime('now','localtime'),'" + sentencia + "');";
                Console.WriteLine("Query ejecutado: " + insercion);
                snt=new SQLiteCommand(insercion,conexion);
                snt.ExecuteNonQuery();
                
            }

            catch (Exception e)
            {
                MessageBox.Show("No se ha podido registrar cambio en Bitacora", "Aviso");
            }
            
            CSQL.conectarSQL.Close();
        }

        /***************************************************************
        NOMBRE:             CargarBasesDeDatos
        FECHA:		    24-08-2013
        CREADOR:     	    Zayda Hernandez          
        DESCRIPCIÓN         Es utilizado para cargar las Bases de Datos a diferentes componentes
        DETALLE:            Verifica que componente se desea actualizar. multiusos
        MODIFICACIÓN:       
        ***************************************************************/
        public void CargarBasesDeDatos()
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

                    cb_BD.Items.Clear();
                

                while (reader.Read())
                {

                        cb_BD.Items.Add(reader.GetString(0));
                   
                    inControl_b = 1;
                }
               
                    if (inControl_b == 1)
                    {
                        lt_Multi_funcion.SetSelected(0, true);
                    }
                    else
                    {
                        lt_Multi_funcion.Items.Add("No existen Bases de Datos");
                        inControl_b = 0;
                    }

                    RegistroDeActividadEnBitacora(stUsuario, stCadena);
            }

            catch (MySqlException ex)
            {
                tb_Resultados.Text = ("Error de sintaxis" + "\n" + ex);
                CSQL.conectarSQL.Close();
            }

            CSQL.conectarSQL.Close();
            this.cb_BD.SelectedIndex++;
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
                RegistroDeActividadEnBitacora(stUsuario, stCadena);
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


                String stValor_tabla = lt_Multi_funcion.SelectedItem.ToString();
                stBase_de_datos = ""; stBase_de_datos = stBase_de_datos + stValor_tabla;
                inControl_tabla_multi = 1;
                lt_Multi_funcion.Items.Clear();
                CargarBasesDeDatos();
                CargarTablas();

        }

        /***************************************************************
         NOMBRE:             EjecutarConsolaSQL
         FECHA:		         25-08-2013
         CREADOR:     	     Mario Godoy
         DESCRIPCIÓN         Realiza la manipulacion de consola en SQL directamente
         DETALLE:            Trabaja por Parametros
         MODIFICACIÓN:       
         ***************************************************************/
        public void EjecutarConsolaSQL(string cadena)
        {


            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = cadena;
                string[] vector = cadena.Split(' ');

                CSQL.CONECTAR(stHost, stBase_de_datos, stUsuario, stContrasena);
                CSQL.conectarSQL.Open();
                cmd.Connection = CSQL.conectarSQL;

                if ((vector[0] == "select") || (vector[0] == "show"))
                {

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string select = "";
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            select = select + (reader.GetString(i)) + "\t";
                        }

                        tb_Resultados.AppendText(select + "\n");
                    }

                }



                if ((vector[0] == "insert"))
                {
                    tb_Resultados.Text = ("Insercion realizada con exito");
                    cmd.ExecuteNonQuery();
                }
                if ((vector[0] == "alter"))
                {
                    tb_Resultados.Text = ("modificacion realizada con exito");
                    cmd.ExecuteNonQuery();
                }
                if ((vector[0] == "create"))
                {
                    tb_Resultados.Text = ("Tabla creada con exito");
                    cmd.ExecuteNonQuery();
                }

                if ((vector[0] == "delete"))
                {
                    tb_Resultados.Text = ("Eliminacion realizada con exito");
                    cmd.ExecuteNonQuery();
                }
                if ((vector[0] == "update"))
                {
                    tb_Resultados.Text = ("modificacion realizada con exito");
                    cmd.ExecuteNonQuery();
                }

                if ((vector[0] == "drop"))
                {
                    tb_Resultados.Text = ("Eliminacion realizada con exito");
                    cmd.ExecuteNonQuery();
                }

                CSQL.conectarSQL.Close();
                RegistroDeActividadEnBitacora(stUsuario, cadena);
            }
            catch (MySqlException ex)
            {
                tb_Resultados.Text = ("Error de sintaxis" + "\n" + ex);
                CSQL.conectarSQL.Close();
            }
        }

        private void cb_BD_SelectedValueChanged(object sender, EventArgs e)
        {
            CSQL.conectarSQL.Close();
            stBase_de_datos = this.cb_BD.Text;
            if (cb_BD.Visible)
            {lt_Multi_funcion.Enabled = true;
                CSQL.txConexGlobal = "Server=" + stHost +";Database=" + this.cb_BD.Text + ";Uid=" +stUsuario+";Port=3306";

                CSQL.mostrar("Show tables", stHost, this.cb_BD.Text, stUsuario, stContrasena);
              
                lt_Multi_funcion.DataSource = CSQL.ds.Tables[0].DefaultView;

                lt_Multi_funcion.ValueMember = CSQL.ds.Tables[0].Columns[0].ColumnName;
                RegistroDeActividadEnBitacora(stUsuario, "Show tables;");
            }
        }
        
        /*--------------------------------------------
           Nombre:         Cambio en valor de lista de tablas
           Autor:          Jaime Pérez
           fecha:          18ago2013
           Detalle:        permitirá cambiar a DML y llenar el dataGrid al seleccionar una tabla
           Modificación:   Aislamiento de codigo division del mismo
            * 
        //--------------------------------------*/
        public void LlenarDatagrid(string stSQL)
        {
            CSQL.mostrar(stSQL, stHost, this.cb_BD.Text, stUsuario, stContrasena); //enviar consulta a clase común
              dgTabla.DataSource = CSQL.ds.Tables[0]; //llenar datagrid

              this.ta_Consola_SQL.SelectedIndex = 2;  //cambiar a DML JP
                this.lbTituloTabla.Text = "Contenido de tabla " + lt_Multi_funcion.Text; //colocar nombre de tabla en título JP
             this.dgTabla.AutoResizeColumns(); //coloca el tamaño adecuado para lectura
        }
        
        private void lt_Multi_funcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cb_BD.Visible && lt_Multi_funcion.Enabled)
            {
              
                CSQL.txConexGlobal = "Server="+stHost +";Database=" + this.cb_BD.Text + ";Uid=" + stUsuario +";Port=3306"; //string de conexion

                string stSQL = "Select * from " + lt_Multi_funcion.Text; //string de consulta
                Console.WriteLine("SQL: "+stSQL);
                //LlenarDatagrid(stSQL);
            }

        }

        private void dgTabla_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (inEstadoIns == 0)
            {
                inEstadoIns = 2;
                this.dgTabla.CurrentRow.DefaultCellStyle.BackColor = System.Drawing.Color.LightSalmon;
                this.dgTabla.CurrentRow.DefaultCellStyle.ForeColor = System.Drawing.Color.Maroon;
                inFilaAct = this.dgTabla.CurrentRow.Index;
            }
        }

        private void dgTabla_CancelRowEdit(object sender, QuestionEventArgs e)
        {
            inEstadoIns = 0;
        }
        
        private void dgTabla_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (this.dgTabla.FirstDisplayedScrollingRowIndex >= 0)
            {
                if (MessageBox.Show("Está a punto de eliminar una fila\n¿Desea Continuar?", "Eliminación -quitando-", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    e.Cancel = true;
                else
                {
                    inEstadoIns = 3;
                    ManejarDML();
                    inEstadoIns = 0;
                }

            }
        }

        private void dgTabla_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dgTabla.IsCurrentRowDirty)
            {
                this.dgTabla.NotifyCurrentCellDirty(true);
                this.dgTabla.EndEdit();
                ManejarDML();
                inEstadoIns = 0;
                inFilaAct = this.dgTabla.CurrentRow.Index;

            }
        }

        private void dgTabla_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            if (dgTabla.IsCurrentRowDirty)
            {
                inEstadoIns = 1;

                this.dgTabla.CurrentRow.DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
                this.dgTabla.CurrentRow.DefaultCellStyle.ForeColor = System.Drawing.Color.Tomato;
            }

        }

        private void dgTabla_UserDeletingRow_1(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (this.dgTabla.FirstDisplayedScrollingRowIndex >= 0)
            {
                if (MessageBox.Show("Está a punto de eliminar una fila\n¿Desea Continuar?", "Eliminación -quitando-", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    e.Cancel = true;
                else
                {
                    inEstadoIns = 3;
                    ManejarDML();
                    inEstadoIns = 0;
                }

            }
        }

        private void dgTabla_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgTabla.IsCurrentRowDirty)
                this.dgTabla.NotifyCurrentCellDirty(true);
        }
  
    }
    
}


