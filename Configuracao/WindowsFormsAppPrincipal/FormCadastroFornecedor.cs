using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormCadastroFornecedor : Form
    {
        int cod;
        public FormCadastroFornecedor(int _cod = 0)
        {
            InitializeComponent();
            cod = _cod;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedor fornecedor = (Fornecedor)fornecedorBindingSource.Current;

                fornecedorBindingSource.EndEdit();

                if (cod == 0)
                    new FornecedorBLL().Inserir(fornecedor);
                else
                    new FornecedorBLL().Alterar(fornecedor);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroFornecedor_Load(object sender, EventArgs e)
        {
            try
            {
                if (cod == 0)
                    fornecedorBindingSource.AddNew();
                else
                    fornecedorBindingSource.DataSource = new FornecedorBLL().BuscarPorId(cod);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
