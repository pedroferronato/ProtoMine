using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtoMine.View
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            Image i = Image.FromFile("../../icon/Miner.png");
            foto.BackgroundImage = i;
        }

        private void PrincipalFechada(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            // Quando a janela principal for fechada toda a execução do sistema será interrompida
            
        }

        private void OnClickSair(object sender, EventArgs e)
        {
            Application.Exit();
            // Quando a janela principal for fechada toda a execução do sistema será interrompida
        }
    }
}
