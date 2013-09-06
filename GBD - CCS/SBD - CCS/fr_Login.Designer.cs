namespace SBD___CCS
{
    partial class fr_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_Login));
            this.tb_Usuario = new System.Windows.Forms.TextBox();
            this.tb_Contrasena = new System.Windows.Forms.TextBox();
            this.lb_Usuario = new System.Windows.Forms.Label();
            this.lb_Contrasena = new System.Windows.Forms.Label();
            this.lb_Host = new System.Windows.Forms.Label();
            this.tb_Host = new System.Windows.Forms.TextBox();
            this.bt_Ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Usuario
            // 
            this.tb_Usuario.Location = new System.Drawing.Point(132, 29);
            this.tb_Usuario.Name = "tb_Usuario";
            this.tb_Usuario.Size = new System.Drawing.Size(100, 20);
            this.tb_Usuario.TabIndex = 0;
            this.tb_Usuario.Text = "root";
            // 
            // tb_Contrasena
            // 
            this.tb_Contrasena.Location = new System.Drawing.Point(132, 56);
            this.tb_Contrasena.Name = "tb_Contrasena";
            this.tb_Contrasena.Size = new System.Drawing.Size(100, 20);
            this.tb_Contrasena.TabIndex = 1;
            // 
            // lb_Usuario
            // 
            this.lb_Usuario.AutoSize = true;
            this.lb_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Usuario.Location = new System.Drawing.Point(44, 36);
            this.lb_Usuario.Name = "lb_Usuario";
            this.lb_Usuario.Size = new System.Drawing.Size(50, 13);
            this.lb_Usuario.TabIndex = 2;
            this.lb_Usuario.Text = "Usuario";
            // 
            // lb_Contrasena
            // 
            this.lb_Contrasena.AutoSize = true;
            this.lb_Contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Contrasena.Location = new System.Drawing.Point(44, 63);
            this.lb_Contrasena.Name = "lb_Contrasena";
            this.lb_Contrasena.Size = new System.Drawing.Size(71, 13);
            this.lb_Contrasena.TabIndex = 3;
            this.lb_Contrasena.Text = "Contraseña";
            // 
            // lb_Host
            // 
            this.lb_Host.AutoSize = true;
            this.lb_Host.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Host.Location = new System.Drawing.Point(44, 89);
            this.lb_Host.Name = "lb_Host";
            this.lb_Host.Size = new System.Drawing.Size(33, 13);
            this.lb_Host.TabIndex = 7;
            this.lb_Host.Text = "Host";
            // 
            // tb_Host
            // 
            this.tb_Host.Location = new System.Drawing.Point(132, 82);
            this.tb_Host.Name = "tb_Host";
            this.tb_Host.Size = new System.Drawing.Size(100, 20);
            this.tb_Host.TabIndex = 6;
            this.tb_Host.Text = "127.0.0.1";
            // 
            // bt_Ingresar
            // 
            this.bt_Ingresar.Location = new System.Drawing.Point(157, 108);
            this.bt_Ingresar.Name = "bt_Ingresar";
            this.bt_Ingresar.Size = new System.Drawing.Size(75, 23);
            this.bt_Ingresar.TabIndex = 8;
            this.bt_Ingresar.Text = "Ingresar";
            this.bt_Ingresar.UseVisualStyleBackColor = true;
            this.bt_Ingresar.Click += new System.EventHandler(this.btn_INGRESAR_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 169);
            this.Controls.Add(this.bt_Ingresar);
            this.Controls.Add(this.lb_Host);
            this.Controls.Add(this.tb_Host);
            this.Controls.Add(this.lb_Contrasena);
            this.Controls.Add(this.lb_Usuario);
            this.Controls.Add(this.tb_Contrasena);
            this.Controls.Add(this.tb_Usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Base de Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Usuario;
        private System.Windows.Forms.TextBox tb_Contrasena;
        private System.Windows.Forms.Label lb_Usuario;
        private System.Windows.Forms.Label lb_Contrasena;
        private System.Windows.Forms.Label lb_Host;
        private System.Windows.Forms.TextBox tb_Host;
        private System.Windows.Forms.Button bt_Ingresar;
    }
}