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

        public CriacaoPedido(ItemModel item, Principal principal)
        {
            InitializeComponent();
            TelaPrincipal = principal;
            itemEscolhido = item;
            picItem.Image = Image.FromFile(item.UrlImg);
            lbNome.Text = item.Nome;
            lbQtdUser.Text = item.Quantidade.ToString();
        }

        private void Cancelar(object sender, EventArgs e)
        {
            Close();
        }

        private void CriarPedidoVenda(object sender, EventArgs e)
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
