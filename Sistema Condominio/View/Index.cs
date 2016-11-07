using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using Sistema_Condominio.Model;
using Sistema_Condominio.Dao;
using System.Windows.Forms;

namespace Sistema_Condominio.View
{
    public partial class Index : MetroForm
    {
        private unidade unidade;


        public Index()
        {
            InitializeComponent();
        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void btCadastrarUnidade_Click(object sender, EventArgs e){

            //BancoDeDados banco = new BancoDeDados();
            try
            {
                unidade = new unidade();
                carregaUnidade();
                UnidadeDAO unidadeDao = new UnidadeDAO();
                unidadeDao.cadastrarUnidade(unidade);

                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }


        private void carregaUnidade()
        {

            unidade.ATIVO = checkBoxUnidade.Checked;
            unidade.grupo_unidade.DESCRICAO = cbTipoImovel.Text;
            unidade.grupo_unidade.QNT_APARTAMENTO = int.Parse(tbQtdApartamento.Text);
            unidade.tipo_unidade.QNTD_COMODO = int.Parse(tbQtdComodo.Text);
            unidade.tipo_unidade.DESCRICAO = tbDescricao.Text;
            unidade.tipo_unidade.ANDAR = tbAndar.Text;

           
        }






        private void cbTipoImovel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbTipoImovel.SelectedItem.ToString().Trim().Equals("Prédio"))
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

        private void tbQtdComodo_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }

        private void tbQtdComodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Insira apenas números!");
            }
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }
    }
}
