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
    public partial class Item : Form
    {
        UtilidadesTelas util = new UtilidadesTelas();
        ItemModel itemModel = new ItemModel();
        Principal prin;
        public Item(ItemModel item, Principal principal)
        {
            InitializeComponent();
            itemModel = item;
            picImgItem.Image = Image.FromFile(item.UrlImg);
            labQuant.Text = item.Quantidade.ToString();
            labPeso.Text = item.Peso.ToString() + " Kg";
            labNome.Text = item.Nome;
            prin = principal;
        }

        private void GenItem()
        {
            GerenciarItem gerenciarItem = new GerenciarItem(itemModel.Id, prin);
            gerenciarItem.ShowDialog();
        }

        private void GenItemImg(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                GenItem();
            }
        }

        private void GenItemBg(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                GenItem();
            }
        }
    }
}
