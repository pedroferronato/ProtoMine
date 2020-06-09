using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.PowerPacks;
using MySql.Data.MySqlClient;
using ProtoMine.Cache;
using ProtoMine.DAO;
using ProtoMine.Modelo;
using ProtoMine.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtoMine.Controle
{
    class ItemController
    {
        UtilidadesTelas util = new UtilidadesTelas();
        public void CarregarItens(Principal principal)
        {
            
            ItemBasicoDAO itemDAO = new ItemBasicoDAO();
            try
            {
                itemDAO.carregarItensSimples(UserCache.UsuarioLogado.Id);
                foreach (ItemModel item in ItemCache.ListaItens)
                {
                    AcrescentarPeso(item, principal);
                }
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro no load dos itens, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado no load dos itens:  " + ex.Message, "Erro!");
                throw ex;
            }
        }

        public void BuscarTodos()
        {
            ItemBasicoDAO itemDAO = new ItemBasicoDAO();
            try
            {
                itemDAO.BuscarTodos();
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro no load dos itens, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (ArgumentException arg)
            {
                util.MensagemDeTeste("Itens já carregados:  " + arg.Message, "Erro!");
                throw arg;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado no load dos itens:  " + ex.Message, "Erro!");
                throw ex;
            }
        }

        public void AdicionarItens(Principal principal, List<Label> listaDrops)
        {
            if (!ItemCache.Carregado)
            {
                foreach (Label l in listaDrops)
                {
                    l.Text = "0";
                }
                List<ItemModel> dropados = GerarItensMinerados();
                foreach (ItemModel i in dropados)
                {
                    if (ItemCache.ListaItens.Any(it => it.Id == i.Id))
                    {

                        if (UserCache.UsuarioLogado.Peso + i.Quantidade > UserCache.UsuarioLogado.Capacidade)
                        {
                            util.MensagemDeTeste("Peso estourou", "Aaaaa");
                            ItemCache.ListaItens[i.Id - 1].Quantidade += i.Quantidade;
                            ItemCache.Carregado = true;
                            listaDrops[i.Id - 1].Text = i.Quantidade.ToString();
                            principal.inventario[i.Id -1].labQuant.Text = ItemCache.ListaItens[i.Id - 1].Quantidade.ToString();
                            break;
                        }
                        else
                        {
                            ItemCache.ListaItens[i.Id - 1].Quantidade += i.Quantidade;
                            listaDrops[i.Id - 1].Text = i.Quantidade.ToString(); 
                            principal.inventario[i.Id - 1].labQuant.Text = ItemCache.ListaItens[i.Id - 1].Quantidade.ToString();
                        }
                    }
                    if (!UserCache.Mestre)
                    {
                        int nv = UserCache.UsuarioLogado.Nivel;
                        double xp = (i.Id * i.Quantidade);
                        int tetoXp = ((nv * 100) - (nv * nv)) + (nv * nv * nv);
                        int porcentagem = (int)(xp * 100) / tetoXp;
                        try
                        {
                            UserCache.UsuarioLogado.Experiencia += (porcentagem * tetoXp) / 100;
                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                        principal.panSupXp.Width += porcentagem * 2;
                        if (tetoXp <= UserCache.UsuarioLogado.Experiencia)
                        {
                            principal.panSupXp.Width = 0;
                            UserCache.UsuarioLogado.Experiencia = 0;
                            if ((UserCache.UsuarioLogado.Nivel + 1) == 20)
                            {
                                UserCache.UsuarioLogado.Nivel += 1;
                                principal.panSupXp.Width = 200;
                                principal.panSupXp.BackColor = Color.Gold;
                                UserCache.Mestre = true;
                            }
                            else
                            {
                                UserCache.UsuarioLogado.Nivel += 1;
                            }
                            principal.lbNivel.Text = "Nível: " + UserCache.UsuarioLogado.Nivel.ToString();
                        } 
                    }
                }
                UserCache.UsuarioLogado.Peso = 0;
                foreach (ItemModel item in ItemCache.ListaItens)
                {
                    AcrescentarPeso(item, principal);
                }
                principal.lbPeso.Text = UserCache.UsuarioLogado.Peso.ToString() + " Kg";
            }
            else
            {
                util.MensagemDeTeste("By: Carrinho", "Não suporto mais");
            }
        }

        public List<ItemModel> GerarItensMinerados()
        {
            int numDrop = new Random().Next(1, 101);
            int qntDrop = CalcularProbabilidade(numDrop);

            List<int> listaDrop = new List<int>();
            List<ItemModel> listaDropReal = new List<ItemModel>();

            for (int i = 1; i <= qntDrop; i++)
            {
                int itemDropado = new Random().Next(1, 101);
                itemDropado += UserCache.UsuarioLogado.Nivel;
                int minerio = CalcularProbabilidade(itemDropado);

                if (listaDrop.Any(l => l == minerio))
                    i--;
                else
                {
                    int qntPerc = new Random().Next(1, 101);
                    int quant = CalcularProbabilidade(qntPerc);
                    listaDrop.Add(minerio);
                    ItemModel item = ItemCache.ListaGeral[minerio];
                    item.Quantidade = quant;
                    listaDropReal.Add(item);
                }
            }
            return listaDropReal;
        }

        private int CalcularProbabilidade(int i)
        {
            // Definindo probablidade 
            // 50 % - 1
            // 30 % - 2
            // 8  % - 3
            // 7  % - 4
            // 3  % - 5
            // 2  % - 6
       
            if (i >= 1 && i <= 50)
                return 1;
            else if (i >= 51 && i <= 80)
                return 2;
            else if (i >= 81 && i <= 88)
                return 3;
            else if (i >= 89 && i <= 95)
                return 4;
            else if (i >= 96 && i <= 98)
                return 5;
            else if (i >= 99)
                return 6;
            return 1;
        }

        public void AcrescentarPeso(ItemModel item, Principal princip)
        {
            UserCache.UsuarioLogado.Peso += item.CalcularPeso();
            VerificarCor(princip);
        }

        public void VerificarCor(Principal principal)
        {
            double porcentagemAtual = (UserCache.UsuarioLogado.Peso * 100) / UserCache.UsuarioLogado.Capacidade;

            if (porcentagemAtual >= 100)
                principal.panPesoBaixo.BackColor = Color.Black;
            else if (porcentagemAtual >= 75 && porcentagemAtual < 100)
                principal.panPesoBaixo.BackColor = Color.Red;
            else if (porcentagemAtual >= 50 && porcentagemAtual < 75)
                principal.panPesoBaixo.BackColor = Color.Yellow;
            else if (porcentagemAtual >= 0 && porcentagemAtual < 50)
                principal.panPesoBaixo.BackColor = Color.Green;
        }
    }
}
