using ProtoMine.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoMine.Modelo
{
    class Pedido
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public string Tipo { get; set; }
        public ItemModel Item { get; set; }
        public Usuario Usuario { get; set; }
        public double ValorUnitario { get; set; }

        public Pedido(int id, double valor, string tipo, ItemModel item, Usuario usuario, double valorUnitario)
        {
            Id = id;
            Valor = valor;
            Tipo = tipo;
            Item = item;
            Usuario = usuario;
            ValorUnitario = valorUnitario;
        }

        public Pedido()
        {
        }
    }
}
