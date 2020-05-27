using ProtoMine.DAO;
using ProtoMine.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoMine.Controle
{
    class UsuarioController
    {
        public bool Logar(Usuario user)
        {

			UsuarioDAO userDAO = new UsuarioDAO();

			try
			{
				UtilidadesTelas util = new UtilidadesTelas();
				user = userDAO.buscarLogin(user.Login, user.Senha);
				if (user.Id != 0)
				{
					return true;
				}
				return false;
			}
			catch (Exception exce)
			{
				throw exce;
			}
        }
    }
}
