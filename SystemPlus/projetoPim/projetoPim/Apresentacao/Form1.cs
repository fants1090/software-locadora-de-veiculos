using projetoPim.Apresentacao;
using projetoPim.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoPim
{
    public partial class frmSystemPlus : Form
    {

        public frmSystemPlus()
        {
            InitializeComponent();
        }
        private void btnCadastreSe_Click(object sender, EventArgs e)
        {
            CadastroDeOperadores cdo = new CadastroDeOperadores();
            cdo.Show();
        }
        //esse codigo com application é para fechar o software inteiro.
        private void btnSair_Click(object sender, EventArgs e)
        {
            string mens1 = "deseja sair do sistema?";
            string titulo = "*******FIM DA EXECUÇÃO*******";
            if (MessageBox.Show(mens1, titulo, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)

            {
                Application.Exit();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //usando o metodo acessar, enviando as duas informações de usuario e senha, e ele vai entrar no controle para procurar o metodo...
            //acessar que foi enviado ás duas informações,em seguida extanciamos loginDAO e acessamos o metodo dele chamado verificar login...
            //enviando essas duas informações tambem, e então ele vai lá para o loginDAO, irar Procurar o login no banco de dados execurar...
            //ver se tem a linha , caso tenha a linha, foi encontando então a variavel true, e vai retornar lá para o controle, ele volto...
            //para o controle guardo (tem) então recebeu verdadeiro, se recebeu verdadeiro ea mensagem estiver vazia, então terá...
            //que ter as duas opção a mensagens terá que estár vazia, então está tudo ok, e então nós retornamos essa mensagem para o formulario...
            //
            Controle controle = new Controle();
            controle.acessar(cbLogin.Text, txbSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if(controle.tem)
                {
                    MessageBox.Show("logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TelaPrincipal TP = new TelaPrincipal();
                    TP.Show();
                }
                else
                {
                    MessageBox.Show("Usuario não encontrado,verificar Login e Senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

        }
    }
}
