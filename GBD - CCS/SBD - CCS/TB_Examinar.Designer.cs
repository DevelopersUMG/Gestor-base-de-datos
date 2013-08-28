namespace SBD___CCS
{
    partial class TB_Examinar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TB_Examinar));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_TM = new System.Windows.Forms.Label();
            this.btn_CANCELAR = new System.Windows.Forms.Button();
            this.btn_INSERTAR = new System.Windows.Forms.Button();
            this.btn_EDITAR = new System.Windows.Forms.Button();
            this.btn_MODIFICAR = new System.Windows.Forms.Button();
            this.btn_ELIMINAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Estado,
            this.Telefono});
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 210);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // lbl_TM
            // 
            this.lbl_TM.Location = new System.Drawing.Point(13, 13);
            this.lbl_TM.Name = "lbl_TM";
            this.lbl_TM.Size = new System.Drawing.Size(174, 23);
            this.lbl_TM.TabIndex = 2;
            // 
            // btn_CANCELAR
            // 
            this.btn_CANCELAR.Location = new System.Drawing.Point(325, 257);
            this.btn_CANCELAR.Name = "btn_CANCELAR";
            this.btn_CANCELAR.Size = new System.Drawing.Size(75, 23);
            this.btn_CANCELAR.TabIndex = 3;
            this.btn_CANCELAR.Text = "Cancelar";
            this.btn_CANCELAR.UseVisualStyleBackColor = true;
            this.btn_CANCELAR.Click += new System.EventHandler(this.btn_CANCELAR_Click);
            // 
            // btn_INSERTAR
            // 
            this.btn_INSERTAR.Location = new System.Drawing.Point(486, 127);
            this.btn_INSERTAR.Name = "btn_INSERTAR";
            this.btn_INSERTAR.Size = new System.Drawing.Size(67, 27);
            this.btn_INSERTAR.TabIndex = 12;
            this.btn_INSERTAR.Text = "Insertar";
            this.btn_INSERTAR.UseVisualStyleBackColor = true;
            // 
            // btn_EDITAR
            // 
            this.btn_EDITAR.Location = new System.Drawing.Point(486, 84);
            this.btn_EDITAR.Name = "btn_EDITAR";
            this.btn_EDITAR.Size = new System.Drawing.Size(67, 27);
            this.btn_EDITAR.TabIndex = 11;
            this.btn_EDITAR.Text = "Editar";
            this.btn_EDITAR.UseVisualStyleBackColor = true;
            // 
            // btn_MODIFICAR
            // 
            this.btn_MODIFICAR.Location = new System.Drawing.Point(486, 41);
            this.btn_MODIFICAR.Name = "btn_MODIFICAR";
            this.btn_MODIFICAR.Size = new System.Drawing.Size(67, 27);
            this.btn_MODIFICAR.TabIndex = 10;
            this.btn_MODIFICAR.Text = "Modificar";
            this.btn_MODIFICAR.UseVisualStyleBackColor = true;
            this.btn_MODIFICAR.Click += new System.EventHandler(this.btn_MODIFICAR_Click);
            // 
            // btn_ELIMINAR
            // 
            this.btn_ELIMINAR.Location = new System.Drawing.Point(486, 170);
            this.btn_ELIMINAR.Name = "btn_ELIMINAR";
            this.btn_ELIMINAR.Size = new System.Drawing.Size(67, 27);
            this.btn_ELIMINAR.TabIndex = 13;
            this.btn_ELIMINAR.Text = "Eliminar";
            this.btn_ELIMINAR.UseVisualStyleBackColor = true;
            // 
            // TB_Examinar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 292);
            this.Controls.Add(this.btn_ELIMINAR);
            this.Controls.Add(this.btn_INSERTAR);
            this.Controls.Add(this.btn_EDITAR);
            this.Controls.Add(this.btn_MODIFICAR);
            this.Controls.Add(this.btn_CANCELAR);
            this.Controls.Add(this.lbl_TM);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TB_Examinar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.SQLgrafico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Label lbl_TM;
        private System.Windows.Forms.Button btn_CANCELAR;
        private System.Windows.Forms.Button btn_INSERTAR;
        private System.Windows.Forms.Button btn_EDITAR;
        private System.Windows.Forms.Button btn_MODIFICAR;
        private System.Windows.Forms.Button btn_ELIMINAR;
    }
}