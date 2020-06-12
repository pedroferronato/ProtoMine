using MySql.Data.MySqlClient;
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

        readonly Principal principal;

        readonly UtilidadesTelas util = new UtilidadesTelas();

        public LojaPedidos(Principal pri)
        {
            InitializeComponent();
            try
            {
                tabela.DataSource = pedidosController.GerarTabela(cbTIpo.SelectedIndex);
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro ao carregar pedidos, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado ao carregar pedidos:  " + ex.Message, "Erro!");
                throw ex;
            }

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
            try
            {
                tabela.DataSource = pedidosController.GerarTabela(cbTIpo.SelectedIndex);
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro ao carregar pedidos, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado ao carregar pedidos:  " + ex.Message, "Erro!");
                throw ex;
            }
        }

        private void ComprarPedidoVenda(object sender, DataGridViewCellMouseEventArgs e)
        {
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
                    catch (MySqlException exce)
                    {
                        util.MensagemDeTeste("Erro ao criar venda, falha na conexão ao banco de dados", "Erro!");
                        throw exce;
                    }
                    catch (Exception ex)
                    {
                        util.MensagemDeTeste("Erro não esperado ao criar venda:  " + ex.Message, "Erro!");
                        throw ex;
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
                        principal.lbPeso.Text = UserCache.UsuarioLogado.Peso.ToString() + " Kg";
                        ItemController iContro = new ItemController();
                        iContro.VerificarCor(principal);
                        try
                        {
                            PedidosController pedidosController = new PedidosController();
                            pedidosController.ExcluirPedido(venda.Pedido.Id);
                            tabela.DataSource = pedidosController.GerarTabela(cbTIpo.SelectedIndex);
                        }
                        catch (MySqlException exce)
                        {
                            util.MensagemDeTeste("Erro ao excluir pedidos, falha na conexão ao banco de dados", "Erro!");
                            throw exce;
                        }
                        catch (Exception ex)
                        {
                            util.MensagemDeTeste("Erro não esperado ao excluir pedidos:  " + ex.Message, "Erro!");
                            throw ex;
                        }
                    }
                }
            }
        }
    }
}
