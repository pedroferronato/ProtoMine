using ProtoMine.DAO;
using ProtoMine.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoMine.Controle
{
    class PedidosController
    {
        PedidoDAO pedidoDAO = new PedidoDAO();

        public DataTable GerarTabela(int tipo)
        {
            return pedidoDAO.BuscarPedidos(tipo);
        }

        public void InserirPedido(Pedido pedido, int idItem)
        {
            pedidoDAO.AdicionarPedido(pedido, idItem);
        }

        public void ExcluirPedido(int i)
        {
            pedidoDAO.ExcluirPedido(i);
        }
    }
}
