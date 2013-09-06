using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Resources;
using ArchivoRuta;
using RegistroEnBitacora;


namespace SBD___CCS
{
    public partial class fr_Inicio : Form
    {
        clBitacorax obBitacora = new clBitacorax();
        int inControl_tabla_multi = 0;
        int inControl_b = 0;
        int inControl_t = 0;

        public String stHost = "";
        public String stBase_de_datos = "";
        public String stUsuario = "";
        public String stContrasena = "";


        int inA = 0;//1 iniciado//2
        int inB = 0;
        int inControl_c = 0;
        public String stAlter1 = "";
        int inEstadoIns = 0;  //verificar estado de transacción: 0:navegación 1=inserción, 2=edición JP
        int inFilaAct;  //controla la fila actual JP

        ConexionSQL CSQL = new ConexionSQL();


        public fr_Inicio(string stx, string sty, string stz)
        {
            stUsuario = stx;
            stContrasena = sty;
            stHost = stz;
            string sentencia = "Inicio de sesion";
            InitializeComponent();
            lt_Multi_funcion.SetSelected(0, true);
            tm_Estado_BD.Start();
            obBitacora.RegistroDeActividadEnBitacora(stUsuario, sentencia);
            CargarBasesDeDatos();
            CargarTablasR();
            cb_Tipo.SelectedIndex++;
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



        private void timer1_Tick(object sender, EventArgs e)
        {
            VerificarEstado();
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
            fr_Login obX = new fr_Login();
            obX.Show();
        }



        private void btn_ELIMINAR_Click(object sender, EventArgs e)
        {//



            ///
            //EliminarTabla(lt_Multi_funcion.SelectedItem.ToString());
            DataRowView rowView = lt_Multi_funcion.SelectedItem as DataRowView;
            string x = rowView.ToString();
            Console.WriteLine("VARIABLE: " + x);
            if (null == rowView)
            {
                return;
            }

            rowView.Row.Delete();
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

        }

        private void bt_AB_Click(object sender, EventArgs e)
        {
            CargarCampos(2, cb_B.Text);
            CrearRelacion(1, cb_A.Text, cb_B.Text, lt_A.SelectedItem.ToString());
            CargarCampos(1, cb_A.Text);
            EjecutarRelacionSQL(cb_B.Text, lt_A.SelectedItem.ToString(), cb_A.Text, 2);
            VerificarEstadodelquery();
        }

        private void bt_BA_Click(object sender, EventArgs e)
        {
            CargarCampos(1, cb_A.Text);
            CrearRelacion(2, cb_B.Text, cb_A.Text, lt_B.SelectedItem.ToString());
            CargarCampos(2, cb_B.Text);
            EjecutarRelacionSQL(cb_A.Text, lt_B.SelectedItem.ToString(), cb_B.Text, 1);
            VerificarEstadodelquery();
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



        /***************************************************************
        NOMBRE:             EliminarTabla
        FECHA:              17-08-2013 
        CREADOR:            Enrique Magnani
        DESCRIPCIÓN         Realiza la manipulacion de consola en SQL directamente
        DETALLE:            Trabaja por Parametros
        MODIFICACIÓN:       
        ***************************************************************/
        public void EliminarTabla(string stTabla)
        {

            Console.WriteLine("Se eliminara: " + stTabla);
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

                obBitacora.RegistroDeActividadEnBitacora(stUsuario, stCadena);
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
                obBitacora.RegistroDeActividadEnBitacora(stUsuario, stCadena);
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
         CREADOR:     	     Mario Godoy y Agusto Murga
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

                if ((vector[0] == "select") || (vector[0] == "show") || (vector[0] == "SELECT"))
                {
                    obBitacora.RegistroDeActividadEnBitacora(stUsuario, "Sentencia Consola: " + cadena);

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
                else
                {
                    tb_Resultados.AppendText("Favor revisar sentencia sql select\n");

                }
                if ((vector[0] == "insert") || (vector[0] == "INSERT"))
                {
                    obBitacora.RegistroDeActividadEnBitacora(stUsuario, "Sentencia Consola: " + cadena);

                    tb_Resultados.Text = ("Insercion realizada con exito");
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    tb_Resultados.AppendText("Favor revisar sentencia sql insert\n");

                }
                if ((vector[0] == "alter") || (vector[0] == "ALTER"))
                {
                    obBitacora.RegistroDeActividadEnBitacora(stUsuario, "Sentencia Consola: " + cadena);

                    tb_Resultados.Text = ("modificacion realizada con exito");
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    tb_Resultados.AppendText("Favor revisar sentencia sql alter\n");

                }
                if ((vector[0] == "create") || (vector[0] == "CREATE"))
                {
                    obBitacora.RegistroDeActividadEnBitacora(stUsuario, "Sentencia Consola: " + cadena);

                    tb_Resultados.Text = ("Tabla creada con exito");
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    tb_Resultados.AppendText("Favor revisar sentencia sql create\n");
                    if ((vector[1] != "table") || (vector[1] != "TABLE"))
                    {
                        tb_Resultados.AppendText("Favor revisar la palabra table\n");
                    }
                    if ((vector[2] != ";") || (vector[2] != ";"))
                    {
                        tb_Resultados.AppendText("Favor revisar falta un punto y coma en la sentencia\n");
                    }

                }
                if ((vector[0] == "delete") || (vector[0] == "DELETE"))
                {
                    obBitacora.RegistroDeActividadEnBitacora(stUsuario, "Sentencia Consola: " + cadena);

                    tb_Resultados.Text = ("Eliminacion realizada con exito");
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    tb_Resultados.AppendText("Favor revisar sentencia sql delete\n");

                }
                if ((vector[0] == "update") || (vector[0] == "UPDATE"))
                {
                    obBitacora.RegistroDeActividadEnBitacora(stUsuario, "Sentencia Consola: " + cadena);

                    tb_Resultados.Text = ("modificacion realizada con exito");
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    tb_Resultados.AppendText("Favor revisar sentencia sql update\n");

                }
                if ((vector[0] == "drop") || (vector[0] == "DROP"))
                {
                    obBitacora.RegistroDeActividadEnBitacora(stUsuario, "Sentencia Consola: " + cadena);

                    tb_Resultados.Text = ("Eliminacion realizada con exito");
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    tb_Resultados.AppendText("Favor revisar sentencia sql drop\n");
                    if ((vector[1] != "database") || (vector[1] != "DATABASE"))
                    {
                        tb_Resultados.AppendText("Favor revisar la palabra database\n");
                    }
                    if ((vector[2] != ";") || (vector[2] != ";"))
                    {
                        tb_Resultados.AppendText("Favor revisar falta un punto y coma en la sentencia\n");
                    }
                }
                CSQL.conectarSQL.Close();

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
            {
                lt_Multi_funcion.Enabled = true;
                CSQL.txConexGlobal = "Server=" + stHost + ";Database=" + this.cb_BD.Text + ";Uid=" + stUsuario + ";Port=3306";

                CSQL.mostrar("Show tables", stHost, this.cb_BD.Text, stUsuario, stContrasena);

                lt_Multi_funcion.DataSource = CSQL.ds.Tables[0].DefaultView;

                lt_Multi_funcion.ValueMember = CSQL.ds.Tables[0].Columns[0].ColumnName;
                obBitacora.RegistroDeActividadEnBitacora(stUsuario, "Show tables;");
            }
            CargarTablasR();
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

                CSQL.txConexGlobal = "Server=" + stHost + ";Database=" + this.cb_BD.Text + ";Uid=" + stUsuario + ";Port=3306"; //string de conexion

                string stSQL = "Select * from " + lt_Multi_funcion.Text; //string de consulta
                Console.WriteLine("SQL: " + stSQL);
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

        private void cb_A_SelectedIndexChanged(object sender, EventArgs e)
        {
            CSQL.conectarSQL.Close();
            CargarCampos(1, cb_A.Text);
            CargarCampos(2, cb_B.Text);
        }

        private void cb_B_SelectedIndexChanged(object sender, EventArgs e)
        {
            CSQL.conectarSQL.Close();
            CargarCampos(1, cb_A.Text);
            CargarCampos(2, cb_B.Text);
        }

        private void bt_Ejecutar_Click(object sender, EventArgs e)
        {
            EjecutarQuery();
        }

        /***************************************************************
        NOMBRE:             VerificarPrimaryKey
        FECHA:              05-09-2013
        CREADOR:            Enrique Magnani
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
        FECHA:              06-09-2013
        CREADOR:            Enrique Magnani
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
            CSQL.conectarSQL.Close();
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
        NOMBRE:             CargarTablasR
        FECHA:              23-08-2013
        CREADOR:            Enrique Magnani
        DESCRIPCIÓN         Carga tablas en los combobox
        DETALLE:            Su funcion es de suma importancia
        MODIFICACIÓN:       
        ***************************************************************/
        public void CargarTablasR()
        {

            lt_A.Items.Clear();
            lt_B.Items.Clear();
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

                    int inRelacion = 0;
                    while (reader.Read())
                    {

                        if ((reader.GetString(0) == stllaveforanea) && (sttablaB != sttablaA))
                        {
                            tb_Query.Clear();
                            tb_Query.AppendText("Ya existe la relacion");
                            inRelacion = 1;
                        }




                    }
                    if (inRelacion == 1)
                    {

                        CargarCampos(inOp, sttablaB);
                    }

                }
            }
            catch (MySqlException ex)
            {

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



        /***************************************************************
        NOMBRE:             EjecutarQuery
        FECHA:              05-09-2013
        CREADOR:            Enrique Magnani            
        DESCRIPCIÓN         
        DETALLE:            
        MODIFICACIÓN:       
        ***************************************************************/
        public void EjecutarQuery()
        {
            string stB = (tb_Query.Text);
            string stC = stAlter1;


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
                obBitacora.RegistroDeActividadEnBitacora(stUsuario, "Relacion " + stB);

                tb_Resultados.AppendText("Relacion creada con exito");

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();


                CSQL.conectarSQL.Close();
            }
            catch (MySqlException ex)
            {
                CSQL.conectarSQL.Close();
            }



        }




        /***************************************************************
              NOMBRE:             InsertarTabla
              FECHA:              05-08-2013 
              CREADOR:            Enrique Magnani
              DESCRIPCIÓN         Inserta la tabla en la BD
              DETALLE:            
              MODIFICACIÓN:       
              ***************************************************************/
        public void InsertarTabla(string stQuery)
        {

            try
            {
                Console.WriteLine("SQL: " + stQuery);
                CSQL.CONECTAR(stHost, stBase_de_datos, stUsuario, stContrasena);
                CSQL.conectarSQL.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = stQuery;
                cmd.Connection = CSQL.conectarSQL;
                cmd.ExecuteNonQuery();


                MessageBox.Show("Tabla creada con exito", "Realizado");
                obBitacora.RegistroDeActividadEnBitacora(stUsuario, stQuery);
                CSQL.conectarSQL.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Creacion Fallida", "Error");
                obBitacora.RegistroDeActividadEnBitacora(stUsuario, "Creacion de tabla Fallida");
                CSQL.conectarSQL.Close();
            }


        }

        /***************************************************************
        NOMBRE:             VerificarTabla
        FECHA:              05-08-2013 
        CREADOR:            Enrique Magnani
        DESCRIPCIÓN         Verifica si la tabla existe en la BD ya
        DETALLE:            En proceso
        MODIFICACIÓN:       
        ***************************************************************/
        public int VerificarTabla(string stTabla)
        {
            int inBandera = 0;
            string stCadena = "show tables;";
            try
            {
                CSQL.CONECTAR(stHost, stBase_de_datos, stUsuario, stContrasena);
                CSQL.conectarSQL.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = stCadena;

                cmd.Connection = CSQL.conectarSQL;



                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(0) == stTabla)
                    {
                        inBandera = 1;
                    }
                }

            }

            catch (MySqlException ex)
            {
                CSQL.conectarSQL.Close();
            }

            CSQL.conectarSQL.Close();
            return inBandera;
        }



        /***************************************************************
        NOMBRE:             AgregarRegistro
        FECHA:              28-08-2013 
        CREADOR:            Enrique Magnani
        DESCRIPCIÓN         Agrega el registro a dt_Embarc
        DETALLE:            En proceso
        MODIFICACIÓN:       
        ***************************************************************/
        public void AgregarRegistro()
        {
            string stquery = "CREATE TABLE " + tx_Nombredetabla.Text + "(";

            int inquery = 0;
            foreach (DataGridViewRow Fila in dt_Embarc.Rows)
            {
                string[] vector = (Convert.ToString(Fila.Cells[2].Value)).Split('(');
                string stsubquery = "";

                Console.WriteLine("Fila: " + (Convert.ToString(Fila.Cells[0].Value)));
                if (inquery > 0)
                {
                    stsubquery = stsubquery + ",";
                }
                inquery++;
                stsubquery = stsubquery + (Convert.ToString(Fila.Cells[1].Value)) + " ";
                if ((vector[0]) == "VARCHAR")
                {
                    stsubquery = stsubquery + (Convert.ToString(Fila.Cells[2].Value));
                    if ((Convert.ToString(Fila.Cells[0].Value) == "SI"))
                    {

                        stsubquery = stsubquery + " PRIMARY KEY NOT NULL";
                    }
                }

                if (((vector[0]) == "INTEGER") || ((vector[0]) == "DOUBLE"))
                {
                    stsubquery = stsubquery + (Convert.ToString(Fila.Cells[2].Value));
                    if ((Convert.ToString(Fila.Cells[0].Value) == "SI"))
                    {

                        stsubquery = stsubquery + "PRIMARY KEY";
                    }
                    stsubquery = stsubquery + " NOT NULL ";
                }



                stquery = stquery + stsubquery;

            }
            stquery = stquery + ");";
            if (tx_Nombredetabla.Text == "")
            {
                MessageBox.Show("Se requiere el nombre de la tabla", "Error");
            }
            else
            {
                if (VerificarTabla(tx_Nombredetabla.Text) == 0)
                {
                    InsertarTabla(stquery);

                }
                else
                {
                    MessageBox.Show("Tabla Repetida", "Error");
                    tx_Nombredetabla.Text = "";
                }
            }
        }


        /***************************************************************
        NOMBRE:             VerificarAmbieguedad
        FECHA:              28-08-2013 
        CREADOR:            Enrique Magnani
        DESCRIPCIÓN         Agrega el registro a dt_Embarc
        DETALLE:            En proceso
        MODIFICACIÓN:       
        ***************************************************************/
        public void VerificarAmbieguedad()
        {
            int inControl_pk = 0;
            int inControl_cr = 0;

            decimal number = 0;
            bool canConvert = decimal.TryParse(tx_Tamano.Text, out number);
            if (canConvert == true)
            {

                if (tx_Nombre.Text == "")
                {

                    MessageBox.Show("Necesita especificar el nombre del campo", "Error");
                    tx_Nombre.Text = "";

                }
                else
                {

                    foreach (DataGridViewRow Fila in dt_Embarc.Rows)
                    {


                        Console.WriteLine("Fila: " + (Convert.ToString(Fila.Cells[0].Value)));
                        if ((Convert.ToString(Fila.Cells[0].Value) == "SI"))
                        {

                            inControl_pk = 1;
                        }
                        if ((Convert.ToString(Fila.Cells[1].Value) == tx_Nombre.Text))
                        {
                            inControl_cr = 1;

                        }


                    }
                    if (inControl_cr == 1)
                    {

                        MessageBox.Show("Es un campo repetido", "Error");
                        tx_Nombre.Text = "";
                    }
                    else
                    {
                        if ((cx_PrimaryKey.Checked == false))
                        {
                            Console.WriteLine("No se selecciono  nada");
                            this.dt_Embarc.Rows.Add("", tx_Nombre.Text, cb_Tipo.Text + "(" + tx_Tamano.Text + ")");
                        }
                        else
                        {
                            if (inControl_pk == 1)
                            {
                                MessageBox.Show("Ya existe una llave primaria", "Error");

                            }
                            else
                            {

                                this.dt_Embarc.Rows.Add("SI", tx_Nombre.Text, cb_Tipo.Text + "(" + tx_Tamano.Text + ")");
                            }
                            cx_PrimaryKey.Checked = false;
                        }



                    }
                    //  
                }
            }
            else
            {

                MessageBox.Show("En el campo tamaño debe especificar un valor entero", "Error");
                tx_Tamano.Text = "";
            }

        }







        private void bt_Agregarregistro_Click(object sender, EventArgs e)
        {
            VerificarAmbieguedad();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            AgregarRegistro();
        }

        /*--------------------------------------------
Nombre:         ayuda
Autor:          Mario Godoy
fecha:          04/agosto/2013
Detalle:        permite la ejecucion de ayuda * 
//--------------------------------------*/

        private void ts_Acercade_Click(object sender, EventArgs e)
        {
            String ruta = System.IO.Directory.GetCurrentDirectory().ToString();

            System.Diagnostics.Process.Start(ruta + "/ayuda1.chm");
        }

        private void bt_Eliminar_query_Click(object sender, EventArgs e)
        {
            tb_Consola_query.Clear();
        }

        private void bt_Guardar_query_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filetosaveas = saveFileDialog1.FileName;

            System.IO.StreamWriter objwrite = new System.IO.StreamWriter(filetosaveas);
            objwrite.Write(tb_Consola_query);
            objwrite.Close();

        }

        private void bt_Actualizar_BD_Click(object sender, EventArgs e)
        {

        }

        private void lt_Multi_funcion_MouseClick(object sender, MouseEventArgs e)
        {


        }
    }
}
    



