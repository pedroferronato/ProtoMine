using MySql.Data.MySqlClient;
using ProtoMine.Cache;
using ProtoMine.Controle;
using ProtoMine.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoMine.DAO
{
    class PedidoDAO : Conexao
    {
        MySqlCommand comando = null;
        UtilidadesTelas util = new UtilidadesTelas();

        public DataTable BuscarPedidos(int tipo)
        {
            try
            {
                abrirConexao();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("select item.nome, pedido.quantidade, pedido.valor, pedido.tipo from pedido" +
                    " join item on item.id = pedido.id_item" +
                    " where pedido.id_usuario != @id" +
                    " and pedido.tipo != @tipo" +
                    " order by pedido.valor ASC limit 20", conexao);

                comando.Parameters.AddWithValue("@id", UserCache.UsuarioLogado.Id);
                if (tipo == 0)
                    comando.Parameters.AddWithValue("@tipo", "tipo");
                else if (tipo == 1)
                    comando.Parameters.AddWithValue("@tipo", "Venda");
                else
                    comando.Parameters.AddWithValue("@tipo", "Compra");
                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;

            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro no load dos pedidos, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado no load dos pedidos:  " + ex.Message, "Erro!");
                throw ex;
            }
            finally
            {
                fecharConexao(); // Fecha a conexão
            }
        }

        public void AdicionarPedido(Pedido pedido, int idItem)
        {
            try
            {
                abrirConexao();

                comando = new MySqlCommand("INSERT INTO pedido (valor, tipo, id_usuario, " +
                    "id_item, valorUnitario, quantidade) " +
                    "VALUES (@valor, @tipo, @idUsu, @idItem, @valUnit, @qtd)", conexao);

                comando.Parameters.AddWithValue("@valor", pedido.Valor);
                comando.Parameters.AddWithValue("@tipo", "Venda");
                comando.Parameters.AddWithValue("@idUsu", UserCache.UsuarioLogado.Id);
                comando.Parameters.AddWithValue("@idItem", idItem);
                comando.Parameters.AddWithValue("@valUnit", pedido.ValorUnitario);
                comando.Parameters.AddWithValue("@qtd", pedido.Quantidade);

                comando.ExecuteNonQuery();
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro na criação de pedido, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado na criação de pedido:  " + ex.Message, "Erro!");
                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
