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

namespace projetoPim.Apresentacao
{
    public partial class CadastroDeOperadores : Form
    {
        public CadastroDeOperadores()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Novo(txbOperador.Text, txbSenha.Text, txbConfirmarSenha.Text, txbFunção.Text, cbbNivel.Items, txbEntrada.Text, txbSaida.Text,
                txbStatus.Text, txbNumero.Text);
        }
    }
}
