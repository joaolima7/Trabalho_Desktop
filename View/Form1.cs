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
        private bool fechaform = false;

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
            if (Cb_filter.Text == "Nome Animal")
            {

            }
            else if (Cb_filter.Text == "Nome Nome Proprietário")
            {

            }
            else if (Cb_filter.Text == "Código")
            {

            }
            else
            {
                MessageBox.Show("Selecione o tipo de pesquisa!", "ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Cb_filter.Focus();
            }
            
            lbl_valorTotal.Visible = true;
            lbl_totalRegistro.Visible = true;
            panel3.Visible = true;
            panel2.Visible = true;
            button1.Enabled = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btn_salvar_EnabledChanged(object sender, EventArgs e)
        {
            if (btn_salvar.Enabled == true)
            {
                btn_salvar.BackColor = Color.LightSteelBlue;
            }
            else
            {
                btn_salvar.BackColor = Color.DarkGray;
            }
        }

        private void btn_cancelar_EnabledChanged(object sender, EventArgs e)
        {
            if (btn_cancelar.Enabled == true)
            {
                btn_cancelar.BackColor = Color.LightSteelBlue;
            }
            else
            {
                btn_cancelar.BackColor = Color.DarkGray;
            }
        }

        private void btn_excluir_EnabledChanged(object sender, EventArgs e)
        {
            if (btn_excluir.Enabled == true)
            {
                btn_excluir.BackColor = Color.LightSteelBlue;
            }
            else
            {
                btn_excluir.BackColor = Color.DarkGray;
            }
        }

        private void btn_criar_EnabledChanged(object sender, EventArgs e)
        {
            if (btn_criar.Enabled == true)
            {
                btn_criar.BackColor = Color.LightSteelBlue;
            }
            else
            {
                btn_criar.BackColor = Color.DarkGray;
            }
        }

        private void button1_EnabledChanged(object sender, EventArgs e)
        {
            if (button1.Enabled == true)
            {
                button1.BackColor = Color.LightSteelBlue;
            }
            else
            {
                button1.BackColor = Color.DarkGray;
            }
        }

        private void button2_EnabledChanged(object sender, EventArgs e)
        {
            if (button2.Enabled == true)
            {
                button2.BackColor = Color.LightSteelBlue;
            }
            else
            {
                button2.BackColor = Color.DarkGray;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            btn_criar.Enabled = false;
            button1.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_salvar.Enabled = true;
            btn_excluir.Enabled = false;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            btn_salvar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_criar.Enabled = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            btn_cancelar.Enabled = false;
            button1.Enabled = false;
            btn_criar.Enabled = true;
            btn_salvar.Enabled = false;
            btn_excluir.Enabled = false;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            btn_excluir.Enabled = false;
            btn_salvar.Enabled=false;
            btn_cancelar.Enabled = false;
            btn_criar.Enabled = true; 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!fechaform)
            {
                DialogResult dr = MessageBox.Show("Deseja sair?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    fechaform = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
