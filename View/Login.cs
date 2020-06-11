using ProtoMine.Controle;
using ProtoMine.DAO;
using ProtoMine.Cache;
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
using MySql.Data.MySqlClient;

namespace ProtoMine
{
    public partial class Login : Form
    {
        UtilidadesTelas util = new UtilidadesTelas();
        public Login()
        {
            InitializeComponent();
        }

        // importação de dll para captura de mouse e movimentação de tela
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

        private void Logar()
        {
            lbErro.Visible = false;

            if (txtUsuario.Text == "USUARIO" && txtSenha.Text == "SENHA")
            {
                lbErro.Visible = true;
                lbErro.Text = "   Os campos Usuário e Senha devem ser preenchidos";
                return;
            }
            else if (txtSenha.Text == "SENHA")
            {
                lbErro.Visible = true;
                lbErro.Text = "   O campo Senha deve ser preenchido";
                txtSenha.Focus();
                return;
            }
            else if (txtUsuario.Text == "USUARIO")
            {
                lbErro.Visible = true;
                lbErro.Text = "   O campo Usuário deve ser preenchido";
                txtUsuario.Focus();
                return;
            }

            bool logado;
            UsuarioController usController = new UsuarioController();

            try
            {
                logado = usController.Logar(txtUsuario.Text, txtSenha.Text); // Retorno do usuário (Existe ou não)
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro no login, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro desconhecido no login:  " + ex.Message, "Erro!");
                throw ex;
            }

            if (logado) // Caso login válido
            {
                this.Hide(); // Esconde tela de login
                Principal p = new Principal(this); // Instancia tela principal
                p.ShowDialog(); // Apresenta tela principal
            }
            else // Caso login inválido
            {
                txtSenha.ForeColor = Color.FromArgb(1, 255, 255, 255);
                txtSenha.UseSystemPasswordChar = false;
                lbErro.Visible = true;
                lbErro.Text = "   Credênciais inválidas, favor conferir.\n   usuário não encontrado";
                txtSenha.Text = "SENHA";
                txtUsuario.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void userLogin(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
            }
        }

        private void senhaLogar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
            }
        }
    }
}
