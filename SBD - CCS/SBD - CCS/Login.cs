using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SBD___CCS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_INGRESAR_Click(object sender, EventArgs e)
        {
            Inicio x = new Inicio(txt_USUARIO.Text,txt_CONTRA.Text,txt_HOST.Text);
            x.Show();
            this.Hide();
            
           
            
        }

      
    }
}
