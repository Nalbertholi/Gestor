using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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
                Fornecedor cliente = (Fornecedor)fornecedorBindingSource.Current;

                fornecedorBindingSource.EndEdit();

                if (cod == 0)
                    new FornecedorBLL().Inserir(cliente);
                else
                    new FornecedorBLL().Alterar(cliente);

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
        /*private void FormCadastroFornecedor_Load(object sender, EventArgs e)
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
        }*/
    }
}
