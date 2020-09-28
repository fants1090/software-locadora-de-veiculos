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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }
        private void mensalistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mensalista cad = new Mensalista();
            cad.Show();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntradaDeVeiculos entrada = new EntradaDeVeiculos();
            entrada.Show();
        }

        private void SairtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void horistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDeHorista cdh = new CadastroDeHorista();
            cdh.Show();
        }

        private void operadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDeOperadores cdo = new CadastroDeOperadores();
            cdo.Show();
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntradaDeVeiculos edv = new EntradaDeVeiculos();
            edv.Show();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDeConvênios cdc = new CadastroDeConvênios();
            cdc.Show();
        }
    }
}
