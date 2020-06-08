using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoMine.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public double Moeda { get; set; }
        public double Capacidade { get; set; }
        public double Proficiencia { get; set; }
        public string Role { get; set; }
        public double Peso { get; set; }
        public int Nivel { get; set; }

        public Usuario ()
        {

        }

        public Usuario (string login, string senha)
        {
            Login = login;
            Senha = senha;
        }

        public Usuario(int id, string nome, string login, string senha, double moeda, double capacidade, double proficiencia, string role, double peso, int nivel)
        {
            Id = id;
            Nome = nome;
            Login = login;
            Senha = senha;
            Moeda = moeda;
            Capacidade = capacidade;
            Proficiencia = proficiencia;
            Role = role;
            Peso = peso;
            Nivel = nivel;
        }

        public override string ToString()
        {
            return "ID: " + Id +
                   " Nome: " + Nome +
                   " Login: " + Login +
                   " Senha: " + Senha +
                   " Moeda: " + Moeda +
                   " Capacidade: " + Capacidade +
                   " Proficiencia: " + Proficiencia +
                   " Role: " + Role +
                   " Peso: " + Peso;
        }
    }
}
