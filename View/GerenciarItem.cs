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
    public partial class GerenciarItem : Form
    {
        ItemModel itemModel = new ItemModel();
        ItemController itemController = new ItemController();
        Principal prin;
        public GerenciarItem(int id, Principal principal)
        {
            InitializeComponent();
            itemModel.Id = id;
            prin = principal;

        }
        private void FecharTela(object sender, EventArgs e)
        {
            Close();
        }

        private void JogarFora(object sender, EventArgs e)
        {
            ItemCache.ListaItens[itemModel.Id - 1].Quantidade = 0;
            prin.inventario[itemModel.Id - 1].labQuant.Text = "0";
            UserCache.UsuarioLogado.Peso = 0;
            foreach (ItemModel item in ItemCache.ListaItens)
            {
                itemController.AcrescentarPeso(item, prin);
            }
            prin.lbPeso.Text = UserCache.UsuarioLogado.Peso.ToString()+ " Kg";
            if (UserCache.UsuarioLogado.Capacidade > UserCache.UsuarioLogado.Peso)
            {
                ItemCache.Carregado = false;
            }
            Close();
        }
    }
}
