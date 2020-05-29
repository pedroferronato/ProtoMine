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

namespace ProtoMine.Controle
{
    class UsuarioController
    {
        public Usuario Logar(Usuario user)
        {
            UtilidadesTelas util = new UtilidadesTelas();
			UsuarioDAO userDAO = new UsuarioDAO();

			try
			{
				user = userDAO.buscarLogin(user.Login, user.Senha); // Realiza a conexão da tela com o DAO
				return user;
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
