using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoMine.Modelo
{
    public class ItemModel : ItemAbstract
    {
        public ItemModel()
        {
            Tipo = "Comum";
        }

        public ItemModel(int id, string nome, double peso, string urlImg, int quantidade)
        {
            Id = id;
            Nome = nome;
            Peso = peso;
            UrlImg = urlImg;
            Quantidade = quantidade;
            Tipo = "Comum";
        }

        public override double CalcularPeso()
        {
            throw new NotImplementedException();
        }
    }
}
