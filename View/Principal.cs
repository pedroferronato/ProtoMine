using Microsoft.VisualBasic.ApplicationServices;
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
        List<Panel> paineis = new List<Panel>();

        ItemController itemController = new ItemController();

        int pepega = 1;

        Usuario usuLogado = UserCache.UsuarioLogado;

        public Principal(Form login)
        {
            InitializeComponent();
            picPeso.BackColor = Color.Transparent;
            // Início do load de itens
            itemController.CarregarItens(this);
            GerarDict();
            // labels de item
            paineis.Add(panelItem1);
            paineis.Add(panelItem2);
            paineis.Add(panelItem3);
            paineis.Add(panelItem4);
            paineis.Add(panelItem5);
            paineis.Add(panelItem6);

            CarregarInventario();

            Image i;
            if (UserCache.UsuarioLogado.Role.Equals("admin"))
                i = Image.FromFile("../../icon/jones.png");
            else
                i = Image.FromFile("../../icon/miner.png");
            foto.BackgroundImage = i;
            lbNome.Text = usuLogado.Nome;
            money.Text = usuLogado.Moeda.ToString() + " $";
            lbPeso.Text = usuLogado.Peso.ToString() + " Kg";
            picDesligar.Visible = false;
            picRelogar.Visible = false;
            picLoja.Visible = false;
            picMinerar.Visible = false;
            picADM.Visible = false;
            lbNivel.Text = "Nível: " + UserCache.UsuarioLogado.Nivel.ToString();
            CarregarXp();
        }

        private void CarregarXp()
        {
            if (!UserCache.Mestre)
            {
                int nv = UserCache.UsuarioLogado.Nivel;
                int tetoXp = ((nv * 100) - (nv * nv)) + (nv * nv * nv);
                int porcentagem = (int)(UserCache.UsuarioLogado.Experiencia * 100) / tetoXp;
                panSupXp.Width = porcentagem * 2; 
            }
            else
            {
                panSupXp.Width = 200;
                panSupXp.BackColor = Color.Gold;
            }
        }

        public void CarregarInventario()
        {
            int index = 0;

            foreach (ItemModel item in ItemCache.ListaItens)
            {
                AbrirTela(new Item(ItemCache.ListaItens[index]), paineis[index]);
                index++;
            }
        }

        private void mostarMenu(object sender, EventArgs e)
        {
            picDesligar.Visible = !picDesligar.Visible;
            picRelogar.Visible = !picRelogar.Visible;
            picLoja.Visible = !picLoja.Visible;
            picMinerar.Visible = !picMinerar.Visible;
            if (!usuLogado.Role.Equals("jogador"))
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

        public void GerarDict()
        {
            UtilidadesTelas util = new UtilidadesTelas();
            ItemController itemController = new ItemController();
            itemController.BuscarTodos();
            /*string teste = "";
            foreach (KeyValuePair<int, ItemModel> item in ItemCache.ListaGeral)
            {
                teste += "Key: " + item.Key + " Item id: " + item.Value.Id + " Nome: " + item.Value.Nome + "\n";
            }
            util.MensagemDeTeste(teste, "geral");*/
        }

        private void AbrirTela(object formGen, Panel fundoBase)
        {
            if (fundoBase.Controls.Count > 0)
                fundoBase.Controls.RemoveAt(0);
            Form fm = formGen as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            fundoBase.Controls.Add(fm);
            fundoBase.Tag = fm;
            fm.Show();
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
            Minerar miner = new Minerar(this);
            pepega++;
            if (pepega >= 10)
            {
                Pepega easter = new Pepega();
                AbrirTela(easter, panelPrincipal);
            }
            else
                AbrirTela(miner, panelPrincipal);
        }

        private void Cadastrar(object sender, EventArgs e)
        {
            Cadastro telaCadastro = new Cadastro(this);
            AbrirTela(telaCadastro, panelPrincipal);
        }
    }
}
