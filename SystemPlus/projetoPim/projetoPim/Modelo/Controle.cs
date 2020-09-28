using projetoPim.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoPim.Modelo
{
     public class Controle
    {
        public bool tem;
        public string mensagem="";

        public bool acessar(String login, String senha)
        {
            //primeiro devemos extanciar a classe login, nessa classe utilizaremos o metodo verificar login
            //passando que as duas informações que viaeram do formulario, foi as informações que a pessoa digitou la
            //nesse metodo verificar login, vai ser verificado se esse login foi encontrado e vai retornar para mim  na variavel tem
            //nessa variavem tem, nessa variavel tem vai está verdadeiro ou falso, e nos vamos retornar la para o formulario essa variavel tem
            // e antes disso será feito uma verificação se a mensagem foi preenchida com uma STRING de erro, casso ao contrario, ela irar contnuar
            // vazia, e assim que vamos saber como lidar com os erros do programa.
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.VerificarLogin(login, senha);
            if(!loginDao.mensagem.Equals(""))//caso entrar estara tudo ok em nosso programa de posi só salvar 
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        internal void Novo(string text1, string text2, string text3, string text4, ComboBox.ObjectCollection items, string text5, string text6, string text7, string text8)
        {
            throw new NotImplementedException();
        }

        public string CadastroDeOperadores(string Operador, string Senha, string ConfirmarSenha, string Nivel, string Função, string Entrada,
                                string Saida, string Status, string Numero)
            //(string codigo, string nome, string cnh, string endereço, string Numero,
            //string complemento, string cep, string bairro, string cidade, string estado, string pessoafisica,
            //string rgie, string ccm, string cnpjcpf, string telefone, string celular, string email, string nrveiculo,
            //string vencimento, string estadisponivel, string status, string tabelapreço, string grupo, string ativo,
            //string mensagem)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.CadastroDeOperadores(Operador, Senha, ConfirmarSenha, Nivel, Função, Entrada, Saida, Status, Numero);
            if(loginDao.tem)// a menssagem que vai vir e de sucesso
            {
                this.tem = true;
            }
            //(codigo, nome, cnh,  endereço, Numero, complemento, cep, bairro, cidade, estado, pessoafisica, rgie, 
            //ccm, cnpjcpf, telefone, celular, email, nrveiculo, vencimento, estadisponivel, status, tabelapreço,  grupo, ativo, mensagem);
            return mensagem;
        }
    }
}
