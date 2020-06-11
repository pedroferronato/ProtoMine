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
    }
}
