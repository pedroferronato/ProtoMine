using ProtoMine.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoMine.Modelo
{
    public class ItemEspecial : ItemAbstract
    {
        public ItemEspecial()
        {
            Tipo = "Especial";
        }

        public ItemEspecial(int id, string nome, double peso, string urlImg, int quantidade)
        {
            Id = id;
            Nome = nome;
            Peso = peso;
            UrlImg = urlImg;
            Quantidade = quantidade;
            Tipo = "Especial";
        }

        public override double CalcularPeso() {
            if (Tipo == "bag")
            {
                UserCache.UsuarioLogado.Capacidade = (Peso * 100);
            }
            return 0.0;
        }
    }
}
