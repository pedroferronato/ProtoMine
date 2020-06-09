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
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography.X509Certificates;

namespace ProtoMine.DAO
{
    class UsuarioDAO : Conexao
    {
        MySqlCommand comando = null;
        UtilidadesTelas util = new UtilidadesTelas();

        public void Cadastro(Usuario user)
        {
            try
            {
                abrirConexao();

                comando = new MySqlCommand("INSERT INTO usuario (nome,login,senha,role)" +
                    "VALUES (@nome, @login, @senha,@role)", conexao);

                comando.Parameters.AddWithValue("@nome", user.Nome);
                comando.Parameters.AddWithValue("@login", user.Login);
                comando.Parameters.AddWithValue("@senha", user.Senha);
                comando.Parameters.AddWithValue("@role", user.Role);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro no login, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro inesperado no cadastro:  " + ex.Message, "Erro!");
                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }

        public DataTable GerarTabela()
        {
            try
            {
                abrirConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("SELECT nome,login,nivel,experiencia,moeda,peso,capacidade,role FROM usuario", conexao);

                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;

            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro no login, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado no login:  " + ex.Message, "Erro!");
                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }

        public Usuario buscarLogin(string login, string senha) // Recebe Login e senha e conecta-se à base de dados 
        {
            try // Tenta conectar-se e realziar a busca
            {
                abrirConexao(); // Abre a conexão

                comando = new MySqlCommand("select * from usuario where login = @LOGIN and senha = @SENHA", conexao);
                // Define o comando SQL

                comando.Parameters.AddWithValue("@LOGIN", login);
                comando.Parameters.AddWithValue("@SENHA", senha);
                // Define valor ao Parâmetros

                MySqlDataReader reader = comando.ExecuteReader();
                // Executa o comando SQL na base de dados

                Usuario user = new Usuario();

                while (reader.Read()) // Enquanto existir registro para ler (O esperado e lógico é haver somente um resultado)
                {
                    user.Id = reader.GetInt32(0); // Defina o id do usuário como um inteiro que está na primeira posição do item SQL
                    user.Nome = reader.GetString(1); // Defina o nome do usuário como uma string que está na segunda posição do item SQL
                    user.Login = reader.GetString(2); // Defina o login do usuário como uma string que está na terceira posição do item SQL
                    user.Senha = reader.GetString(3); // Defina a senha do usuário como uma string que está na quarta posição do item SQL
                    user.Moeda = reader.GetFloat(4); // Defina a moeda do usuário como um double que está na quinta posição do item SQL
                    user.Capacidade = reader.GetFloat(5); // Defina a capacidade do usuário como um double que está na sexta posição do item SQL
                    user.Experiencia = reader.GetInt32(6); // Defina a proficiência do usuário como um double que está na sétima posição do item SQL
                    user.Role = reader.GetString(7); // Defina o cargo do usuário como uma string que está na primeira oitava do item SQL
                    user.Peso = reader.GetDouble(8);
                    user.Nivel = reader.GetInt32(9);
                }
                return user; // Retorna o usuario preenchido caso exista e somente com login e senha caso não exista 
                //(o importante para verificação se trata do login ser diferente de 0 "valor padrão e nunca existente no banco de dados")
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro no login, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado no login:  " + ex.Message, "Erro!");
                throw ex;
            }
            finally
            {
                fecharConexao(); // Fecha a conexão
            }
        }
    }
}
