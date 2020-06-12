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
    public partial class CriacaoPedido : Form
    {
        ItemModel itemEscolhido;

        Principal TelaPrincipal;

        string trava;

        public CriacaoPedido(ItemModel item, Principal principal)
        {
            InitializeComponent();
            TelaPrincipal = principal;
            itemEscolhido = item;
            picItem.Image = Image.FromFile(item.UrlImg);
            lbNome.Text = item.Nome;
            lbQtdUser.Text = item.Quantidade.ToString();
        }

        public CriacaoPedido(ItemModel item, Principal principal, string travaVendaNpc)
        {
            InitializeComponent();
            TelaPrincipal = principal;
            itemEscolhido = item;
            picItem.Image = Image.FromFile(item.UrlImg);
            lbNome.Text = item.Nome;
            lbQtdUser.Text = item.Quantidade.ToString();
            VendaController vendaController = new VendaController();
            numValUnit.Value = vendaController.CalcularMedia(item.Id);
            numValUnit.Minimum = numValUnit.Value;
            numValUnit.Maximum = numValUnit.Value;
            txtValorTotal.Text = (numQuantidade.Value * numValUnit.Value).ToString();
            trava = travaVendaNpc;
            btnPedido.Text = "Vender";
        }

        private void Cancelar(object sender, EventArgs e)
        {
            Close();
        }

        private void CriarPedidoVenda(object sender, EventArgs e)
        {
            if (trava != "NPC")
            {
                Pedido pedido = new Pedido();
                pedido.Quantidade = Convert.ToInt32(numQuantidade.Value);
                pedido.Valor = Convert.ToInt32(txtValorTotal.Text);
                pedido.ValorUnitario = Convert.ToInt32(numValUnit.Value);
                PedidosController pedidosController = new PedidosController();
                try
                {
                    pedidosController.InserirPedido(pedido, itemEscolhido.Id);
                    TelaPrincipal.inventario[itemEscolhido.Id - 1].labQuant.Text =
                        (Convert.ToInt32(TelaPrincipal.inventario[itemEscolhido.Id - 1].labQuant.Text) - pedido.Quantidade).ToString();
                    ItemCache.ListaItens[itemEscolhido.Id - 1].Quantidade -= pedido.Quantidade;
                    UserCache.UsuarioLogado.Peso -= itemEscolhido.Peso * pedido.Quantidade;
                    TelaPrincipal.lbPeso.Text = UserCache.UsuarioLogado.Peso.ToString() + " Kg";
                    ItemController itemController = new ItemController();
                    itemController.VerificarCor(TelaPrincipal);
                    if (UserCache.UsuarioLogado.Peso < UserCache.UsuarioLogado.Capacidade)
                        ItemCache.Carregado = false;
                    else
                        ItemCache.Carregado = true;
                }
                catch (Exception)
                {
                    // Arrumar melhor na refatoração
                    throw;
                } 
            }
            else
            {
                ItemCache.ListaItens[itemEscolhido.Id - 1].Quantidade -= Convert.ToInt32(numQuantidade.Value);
                UserCache.UsuarioLogado.Peso -= itemEscolhido.Peso * Convert.ToInt32(numQuantidade.Value);
                TelaPrincipal.lbPeso.Text = UserCache.UsuarioLogado.Peso.ToString() + " Kg";
                ItemController itemController = new ItemController();
                itemController.VerificarCor(TelaPrincipal);
                TelaPrincipal.inventario[itemEscolhido.Id - 1].labQuant.Text =
                        (Convert.ToInt32(TelaPrincipal.inventario[itemEscolhido.Id - 1].labQuant.Text) - Convert.ToInt32(numQuantidade.Value)).ToString();
                UserCache.UsuarioLogado.Moeda += Convert.ToInt32(txtValorTotal.Text);
                TelaPrincipal.money.Text = UserCache.UsuarioLogado.Moeda.ToString() + " $";
            }
            Close();
        }

        private void CarregarTotal(object sender, EventArgs e)
        {
            if (numQuantidade.Value > Convert.ToInt32(lbQtdUser.Text))
                numQuantidade.Value = Convert.ToInt32(lbQtdUser.Text);
            txtValorTotal.Text = (numQuantidade.Value * numValUnit.Value).ToString();
        }

        private void CarregarTotal2(object sender, EventArgs e)
        {
            txtValorTotal.Text = (numQuantidade.Value * numValUnit.Value).ToString();
        }
    }
}
