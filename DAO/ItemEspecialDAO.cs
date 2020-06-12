using Microsoft.Win32;
using MySql.Data.MySqlClient;
using ProtoMine.Cache;
using ProtoMine.Controle;
using ProtoMine.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProtoMine.DAO
{
    class ItemEspecialDAO : Conexao
    {
        MySqlCommand comando = null;
        readonly UtilidadesTelas util = new UtilidadesTelas();
        public void CarregarItensEspeciais()
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("select item.* from item "
                    + "join usuarioitem on item.id = usuarioitem.id_item "
                    + "join usuario on usuario.id = usuarioitem.id_usuario "
                    + "where usuario.id = @ID and item.tipo != @TIPO", conexao);

                comando.Parameters.AddWithValue("@ID", UserCache.UsuarioLogado.Id);
                comando.Parameters.AddWithValue("@TIPO", "comum");

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    ItemEspecial itemTemp = new ItemEspecial
                    {
                        Id = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        Peso = reader.GetDouble(2),
                        UrlImg = reader.GetString(3),
                        Tipo = reader.GetString(4)
                    };

                    if (itemTemp.Tipo == "pic")
                        UserCache.Picareta = itemTemp;
                    else
                        UserCache.Mochila = itemTemp;
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
        public void CarregarItemEspecial()
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("select * from item "
                    + "where item.tipo != @TIPO", conexao);

                comando.Parameters.AddWithValue("@ID", UserCache.UsuarioLogado.Id);
                comando.Parameters.AddWithValue("@TIPO", "comum");

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    ItemEspecial itemTemp = new ItemEspecial
                    {
                        Id = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        Peso = reader.GetDouble(2),
                        UrlImg = reader.GetString(3),
                        Tipo = reader.GetString(4)
                    };
                    ItemCache.ListaItensEspeciais.Add(itemTemp);
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
        public void Deletar(int idItem)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("Delete from usuarioitem "
                    + "where id_usuario = @id_usuario and id_item = @id_item", conexao);

                comando.Parameters.AddWithValue("@id_usuario", UserCache.UsuarioLogado.Id);
                comando.Parameters.AddWithValue("@id_item", idItem);

                comando.ExecuteNonQuery();
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro na exclusão da mochila, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado na exclusão da mochila:  " + ex.Message, "Erro!");
                throw ex;
            }
            finally
            {
                FecharConexao();
            }

        }

        public void Atribuir(int idItem)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO usuarioitem (id_usuario,id_item,quantidade)"
                    + "VALUES(@id_usuario,@id_item,@quantidade)", conexao);

                comando.Parameters.AddWithValue("@id_usuario", UserCache.UsuarioLogado.Id);
                comando.Parameters.AddWithValue("@id_item", idItem);
                comando.Parameters.AddWithValue("@quantidade", 1);

                comando.ExecuteNonQuery();
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro na atribuição do item, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado na atribuição do item:  " + ex.Message, "Erro!");
                throw ex;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
