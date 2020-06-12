using Microsoft.VisualBasic.ApplicationServices;
using ProtoMine.Cache;
using ProtoMine.Controle;
using ProtoMine.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtoMine.View
{
    public partial class Loja : Form
    {
        Principal telaPrincipal;
        UtilidadesTelas util = new UtilidadesTelas();
        ItemController itemController = new ItemController();

        public Loja(Principal principal)
        {
            InitializeComponent();
            telaPrincipal = principal;
            
        }

        private void AbrirPedidos(object sender, EventArgs e)
        {
            LojaPedidos telaPedidos = new LojaPedidos();
            telaPrincipal.AbrirTela(telaPedidos, telaPrincipal.panelPrincipal);
        }

        private void ComprarBolsa3(object sender, EventArgs e)
        {
            ComprarMochila(150000, "Bolsa III");
        }

        private void ComprarBolsa2(object sender, EventArgs e)
        {
            ComprarMochila(90000, "Bolsa II");
        }

        private void ComprarBolsa1(object sender, EventArgs e)
        {
            ComprarMochila(15000, "Bolsa I");
        }

        private void ComprarPicareta3(object sender, EventArgs e)
        {
            ComprarPicareta(300000, "Picareta III");
        }

        private void ComprarPicareta2(object sender, EventArgs e)
        {
            ComprarPicareta(125000, "Picareta II");
        }

        private void ComprarPicareta1(object sender, EventArgs e)
        {
            ComprarPicareta(5000, "Picareta I");
        }

        private void ComprarMochila(int valor, string item)
        {
            if (UserCache.UsuarioLogado.Moeda >= valor)
            {
                bool resposta = util.MensagemDeConfirmacao("Deseja comprar ?", "Compra");
                if (resposta)
                {

                    if (telaPrincipal.itensEspeciais.Count == 1)
                    {
                        UserCache.Mochila = ItemCache.ListaItensEspeciais.Find(l => l.Nome == item);
                        telaPrincipal.itensEspeciais.Add(new ItemEspecialView(UserCache.Mochila));
                        telaPrincipal.AbrirTela(telaPrincipal.itensEspeciais[1], telaPrincipal.lbEspeciais[1]);
                        UserCache.UsuarioLogado.Moeda -= valor;
                        telaPrincipal.money.Text = UserCache.UsuarioLogado.Moeda + " $";
                        itemController.AtribuirItem(UserCache.Mochila.Id);
                        UserCache.Mochila.CalcularPeso();
                        if (UserCache.UsuarioLogado.Peso < UserCache.UsuarioLogado.Capacidade)
                            ItemCache.Carregado = false;
                        else
                            ItemCache.Carregado = true;
                    }
                    else if (UserCache.Mochila.Nome == item)
                    {
                        util.MensagemDeTeste("Você já possui está bolsa.", "Atenção!");
                    }
                    else
                    {
                        double capacidadeAntiga = UserCache.Mochila.Peso * 100;
                        itemController.DeletarItem(UserCache.Mochila.Id);
                        UserCache.Mochila = ItemCache.ListaItensEspeciais.Find(l => l.Nome == item);
                        UserCache.UsuarioLogado.Moeda -= valor;
                        telaPrincipal.AbrirTela(new ItemEspecialView(UserCache.Mochila), telaPrincipal.lbEspeciais[1]);
                        telaPrincipal.money.Text = UserCache.UsuarioLogado.Moeda + " $";
                        itemController.AtribuirItem(UserCache.Mochila.Id);
                        UserCache.Mochila.CalcularPeso();
                        UserCache.UsuarioLogado.Capacidade -= capacidadeAntiga;
                        if (UserCache.UsuarioLogado.Peso < UserCache.UsuarioLogado.Capacidade)
                            ItemCache.Carregado = false;
                        else
                            ItemCache.Carregado = true;
                    }
                }
            }
            else
            {
                util.MensagemDeTeste("Dinheiro Insuficiente", "Vai minerar mais!!");
            }
        }
        private void ComprarPicareta(int valor, string item)
        {
            if (UserCache.UsuarioLogado.Moeda >= valor)
            {
                bool resposta = util.MensagemDeConfirmacao("Deseja comprar ?", "Compra");
                if (resposta)
                {
                    if (UserCache.Picareta.Nome == item)
                    {
                        util.MensagemDeTeste("Você já possui está picareta.", "Atenção!");
                    }
                    else
                    {
                        itemController.DeletarItem(UserCache.Picareta.Id);
                        UserCache.Picareta = ItemCache.ListaItensEspeciais.Find(l => l.Nome == item);
                        UserCache.UsuarioLogado.Moeda -= valor;
                        telaPrincipal.AbrirTela(new ItemEspecialView(UserCache.Picareta), telaPrincipal.lbEspeciais[0]);
                        telaPrincipal.money.Text = UserCache.UsuarioLogado.Moeda + " $";
                        itemController.AtribuirItem(UserCache.Picareta.Id);
                    }
                }
            }
            else
            {
                util.MensagemDeTeste("Dinheiro Insuficiente", "Vai minerar mais!!");
            }
        }
    }
}
