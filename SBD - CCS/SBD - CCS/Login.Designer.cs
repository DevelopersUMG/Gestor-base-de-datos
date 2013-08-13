namespace SBD___CCS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_USUARIO = new System.Windows.Forms.TextBox();
            this.txt_CONTRA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_INGRESAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_HOST = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_USUARIO
            // 
            this.txt_USUARIO.Location = new System.Drawing.Point(132, 29);
            this.txt_USUARIO.Name = "txt_USUARIO";
            this.txt_USUARIO.Size = new System.Drawing.Size(100, 20);
            this.txt_USUARIO.TabIndex = 0;
            // 
            // txt_CONTRA
            // 
            this.txt_CONTRA.Location = new System.Drawing.Point(132, 56);
            this.txt_CONTRA.Name = "txt_CONTRA";
            this.txt_CONTRA.Size = new System.Drawing.Size(100, 20);
            this.txt_CONTRA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // btn_INGRESAR
            // 
            this.btn_INGRESAR.Location = new System.Drawing.Point(157, 117);
            this.btn_INGRESAR.Name = "btn_INGRESAR";
            this.btn_INGRESAR.Size = new System.Drawing.Size(75, 23);
            this.btn_INGRESAR.TabIndex = 5;
            this.btn_INGRESAR.Text = "Ingresar";
            this.btn_INGRESAR.UseVisualStyleBackColor = true;
            this.btn_INGRESAR.Click += new System.EventHandler(this.btn_INGRESAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Host";
            // 
            // txt_HOST
            // 
            this.txt_HOST.Location = new System.Drawing.Point(132, 82);
            this.txt_HOST.Name = "txt_HOST";
            this.txt_HOST.Size = new System.Drawing.Size(100, 20);
            this.txt_HOST.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 169);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_HOST);
            this.Controls.Add(this.btn_INGRESAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CONTRA);
            this.Controls.Add(this.txt_USUARIO);
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

        private System.Windows.Forms.TextBox txt_USUARIO;
        private System.Windows.Forms.TextBox txt_CONTRA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_INGRESAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_HOST;
    }
}