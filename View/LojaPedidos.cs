using ProtoMine.Controle;
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
    public partial class LojaPedidos : Form
    {
        readonly PedidosController pedidosController = new PedidosController();
        public LojaPedidos()
        {
            InitializeComponent();
            tabela.DataSource = pedidosController.GerarTabela(cbTIpo.SelectedIndex);
            cbTIpo.Items.Insert(0, "Compra/Venda");
            cbTIpo.Items.Insert(1, "Compra");
            cbTIpo.Items.Insert(2, "Venda");
            cbTIpo.SelectedIndex = 0;
        }
        
        private void AlterarBusca(object sender, EventArgs e)
        {
            tabela.DataSource = pedidosController.GerarTabela(cbTIpo.SelectedIndex);
        }
    }
}
