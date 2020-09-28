using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoPim.Apresentacao
{
    public partial class Mensalista : Form
    {
        public object Novo { get; private set; }

        public Mensalista()
        {
            InitializeComponent();
        }
        //Esse codigo é para fechar apenas a tela de cadastro,
        //caso queira fechar tudo basta ir na tela de codigo FORM1.CS
        //que la estara o modelo do codigo para esse tipo de requisito.
        private void btnSair_Click(object sender, EventArgs e)
        {
            string texto = "deseja sair da tela cadastro?";
            string titulo = " FINALIZANDO ";
            if (MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
