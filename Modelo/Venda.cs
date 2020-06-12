using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoMine.Modelo
{
    class Venda
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public Usuario Comprador { get; set; }
        public Usuario Vendedor { get; set; }
        public ItemAbstract Item { get; set; }
        public double ValorUnitario { get; set; }
        public Pedido Pedido { get; set; }

        public Venda(int id, double valor, Usuario comprador, Usuario vendedor, ItemAbstract item, double valorUnitario, Pedido pedido)
        {
            Id = id;
            Valor = valor;
            Comprador = comprador;
            Vendedor = vendedor;
            Item = item;
            ValorUnitario = valorUnitario;
            Pedido = pedido;
        }

        public Venda() { }
    }
}
