using MetroFramework.Forms;
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

namespace Sistema_Condominio.View
{
    public partial class UnidadeMoradorCadastro : MetroForm
    {
        private int morador_id;
        private int unidade_id;
        private morador morador;
        private unidade unidade;
        private UnidadeMoradorDAO unidadeMoradorDAO;
        private unidade_morador unidadeMorador;
        private string metodo;

        public UnidadeMoradorCadastro()
        {
            InitializeComponent();
        }

        public UnidadeMoradorCadastro(morador morador, unidade unidade, UnidadeMoradorDAO unidadeMoradorDAO, string metodo)
        {
            this.metodo = metodo;
            this.morador = morador;
            this.unidade = unidade;
            this.unidadeMoradorDAO = unidadeMoradorDAO;
            
            InitializeComponent();
        }

        private void UnidadeMoradorCadastro_Load(object sender, EventArgs e)
        {

            if (metodo == "alterar")
            {
                preencheFormularioUnidadeMorador();
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            MoradorPesquisar moradorPesquisar = new MoradorPesquisar();
            moradorPesquisar.ShowDialog();
            metroTextBoxMoradorNome.Text = moradorPesquisar.retornarMorador().pessoa.NOME;
            morador_id = moradorPesquisar.retornarMorador().ID;
        }

        private void carregaUnidadeMorador()
        {
            if (unidadeMorador == null)
            {
                unidadeMorador = new unidade_morador();
            }
            unidadeMorador.MORADOR_ID = morador_id;
            unidadeMorador.UNIDADE_ID = unidade_id;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                unidadeMorador = new unidade_morador();
                carregaUnidadeMorador();
                UnidadeMoradorDAO unidadeMoradorDao = new UnidadeMoradorDAO();
                unidadeMoradorDao.cadastrarMoradorUnidade(unidadeMorador);

                MessageBox.Show("Unidade do Morador Salvo");
                Index index = new Index();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void preencheFormularioUnidadeMorador()
        {
            //metroTextBoxMoradorNome.Text = unidadeMora.morador.pessoa.NOME;
            //textBoxMarca.Text = veiculo.MARCA;
            //textBoxModelo.Text = veiculo.MODELO;
            //textBoxCor.Text = veiculo.COR;
            //textBoxNrPlaca.Text = veiculo.N_PLACA;
            //textBoxVagaAlugada.Text = veiculo.VAGA_ALUGADA.ToString();

        }


    }
}
