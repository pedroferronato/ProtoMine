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

namespace ProtoMine.DAO
{
    class UsuarioDAO : Conexao
    {
        MySqlCommand comando = null;
        UtilidadesTelas util = new UtilidadesTelas();
        public Usuario buscarLogin(string login, string senha)
        {
            try
            {
                abrirConexao();

                comando = new MySqlCommand("select * from usuario where login = @LOGIN and senha = @SENHA", conexao);

                comando.Parameters.AddWithValue("@LOGIN", login);
                comando.Parameters.AddWithValue("@SENHA", senha);

                MySqlDataReader reader = comando.ExecuteReader();

                Usuario user = new Usuario();

                while (reader.Read())
                {
                    user.Id = reader.GetInt32(0);
                    user.Nome = reader.GetString(1);
                    user.Login = reader.GetString(2);
                    user.Senha = reader.GetString(3);
                    user.Moeda = reader.GetFloat(4);
                    user.Capacidade = reader.GetFloat(5);
                    user.Proficiencia = reader.GetFloat(6);
                    user.Role = reader.GetString(7);
                }
                return user;
            }
            catch (Exception e)
            {
                util.MensagemDeTeste(e.Message, e.Message);
                throw e;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
