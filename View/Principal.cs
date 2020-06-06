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
        Minerar miner = new Minerar();
        Item itemTeste = new Item();
        public Principal(Form login)
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
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;

        
        private void FecharAplicacao(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", buttons) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void DesconectarUser(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente desconectar?", "Desconectar", buttons) == DialogResult.Yes)
            {
                Application.Restart();
            }  
        }

        private void AbrirTela(object formGen)
        {
            Form fm = formGen as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(fm);
            panelPrincipal.Tag = fm;
            fm.Show();
        }

        private void abrirMineracao(object sender, EventArgs e)
        {
            AbrirTela(miner);
        }

        private void abrirItem(object sender, EventArgs e)
        {
            Form fm = itemTeste as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            panelItem1.Controls.Add(fm);
            panelItem1.Tag = fm;
            fm.Show();
        }
    }
}
