using MySql.Data.MySqlClient;
using ProtoMine.Controle;
using ProtoMine.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoMine.DAO
{
    class VendaDAO : Conexao
    {
        MySqlCommand comando = null;
        UtilidadesTelas util = new UtilidadesTelas();

        public List<Venda> BuscarVendas()
        {
            try
            {
                abrirConexao();

                comando = new MySqlCommand("select * from venda ", conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                List<Venda> listaDeVendas = new List<Venda>();

                while (reader.Read())
                {
                    Venda venda = new Venda();
                    venda.Id = reader.GetInt32(0);
                    venda.Valor = reader.GetDouble(1);
                    venda.Comprador.Id = reader.GetInt32(2);
                    venda.Vendedor.Id = reader.GetInt32(3);
                    venda.Item.Id = reader.GetInt32(4);
                    venda.ValorUnitario = reader.GetDouble(5);
                    venda.Pedido.Id = reader.GetInt32(6);
                    listaDeVendas.Add(venda);
                }
                return listaDeVendas;
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro no load das vendas, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado no load das vendas:  " + ex.Message, "Erro!");
                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }

        public void AdicionarVenda(Venda venda)
        {
            try
            {
                abrirConexao();

                comando = new MySqlCommand("INSERT INTO venda (valor, id_comprador, id_vendedor, " +
                    "id_item, valorUnitario, id_pedido) " +
                    "VALUES (@valor, @idComprador, @idVendedor, @idItem, @valUnit, @idPedido)", conexao);

                comando.Parameters.AddWithValue("@valor", venda.Valor);
                comando.Parameters.AddWithValue("@idComprador", venda.Comprador.Id);
                comando.Parameters.AddWithValue("@idVendedor", venda.Vendedor.Id);
                comando.Parameters.AddWithValue("@idItem", venda.Item.Id);
                comando.Parameters.AddWithValue("@valUnit", venda.ValorUnitario);
                comando.Parameters.AddWithValue("@idPedido", venda.Pedido.Id);

                comando.ExecuteNonQuery();
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro na criação de venda, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado na criação de venda:  " + ex.Message, "Erro!");
                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }

        public int CalcularMedia(int id)
        {
            try
            {
                abrirConexao();

                comando = new MySqlCommand("select avg(valorUnitario) from venda where id_item = @id limit 50", conexao);

                comando.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = comando.ExecuteReader();

                List<Venda> listaDeVendas = new List<Venda>();

                int media = 0;

                while (reader.Read())
                {
                    media = Convert.ToInt32(Math.Truncate(reader.GetDouble(0)));
                }
                return media;
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro no load da média vendas, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado no load da média vendas:  " + ex.Message, "Erro!");
                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
