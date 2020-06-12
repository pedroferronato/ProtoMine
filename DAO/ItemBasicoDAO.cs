using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using ProtoMine.Modelo;
using ProtoMine.Controle;
using System.Data.SqlClient;
using ProtoMine.Cache;

namespace ProtoMine.DAO
{
    class ItemBasicoDAO : Conexao
    {
        MySqlCommand comando = null;
        readonly UtilidadesTelas util = new UtilidadesTelas();

        public void CarregarItensSimples(int id)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("select item.*, quantidade from usuarioitem "
                    + "join usuario on usuario.id = usuarioitem.id_usuario "
                    + "join item on item.id = usuarioitem.id_item "
                    + "where usuario.id = @ID and item.tipo = @TIPO", conexao);

                comando.Parameters.AddWithValue("@ID", id);
                comando.Parameters.AddWithValue("@TIPO", "comum");

                MySqlDataReader reader = comando.ExecuteReader();
                
                while (reader.Read())
                {
                    ItemModel itemTemp = new ItemModel
                    {
                        Id = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        Peso = reader.GetDouble(2),
                        UrlImg = reader.GetString(3),
                        Quantidade = reader.GetInt32(5)
                    };
                    ItemCache.ListaItens.Add(itemTemp);
                }
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro no load dos itens, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado no load dos itens:  " + ex.Message, "Erro!");
                throw ex;
            }
            finally
            {
                FecharConexao(); 
            }
        }

        public void BuscarTodos()
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("select * from item", conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    ItemModel itemTemp = new ItemModel
                    {
                        Id = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        Peso = reader.GetDouble(2),
                        UrlImg = reader.GetString(3)
                    };
                    ItemCache.ListaGeral.Add(itemTemp.Id, itemTemp);
                }
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro no load dos itens, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado no load dos itens:  " + ex.Message, "Erro!");
                throw ex;
            }
            finally
            {
                FecharConexao(); 
            }
        }

        public void AtualizarItem(ItemModel item)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("update usuarioitem set quantidade = @quantidade " +
                    "where id_item = @idItem and id_usuario = @idUsu", conexao);

                comando.Parameters.AddWithValue("@quantidade", item.Quantidade);
                comando.Parameters.AddWithValue("@idItem", item.Id);
                comando.Parameters.AddWithValue("@idUsu", UserCache.UsuarioLogado.Id);

                comando.ExecuteNonQuery();
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro ao atualizar os itens, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado ao atualizar os itens:  " + ex.Message, "Erro!");
                throw ex;
            }
            finally
            {
                FecharConexao();
            }
        }

    }
}
