namespace SBD___CCS
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.ts_BD = new System.Windows.Forms.ToolStrip();
            this.ts_Sesion = new System.Windows.Forms.ToolStripSplitButton();
            this.ts_Status = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Desconectar = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Nueva_BD = new System.Windows.Forms.ToolStripButton();
            this.ms_Principal = new System.Windows.Forms.MenuStrip();
            this.ts_Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Query = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Insertar = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Crear = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Nueva_tabla = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Acercade = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Manuales = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_Barra_inferior = new System.Windows.Forms.StatusStrip();
            this.ts_Panel = new System.Windows.Forms.ToolStrip();
            this.tc_Panel_BD = new System.Windows.Forms.ToolStripContainer();
            this.bt_Inicio_BD = new System.Windows.Forms.Button();
            this.bt_Actualizar_BD = new System.Windows.Forms.Button();
            this.bt_Seleccionar_BD = new System.Windows.Forms.Button();
            this.lt_Multi_funcion = new System.Windows.Forms.ListBox();
            this.lb_BD = new System.Windows.Forms.Label();
            this.cb_BD = new System.Windows.Forms.ComboBox();
            this.ta_Panel_inferior = new System.Windows.Forms.TabControl();
            this.tp_Resultados = new System.Windows.Forms.TabPage();
            this.tb_Resultados = new System.Windows.Forms.TextBox();
            this.tp_Errores = new System.Windows.Forms.TabPage();
            this.tb_Errores = new System.Windows.Forms.TextBox();
            this.ta_Consola_SQL = new System.Windows.Forms.TabControl();
            this.tb_SQL = new System.Windows.Forms.TabPage();
            this.bt_Eliminar_query = new System.Windows.Forms.Button();
            this.tb_Consola_query = new System.Windows.Forms.TextBox();
            this.bt_Guardar_query = new System.Windows.Forms.Button();
            this.bt_Ejecutar_query = new System.Windows.Forms.Button();
            this.ts_Consola_SQL = new System.Windows.Forms.ToolStrip();
            this.tp_DDL = new System.Windows.Forms.TabPage();
            this.bt_Examinar_tabla = new System.Windows.Forms.Button();
            this.bt_Eliminar_tabla = new System.Windows.Forms.Button();
            this.bt_Relacionar_tabla = new System.Windows.Forms.Button();
            this.bt_Nueva_tabla = new System.Windows.Forms.Button();
            this.lb_Mensaje_error = new System.Windows.Forms.Label();
            this.tm_Estado_BD = new System.Windows.Forms.Timer(this.components);
            this.pb_Estado = new System.Windows.Forms.PictureBox();
            this.tb_DML = new System.Windows.Forms.TabPage();
            this.ts_BD.SuspendLayout();
            this.ms_Principal.SuspendLayout();
            this.tc_Panel_BD.ContentPanel.SuspendLayout();
            this.tc_Panel_BD.SuspendLayout();
            this.ta_Panel_inferior.SuspendLayout();
            this.tp_Resultados.SuspendLayout();
            this.tp_Errores.SuspendLayout();
            this.ta_Consola_SQL.SuspendLayout();
            this.tb_SQL.SuspendLayout();
            this.tp_DDL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Estado)).BeginInit();
            this.SuspendLayout();
            // 
            // ts_BD
            // 
            this.ts_BD.AutoSize = false;
            this.ts_BD.Dock = System.Windows.Forms.DockStyle.Right;
            this.ts_BD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Sesion,
            this.ts_Nueva_BD});
            this.ts_BD.Location = new System.Drawing.Point(917, 24);
            this.ts_BD.Name = "ts_BD";
            this.ts_BD.Size = new System.Drawing.Size(46, 519);
            this.ts_BD.TabIndex = 2;
            this.ts_BD.Text = "toolStrip1";
            // 
            // ts_Sesion
            // 
            this.ts_Sesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_Sesion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Status,
            this.ts_Desconectar});
            this.ts_Sesion.Image = global::SBD___CCS.Properties.Resources.xfsm_logout;
            this.ts_Sesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Sesion.Name = "ts_Sesion";
            this.ts_Sesion.Size = new System.Drawing.Size(44, 20);
            this.ts_Sesion.Text = "Sesion";
            // 
            // ts_Status
            // 
            this.ts_Status.Image = global::SBD___CCS.Properties.Resources.stock_refresh;
            this.ts_Status.Name = "ts_Status";
            this.ts_Status.Size = new System.Drawing.Size(139, 22);
            this.ts_Status.Text = "Status";
            // 
            // ts_Desconectar
            // 
            this.ts_Desconectar.Image = global::SBD___CCS.Properties.Resources.xfce_system_exit;
            this.ts_Desconectar.Name = "ts_Desconectar";
            this.ts_Desconectar.Size = new System.Drawing.Size(139, 22);
            this.ts_Desconectar.Text = "Desconectar";
            this.ts_Desconectar.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // ts_Nueva_BD
            // 
            this.ts_Nueva_BD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_Nueva_BD.Image = global::SBD___CCS.Properties.Resources.openofficeorg3_oasis_database;
            this.ts_Nueva_BD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Nueva_BD.Name = "ts_Nueva_BD";
            this.ts_Nueva_BD.Size = new System.Drawing.Size(44, 20);
            this.ts_Nueva_BD.Text = "Nueva Base de Datos";
            // 
            // ms_Principal
            // 
            this.ms_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Archivo,
            this.ts_Query,
            this.ts_Ayuda});
            this.ms_Principal.Location = new System.Drawing.Point(0, 0);
            this.ms_Principal.Name = "ms_Principal";
            this.ms_Principal.Size = new System.Drawing.Size(963, 24);
            this.ms_Principal.TabIndex = 3;
            this.ms_Principal.Text = "menuStrip1";
            // 
            // ts_Archivo
            // 
            this.ts_Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Abrir,
            this.ts_Salir});
            this.ts_Archivo.Name = "ts_Archivo";
            this.ts_Archivo.Size = new System.Drawing.Size(60, 20);
            this.ts_Archivo.Text = "Archivo";
            // 
            // ts_Abrir
            // 
            this.ts_Abrir.Name = "ts_Abrir";
            this.ts_Abrir.Size = new System.Drawing.Size(152, 22);
            this.ts_Abrir.Text = "Abrir";
            // 
            // ts_Salir
            // 
            this.ts_Salir.Name = "ts_Salir";
            this.ts_Salir.Size = new System.Drawing.Size(152, 22);
            this.ts_Salir.Text = "Salir";
            // 
            // ts_Query
            // 
            this.ts_Query.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Insertar,
            this.ts_Crear,
            this.ts_Modificar});
            this.ts_Query.Name = "ts_Query";
            this.ts_Query.Size = new System.Drawing.Size(56, 20);
            this.ts_Query.Text = "Querys";
            // 
            // ts_Insertar
            // 
            this.ts_Insertar.Name = "ts_Insertar";
            this.ts_Insertar.Size = new System.Drawing.Size(152, 22);
            this.ts_Insertar.Text = "Insertar";
            // 
            // ts_Crear
            // 
            this.ts_Crear.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Nueva_tabla});
            this.ts_Crear.Name = "ts_Crear";
            this.ts_Crear.Size = new System.Drawing.Size(152, 22);
            this.ts_Crear.Text = "Crear";
            // 
            // ts_Nueva_tabla
            // 
            this.ts_Nueva_tabla.Name = "ts_Nueva_tabla";
            this.ts_Nueva_tabla.Size = new System.Drawing.Size(103, 22);
            this.ts_Nueva_tabla.Text = "Tabla";
            // 
            // ts_Modificar
            // 
            this.ts_Modificar.Name = "ts_Modificar";
            this.ts_Modificar.Size = new System.Drawing.Size(152, 22);
            this.ts_Modificar.Text = "Modificar";
            this.ts_Modificar.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // ts_Ayuda
            // 
            this.ts_Ayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Acercade,
            this.ts_Manuales});
            this.ts_Ayuda.Name = "ts_Ayuda";
            this.ts_Ayuda.Size = new System.Drawing.Size(53, 20);
            this.ts_Ayuda.Text = "Ayuda";
            // 
            // ts_Acercade
            // 
            this.ts_Acercade.Name = "ts_Acercade";
            this.ts_Acercade.Size = new System.Drawing.Size(152, 22);
            this.ts_Acercade.Text = "Acerca de";
            // 
            // ts_Manuales
            // 
            this.ts_Manuales.Name = "ts_Manuales";
            this.ts_Manuales.Size = new System.Drawing.Size(152, 22);
            this.ts_Manuales.Text = "Manuales";
            // 
            // ss_Barra_inferior
            // 
            this.ss_Barra_inferior.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ss_Barra_inferior.Location = new System.Drawing.Point(0, 521);
            this.ss_Barra_inferior.Name = "ss_Barra_inferior";
            this.ss_Barra_inferior.Size = new System.Drawing.Size(917, 22);
            this.ss_Barra_inferior.TabIndex = 4;
            this.ss_Barra_inferior.Text = "statusStrip1";
            // 
            // ts_Panel
            // 
            this.ts_Panel.AutoSize = false;
            this.ts_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ts_Panel.Location = new System.Drawing.Point(0, 24);
            this.ts_Panel.Name = "ts_Panel";
            this.ts_Panel.Size = new System.Drawing.Size(145, 497);
            this.ts_Panel.TabIndex = 12;
            this.ts_Panel.Text = "toolStrip2";
            // 
            // tc_Panel_BD
            // 
            // 
            // tc_Panel_BD.ContentPanel
            // 
            this.tc_Panel_BD.ContentPanel.Controls.Add(this.bt_Inicio_BD);
            this.tc_Panel_BD.ContentPanel.Controls.Add(this.bt_Actualizar_BD);
            this.tc_Panel_BD.ContentPanel.Controls.Add(this.bt_Seleccionar_BD);
            this.tc_Panel_BD.ContentPanel.Controls.Add(this.lt_Multi_funcion);
            this.tc_Panel_BD.ContentPanel.Controls.Add(this.lb_BD);
            this.tc_Panel_BD.ContentPanel.Controls.Add(this.cb_BD);
            this.tc_Panel_BD.ContentPanel.Size = new System.Drawing.Size(121, 445);
            this.tc_Panel_BD.Location = new System.Drawing.Point(12, 44);
            this.tc_Panel_BD.Name = "tc_Panel_BD";
            this.tc_Panel_BD.Size = new System.Drawing.Size(121, 470);
            this.tc_Panel_BD.TabIndex = 13;
            this.tc_Panel_BD.Text = "toolStripContainer1";
            // 
            // bt_Inicio_BD
            // 
            this.bt_Inicio_BD.BackgroundImage = global::SBD___CCS.Properties.Resources.gtk_home;
            this.bt_Inicio_BD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Inicio_BD.Location = new System.Drawing.Point(6, 50);
            this.bt_Inicio_BD.Name = "bt_Inicio_BD";
            this.bt_Inicio_BD.Size = new System.Drawing.Size(35, 35);
            this.bt_Inicio_BD.TabIndex = 24;
            this.bt_Inicio_BD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_Inicio_BD.UseVisualStyleBackColor = true;
            this.bt_Inicio_BD.Click += new System.EventHandler(this.btn_INICIOBD_Click);
            // 
            // bt_Actualizar_BD
            // 
            this.bt_Actualizar_BD.BackgroundImage = global::SBD___CCS.Properties.Resources.mail_send_receive;
            this.bt_Actualizar_BD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Actualizar_BD.Location = new System.Drawing.Point(42, 50);
            this.bt_Actualizar_BD.Name = "bt_Actualizar_BD";
            this.bt_Actualizar_BD.Size = new System.Drawing.Size(35, 35);
            this.bt_Actualizar_BD.TabIndex = 23;
            this.bt_Actualizar_BD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_Actualizar_BD.UseVisualStyleBackColor = true;
            // 
            // bt_Seleccionar_BD
            // 
            this.bt_Seleccionar_BD.BackgroundImage = global::SBD___CCS.Properties.Resources.gtk_leave_fullscreen;
            this.bt_Seleccionar_BD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Seleccionar_BD.Location = new System.Drawing.Point(83, 50);
            this.bt_Seleccionar_BD.Name = "bt_Seleccionar_BD";
            this.bt_Seleccionar_BD.Size = new System.Drawing.Size(35, 35);
            this.bt_Seleccionar_BD.TabIndex = 22;
            this.bt_Seleccionar_BD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_Seleccionar_BD.UseVisualStyleBackColor = true;
            this.bt_Seleccionar_BD.Click += new System.EventHandler(this.btn_SELECCIONARBD_Click);
            // 
            // lt_Multi_funcion
            // 
            this.lt_Multi_funcion.FormattingEnabled = true;
            this.lt_Multi_funcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lt_Multi_funcion.Items.AddRange(new object[] {
            "Sin Conexion"});
            this.lt_Multi_funcion.Location = new System.Drawing.Point(4, 91);
            this.lt_Multi_funcion.Name = "lt_Multi_funcion";
            this.lt_Multi_funcion.Size = new System.Drawing.Size(106, 342);
            this.lt_Multi_funcion.TabIndex = 6;
            this.lt_Multi_funcion.DoubleClick += new System.EventHandler(this.lista_multi_DoubleClick);
            // 
            // lb_BD
            // 
            this.lb_BD.AutoSize = true;
            this.lb_BD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BD.Location = new System.Drawing.Point(3, 13);
            this.lb_BD.Name = "lb_BD";
            this.lb_BD.Size = new System.Drawing.Size(96, 13);
            this.lb_BD.TabIndex = 4;
            this.lb_BD.Text = "Bases de Datos";
            this.lb_BD.Visible = false;
            // 
            // cb_BD
            // 
            this.cb_BD.FormattingEnabled = true;
            this.cb_BD.Items.AddRange(new object[] {
            "Sin Conexion"});
            this.cb_BD.Location = new System.Drawing.Point(3, 29);
            this.cb_BD.Name = "cb_BD";
            this.cb_BD.Size = new System.Drawing.Size(115, 21);
            this.cb_BD.TabIndex = 3;
            this.cb_BD.Visible = false;
            this.cb_BD.SelectedIndexChanged += new System.EventHandler(this.cb_BD_SelectedIndexChanged);
            // 
            // ta_Panel_inferior
            // 
            this.ta_Panel_inferior.Controls.Add(this.tp_Resultados);
            this.ta_Panel_inferior.Controls.Add(this.tp_Errores);
            this.ta_Panel_inferior.Location = new System.Drawing.Point(148, 375);
            this.ta_Panel_inferior.Name = "ta_Panel_inferior";
            this.ta_Panel_inferior.SelectedIndex = 0;
            this.ta_Panel_inferior.Size = new System.Drawing.Size(766, 143);
            this.ta_Panel_inferior.TabIndex = 18;
            // 
            // tp_Resultados
            // 
            this.tp_Resultados.Controls.Add(this.tb_Resultados);
            this.tp_Resultados.Location = new System.Drawing.Point(4, 22);
            this.tp_Resultados.Name = "tp_Resultados";
            this.tp_Resultados.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Resultados.Size = new System.Drawing.Size(758, 117);
            this.tp_Resultados.TabIndex = 0;
            this.tp_Resultados.Text = "Resultados";
            this.tp_Resultados.UseVisualStyleBackColor = true;
            // 
            // tb_Resultados
            // 
            this.tb_Resultados.Location = new System.Drawing.Point(4, 7);
            this.tb_Resultados.Multiline = true;
            this.tb_Resultados.Name = "tb_Resultados";
            this.tb_Resultados.Size = new System.Drawing.Size(748, 104);
            this.tb_Resultados.TabIndex = 0;
            // 
            // tp_Errores
            // 
            this.tp_Errores.Controls.Add(this.tb_Errores);
            this.tp_Errores.Location = new System.Drawing.Point(4, 22);
            this.tp_Errores.Name = "tp_Errores";
            this.tp_Errores.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Errores.Size = new System.Drawing.Size(758, 117);
            this.tp_Errores.TabIndex = 1;
            this.tp_Errores.Text = "Errores";
            this.tp_Errores.UseVisualStyleBackColor = true;
            // 
            // tb_Errores
            // 
            this.tb_Errores.Location = new System.Drawing.Point(5, 6);
            this.tb_Errores.Multiline = true;
            this.tb_Errores.Name = "tb_Errores";
            this.tb_Errores.Size = new System.Drawing.Size(748, 104);
            this.tb_Errores.TabIndex = 1;
            // 
            // ta_Consola_SQL
            // 
            this.ta_Consola_SQL.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.ta_Consola_SQL.Controls.Add(this.tb_SQL);
            this.ta_Consola_SQL.Controls.Add(this.tp_DDL);
            this.ta_Consola_SQL.Controls.Add(this.tb_DML);
            this.ta_Consola_SQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ta_Consola_SQL.Location = new System.Drawing.Point(152, 27);
            this.ta_Consola_SQL.Multiline = true;
            this.ta_Consola_SQL.Name = "ta_Consola_SQL";
            this.ta_Consola_SQL.SelectedIndex = 0;
            this.ta_Consola_SQL.Size = new System.Drawing.Size(755, 342);
            this.ta_Consola_SQL.TabIndex = 21;
            // 
            // tb_SQL
            // 
            this.tb_SQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_SQL.Controls.Add(this.bt_Eliminar_query);
            this.tb_SQL.Controls.Add(this.tb_Consola_query);
            this.tb_SQL.Controls.Add(this.bt_Guardar_query);
            this.tb_SQL.Controls.Add(this.bt_Ejecutar_query);
            this.tb_SQL.Controls.Add(this.ts_Consola_SQL);
            this.tb_SQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SQL.Location = new System.Drawing.Point(23, 4);
            this.tb_SQL.Name = "tb_SQL";
            this.tb_SQL.Padding = new System.Windows.Forms.Padding(3);
            this.tb_SQL.Size = new System.Drawing.Size(728, 334);
            this.tb_SQL.TabIndex = 0;
            this.tb_SQL.Text = "SQL";
            // 
            // bt_Eliminar_query
            // 
            this.bt_Eliminar_query.BackgroundImage = global::SBD___CCS.Properties.Resources.gtk_quit;
            this.bt_Eliminar_query.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Eliminar_query.Location = new System.Drawing.Point(88, 3);
            this.bt_Eliminar_query.Name = "bt_Eliminar_query";
            this.bt_Eliminar_query.Size = new System.Drawing.Size(35, 35);
            this.bt_Eliminar_query.TabIndex = 21;
            this.bt_Eliminar_query.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_Eliminar_query.UseVisualStyleBackColor = true;
            // 
            // tb_Consola_query
            // 
            this.tb_Consola_query.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Consola_query.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tb_Consola_query.Location = new System.Drawing.Point(6, 44);
            this.tb_Consola_query.Multiline = true;
            this.tb_Consola_query.Name = "tb_Consola_query";
            this.tb_Consola_query.Size = new System.Drawing.Size(719, 284);
            this.tb_Consola_query.TabIndex = 2;
            // 
            // bt_Guardar_query
            // 
            this.bt_Guardar_query.BackgroundImage = global::SBD___CCS.Properties.Resources.document_save_3_256x256x32;
            this.bt_Guardar_query.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Guardar_query.Location = new System.Drawing.Point(6, 3);
            this.bt_Guardar_query.Name = "bt_Guardar_query";
            this.bt_Guardar_query.Size = new System.Drawing.Size(35, 35);
            this.bt_Guardar_query.TabIndex = 3;
            this.bt_Guardar_query.UseVisualStyleBackColor = true;
            // 
            // bt_Ejecutar_query
            // 
            this.bt_Ejecutar_query.BackgroundImage = global::SBD___CCS.Properties.Resources.gtk_media_play_ltr_3_256x256x32;
            this.bt_Ejecutar_query.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Ejecutar_query.Location = new System.Drawing.Point(47, 3);
            this.bt_Ejecutar_query.Name = "bt_Ejecutar_query";
            this.bt_Ejecutar_query.Size = new System.Drawing.Size(35, 35);
            this.bt_Ejecutar_query.TabIndex = 1;
            this.bt_Ejecutar_query.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_Ejecutar_query.UseVisualStyleBackColor = true;
            this.bt_Ejecutar_query.Click += new System.EventHandler(this.btn_EJECUTAR_Click);
            // 
            // ts_Consola_SQL
            // 
            this.ts_Consola_SQL.AutoSize = false;
            this.ts_Consola_SQL.Location = new System.Drawing.Point(3, 3);
            this.ts_Consola_SQL.Name = "ts_Consola_SQL";
            this.ts_Consola_SQL.Size = new System.Drawing.Size(722, 38);
            this.ts_Consola_SQL.TabIndex = 20;
            this.ts_Consola_SQL.Text = "toolStrip4";
            // 
            // tp_DDL
            // 
            this.tp_DDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tp_DDL.Controls.Add(this.bt_Examinar_tabla);
            this.tp_DDL.Controls.Add(this.bt_Eliminar_tabla);
            this.tp_DDL.Controls.Add(this.bt_Relacionar_tabla);
            this.tp_DDL.Controls.Add(this.bt_Nueva_tabla);
            this.tp_DDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_DDL.Location = new System.Drawing.Point(23, 4);
            this.tp_DDL.Name = "tp_DDL";
            this.tp_DDL.Padding = new System.Windows.Forms.Padding(3);
            this.tp_DDL.Size = new System.Drawing.Size(728, 334);
            this.tp_DDL.TabIndex = 1;
            this.tp_DDL.Text = "DDL";
            // 
            // bt_Examinar_tabla
            // 
            this.bt_Examinar_tabla.Location = new System.Drawing.Point(294, 13);
            this.bt_Examinar_tabla.Name = "bt_Examinar_tabla";
            this.bt_Examinar_tabla.Size = new System.Drawing.Size(90, 37);
            this.bt_Examinar_tabla.TabIndex = 4;
            this.bt_Examinar_tabla.Text = "Examinar";
            this.bt_Examinar_tabla.UseVisualStyleBackColor = true;
            this.bt_Examinar_tabla.Click += new System.EventHandler(this.btn_EXAMINAR_Click);
            // 
            // bt_Eliminar_tabla
            // 
            this.bt_Eliminar_tabla.Location = new System.Drawing.Point(198, 13);
            this.bt_Eliminar_tabla.Name = "bt_Eliminar_tabla";
            this.bt_Eliminar_tabla.Size = new System.Drawing.Size(90, 37);
            this.bt_Eliminar_tabla.TabIndex = 3;
            this.bt_Eliminar_tabla.Text = "Eliminar";
            this.bt_Eliminar_tabla.UseVisualStyleBackColor = true;
            this.bt_Eliminar_tabla.Click += new System.EventHandler(this.btn_ELIMINAR_Click);
            // 
            // bt_Relacionar_tabla
            // 
            this.bt_Relacionar_tabla.Location = new System.Drawing.Point(102, 13);
            this.bt_Relacionar_tabla.Name = "bt_Relacionar_tabla";
            this.bt_Relacionar_tabla.Size = new System.Drawing.Size(90, 37);
            this.bt_Relacionar_tabla.TabIndex = 2;
            this.bt_Relacionar_tabla.Text = "Relaciones";
            this.bt_Relacionar_tabla.UseVisualStyleBackColor = true;
            this.bt_Relacionar_tabla.Click += new System.EventHandler(this.btn_RELACIONES_Click);
            // 
            // bt_Nueva_tabla
            // 
            this.bt_Nueva_tabla.Location = new System.Drawing.Point(6, 13);
            this.bt_Nueva_tabla.Name = "bt_Nueva_tabla";
            this.bt_Nueva_tabla.Size = new System.Drawing.Size(90, 37);
            this.bt_Nueva_tabla.TabIndex = 1;
            this.bt_Nueva_tabla.Text = "Nueva Tabla";
            this.bt_Nueva_tabla.UseVisualStyleBackColor = true;
            this.bt_Nueva_tabla.Click += new System.EventHandler(this.btn_NUEVATABLA_Click);
            // 
            // lb_Mensaje_error
            // 
            this.lb_Mensaje_error.BackColor = System.Drawing.Color.Gray;
            this.lb_Mensaje_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mensaje_error.Location = new System.Drawing.Point(148, 524);
            this.lb_Mensaje_error.Name = "lb_Mensaje_error";
            this.lb_Mensaje_error.Size = new System.Drawing.Size(209, 13);
            this.lb_Mensaje_error.TabIndex = 23;
            // 
            // tm_Estado_BD
            // 
            this.tm_Estado_BD.Interval = 1000;
            this.tm_Estado_BD.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pb_Estado
            // 
            this.pb_Estado.Image = global::SBD___CCS.Properties.Resources.nc;
            this.pb_Estado.Location = new System.Drawing.Point(871, 520);
            this.pb_Estado.Name = "pb_Estado";
            this.pb_Estado.Size = new System.Drawing.Size(24, 23);
            this.pb_Estado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Estado.TabIndex = 20;
            this.pb_Estado.TabStop = false;
            // 
            // tb_DML
            // 
            this.tb_DML.Location = new System.Drawing.Point(23, 4);
            this.tb_DML.Name = "tb_DML";
            this.tb_DML.Padding = new System.Windows.Forms.Padding(3);
            this.tb_DML.Size = new System.Drawing.Size(728, 334);
            this.tb_DML.TabIndex = 2;
            this.tb_DML.Text = "DML";
            this.tb_DML.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(963, 543);
            this.Controls.Add(this.lb_Mensaje_error);
            this.Controls.Add(this.ta_Consola_SQL);
            this.Controls.Add(this.pb_Estado);
            this.Controls.Add(this.ta_Panel_inferior);
            this.Controls.Add(this.tc_Panel_BD);
            this.Controls.Add(this.ts_Panel);
            this.Controls.Add(this.ss_Barra_inferior);
            this.Controls.Add(this.ts_BD);
            this.Controls.Add(this.ms_Principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Base de Datos";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ts_BD.ResumeLayout(false);
            this.ts_BD.PerformLayout();
            this.ms_Principal.ResumeLayout(false);
            this.ms_Principal.PerformLayout();
            this.tc_Panel_BD.ContentPanel.ResumeLayout(false);
            this.tc_Panel_BD.ContentPanel.PerformLayout();
            this.tc_Panel_BD.ResumeLayout(false);
            this.tc_Panel_BD.PerformLayout();
            this.ta_Panel_inferior.ResumeLayout(false);
            this.tp_Resultados.ResumeLayout(false);
            this.tp_Resultados.PerformLayout();
            this.tp_Errores.ResumeLayout(false);
            this.tp_Errores.PerformLayout();
            this.ta_Consola_SQL.ResumeLayout(false);
            this.tb_SQL.ResumeLayout(false);
            this.tb_SQL.PerformLayout();
            this.tp_DDL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Estado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSplitButton ts_Sesion;
        private System.Windows.Forms.ToolStripMenuItem ts_Status;
        private System.Windows.Forms.MenuStrip ms_Principal;
        private System.Windows.Forms.ToolStripMenuItem ts_Archivo;
        private System.Windows.Forms.ToolStripMenuItem ts_Abrir;
        private System.Windows.Forms.ToolStripMenuItem ts_Salir;
        private System.Windows.Forms.ToolStripMenuItem ts_Desconectar;
        private System.Windows.Forms.ToolStripButton ts_Nueva_BD;
        private System.Windows.Forms.StatusStrip ss_Barra_inferior;
        public System.Windows.Forms.ToolStrip ts_BD;
        private System.Windows.Forms.ToolStrip ts_Panel;
        private System.Windows.Forms.ToolStripContainer tc_Panel_BD;
        private System.Windows.Forms.TabControl ta_Panel_inferior;
        private System.Windows.Forms.TabPage tp_Resultados;
        private System.Windows.Forms.TabPage tp_Errores;
        private System.Windows.Forms.Label lb_BD;
        private System.Windows.Forms.ComboBox cb_BD;
        private System.Windows.Forms.PictureBox pb_Estado;
        private System.Windows.Forms.ListBox lt_Multi_funcion;
        private System.Windows.Forms.ToolStripMenuItem ts_Query;
        private System.Windows.Forms.ToolStripMenuItem ts_Insertar;
        private System.Windows.Forms.ToolStripMenuItem ts_Crear;
        private System.Windows.Forms.ToolStripMenuItem ts_Nueva_tabla;
        private System.Windows.Forms.ToolStripMenuItem ts_Modificar;
        private System.Windows.Forms.TabControl ta_Consola_SQL;
        private System.Windows.Forms.TabPage tb_SQL;
        private System.Windows.Forms.TabPage tp_DDL;
        private System.Windows.Forms.TextBox tb_Consola_query;
        private System.Windows.Forms.Button bt_Guardar_query;
        private System.Windows.Forms.Button bt_Ejecutar_query;
        private System.Windows.Forms.ToolStrip ts_Consola_SQL;
        private System.Windows.Forms.Button bt_Examinar_tabla;
        private System.Windows.Forms.Button bt_Eliminar_tabla;
        private System.Windows.Forms.Button bt_Relacionar_tabla;
        private System.Windows.Forms.Button bt_Nueva_tabla;
        private System.Windows.Forms.TextBox tb_Resultados;
        private System.Windows.Forms.TextBox tb_Errores;
        private System.Windows.Forms.Label lb_Mensaje_error;
        private System.Windows.Forms.Timer tm_Estado_BD;
        private System.Windows.Forms.Button bt_Eliminar_query;
        private System.Windows.Forms.Button bt_Inicio_BD;
        private System.Windows.Forms.Button bt_Actualizar_BD;
        private System.Windows.Forms.Button bt_Seleccionar_BD;
        private System.Windows.Forms.ToolStripMenuItem ts_Ayuda;
        private System.Windows.Forms.ToolStripMenuItem ts_Acercade;
        private System.Windows.Forms.ToolStripMenuItem ts_Manuales;
        private System.Windows.Forms.TabPage tb_DML;
    }
}

