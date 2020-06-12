using MySqlX.XDevAPI.Relational;
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
    public partial class LojaPedidos : Form
    {
        readonly PedidosController pedidosController = new PedidosController();

        Principal principal;
        public LojaPedidos(Principal pri)
        {
            InitializeComponent();
            tabela.DataSource = pedidosController.GerarTabela(cbTIpo.SelectedIndex);
            cbTIpo.Items.Insert(0, "Compra/Venda");
            cbTIpo.Items.Insert(1, "Compra");
            cbTIpo.Items.Insert(2, "Venda");
            cbTIpo.SelectedIndex = 0;
            tabela.Columns[0].HeaderText = "Nome";
            tabela.Columns[1].HeaderText = "Quantidade";
            tabela.Columns[2].HeaderText = "Valor";
            tabela.Columns[3].HeaderText = "Tipo";
            tabela.Columns[4].Visible = false;
            tabela.Columns[5].Visible = false;
            tabela.Columns[6].Visible = false;
            principal = pri;
        }

        private void AlterarBusca(object sender, EventArgs e)
        {
            tabela.DataSource = pedidosController.GerarTabela(cbTIpo.SelectedIndex);
        }

        private void ComprarPedido(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ComprarPedidoVenda(object sender, DataGridViewCellMouseEventArgs e)
        {
            UtilidadesTelas util = new UtilidadesTelas();
            int index = tabela.CurrentRow.Index;
            util.MensagemDeTeste(index.ToString(),"index");
            bool resposta = util.MensagemDeConfirmacao("Deseja realmente comprar o item: " + tabela.CurrentRow.Cells[0].Value, "Confirmação");
            if (resposta)
            {
                Venda venda = new Venda();
                Usuario vendedor = new Usuario();
                Usuario comprador = new Usuario();
                ItemModel item = new ItemModel();
                Pedido pedido = new Pedido();
                venda.Vendedor = vendedor;
                venda.Comprador = comprador;
                venda.Item = item;
                venda.Pedido = pedido;
                venda.Vendedor.Id = Convert.ToInt32(tabela.CurrentRow.Cells[5].Value);
                venda.Comprador.Id = UserCache.UsuarioLogado.Id;
                venda.Item.Id = Convert.ToInt32(tabela.CurrentRow.Cells[6].Value);
                venda.Pedido.Id = Convert.ToInt32(tabela.CurrentRow.Cells[4].Value);
                venda.Valor = Convert.ToDouble(tabela.CurrentRow.Cells[2].Value);
                venda.ValorUnitario = venda.Valor / Convert.ToInt32(tabela.CurrentRow.Cells[1].Value);
                if (ItemCache.Carregado)
                    util.MensagemDeTeste("Você não pode comprar itens com inventário cheio", "Ameãças");
                else if (UserCache.UsuarioLogado.Moeda < venda.Valor)
                    util.MensagemDeTeste("Você não tem moedas suficientes", "Ameãças");
                else
                {
                    try
                    {
                        VendaController vendaController = new VendaController();
                        vendaController.AdicionarVenda(venda);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    finally
                    {
                        UserCache.UsuarioLogado.Moeda -= venda.Valor;
                        principal.money.Text = UserCache.UsuarioLogado.Moeda.ToString();
                        ItemCache.ListaItens[venda.Item.Id - 1].Quantidade +=
                            Convert.ToInt32(tabela.CurrentRow.Cells[1].Value);
                        principal.inventario[venda.Item.Id - 1].labQuant.Text =
                            ItemCache.ListaItens[venda.Item.Id - 1].Quantidade.ToString();
                        UserCache.UsuarioLogado.Peso +=
                            ItemCache.ListaGeral[venda.Item.Id].Peso *
                            Convert.ToInt32(tabela.CurrentRow.Cells[1].Value);
                        principal.lbPeso.Text = UserCache.UsuarioLogado.Peso.ToString();
                        ItemController iContro = new ItemController();
                        iContro.VerificarCor(principal);
                    }
                }
            }
        }
    }
}
