using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtoMine.Controle
{
    class UtilidadesTelas
    {
        public void Centralizar(Control pai, Control filho)
        {
            filho.Top = (pai.Height / 2) - (filho.Height / 2);
            filho.Left = (pai.Width / 2) - (filho.Width / 2);
        }

        public void MensagemDeTeste(string message, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            
        }
    }
}
