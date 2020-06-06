using ProtoMine.Cache;
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
            Image i;
            if (UserCache.UsuarioLogado.Role.Equals("admin"))
            {
                i = Image.FromFile("../../icon/jones.png");
            }
            else
            {
                i = Image.FromFile("../../icon/miner.png");
            }
            foto.BackgroundImage = i;
            lbNome.Text = UserCache.UsuarioLogado.Nome;
            pnAdmin.Visible = false;
        }

        private void alterarVizibilidadeBurguer()
        {
            panelBurg.Visible = !panelBurg.Visible;
            if (!UserCache.UsuarioLogado.Role.Equals("jogador"))
            {
                pnAdmin.Visible = !pnAdmin.Visible;
            }
        }

        private void mostarMenu(object sender, EventArgs e)
        {
            alterarVizibilidadeBurguer();
        }
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;

        
        private void FecharAplicacao(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", buttons) == DialogResult.Yes)
            {
                Application.Exit();
            }
            alterarVizibilidadeBurguer();
        }

        private void DesconectarUser(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente desconectar?", "Desconectar", buttons) == DialogResult.Yes)
            {
                Application.Restart();
            }
            alterarVizibilidadeBurguer();
        }
    }
}
