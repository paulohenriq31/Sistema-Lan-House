using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace controleEstoque
{
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
            string produto = txtProduto.Text.ToString();
            string marca = txtMarca.Text.ToString();
            int quantidade = Convert.ToInt32(numericQuantC.Text);
            double preco = Convert.ToDouble(txtPreco.Text);
            
            //Debug tem que ser mudado para x64
            //configurar a pasta que será usada
            OleDbConnection connection = new OleDbConnection();
            String endereco = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C://Users//" + Environment.UserName + "//Documents//Sistema-Lan-House//banco//LanHouse.mdb";

            connection.ConnectionString = endereco;

            //INSERT no banco de dados
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO tb_produtos(produtos, marca, quantidade, preco)"
            + "VALUES (@produto,@marca,@quantidade,@preco)";

            cmd.Parameters.AddWithValue("@produto", produto);
            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Connection = connection;

            //executando o INSERT
            connection.Open();

            //verificar se o comando foi afetado
            try
            {
                int linhaAfetadas = cmd.ExecuteNonQuery();

                if (linhaAfetadas > 0)
                {
                    MessageBox.Show("Produto Cadastrado");

                    txtMarca.Clear();
                    txtPreco.Clear();
                    txtProduto.Clear();
                    txtProduto.Focus();
                    numericQuantC.Value = 0;
                }
                else
                {
                    MessageBox.Show("Ocorreu algum problema no cadastro.");
                }

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro! \nPor favor preencher todos os campos", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
            

        }

        private void buttonCadastrarProd_Click(object sender, EventArgs e)
        {
            txtMarca.Enabled = true;
            txtPreco.Enabled = true;
            txtProduto.Enabled = true;
            numericQuantC.Enabled = true;

        }

        private void tb_produtosBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedPreco_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
          
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }

}
