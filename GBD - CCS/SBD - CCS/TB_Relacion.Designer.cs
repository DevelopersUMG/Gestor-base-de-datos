namespace SBD___CCS
{
    partial class TB_Relacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TB_Relacion));
            this.lt_A = new System.Windows.Forms.ListBox();
            this.bt_BA = new System.Windows.Forms.Button();
            this.bt_AB = new System.Windows.Forms.Button();
            this.bt_Ejecutar = new System.Windows.Forms.Button();
            this.tb_Query = new System.Windows.Forms.TextBox();
            this.lb_Query = new System.Windows.Forms.Label();
            this.cb_A = new System.Windows.Forms.ComboBox();
            this.cb_B = new System.Windows.Forms.ComboBox();
            this.lt_B = new System.Windows.Forms.ListBox();
            this.lb_Informacion = new System.Windows.Forms.Label();
            this.lb_A = new System.Windows.Forms.Label();
            this.lb_B = new System.Windows.Forms.Label();
            this.gb_Crear = new System.Windows.Forms.GroupBox();
            this.gb_Crear.SuspendLayout();
            this.SuspendLayout();
            // 
            // lt_A
            // 
            this.lt_A.Enabled = false;
            this.lt_A.FormattingEnabled = true;
            this.lt_A.Items.AddRange(new object[] {
            "Seleccione una tabla..."});
            this.lt_A.Location = new System.Drawing.Point(15, 53);
            this.lt_A.Name = "lt_A";
            this.lt_A.Size = new System.Drawing.Size(163, 108);
            this.lt_A.TabIndex = 0;
            // 
            // bt_BA
            // 
            this.bt_BA.Location = new System.Drawing.Point(184, 82);
            this.bt_BA.Name = "bt_BA";
            this.bt_BA.Size = new System.Drawing.Size(47, 23);
            this.bt_BA.TabIndex = 5;
            this.bt_BA.Text = "<<";
            this.bt_BA.UseVisualStyleBackColor = true;
            this.bt_BA.Click += new System.EventHandler(this.btn_BA_Click);
            // 
            // bt_AB
            // 
            this.bt_AB.Location = new System.Drawing.Point(184, 53);
            this.bt_AB.Name = "bt_AB";
            this.bt_AB.Size = new System.Drawing.Size(47, 23);
            this.bt_AB.TabIndex = 6;
            this.bt_AB.Text = ">>";
            this.bt_AB.UseVisualStyleBackColor = true;
            this.bt_AB.Click += new System.EventHandler(this.btn_AB_Click);
            // 
            // bt_Ejecutar
            // 
            this.bt_Ejecutar.Location = new System.Drawing.Point(337, 300);
            this.bt_Ejecutar.Name = "bt_Ejecutar";
            this.bt_Ejecutar.Size = new System.Drawing.Size(75, 23);
            this.bt_Ejecutar.TabIndex = 7;
            this.bt_Ejecutar.Text = "Ejecutar";
            this.bt_Ejecutar.UseVisualStyleBackColor = true;
            // 
            // tb_Query
            // 
            this.tb_Query.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Query.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tb_Query.Location = new System.Drawing.Point(27, 210);
            this.tb_Query.Multiline = true;
            this.tb_Query.Name = "tb_Query";
            this.tb_Query.Size = new System.Drawing.Size(382, 84);
            this.tb_Query.TabIndex = 8;
            // 
            // lb_Query
            // 
            this.lb_Query.AutoSize = true;
            this.lb_Query.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Query.Location = new System.Drawing.Point(24, 194);
            this.lb_Query.Name = "lb_Query";
            this.lb_Query.Size = new System.Drawing.Size(44, 13);
            this.lb_Query.TabIndex = 9;
            this.lb_Query.Text = "Query:";
            // 
            // cb_A
            // 
            this.cb_A.FormattingEnabled = true;
            this.cb_A.Items.AddRange(new object[] {
            "Clientes",
            "Proveedores",
            "Productos"});
            this.cb_A.Location = new System.Drawing.Point(15, 26);
            this.cb_A.Name = "cb_A";
            this.cb_A.Size = new System.Drawing.Size(163, 21);
            this.cb_A.TabIndex = 10;
            this.cb_A.SelectedIndexChanged += new System.EventHandler(this.cmb_A_SelectedIndexChanged);
            // 
            // cb_B
            // 
            this.cb_B.FormattingEnabled = true;
            this.cb_B.Items.AddRange(new object[] {
            "Clientes",
            "Proveedores",
            "Productos"});
            this.cb_B.Location = new System.Drawing.Point(237, 28);
            this.cb_B.Name = "cb_B";
            this.cb_B.Size = new System.Drawing.Size(163, 21);
            this.cb_B.TabIndex = 14;
            this.cb_B.SelectedIndexChanged += new System.EventHandler(this.cmb_B_SelectedIndexChanged_1);
            // 
            // lt_B
            // 
            this.lt_B.Enabled = false;
            this.lt_B.FormattingEnabled = true;
            this.lt_B.Items.AddRange(new object[] {
            "Seleccione una tabla..."});
            this.lt_B.Location = new System.Drawing.Point(237, 53);
            this.lt_B.Name = "lt_B";
            this.lt_B.Size = new System.Drawing.Size(163, 108);
            this.lt_B.TabIndex = 13;
            this.lt_B.SelectedIndexChanged += new System.EventHandler(this.lt_B_SelectedIndexChanged);
            // 
            // lb_Informacion
            // 
            this.lb_Informacion.AutoSize = true;
            this.lb_Informacion.Location = new System.Drawing.Point(203, 148);
            this.lb_Informacion.Name = "lb_Informacion";
            this.lb_Informacion.Size = new System.Drawing.Size(13, 13);
            this.lb_Informacion.TabIndex = 16;
            this.lb_Informacion.Text = "a";
            // 
            // lb_A
            // 
            this.lb_A.AutoSize = true;
            this.lb_A.Location = new System.Drawing.Point(184, 148);
            this.lb_A.Name = "lb_A";
            this.lb_A.Size = new System.Drawing.Size(0, 13);
            this.lb_A.TabIndex = 17;
            // 
            // lb_B
            // 
            this.lb_B.AutoSize = true;
            this.lb_B.Location = new System.Drawing.Point(222, 148);
            this.lb_B.Name = "lb_B";
            this.lb_B.Size = new System.Drawing.Size(0, 13);
            this.lb_B.TabIndex = 18;
            // 
            // gb_Crear
            // 
            this.gb_Crear.Controls.Add(this.cb_A);
            this.gb_Crear.Controls.Add(this.lb_B);
            this.gb_Crear.Controls.Add(this.lt_A);
            this.gb_Crear.Controls.Add(this.lb_A);
            this.gb_Crear.Controls.Add(this.bt_BA);
            this.gb_Crear.Controls.Add(this.lb_Informacion);
            this.gb_Crear.Controls.Add(this.bt_AB);
            this.gb_Crear.Controls.Add(this.cb_B);
            this.gb_Crear.Controls.Add(this.lt_B);
            this.gb_Crear.Location = new System.Drawing.Point(12, 12);
            this.gb_Crear.Name = "gb_Crear";
            this.gb_Crear.Size = new System.Drawing.Size(410, 178);
            this.gb_Crear.TabIndex = 19;
            this.gb_Crear.TabStop = false;
            this.gb_Crear.Text = "Crear Relacion";
            // 
            // TB_Relacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 331);
            this.Controls.Add(this.gb_Crear);
            this.Controls.Add(this.lb_Query);
            this.Controls.Add(this.tb_Query);
            this.Controls.Add(this.bt_Ejecutar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TB_Relacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relacionar";
            this.Load += new System.EventHandler(this.TB_Relacion_Load);
            this.gb_Crear.ResumeLayout(false);
            this.gb_Crear.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lt_A;
        private System.Windows.Forms.Button bt_BA;
        private System.Windows.Forms.Button bt_AB;
        private System.Windows.Forms.Button bt_Ejecutar;
        private System.Windows.Forms.TextBox tb_Query;
        private System.Windows.Forms.Label lb_Query;
        private System.Windows.Forms.ComboBox cb_A;
        private System.Windows.Forms.ComboBox cb_B;
        private System.Windows.Forms.ListBox lt_B;
        private System.Windows.Forms.Label lb_Informacion;
        private System.Windows.Forms.Label lb_A;
        private System.Windows.Forms.Label lb_B;
        private System.Windows.Forms.GroupBox gb_Crear;
    }
}