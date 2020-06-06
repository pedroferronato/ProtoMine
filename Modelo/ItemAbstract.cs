using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoMine.Modelo
{
    abstract class ItemAbstract
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Peso { get; set; }
        public string urlImg { get; set; }
        public int Quantidade { get; set; }

        abstract public double CalcularPeso();

    }
}
