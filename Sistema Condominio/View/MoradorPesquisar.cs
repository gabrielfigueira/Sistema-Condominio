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
    public partial class MoradorPesquisar : MetroForm
    {
        public MoradorPesquisar()
        {
            InitializeComponent();
        }

        private void MoradorPesquisar_Load(object sender, EventArgs e)
        {
            carregaDadosMorador();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            BancoDeDados banco = new BancoDeDados();
            MoradorDAO moradordao = new MoradorDAO(); //Instancio a Dao
            var parametro_pesquisa = textFieldPesquisarMorador.Text; // Recebo parametro do textfield de pesquisa
            var pesquisa = moradordao.pesquisarMorador(parametro_pesquisa); // Chamo o metodo de pesquisa da dao e Executa a pesquisa, no caso esta apenas por nome  e listo ela
            dataGridMorador.DataSource = pesquisa; // atribuo o valor recebido da consulta na lista
        }

        private void carregaDadosMorador()
        {
            // Carregando dados do morado r listando no datagrid view
            BancoDeDados banco = new BancoDeDados();
            var lista = banco.morador.Include(m => m.pessoa).ToList();
            dataGridMorador.DataSource = lista;
        }
    }
}
