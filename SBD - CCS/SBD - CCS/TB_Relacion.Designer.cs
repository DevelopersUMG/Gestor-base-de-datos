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
            this.lst_A = new System.Windows.Forms.ListBox();
            this.btn_BA = new System.Windows.Forms.Button();
            this.btn_AB = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_QUERY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_A = new System.Windows.Forms.ComboBox();
            this.cmb_B = new System.Windows.Forms.ComboBox();
            this.lst_B = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_A = new System.Windows.Forms.Label();
            this.lbl_B = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SELECCIONARA = new System.Windows.Forms.Button();
            this.btn_SELECCIONARB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_A
            // 
            this.lst_A.FormattingEnabled = true;
            this.lst_A.Items.AddRange(new object[] {
            "ID_Producto"});
            this.lst_A.Location = new System.Drawing.Point(15, 53);
            this.lst_A.Name = "lst_A";
            this.lst_A.Size = new System.Drawing.Size(163, 108);
            this.lst_A.TabIndex = 0;
            // 
            // btn_BA
            // 
            this.btn_BA.Location = new System.Drawing.Point(184, 82);
            this.btn_BA.Name = "btn_BA";
            this.btn_BA.Size = new System.Drawing.Size(47, 23);
            this.btn_BA.TabIndex = 5;
            this.btn_BA.Text = "<<";
            this.btn_BA.UseVisualStyleBackColor = true;
            this.btn_BA.Click += new System.EventHandler(this.btn_BA_Click);
            // 
            // btn_AB
            // 
            this.btn_AB.Location = new System.Drawing.Point(184, 53);
            this.btn_AB.Name = "btn_AB";
            this.btn_AB.Size = new System.Drawing.Size(47, 23);
            this.btn_AB.TabIndex = 6;
            this.btn_AB.Text = ">>";
            this.btn_AB.UseVisualStyleBackColor = true;
            this.btn_AB.Click += new System.EventHandler(this.btn_AB_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 543);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Ejecutar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txt_QUERY
            // 
            this.txt_QUERY.Location = new System.Drawing.Point(27, 210);
            this.txt_QUERY.Multiline = true;
            this.txt_QUERY.Name = "txt_QUERY";
            this.txt_QUERY.Size = new System.Drawing.Size(382, 84);
            this.txt_QUERY.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Query:";
            // 
            // cmb_A
            // 
            this.cmb_A.FormattingEnabled = true;
            this.cmb_A.Items.AddRange(new object[] {
            "Clientes",
            "Proveedores",
            "Productos"});
            this.cmb_A.Location = new System.Drawing.Point(15, 26);
            this.cmb_A.Name = "cmb_A";
            this.cmb_A.Size = new System.Drawing.Size(120, 21);
            this.cmb_A.TabIndex = 10;
            // 
            // cmb_B
            // 
            this.cmb_B.FormattingEnabled = true;
            this.cmb_B.Items.AddRange(new object[] {
            "Clientes",
            "Proveedores",
            "Productos"});
            this.cmb_B.Location = new System.Drawing.Point(237, 28);
            this.cmb_B.Name = "cmb_B";
            this.cmb_B.Size = new System.Drawing.Size(120, 21);
            this.cmb_B.TabIndex = 14;
            // 
            // lst_B
            // 
            this.lst_B.FormattingEnabled = true;
            this.lst_B.Items.AddRange(new object[] {
            "ID_Cliente"});
            this.lst_B.Location = new System.Drawing.Point(237, 53);
            this.lst_B.Name = "lst_B";
            this.lst_B.Size = new System.Drawing.Size(163, 108);
            this.lst_B.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "a";
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.Location = new System.Drawing.Point(184, 148);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(0, 13);
            this.lbl_A.TabIndex = 17;
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.Location = new System.Drawing.Point(222, 148);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(0, 13);
            this.lbl_B.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_SELECCIONARB);
            this.groupBox1.Controls.Add(this.btn_SELECCIONARA);
            this.groupBox1.Controls.Add(this.cmb_A);
            this.groupBox1.Controls.Add(this.lbl_B);
            this.groupBox1.Controls.Add(this.lst_A);
            this.groupBox1.Controls.Add(this.lbl_A);
            this.groupBox1.Controls.Add(this.btn_BA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_AB);
            this.groupBox1.Controls.Add(this.cmb_B);
            this.groupBox1.Controls.Add(this.lst_B);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 178);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Relacion";
            // 
            // btn_SELECCIONARA
            // 
            this.btn_SELECCIONARA.BackgroundImage = global::SBD___CCS.Properties.Resources.document_save_3_256x256x32;
            this.btn_SELECCIONARA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SELECCIONARA.Location = new System.Drawing.Point(141, 12);
            this.btn_SELECCIONARA.Name = "btn_SELECCIONARA";
            this.btn_SELECCIONARA.Size = new System.Drawing.Size(35, 35);
            this.btn_SELECCIONARA.TabIndex = 19;
            this.btn_SELECCIONARA.UseVisualStyleBackColor = true;
            this.btn_SELECCIONARA.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_SELECCIONARB
            // 
            this.btn_SELECCIONARB.BackgroundImage = global::SBD___CCS.Properties.Resources.document_save_3_256x256x32;
            this.btn_SELECCIONARB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SELECCIONARB.Location = new System.Drawing.Point(365, 14);
            this.btn_SELECCIONARB.Name = "btn_SELECCIONARB";
            this.btn_SELECCIONARB.Size = new System.Drawing.Size(35, 35);
            this.btn_SELECCIONARB.TabIndex = 20;
            this.btn_SELECCIONARB.UseVisualStyleBackColor = true;
            // 
            // TB_Relacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 304);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_QUERY);
            this.Controls.Add(this.button3);
            this.Name = "TB_Relacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relacionar";
            this.Load += new System.EventHandler(this.TB_Relacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_A;
        private System.Windows.Forms.Button btn_BA;
        private System.Windows.Forms.Button btn_AB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_QUERY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_A;
        private System.Windows.Forms.ComboBox cmb_B;
        private System.Windows.Forms.ListBox lst_B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.Label lbl_B;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SELECCIONARB;
        private System.Windows.Forms.Button btn_SELECCIONARA;
    }
}