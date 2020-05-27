using ProtoMine.Controle;
using ProtoMine.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProtoMine.Modelo;

namespace ProtoMine
{
    public partial class Login : Form
    {
        UtilidadesTelas util = new UtilidadesTelas();
        public Login()
        {
            InitializeComponent();

            CustomizarPanelLogin();
        }

        private void CustomizarPanelLogin()
        {
            util.Centralizar(this, panel1);
            titulo.Top = (panel1.Height / 10) - (titulo.Height / 2);
            titulo.Left = (panel1.Width / 2) - (titulo.Width / 2);

            panellogin.Top = titulo.Top + 65;
            panellogin.Left = (panel1.Width / 2) - (panellogin.Width / 2);

            panel1.Width -= 15;
        }

        private void OnClickLogin(object sender, EventArgs e)
        {
            UsuarioDAO userDAO = new UsuarioDAO();
            Usuario user = userDAO.buscarLogin(txtLogin.Text, txtSenha.Text);
            util.MensagemDeTeste(user.ToString(), "Login");
        }
    }
}
