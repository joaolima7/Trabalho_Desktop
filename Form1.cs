using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_valorTotal_TextChanged(object sender, EventArgs e)
        {
            if (lbl_valorTotal.Text == "0")
            {
                panel3.BackColor = Color.IndianRed;
            }
            else
            {
                panel3.BackColor= Color.CornflowerBlue;
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            lbl_valorTotal.Visible = true;
            lbl_totalRegistro.Visible = true;
            panel3.Visible = true;
            panel2.Visible = true;
        }
    }
}
