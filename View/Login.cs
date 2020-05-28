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
using ProtoMine.View;

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
            util.Centralizar(this, panel1); // Centraliza painal de login

            titulo.Top = (panel1.Height / 10) - (titulo.Height / 2); // Define altura do título
            titulo.Left = (panel1.Width / 2) - (titulo.Width / 2); // Define Centralização do título

            panellogin.Top = titulo.Top + 65; // Define distânica do painel secundário em relação ao título
            panellogin.Left = (panel1.Width / 2) - (panellogin.Width / 2); // Centraliza o Painel central

            panel1.Width -= 15; // Remove 15 pixels do painel de login para ajuste
        }

        private void OnClickLogin(object sender, EventArgs e) // Ao clickar no botão login
        {
            Usuario usuario = new Usuario(txtLogin.Text, txtSenha.Text); // Instancia usuário com login e senha
            UsuarioController usController = new UsuarioController();

            try
            {
                usuario = usController.Logar(usuario); // Retorno do usuário (Existe ou não)
            }
            catch (Exception exce)
            {
                util.MensagemDeTeste("Erro no login", "Erro!");
                throw exce;
            }

            if (usuario.Id != 0) // Caso login válido
            {
                this.Hide(); // Esconde tela de login
                Principal p = new Principal(); // Instancia tela principal
                p.ShowDialog(); // Apresenta tela principal
            } 
            else // Caso login inválido
            {
                util.MensagemDeTeste("Usuário não encontrado", "Erro!");
                txtSenha.Text = "";
            }
        }
    }
}
