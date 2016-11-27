using Sistema_Condominio.Dao;
using Sistema_Condominio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Sistema_Condominio.View
{
    public partial class UnidadeCadastro : MetroForm
    {
        private unidade unidade;
        private UnidadeDAO unidadeDao;
        public string metodo;

        public UnidadeCadastro()
        {
            InitializeComponent();
        }

        public UnidadeCadastro(unidade unidade, UnidadeDAO unidadeDao, string metodo) // Sobrecarga de metodo para passar parametro de morador
        {
            this.metodo = metodo;
            this.unidade = unidade;
            this.unidadeDao = unidadeDao;
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index index = new Index();
            index.ShowDialog();
        }

     

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Insira apenas números!");
            }
        }

        private void btCadastrarUnidade_Click(object sender, EventArgs e)
        {
            try
            {
                unidade = new unidade();
                carregaUnidade();
                UnidadeDAO unidadeDao = new UnidadeDAO();
                unidadeDao.cadastrarUnidade(unidade);
                Index index = new Index();
                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void carregaUnidade()
        {
            if (unidade.grupoUnidade == null)
            {
                unidade.grupoUnidade = new grupo_unidade();
            }

            if (unidade.tipoUnidade == null)
            {
                unidade.tipoUnidade = new tipo_unidade();
            }

            unidade.ATIVO = checkBoxUnidade.Checked;
            unidade.grupo_unidade.DESCRICAO = cbTipoImovel.Text;
            unidade.grupo_unidade.QNT_APARTAMENTO = int.Parse(tbQtdApartamento.Text);
            unidade.tipo_unidade.QNTD_COMODO = int.Parse(tbQtdComodo.Text);
            unidade.tipo_unidade.DESCRICAO = tbDescricao.Text;
            unidade.tipo_unidade.ANDAR = tbAndar.Text;
        }


        private void preencheFormularioUnidade()
        {
            checkBoxUnidade.Checked = Convert.ToBoolean(unidade.ATIVO);
            cbTipoImovel.Text = unidade.grupo_unidade.DESCRICAO;
            tbQtdApartamento.Text = Convert.ToString(unidade.grupo_unidade.QNT_APARTAMENTO);
            tbQtdComodo.Text = Convert.ToString(unidade.tipo_unidade.QNTD_COMODO);
            tbDescricao.Text = unidade.tipo_unidade.DESCRICAO;
            tbAndar.Text = unidade.tipo_unidade.ANDAR;
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!cbTipoImovel.SelectedItem.Equals("Prédio"))
            {
                tbQtdApartamento.Enabled = false;
                tbAndar.Enabled = false;
            }
            if (cbTipoImovel.SelectedItem.ToString().Trim().Equals("Prédio"))
            {
                tbQtdApartamento.Enabled = true;
                tbAndar.Enabled = true;
            }
        }


        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


       

        private void Unidade_Load(object sender, EventArgs e)
        {
            if (metodo == "alterar")
            {
                preencheFormularioUnidade();
            }
        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
