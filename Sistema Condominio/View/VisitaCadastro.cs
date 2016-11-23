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
    public partial class VisitaCadastro : MetroForm
    {
        private morador morador;
        private visita visita;
        public VisitaCadastro()
        {
            InitializeComponent();
        }

        public VisitaCadastro(morador morador)
        {
            this.morador = morador;
            InitializeComponent();
        }

        private void VisitanteCadastro_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void carregaVisita()
        {
            visita.MORADOR_ID = morador.ID;
            visita.NOME = textButtonNome.Text;
            visita.DATA_ENTRADA = dateTimeDataEntrada.Value;
            visita.DATA_SAIDA = dateTimeDataSaida.Value;
            visita.DATA_PREVISTA = dateTimeDataPrevista.Value;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                visita = new visita();
                carregaVisita();
                VisitaDAO visitadao = new VisitaDAO();
                MessageBox.Show(visita.NOME);
                visitadao.cadastrarVisita(visita);
                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
