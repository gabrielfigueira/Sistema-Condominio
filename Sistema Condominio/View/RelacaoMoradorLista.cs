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
    public partial class RelacaoMoradorLista : MetroForm
    {
        private morador morador;
        public RelacaoMoradorLista()
        {
            InitializeComponent();
        }

        public RelacaoMoradorLista(morador morador)
        {
            this.morador = morador;
            InitializeComponent();
        }
        private void RelacaoMoradorLista_Load(object sender, EventArgs e)
        {
            carregaDadosRelacaoMorador();
        }

        private void metroTextButtonCadastrar_Click(object sender, EventArgs e)
        {
            RelacaoMoradorCadastro parenteCadastro = new RelacaoMoradorCadastro(morador);
            parenteCadastro.ShowDialog();
            carregaDadosRelacaoMorador();
        }

        private void carregaDadosRelacaoMorador()
        {
            // Carregando dados do morado r listando no datagrid view
            BancoDeDados banco = new BancoDeDados();
            var lista = banco.relacao_morador.Where(m => m.MORADOR_ID == morador.ID).ToList();
            dataGridRelacaoMorador.DataSource = lista;
        }

        private void textButtonExcluir_Click(object sender, EventArgs e)
        {
            
            try
            {
                var relacao_morador = (relacao_morador)dataGridRelacaoMorador.CurrentRow.DataBoundItem;   //Pegar linha selecionado              
                RelacaoMoradorDAO relacaomorador = new RelacaoMoradorDAO();
                relacaomorador.excluirRelacaoMorador(relacao_morador);
                MessageBox.Show("Exclui o Registro");
                carregaDadosRelacaoMorador();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
