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
using System.Runtime.InteropServices;

namespace ProtoMine
{
    public partial class Login : Form
    {
        UtilidadesTelas util = new UtilidadesTelas();
        public Login()
        {
            InitializeComponent();

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void onClickSair(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.FromArgb(1, 50, 50, 50);
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.FromArgb(1, 255, 255, 255);
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "SENHA")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.FromArgb(1, 50, 50, 50);
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA";
                txtSenha.ForeColor = Color.FromArgb(1, 255, 255, 255);
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtUsuario.Text, txtSenha.Text); // Instancia usuário com login e senha
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
