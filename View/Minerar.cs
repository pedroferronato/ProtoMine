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
    public partial class Minerar : Form
    {
        readonly UtilidadesTelas util = new UtilidadesTelas();

        readonly ItemController itemController = new ItemController();

        readonly Principal prin;

        readonly List<Label> listaDrops = new List<Label>();
        
        public Minerar(Principal form)
        {
            prin = form;
            InitializeComponent();

            if (UserCache.UsuarioLogado.Peso > UserCache.UsuarioLogado.Capacidade)
            {
                ItemCache.Carregado = true;
            }

            listaDrops.Add(lbFerro);
            listaDrops.Add(lbBauxita);
            listaDrops.Add(lbQuartzo);
            listaDrops.Add(lbOuro);
            listaDrops.Add(lbVerde);
            listaDrops.Add(lbDiamante);
        }

        private void GerarMinerios(object sender, EventArgs e)
        {
            try
            {
                itemController.AdicionarItens(prin, listaDrops);
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro ao carregar mineração, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro não esperado ao carregar mineração:  " + ex.Message, "Erro!");
                throw ex;
            }
        }
    }
}
