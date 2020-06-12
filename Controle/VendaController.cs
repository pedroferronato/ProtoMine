using ProtoMine.DAO;
using ProtoMine.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoMine.Controle
{
    class VendaController
    {
        readonly VendaDAO vendaDAO = new VendaDAO();

        public void AdicionarVenda(Venda venda)
        {
            vendaDAO.AdicionarVenda(venda);
        }

        public int CalcularMedia(int i)
        {
           return vendaDAO.CalcularMedia(i);
        }
    }
}
