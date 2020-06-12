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
        readonly ItemModel itemModel = new ItemModel();

        readonly Principal prin;

        readonly ItemModel itemPedido;

        public GerenciarItem(int id, Principal principal, ItemModel item)
        {
            InitializeComponent();
            itemModel.Id = id;
            prin = principal;
            itemPedido = item;
        }

        private void FecharTela(object sender, EventArgs e)
        {
            Close();
        }

        private void JogarFora(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CriacaoPedido pedido = new CriacaoPedido(itemPedido, prin, "NPC");
                pedido.ShowDialog();
            }
        }

        private void AbrirPedidoVenda(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CriacaoPedido pedido = new CriacaoPedido(itemPedido, prin);
                pedido.ShowDialog();
            }
        }
    }
}
