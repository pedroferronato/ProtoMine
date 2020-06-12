using ProtoMine.DAO;
using ProtoMine.Modelo;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProtoMine.Cache;

namespace ProtoMine.Controle
{
    class UsuarioController
    {
        Usuario user = new Usuario();

        readonly UtilidadesTelas util = new UtilidadesTelas();

        readonly UsuarioDAO userDAO = new UsuarioDAO();

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                userDAO.Cadastro(usuario);
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro no cadastro, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado no cadastro:  " + ex.Message, "Erro!");
                throw ex;
            }
        }

        public void Alterar(Usuario usuario)
        {
            try
            {
                userDAO.Alterar(usuario);
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro ao alterar, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado na alteração:  " + ex.Message, "Erro!");
                throw ex;
            }
        }

        public void Deletar(Usuario usuario)
        {
            try
            {
                userDAO.Deletar(usuario);
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro ao excluir, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado no delete:  " + ex.Message, "Erro!");
                throw ex;
            }
        }

        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = userDAO.GerarTabela();
                return dt;
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro na listagem, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado na listagem:  " + ex.Message, "Erro!");
                throw ex;
            }
        }

        public bool Logar(string login, string senha)
        {
			try
			{
				user = userDAO.BuscarLogin(login, senha); // Realiza a conexão da tela com o DAO
                if (user.Id != 0)
                {
                    UserCache.UsuarioLogado = user;
                    if (user.Nivel == 20)
                        UserCache.Mestre = true;
                    return true;
                }
                return false;
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
        }

        public void AtualizarUsuario()
        {
            userDAO.AtualizarUsuario();
        }
    }
}
