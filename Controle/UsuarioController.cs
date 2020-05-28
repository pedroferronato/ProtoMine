using ProtoMine.DAO;
using ProtoMine.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtoMine.Controle
{
    class UsuarioController
    {
        public Usuario Logar(Usuario user)
        {

			UsuarioDAO userDAO = new UsuarioDAO();

			try
			{
				user = userDAO.buscarLogin(user.Login, user.Senha); // Realiza a conexão da tela com o DAO
				return user;
			}
			catch (Exception exce)
			{
				throw exce;
			}
        }
    }
}
