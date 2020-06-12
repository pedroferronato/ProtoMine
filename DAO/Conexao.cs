using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProtoMine.Controle;

namespace ProtoMine.DAO
{
    class Conexao
    {
        readonly string info = "SERVER=127.0.0.1; DATABASE=protomine; UID=root; PWD=1234";
        protected MySqlConnection conexao = null;
        readonly UtilidadesTelas util = new UtilidadesTelas();
        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(info);
                conexao.Open();
            }
            catch (Exception e)
            {
                util.MensagemDeTeste(e.Message, e.Message);
                throw e;
            }
        }

        public void FecharConexao()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception e)
            {
                util.MensagemDeTeste(e.Message, e.Message);
                throw e;
            }
        }
    }
}
