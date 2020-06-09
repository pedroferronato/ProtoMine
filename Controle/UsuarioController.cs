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
        UtilidadesTelas util = new UtilidadesTelas();
        UsuarioDAO userDAO = new UsuarioDAO();

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                userDAO.Cadastro(usuario);
            }
            catch (Exception)
            {

                throw;
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
            catch (Exception)
            {

                throw;
            }
        }

        public bool Logar(string login, string senha)
        {
			try
			{
				user = userDAO.buscarLogin(login, senha); // Realiza a conexão da tela com o DAO
                if (user.Id != 0)
                {
                    UserCache.UsuarioLogado = user;
                    if (user.Nivel == 20)
                    {
                        UserCache.Mestre = true;
                    }
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
    }
}
