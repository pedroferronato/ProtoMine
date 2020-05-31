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
        public bool Logar(string login, string senha)
        {
            Usuario user = new Usuario();
            UtilidadesTelas util = new UtilidadesTelas();
			UsuarioDAO userDAO = new UsuarioDAO();

			try
			{
				user = userDAO.buscarLogin(login, senha); // Realiza a conexão da tela com o DAO
                if (user.Id != 0)
                {
                    UserCache.UsuarioLogado = user;
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
                util.MensagemDeTeste("Erro desconhecido no login:  " + ex.Message, "Erro!");
                throw ex;
            }
        }
    }
}
