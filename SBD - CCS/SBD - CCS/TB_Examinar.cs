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
    public partial class TB_Examinar : Form
    {
        public TB_Examinar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SQLgrafico_Load(object sender, EventArgs e)
        {

        }
        public void Asignar(String x) {

            lbl_TM.Text = ("Tabla: " + x);
        }

        private void btn_CANCELAR_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_MODIFICAR_Click(object sender, EventArgs e)
        {

        }

       
    }
}
