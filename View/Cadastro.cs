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
        UsuarioController userController = new UsuarioController();

        public Cadastro(Principal form)
        {
            
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
                util.MensagemDeTeste("Erro inesperado no load dos cadastros:  " + ex.Message, "Erro!");
                throw ex;
            }
            lbNome.Visible = false;
            lbpass.Visible = false;
            lbConf.Visible = false;
            lbLogin.Visible = false;
            btnAtualizar.Visible = false;
        }

        private void NomeEnter(object sender, EventArgs e)
        {
            if (lbNome.Visible)
            {
                lbNome.Visible = false;
            }
            if (txtnomeUsu.Text == "Nome de Usuário")
            {
                txtnomeUsu.Text = "";
            }
        }

        private void NomeLeave(object sender, EventArgs e)
        {
            if (txtnomeUsu.Text == "")
            {
                txtnomeUsu.Text = "Nome de Usuário";
            }
        }

        private void SenhaEnter(object sender, EventArgs e)
        {
            if (lbpass.Visible)
            {
                lbpass.Visible = false;
            }
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void SenhaLeave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void EnterConfSenha(object sender, EventArgs e)
        {
            if (lbConf.Visible)
            {
                lbConf.Visible = false;
            }
            if (txtConfSenha.Text == "Confirme a senha")
            {
                txtConfSenha.Text = "";
                txtConfSenha.UseSystemPasswordChar = true;
            }
        }

        private void LeaveConfSenha(object sender, EventArgs e)
        {
            if (txtConfSenha.Text == "")
            {
                txtConfSenha.Text = "Confirme a senha";
                txtConfSenha.UseSystemPasswordChar = false;
            }
        }

        private void EnterLogin(object sender, EventArgs e)
        {
            if (lbLogin.Visible)
            {
                lbLogin.Visible = false;
            }
            if (txtlogin.Text == "Login")
            {
                txtlogin.Text = "";
            }
        }

        private void LeaveLogin(object sender, EventArgs e)
        {
            if (txtlogin.Text == "")
            {
                txtlogin.Text = "Login";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text == "Login")
            {
                lbLogin.Visible = true;
            }
            if (txtSenha.Text == "Senha")
            {
                lbpass.Visible = true;
            }
            if (txtConfSenha.Text == "Confirme a senha")
            {
                lbConf.Visible = true;
            }
            if (txtnomeUsu.Text == "Nome de Usuário")
            {
                lbNome.Visible = true;
            }

            if (!(lbNome.Visible || lbConf.Visible || lbpass.Visible || lbLogin.Visible))
            {
                if (txtConfSenha.Text == txtSenha.Text)
                {
                    Usuario novoUsuario = new Usuario();
                    novoUsuario.Login = txtlogin.Text;
                    novoUsuario.Senha = txtSenha.Text;
                    novoUsuario.Nome = txtnomeUsu.Text;
                    if (checkRole.Checked)
                        novoUsuario.Role = "admin";
                    else
                        novoUsuario.Role = "jogador";

                    UsuarioController usuarioController = new UsuarioController();
                    try
                    {
                        usuarioController.Cadastrar(novoUsuario);
                        tabela.DataSource = usuarioController.Listar();
                    }
                    catch (MySqlException exce)
                    {
                        util.MensagemDeTeste("Erro ao cadastrar, falha na conexão ao banco de dados", "Erro!");
                        throw exce;
                    }
                    catch (Exception ex)
                    {
                        util.MensagemDeTeste("Erro inesperado no load dos cadastros:  " + ex.Message, "Erro!");
                        throw ex;
                    }
                    finally
                    {
                        txtlogin.Text = "Login";
                        txtSenha.Text = "Senha";
                        txtnomeUsu.Text = "Nome de Usuário";
                        txtConfSenha.Text = "Confirme a senha";
                        txtConfSenha.UseSystemPasswordChar = false;
                        txtSenha.UseSystemPasswordChar = false;
                        checkRole.Checked = false;
                    }
                    
                }
                else
                {
                    lbpass.Visible = true;
                    lbConf.Visible = true;
                }
            }
        }


        private void getDados(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtnomeUsu.Text = tabela.CurrentRow.Cells[0].Value.ToString();
            txtlogin.Text = tabela.CurrentRow.Cells[1].Value.ToString();
            txtSenha.Text = "Senha";
            txtConfSenha.Text = "Confirme a senha";
            if (tabela.CurrentRow.Cells[7].Value.ToString() == "admin")
                checkRole.Checked = true;
            else
                checkRole.Checked = false;
            btnAtualizar.Visible = true;
            btnCadastrar.Visible = false;

        }

        private void deletarDados(object sender, DataGridViewCellEventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();

            var confirmResult = MessageBox.Show("Tem certeza que deseja deletar o usuario "+ tabela.CurrentRow.Cells[0].Value.ToString() +" ?? ",
                                     "Confirme a ação Delete!!",
                                     MessageBoxButtons.YesNo);
            try
            {
                if (confirmResult == DialogResult.Yes)
                {
                    Usuario user = new Usuario();
                    user.Login = tabela.CurrentRow.Cells[1].Value.ToString();
                    userController.Deletar(user);
                    tabela.DataSource = usuarioController.Listar();
                }
            }
            catch (MySqlException exce)
            {
                util.MensagemDeTeste("Erro ao deletar, falha na conexão ao banco de dados", "Erro!");
                throw exce;
            }
            catch (Exception ex)
            {
                util.MensagemDeTeste("Erro inesperado no load do delete:  " + ex.Message, "Erro!");
                throw ex;
            }

        }

        private void Atualizar(object sender, EventArgs e)
        {
            if (txtlogin.Text == "Login")
            {
                lbLogin.Visible = true;
            }
            if (txtSenha.Text == "Senha")
            {
                lbpass.Visible = true;
            }
            if (txtConfSenha.Text == "Confirme a senha")
            {
                lbConf.Visible = true;
            }
            if (txtnomeUsu.Text == "Nome de Usuário")
            {
                lbNome.Visible = true;
            }

            if (!(lbNome.Visible || lbConf.Visible || lbpass.Visible || lbLogin.Visible))
            {
                if (txtConfSenha.Text == txtSenha.Text)
                {
                    Usuario novoUsuario = new Usuario();
                    novoUsuario.Login = txtlogin.Text;
                    novoUsuario.Senha = txtSenha.Text;
                    novoUsuario.Nome = txtnomeUsu.Text;
                    if (checkRole.Checked)
                        novoUsuario.Role = "admin";
                    else
                        novoUsuario.Role = "jogador";

                    UsuarioController usuarioController = new UsuarioController();
                    try
                    {
                        usuarioController.Alterar(novoUsuario);
                        tabela.DataSource = usuarioController.Listar();
                    }
                    catch (MySqlException exce)
                    {
                        util.MensagemDeTeste("Erro ao cadastrar, falha na conexão ao banco de dados", "Erro!");
                        throw exce;
                    }
                    catch (Exception ex)
                    {
                        util.MensagemDeTeste("Erro inesperado no load dos cadastros:  " + ex.Message, "Erro!");
                        throw ex;
                    }
                    finally
                    {
                        txtlogin.Text = "Login";
                        txtSenha.Text = "Senha";
                        txtnomeUsu.Text = "Nome de Usuário";
                        txtConfSenha.Text = "Confirme a senha";
                        txtConfSenha.UseSystemPasswordChar = false;
                        txtSenha.UseSystemPasswordChar = false;
                        checkRole.Checked = false;
                    }

                }
                else
                {
                    lbpass.Visible = true;
                    lbConf.Visible = true;
                }
            }
        }

        private void CancelarAtualizar(object sender, EventArgs e)
        {
            txtlogin.Text = "Login";
            txtnomeUsu.Text = "Nome de Usuário";
            txtSenha.Text = "Senha";
            txtConfSenha.Text = "Confirme a senha";
            checkRole.Checked = false;
            btnAtualizar.Visible = false;
            btnCadastrar.Visible = true;
            txtConfSenha.UseSystemPasswordChar = false;
            txtSenha.UseSystemPasswordChar = false;
        }
    }
}
