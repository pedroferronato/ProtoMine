using ProtoMine.Cache;
using ProtoMine.Controle;
using ProtoMine.Modelo;
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

        List<Panel> paineis = new List<Panel>();

        ItemController itemController = new ItemController();

        pepega easter = new pepega();

        int pepega = 1;

        public Principal(Form login)
        {
            InitializeComponent();
            
            // Início do load de itens
            itemController.CarregarItens();

            // labels de item
            paineis.Add(panelItem1);
            paineis.Add(panelItem2);
            paineis.Add(panelItem3);
            paineis.Add(panelItem4);
            paineis.Add(panelItem5);
            paineis.Add(panelItem6);
            paineis.Add(panelItem7);
            paineis.Add(panelItem8);
            paineis.Add(panelItem9);

            int index = 0;

            foreach (ItemModel item in ItemCache.ListaItens)
            {
                AbrirTela(new Item(), paineis[index]);
                index++;
            }

            Image i;
            if (UserCache.UsuarioLogado.Role.Equals("admin"))
                i = Image.FromFile("../../icon/jones.png");
            else
                i = Image.FromFile("../../icon/miner.png");
            foto.BackgroundImage = i;
            lbNome.Text = UserCache.UsuarioLogado.Nome;
            money.Text = UserCache.UsuarioLogado.Moeda.ToString() + " $";
            picDesligar.Visible = false;
            picRelogar.Visible = false;
            picLoja.Visible = false;
            picMinerar.Visible = false;
            picADM.Visible = false;
        }

        private void mostarMenu(object sender, EventArgs e)
        {
            picDesligar.Visible = !picDesligar.Visible;
            picRelogar.Visible = !picRelogar.Visible;
            picLoja.Visible = !picLoja.Visible;
            picMinerar.Visible = !picMinerar.Visible;
            if (!UserCache.UsuarioLogado.Role.Equals("jogador"))
            {
                picADM.Visible = !picADM.Visible;
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

        private void AbrirTela(object formGen, Panel fundoBase)
        {
            Form fm = formGen as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            fundoBase.Controls.Add(fm);
            fundoBase.Tag = fm;
            fm.Show();
        }

        private void AbrirMineracao(object sender, EventArgs e)
        {
            
        }

        private void FecharAppProto(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", buttons) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Desconectar(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente desconectar?", "Desconectar", buttons) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void Minerar(object sender, EventArgs e)
        {
            pepega++;
            if (pepega == 5)
                AbrirTela(easter, panelPrincipal);
            else
                AbrirTela(miner, panelPrincipal);
        }
    }
}
