using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
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
        readonly Principal telaPrincipal;

        readonly UtilidadesTelas util = new UtilidadesTelas();

        readonly ItemController itemController = new ItemController();

        public Loja(Principal principal)
        {
            InitializeComponent();
            telaPrincipal = principal;
        }

        private void AbrirPedidos(object sender, EventArgs e)
        {
            LojaPedidos telaPedidos = new LojaPedidos(telaPrincipal);
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

                        try
                        {
                            itemController.AtribuirItem(UserCache.Mochila.Id);
                        }
                        catch (MySqlException exce)
                        {
                            util.MensagemDeTeste("Erro ao atribuir itens, falha na conexão ao banco de dados", "Erro!");
                            throw exce;
                        }
                        catch (Exception ex)
                        {
                            util.MensagemDeTeste("Erro não esperado ao atribuir itens:  " + ex.Message, "Erro!");
                            throw ex;
                        }

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

                        try
                        {
                            itemController.DeletarItem(UserCache.Mochila.Id);
                        }
                        catch (MySqlException exce)
                        {
                            util.MensagemDeTeste("Erro ao excluir itens, falha na conexão ao banco de dados", "Erro!");
                            throw exce;
                        }
                        catch (Exception ex)
                        {
                            util.MensagemDeTeste("Erro não esperado ao excluir itens:  " + ex.Message, "Erro!");
                            throw ex;
                        }

                        UserCache.Mochila = ItemCache.ListaItensEspeciais.Find(l => l.Nome == item);
                        UserCache.UsuarioLogado.Moeda -= valor;
                        telaPrincipal.AbrirTela(new ItemEspecialView(UserCache.Mochila), telaPrincipal.lbEspeciais[1]);
                        telaPrincipal.money.Text = UserCache.UsuarioLogado.Moeda + " $";
                        try
                        {
                            itemController.AtribuirItem(UserCache.Mochila.Id);
                        }
                        catch (MySqlException exce)
                        {
                            util.MensagemDeTeste("Erro ao atribuir itens, falha na conexão ao banco de dados", "Erro!");
                            throw exce;
                        }
                        catch (Exception ex)
                        {
                            util.MensagemDeTeste("Erro não esperado ao atribuir itens:  " + ex.Message, "Erro!");
                            throw ex;
                        }

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
                        try
                        {
                            itemController.DeletarItem(UserCache.Picareta.Id);
                        }
                        catch (MySqlException exce)
                        {
                            util.MensagemDeTeste("Erro ao excluir itens, falha na conexão ao banco de dados", "Erro!");
                            throw exce;
                        }
                        catch (Exception ex)
                        {
                            util.MensagemDeTeste("Erro não esperado ao excluir itens:  " + ex.Message, "Erro!");
                            throw ex;
                        }
                        UserCache.Picareta = ItemCache.ListaItensEspeciais.Find(l => l.Nome == item);
                        UserCache.UsuarioLogado.Moeda -= valor;
                        telaPrincipal.AbrirTela(new ItemEspecialView(UserCache.Picareta), telaPrincipal.lbEspeciais[0]);
                        telaPrincipal.money.Text = UserCache.UsuarioLogado.Moeda + " $";
                        try
                        {
                            itemController.AtribuirItem(UserCache.Picareta.Id);
                        }
                        catch (MySqlException exce)
                        {
                            util.MensagemDeTeste("Erro ao atribuir itens, falha na conexão ao banco de dados", "Erro!");
                            throw exce;
                        }
                        catch (Exception ex)
                        {
                            util.MensagemDeTeste("Erro não esperado ao atribuir itens:  " + ex.Message, "Erro!");
                            throw ex;
                        }
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
