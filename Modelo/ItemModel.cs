using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoMine.Modelo
{
    public class ItemModel : ItemAbstract
    {
        public ItemModel() { }

        public ItemModel(int id, string nome, double peso, string urlImg, int quantidade)
        {
            Id = id;
            Nome = nome;
            Peso = peso;
            UrlImg = urlImg;
            Quantidade = quantidade;
        }

        public override double CalcularPeso()
        {
            return Peso * Quantidade;
        }

        public override string ToString()
        {
            return "Nome: " + Nome +
                   " Peso: " + Peso.ToString() +
                   " Quantidade: " + Quantidade.ToString() ;
        }
    }
}
