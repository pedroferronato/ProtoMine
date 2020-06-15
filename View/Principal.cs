using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using ProtoMine.Cache;
using ProtoMine.Controle;
using ProtoMine.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtoMine.View
{
    public partial class Principal : Form
    {
        public List<Panel> paineis = new List<Panel>();

        public List<Item> inventario = new List<Item>();

        public List<ItemEspecialView> itensEspeciais = new List<ItemEspecialView>();
        
        public List<Panel> lbEspeciais = new List<Panel>();

        readonly ItemController itemController = new ItemController();

        readonly UtilidadesTelas util = new UtilidadesTelas();

        int pepega = 1;

        readonly Usuario usuLogado = UserCache.UsuarioLogado;

        public Principal()
        {
            InitializeComponent();
            UserCache.UsuarioLogado.Peso = 0;

            picPeso.BackColor = Color.Transparent;

            // Início do load de itens
            itemController.CarregarItens(this);
            itemController.CarregarItensEspeciais();
            itemController.CarregarMercado();
            GerarDict();

            // labels de item
            paineis.Add(panelItem1);
            paineis.Add(panelItem2);
            paineis.Add(panelItem3);
            paineis.Add(panelItem4);
            paineis.Add(panelItem5);
            paineis.Add(panelItem6);

            lbEspeciais.Add(panelExpecial1);
            lbEspeciais.Add(panelExpecial2);

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

            toolTipAdm.SetToolTip(picADM, "Formulário de administração");
            toolTipMinerar.SetToolTip(picMinerar, "Coleta de itens");
            toolTipLoja.SetToolTip(picLoja, "Loja de compra de itens");
            toolTipReiniciar.SetToolTip(picRelogar, "Desconectar usuário");
            toolTipDesligar.SetToolTip(picDesligar, "Desligar o sistema");
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
                inventario.Add(new Item(ItemCache.ListaItens[index], this));
                AbrirTela(inventario[index], paineis[index]);
                index++;
            }

            itensEspeciais.Add(new ItemEspecialView(UserCache.Picareta));
            if (UserCache.Mochila != null)
                itensEspeciais.Add(new ItemEspecialView(UserCache.Mochila));

            index = 0;
            foreach (ItemEspecialView item in itensEspeciais)
            {
                AbrirTela(item, lbEspeciais[index]);
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

        readonly MessageBoxButtons buttons = MessageBoxButtons.YesNo;

        public void GerarDict()
        {
            try
            {
                itemController.BuscarTodos();
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro ao buscar itens, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado ao buscar itens:  " + ex.Message, "Erro!");
                throw ex;
            }
        }

        public void AbrirTela(object formGen, Panel fundoBase)
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
                try
                {
                    SalvarUsuario();
                }
                catch (MySqlException exce)
                {
                    util.MensagemDeTeste("Erro ao salvar usuario, falha na conexão ao banco de dados", "Erro!");
                    throw exce;
                }
                catch (Exception ex)
                {
                    util.MensagemDeTeste("Erro não esperado ao salvar usuario:  " + ex.Message, "Erro!");
                    throw ex;
                }
                finally
                {
                    Application.Exit();
                }
            }
        }

        private void Desconectar(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente desconectar?", "Desconectar", buttons) == DialogResult.Yes)
            {
                try
                {
                    SalvarUsuario();
                }
                catch (MySqlException exce)
                {
                    util.MensagemDeTeste("Erro ao salvar usuario, falha na conexão ao banco de dados", "Erro!");
                    throw exce;
                }
                catch (Exception ex)
                {
                    util.MensagemDeTeste("Erro não esperado ao salvar usuario:  " + ex.Message, "Erro!");
                    throw ex;
                }
                finally
                {
                    Application.Restart();
                }
            }
        }

        private void Minerar(object sender, EventArgs e)
        {
            Minerar miner = new Minerar(this);
            pepega++;
            if (pepega >= 20)
            {
                Pepega easter = new Pepega();
                AbrirTela(easter, panelPrincipal);
            }
            else
                AbrirTela(miner, panelPrincipal);
        }

        private void Cadastrar(object sender, EventArgs e)
        {
            Cadastro telaCadastro = new Cadastro();
            AbrirTela(telaCadastro, panelPrincipal);
        }

        private void AbrirLoja(object sender, EventArgs e)
        {
            Loja telaLoja = new Loja(this);
            AbrirTela(telaLoja, panelPrincipal);
        }

        private void SalvarUsuario()
        {
            UsuarioController usuarioController = new UsuarioController();
            try
            {
                usuarioController.AtualizarUsuario();
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro ao salvar usuario, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado ao salvar usuario:  " + ex.Message, "Erro!");
                throw ex;
            }
            
            foreach (ItemModel item in ItemCache.ListaItens)
            {
                try
                {
                    itemController.AtualizarItem(item);
                }
                catch (MySqlException exce)
                {
                    util.MensagemDeTeste("Erro ao atualizar item, falha na conexão ao banco de dados", "Erro!");
                    throw exce;
                }
                catch (Exception ex)
                {
                    util.MensagemDeTeste("Erro não esperado ao atualizar item:  " + ex.Message, "Erro!");
                    throw ex;
                }
            }
        }
    }
}
