using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoPim.DAL
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";//Tudo ok
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        private object email;

        public bool VerificarLogin(String login, String senha)
        {
            //comando sql para verificar se tem no banco
            //procurar no banco de dados esse login e senha
            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                 dr = cmd.ExecuteReader();
                if(dr.HasRows)//se foi encontrado
                {
                    tem = true;
                }
                con.Desconectar();
                {
                    dr.Close();
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com banco de Dados!";
            }
            return tem;
        }

        public String CadastroDeOperadores(string Operador, string Senha, string ConfirmarSenha, string Nivel, string Função, string Entrada,
                                string Saida, string Status, string Numero)
           //(String Codigo, String Nome, String Cnh, String Endereço, String Numero,
           //String Complemento, String Cep, String Bairro, String Cidade, String Estado, String PessoaFisica,
           //String RGIE, String CCM, String CNPJCPF, String Telefone, String Celular, String Email, String Nrveiculo,
           //String Vencimento, String Estadisponivel, String Status, String TabelaPreço, String Grupo, String Ativo,
           //String Mensagem)
        {
            //comandos para inserir no banco caso  foi cadastrado ou teve algum erro
            tem = false;
            if (Senha.Equals(ConfirmarSenha))
            {
                cmd.CommandText = "insert into logins values (@l,@s);";
                cmd.Parameters.AddWithValue("@l", email);
                cmd.Parameters.AddWithValue("@s", Senha);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    this.mensagem = "cadastrado com sucesso";
                        tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com banco de dados";
                }
            }else
            {
                this.mensagem = "senha não correspondes!";
            }
            return mensagem;
        }
    }
}
