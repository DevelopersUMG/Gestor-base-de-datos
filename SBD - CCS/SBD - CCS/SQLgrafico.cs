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
    public partial class SQLgrafico : Form
    {
        public SQLgrafico()
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
    }
}
