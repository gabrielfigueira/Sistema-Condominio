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
    public partial class RelacaoMoradorCadastro : MetroForm
    {
        private relacao_morador relacaomorador;
        private morador morador;
        public RelacaoMoradorCadastro()
        {
            InitializeComponent();
        }

        public RelacaoMoradorCadastro(morador morador)
        {
            this.morador = morador;
            InitializeComponent();
        }

        private void RelacaoMoradorCadastro_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        public void carregarRelacaoMorador(){
            relacaomorador.MORADOR_ID       = morador.ID;
            relacaomorador.GRAU_PARENTESCO  = textButtonGrauParentesco.Text;
            relacaomorador.CELULAR          = textButtonCelular.Text;
            relacaomorador.DT_NASC          = dateTimeDtNascimento.Text;
        }

        private void metroTextButtonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                relacaomorador = new relacao_morador();
                carregarRelacaoMorador();
                RelacaoMoradorDAO parente = new RelacaoMoradorDAO();
                parente.cadastrarRelacaoMorador(relacaomorador);
                MessageBox.Show("Salvei");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
