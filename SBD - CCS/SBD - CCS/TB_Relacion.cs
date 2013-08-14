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
    public partial class TB_Relacion : Form
    {
        public TB_Relacion()
        {
            InitializeComponent();
        }

        private void TB_Relacion_Load(object sender, EventArgs e)
        {

        }

        private void btn_AB_Click(object sender, EventArgs e)
        {
            lst_B.Items.Add(lst_A.SelectedItem.ToString());
            lbl_A.Text = ("1");
            lbl_B.Text = ("n");
        }

        private void btn_BA_Click(object sender, EventArgs e)
        {
            
            lst_A.Items.Add(lst_B.SelectedItem.ToString());
            lbl_A.Text = ("n");
            lbl_B.Text = ("1");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
