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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.violarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.querysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.btn_INICIOBD = new System.Windows.Forms.Button();
            this.btn_ACTUALIZARBD = new System.Windows.Forms.Button();
            this.btn_SELECCIONARBD = new System.Windows.Forms.Button();
            this.lista_multi = new System.Windows.Forms.ListBox();
            this.lbl_BD = new System.Windows.Forms.Label();
            this.cmb_BD = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_RESULTADOS = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_ERRORES = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_EXAMINAR = new System.Windows.Forms.Button();
            this.btn_ELIMINAR = new System.Windows.Forms.Button();
            this.btn_RELACIONES = new System.Windows.Forms.Button();
            this.btn_NUEVATABLA = new System.Windows.Forms.Button();
            this.lbl_MSJERROR = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pct_SIGNAL = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_SIGNAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(917, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(46, 519);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.desconectarToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::SBD___CCS.Properties.Resources.xfsm_logout;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(44, 20);
            this.toolStripSplitButton1.Text = "Sesion";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Image = global::SBD___CCS.Properties.Resources.stock_refresh;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.archivoToolStripMenuItem.Text = "Status";
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Image = global::SBD___CCS.Properties.Resources.xfce_system_exit;
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::SBD___CCS.Properties.Resources.openofficeorg3_oasis_database;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(44, 20);
            this.toolStripButton1.Text = "Nueva Base de Datos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1,
            this.querysToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(963, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1,
            this.violarToolStripMenuItem});
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem1.Text = "Archivo";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem1.Text = "Abrir";
            // 
            // violarToolStripMenuItem
            // 
            this.violarToolStripMenuItem.Name = "violarToolStripMenuItem";
            this.violarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.violarToolStripMenuItem.Text = "Salir";
            // 
            // querysToolStripMenuItem
            // 
            this.querysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarToolStripMenuItem,
            this.crearToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.querysToolStripMenuItem.Name = "querysToolStripMenuItem";
            this.querysToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.querysToolStripMenuItem.Text = "Querys";
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.insertarToolStripMenuItem.Text = "Insertar";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaToolStripMenuItem});
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            // 
            // tablaToolStripMenuItem
            // 
            this.tablaToolStripMenuItem.Name = "tablaToolStripMenuItem";
            this.tablaToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.tablaToolStripMenuItem.Text = "Tabla";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusStrip1.Location = new System.Drawing.Point(0, 521);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(917, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(145, 497);
            this.toolStrip2.TabIndex = 12;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btn_INICIOBD);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btn_ACTUALIZARBD);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btn_SELECCIONARBD);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lista_multi);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lbl_BD);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cmb_BD);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(121, 445);
            this.toolStripContainer1.Location = new System.Drawing.Point(12, 44);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(121, 470);
            this.toolStripContainer1.TabIndex = 13;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // btn_INICIOBD
            // 
            this.btn_INICIOBD.BackgroundImage = global::SBD___CCS.Properties.Resources.gtk_home;
            this.btn_INICIOBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_INICIOBD.Location = new System.Drawing.Point(6, 50);
            this.btn_INICIOBD.Name = "btn_INICIOBD";
            this.btn_INICIOBD.Size = new System.Drawing.Size(35, 35);
            this.btn_INICIOBD.TabIndex = 24;
            this.btn_INICIOBD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_INICIOBD.UseVisualStyleBackColor = true;
            // 
            // btn_ACTUALIZARBD
            // 
            this.btn_ACTUALIZARBD.BackgroundImage = global::SBD___CCS.Properties.Resources.mail_send_receive;
            this.btn_ACTUALIZARBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ACTUALIZARBD.Location = new System.Drawing.Point(42, 50);
            this.btn_ACTUALIZARBD.Name = "btn_ACTUALIZARBD";
            this.btn_ACTUALIZARBD.Size = new System.Drawing.Size(35, 35);
            this.btn_ACTUALIZARBD.TabIndex = 23;
            this.btn_ACTUALIZARBD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_ACTUALIZARBD.UseVisualStyleBackColor = true;
            // 
            // btn_SELECCIONARBD
            // 
            this.btn_SELECCIONARBD.BackgroundImage = global::SBD___CCS.Properties.Resources.gtk_leave_fullscreen;
            this.btn_SELECCIONARBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SELECCIONARBD.Location = new System.Drawing.Point(83, 50);
            this.btn_SELECCIONARBD.Name = "btn_SELECCIONARBD";
            this.btn_SELECCIONARBD.Size = new System.Drawing.Size(35, 35);
            this.btn_SELECCIONARBD.TabIndex = 22;
            this.btn_SELECCIONARBD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_SELECCIONARBD.UseVisualStyleBackColor = true;
            this.btn_SELECCIONARBD.Click += new System.EventHandler(this.btn_SELECCIONARBD_Click);
            // 
            // lista_multi
            // 
            this.lista_multi.FormattingEnabled = true;
            this.lista_multi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lista_multi.Items.AddRange(new object[] {
            "mysql",
            "Prueba",
            "ADST-BD"});
            this.lista_multi.Location = new System.Drawing.Point(4, 91);
            this.lista_multi.Name = "lista_multi";
            this.lista_multi.Size = new System.Drawing.Size(106, 342);
            this.lista_multi.TabIndex = 6;
            // 
            // lbl_BD
            // 
            this.lbl_BD.AutoSize = true;
            this.lbl_BD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BD.Location = new System.Drawing.Point(3, 13);
            this.lbl_BD.Name = "lbl_BD";
            this.lbl_BD.Size = new System.Drawing.Size(96, 13);
            this.lbl_BD.TabIndex = 4;
            this.lbl_BD.Text = "Bases de Datos";
            this.lbl_BD.Visible = false;
            // 
            // cmb_BD
            // 
            this.cmb_BD.FormattingEnabled = true;
            this.cmb_BD.Items.AddRange(new object[] {
            "mysql",
            "Prueba",
            "ADST-BD"});
            this.cmb_BD.Location = new System.Drawing.Point(3, 29);
            this.cmb_BD.Name = "cmb_BD";
            this.cmb_BD.Size = new System.Drawing.Size(115, 21);
            this.cmb_BD.TabIndex = 3;
            this.cmb_BD.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(148, 375);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(766, 143);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_RESULTADOS);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(758, 117);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Resultados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_RESULTADOS
            // 
            this.txt_RESULTADOS.Location = new System.Drawing.Point(4, 7);
            this.txt_RESULTADOS.Multiline = true;
            this.txt_RESULTADOS.Name = "txt_RESULTADOS";
            this.txt_RESULTADOS.Size = new System.Drawing.Size(748, 104);
            this.txt_RESULTADOS.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_ERRORES);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(758, 117);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Errores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_ERRORES
            // 
            this.txt_ERRORES.Location = new System.Drawing.Point(5, 6);
            this.txt_ERRORES.Multiline = true;
            this.txt_ERRORES.Name = "txt_ERRORES";
            this.txt_ERRORES.Size = new System.Drawing.Size(748, 104);
            this.txt_ERRORES.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(152, 27);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(755, 342);
            this.tabControl2.TabIndex = 21;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage3.Controls.Add(this.button12);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.toolStrip4);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(23, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(728, 334);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "SQL";
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::SBD___CCS.Properties.Resources.gtk_quit;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.Location = new System.Drawing.Point(88, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(35, 35);
            this.button12.TabIndex = 21;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(6, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(719, 284);
            this.textBox1.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::SBD___CCS.Properties.Resources.document_save_3_256x256x32;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(6, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 35);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::SBD___CCS.Properties.Resources.gtk_media_play_ltr_3_256x256x32;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(47, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 1;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // toolStrip4
            // 
            this.toolStrip4.AutoSize = false;
            this.toolStrip4.Location = new System.Drawing.Point(3, 3);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(722, 38);
            this.toolStrip4.TabIndex = 20;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage4.Controls.Add(this.btn_EXAMINAR);
            this.tabPage4.Controls.Add(this.btn_ELIMINAR);
            this.tabPage4.Controls.Add(this.btn_RELACIONES);
            this.tabPage4.Controls.Add(this.btn_NUEVATABLA);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(23, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(728, 334);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Grafico";
            // 
            // btn_EXAMINAR
            // 
            this.btn_EXAMINAR.Location = new System.Drawing.Point(294, 13);
            this.btn_EXAMINAR.Name = "btn_EXAMINAR";
            this.btn_EXAMINAR.Size = new System.Drawing.Size(90, 37);
            this.btn_EXAMINAR.TabIndex = 4;
            this.btn_EXAMINAR.Text = "Examinar";
            this.btn_EXAMINAR.UseVisualStyleBackColor = true;
            this.btn_EXAMINAR.Click += new System.EventHandler(this.btn_EXAMINAR_Click);
            // 
            // btn_ELIMINAR
            // 
            this.btn_ELIMINAR.Location = new System.Drawing.Point(198, 13);
            this.btn_ELIMINAR.Name = "btn_ELIMINAR";
            this.btn_ELIMINAR.Size = new System.Drawing.Size(90, 37);
            this.btn_ELIMINAR.TabIndex = 3;
            this.btn_ELIMINAR.Text = "Eliminar";
            this.btn_ELIMINAR.UseVisualStyleBackColor = true;
            this.btn_ELIMINAR.Click += new System.EventHandler(this.btn_ELIMINAR_Click);
            // 
            // btn_RELACIONES
            // 
            this.btn_RELACIONES.Location = new System.Drawing.Point(102, 13);
            this.btn_RELACIONES.Name = "btn_RELACIONES";
            this.btn_RELACIONES.Size = new System.Drawing.Size(90, 37);
            this.btn_RELACIONES.TabIndex = 2;
            this.btn_RELACIONES.Text = "Relaciones";
            this.btn_RELACIONES.UseVisualStyleBackColor = true;
            this.btn_RELACIONES.Click += new System.EventHandler(this.btn_RELACIONES_Click);
            // 
            // btn_NUEVATABLA
            // 
            this.btn_NUEVATABLA.Location = new System.Drawing.Point(6, 13);
            this.btn_NUEVATABLA.Name = "btn_NUEVATABLA";
            this.btn_NUEVATABLA.Size = new System.Drawing.Size(90, 37);
            this.btn_NUEVATABLA.TabIndex = 1;
            this.btn_NUEVATABLA.Text = "Nueva Tabla";
            this.btn_NUEVATABLA.UseVisualStyleBackColor = true;
            this.btn_NUEVATABLA.Click += new System.EventHandler(this.btn_NUEVATABLA_Click);
            // 
            // lbl_MSJERROR
            // 
            this.lbl_MSJERROR.BackColor = System.Drawing.Color.Gray;
            this.lbl_MSJERROR.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MSJERROR.Location = new System.Drawing.Point(148, 524);
            this.lbl_MSJERROR.Name = "lbl_MSJERROR";
            this.lbl_MSJERROR.Size = new System.Drawing.Size(209, 13);
            this.lbl_MSJERROR.TabIndex = 23;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pct_SIGNAL
            // 
            this.pct_SIGNAL.Image = global::SBD___CCS.Properties.Resources.nosignal_3_256x256x32;
            this.pct_SIGNAL.Location = new System.Drawing.Point(871, 520);
            this.pct_SIGNAL.Name = "pct_SIGNAL";
            this.pct_SIGNAL.Size = new System.Drawing.Size(24, 23);
            this.pct_SIGNAL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_SIGNAL.TabIndex = 20;
            this.pct_SIGNAL.TabStop = false;
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.manualesToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // manualesToolStripMenuItem
            // 
            this.manualesToolStripMenuItem.Name = "manualesToolStripMenuItem";
            this.manualesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manualesToolStripMenuItem.Text = "Manuales";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(963, 543);
            this.Controls.Add(this.lbl_MSJERROR);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.pct_SIGNAL);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Base de Datos";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_SIGNAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem violarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_BD;
        private System.Windows.Forms.ComboBox cmb_BD;
        private System.Windows.Forms.PictureBox pct_SIGNAL;
        private System.Windows.Forms.ListBox lista_multi;
        private System.Windows.Forms.ToolStripMenuItem querysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.Button btn_EXAMINAR;
        private System.Windows.Forms.Button btn_ELIMINAR;
        private System.Windows.Forms.Button btn_RELACIONES;
        private System.Windows.Forms.Button btn_NUEVATABLA;
        private System.Windows.Forms.TextBox txt_RESULTADOS;
        private System.Windows.Forms.TextBox txt_ERRORES;
        private System.Windows.Forms.Label lbl_MSJERROR;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btn_INICIOBD;
        private System.Windows.Forms.Button btn_ACTUALIZARBD;
        private System.Windows.Forms.Button btn_SELECCIONARBD;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualesToolStripMenuItem;
    }
}

