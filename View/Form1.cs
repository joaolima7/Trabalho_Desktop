﻿using System;
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
            button1.Enabled = true;
        }

        //private void btn_excluir_VisibleChanged(object sender, EventArgs e)
        //{

        //}

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
    }
}