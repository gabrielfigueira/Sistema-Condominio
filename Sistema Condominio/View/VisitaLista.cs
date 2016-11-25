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
    public partial class VisitaLista : MetroForm
    {
        private morador morador;
        public VisitaLista()
        {
            InitializeComponent();
        }

        public VisitaLista(morador morador)
        {
            this.morador = morador;
            InitializeComponent();
        }

        private void VisitaLista_Load(object sender, EventArgs e)
        {
            carregaDadosVisita();
        }

        private void metroTextButtonCadastrar_Click(object sender, EventArgs e)
        {
            VisitaCadastro visitacadastro = new VisitaCadastro(morador);
            visitacadastro.ShowDialog();
        }

        private void carregaDadosVisita()
        {
            // Carregando dados do morado r listando no datagrid view
            BancoDeDados banco = new BancoDeDados();
            var lista = banco.visita.Where(v => v.MORADOR_ID == morador.ID).ToList();
            dataGridRelacaoVisita.DataSource = lista;
        }

        private void textButtonExcluir_Click(object sender, EventArgs e)
        {
            var visita = (visita)dataGridRelacaoVisita.CurrentRow.DataBoundItem;   //Pegar linha selecionado              
            VisitaDAO visitadao = new VisitaDAO();
            visitadao.excluirVisita(visita);
            MessageBox.Show("Exclui o Registro");
            carregaDadosVisita();
        }
    }
}
