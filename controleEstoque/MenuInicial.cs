using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleEstoque
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void buttonCadastrarProdM_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastro = new CadastroProduto();
            cadastro.ShowDialog();
        }

        private void buttonVendaM_Click(object sender, EventArgs e)
        {

        }
    }
}
