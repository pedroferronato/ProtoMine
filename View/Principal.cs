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

        private void mostarMenu(object sender, EventArgs e)
        {
            panelBurg.Visible = !panelBurg.Visible;
            if (!UserCache.UsuarioLogado.Role.Equals("jogador"))
            {
                pnAdmin.Visible = !pnAdmin.Visible;
            }
        }

        private void FecharAplicacao(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
