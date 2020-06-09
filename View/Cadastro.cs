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
using MySql.Data.MySqlClient;

namespace ProtoMine.View
{
    public partial class Cadastro : Form
    {
        UtilidadesTelas util = new UtilidadesTelas();
        Principal prin;

        public Cadastro(Principal form)
        {
            UsuarioController userController = new UsuarioController();
            prin = form;
            InitializeComponent();
            try
            {
                tabela.DataSource = userController.Listar();
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro no login, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro inesperado no cadastro:  " + ex.Message, "Erro!");
                throw ex;
            }
        }
        private void CadastrarUsuario(object sender, EventArgs e)
        {
            
            try
            {
                Usuario user = new Usuario();
                UsuarioController userController = new UsuarioController();

                user.Login = txtLogin.Text;
                user.Senha = txtSenha.Text;
                user.Nome = txtNomePersonagem.Text;
                if (checkRole.Checked)
                {
                    user.Role = "admin";
                }
                else
                {
                    user.Role = "jogador";
                }
                if (txtNomePersonagem.Text == "" || txtLogin.Text == "" || txtSenha.Text == "" )
                {
                    util.MensagemDeTeste("Todos os campos precisam ser preenchidos", "Cadastro Inválido");
                }
                else
                {
                    userController.Cadastrar(user);
                    util.MensagemDeTeste("O pesronagem " + user.Nome + " foi cadastrado!", "Cadastro Realizado");
                    txtLogin.Clear();
                    txtSenha.Clear();
                    txtNomePersonagem.Clear();
                    checkRole.CheckState = CheckState.Unchecked;
                }
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro no login, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro inesperado no cadastro:  " + ex.Message, "Erro!");
                throw ex;
            }
        }
    }
}
