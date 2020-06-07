﻿using System;
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

        public override double CalcularPeso() => throw new NotImplementedException();
    }
}
