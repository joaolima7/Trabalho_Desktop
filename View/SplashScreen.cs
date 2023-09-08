using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Desktop.View
{
    public partial class SplashScreen : Form
    {

        int tempo = 0;
        Form1 Tela = new Form1();
        public SplashScreen()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempo++;
            if (tempo == 3)
            {
                timer1.Stop();
                this.Hide();
                Tela.Show();
            }
        }
    }
}
