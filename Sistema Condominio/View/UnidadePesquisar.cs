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
using System.Data.Entity;

namespace Sistema_Condominio.View
{
    public partial class UnidadePesquisar : MetroForm
    {
        public unidade unidade;
        public unidade_morador unidade_morador;

        public UnidadePesquisar()
        {
            InitializeComponent();
        }

        private void UnidadePesquisar_Load(object sender, EventArgs e)
        {
            carregaDadosUnidade();
        }

        private void carregaDadosUnidade()
        {
            // Carregando dados da unidade r listando no datagrid view
            BancoDeDados banco = new BancoDeDados();
            var lista = banco.unidade.Include(u => u.unidade_morador).ToList();
            dataGridUnidade.DataSource = lista;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            BancoDeDados banco = new BancoDeDados();
            UnidadeDAO unidadedao = new UnidadeDAO(); //Instancio a Dao
            var parametro_pesquisa = textFieldPesquisarUnidade.Text; // Recebo parametro do textfield de pesquisa
            var pesquisa = unidadedao.pesquisarUnidade(int.Parse(parametro_pesquisa)); // Chamo o metodo de pesquisa da dao e Executa a pesquisa, no caso esta apenas por nome  e listo ela
            dataGridUnidade.DataSource = pesquisa; // atribuo o valor recebido da consulta na lista
        }

        private void carregaDadosMorador()
        {
            // Carregando dados do morado r listando no datagrid view
            BancoDeDados banco = new BancoDeDados();
            //var lista = banco.morador.Include(m => m.pessoa).ToList();
            var lista = banco.unidade.ToList();
            dataGridUnidade.DataSource = lista;
        }

        private void metroTextButtonSelecionar_Click(object sender, EventArgs e)
        {
            retornarUnidade();
            this.Close();
        }

        public unidade retornarUnidade()
        {
            var unidade = (unidade)dataGridUnidade.CurrentRow.DataBoundItem;
            return unidade;
        }

        //public unidade_morador retornarUnidadeMorador()
        //{
        //    var unidade_morador = (unidade_morador)dataGridUnidade.CurrentRow.DataBoundItem;
        //    return unidade_morador;
        //}

        private void btPesquisar_Click_1(object sender, EventArgs e)
        {

        }

        private void metroTextButtonSelecionar_Click_1(object sender, EventArgs e)
        {
            retornarUnidade();
            this.Close();
        }
    }
}
