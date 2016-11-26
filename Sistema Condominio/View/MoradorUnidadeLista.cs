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
    public partial class MoradorUnidadeLista : MetroForm
    {
        private morador morador;
        private unidade unidade;

        public MoradorUnidadeLista()
        {
            InitializeComponent();
        }

        public MoradorUnidadeLista(morador morador)
        {
            this.morador = morador;
            InitializeComponent();
        }

        private void MoradorUnidadeLista_Load(object sender, EventArgs e)
        {
            carregaDadosMoradorUnidade();
        }
        
        private void carregaDadosMoradorUnidade()
        {
            BancoDeDados banco = new BancoDeDados();
            var lista = banco.unidade_morador.Where(v => v.MORADOR_ID == morador.ID).ToList();
            dataGridMoradorUnidade.DataSource = lista;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            UnidadeMoradorCadastro unidadeMoradorCadastro = new UnidadeMoradorCadastro(morador, unidade);
            unidadeMoradorCadastro.ShowDialog();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            //    var unidadeMorador = (unidadeMorador)dataGridRelacaoVisita.CurrentRow.DataBoundItem;   //Pegar linha selecionado              
            //    VisitaDAO visitadao = new VisitaDAO();
            //    visitadao.excluirVisita(visita);
            //    MessageBox.Show("Exclui o Registro");
            //    carregaDadosVisita();
        }
    }
}
