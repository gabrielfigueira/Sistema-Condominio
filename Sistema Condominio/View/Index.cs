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
using System.Data.Entity;


namespace Sistema_Condominio.View
{
    public partial class Index : MetroForm
    {
        private MoradorDAO moradordao;
        private UnidadeDAO unidadeDao;


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


        private void tbQtdComodo_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }


        private void Index_Load(object sender, EventArgs e)
        {
            carregaDadosMorador(); //Carregando dados do morador 
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbUnidade_Enter(object sender, EventArgs e)
        {

        }

        private void metroTextButton3_Click(object sender, EventArgs e)
        {
            MoradorCadastro formMorador = new MoradorCadastro(new morador(), moradordao, "cadastrar");
            formMorador.ShowDialog();
            carregaDadosMorador();
        }

        private void dataGridMorador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextButtonAlterarMorador_Click(object sender, EventArgs e)
        {
            try
            {
                var morador = (morador)dataGridMorador.CurrentRow.DataBoundItem;   //Pegar linha selecionado              
                MoradorDAO moradordao = new MoradorDAO();
                moradordao.excluirMorador(morador);
                MessageBox.Show("Exclui o Registro");
                carregaDadosMorador();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            BancoDeDados banco = new BancoDeDados();
            MoradorDAO moradordao = new MoradorDAO(); //Instancio a Dao
            var parametro_pesquisa = textFieldPesquisarMorador.Text; // Recebo parametro do textfield de pesquisa
            var pesquisa = moradordao.pesquisarMorador(parametro_pesquisa); // Chamo o metodo de pesquisa da dao e Executa a pesquisa, no caso esta apenas por nome  e listo ela
            dataGridMorador.DataSource = pesquisa; // atribuo o valor recebido da consulta na lista
        }

        private void metroTextButtonAlterarMorador_Click_1(object sender, EventArgs e)
        {
            BancoDeDados banco = new BancoDeDados();
            MoradorDAO moradordao = new MoradorDAO();
            var morador = (morador)dataGridMorador.CurrentRow.DataBoundItem;
            var alterar = moradordao.visualizarMorador(morador);

            MoradorCadastro formMorador = new MoradorCadastro(alterar, moradordao, "alterar"); //chama formulario            
            formMorador.ShowDialog();// Show dialog chama de forma assincrona
            carregaDadosMorador();
        }

        private void textFieldPesquisarMorador_Click(object sender, EventArgs e)
        {

        }

        private void metroTextButton5_Click(object sender, EventArgs e)
        {
            VeiculoCadastro veiculocadastro = new VeiculoCadastro();
            veiculocadastro.ShowDialog();
            carregaDadosVeiculos();
        }

        private void carregaDadosMorador()
        {
            // Carregando dados do morado r listando no datagrid view
            BancoDeDados banco = new BancoDeDados();
            var lista = banco.morador.Include(m => m.pessoa).ToList();
            dataGridMorador.DataSource = lista;
        }

        private void carregaDadosUnidade()
        {
            BancoDeDados banco = new BancoDeDados();
            var lista = banco.unidade.Include(u => u.tipoUnidade).Include(u => u.grupoUnidade).ToList();
            dataGridUnidade.DataSource = lista;
        }

        private void carregaDadosReserva()
        {
            BancoDeDados banco = new BancoDeDados();
            var lista = banco.reserva.ToList();
            dataGridReserva.DataSource = lista;
        }        

        private void carregaDadosVeiculos()
        {
            BancoDeDados banco = new BancoDeDados();
            var lista = banco.veiculo.ToList();
            dataGridVeiculo.DataSource = lista;
        }

        private void carregaDadosCorpoAdm()
        {
            BancoDeDados banco = new BancoDeDados();
            //var lista = banco.orcamentos.Include(c => c.corpo_adm).ToList(); tinha feito de orçamento, 
            var lista = banco.corpo_adm.Include(c => c.cargo_corpo_admin).Include(p => p.pessoa).ToList();
            dataGridAdministracao.DataSource = lista;
        }

        private void carregaDadosFuncionarios()
        {
            BancoDeDados banco = new BancoDeDados();
            var lista = banco.funcionario.Include(f => f.pessoa).ToList();
            dataGridFuncionario.DataSource = lista;
        }

        private void carregaDadosProprietarios()
        {
            BancoDeDados banco = new BancoDeDados();
            var lista = banco.proprietario.Include(p => p.pessoa).Include(p => p.unidade).ToList();
            dataGridViewProprietario.DataSource = lista;
        }

        private void carregaDadosFeedbacks()
        {
            BancoDeDados banco = new BancoDeDados();
            var lista = banco.feedbacks.Include(f => f.morador).ToList();
            dataGridFeedback.DataSource = lista;
        }

       

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextButton4_Click(object sender, EventArgs e)
        {
            try
            {
                var veiculo = (veiculo)dataGridVeiculo.CurrentRow.DataBoundItem;   //Pegar linha selecionado              
                VeiculoDAO veiculodao = new VeiculoDAO();
                veiculodao.excluirVeiculo(veiculo);
                MessageBox.Show("Exclui o Registro");
                carregaDadosVeiculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroTextButton3_Click_1(object sender, EventArgs e)
        {
            BancoDeDados banco = new BancoDeDados();
            VeiculoDAO veiculodao = new VeiculoDAO();
            var veiculo = (veiculo)dataGridVeiculo.CurrentRow.DataBoundItem;
            var alterar = veiculodao.visualizarVeiculo(veiculo);

            VeiculoCadastro formVeiculo = new VeiculoCadastro(alterar, veiculodao, "alterar"); //chama formulario            
            formVeiculo.ShowDialog();// Show dialog chama de forma assincrona
            carregaDadosVeiculos();
        }

        private void tbQtdComodo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btCadastrarUnidade_Click(object sender, EventArgs e)
        {
            UnidadeCadastro formUnidade = new UnidadeCadastro(new unidade(), unidadeDao, "cadastrar");
            formUnidade.ShowDialog();
            carregaDadosUnidade();
        }

        private void textButtonParentes_Click(object sender, EventArgs e)
        {
            var morador = (morador)dataGridMorador.CurrentRow.DataBoundItem;
            RelacaoMoradorLista parentesMorador = new RelacaoMoradorLista(morador);
            parentesMorador.ShowDialog();
        }

        private void textButtonVisita_Click(object sender, EventArgs e)
        {
            var morador = (morador)dataGridMorador.CurrentRow.DataBoundItem;
            VisitaLista visitalista = new VisitaLista(morador);
            visitalista.ShowDialog();
        }


        private void metroTextButton5_Click_1(object sender, EventArgs e)
        {
            var morador = (morador)dataGridMorador.CurrentRow.DataBoundItem;
            MoradorUnidadeLista moradorUnidadeLista = new MoradorUnidadeLista(morador);
            moradorUnidadeLista.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageUnidade)
            {
                carregaDadosUnidade();
            }
            else if (tabControl1.SelectedTab == tabPageVeiculos)
            {
                carregaDadosVeiculos();
            }
            else if (tabControl1.SelectedTab == tabPageAdministracao)
            {
                carregaDadosCorpoAdm();
            }
            else if (tabControl1.SelectedTab == tabPageFuncionarios)
            {
                carregaDadosFuncionarios();
            }
            else if (tabControl1.SelectedTab == tabPageUsuarios)
            {

            }
            else if (tabControl1.SelectedTab == tabPageProprietario)
            {
                carregaDadosProprietarios();
            }
            else if (tabControl1.SelectedTab == tabPageFeedback)
            {
                carregaDadosFeedbacks();

            }
            else if (tabControl1.SelectedTab == tabPageReserva)
            {
                carregaDadosReserva();
            }
        }

        private void dataGridFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextButton3_Click_2(object sender, EventArgs e)
        {
            BancoDeDados banco = new BancoDeDados();
            UnidadeDAO unidadedao = new UnidadeDAO();
            var unidade = (unidade)dataGridUnidade.CurrentRow.DataBoundItem;
            var alterar = unidadedao.visualizarUnidade(unidade);

            UnidadeCadastro formUnidade = new UnidadeCadastro(alterar, unidadedao, "alterar"); //chama formulario            
            formUnidade.ShowDialog();// Show dialog chama de forma assincrona
            carregaDadosUnidade();
        }

        private void tbExcluirUnidade_Click(object sender, EventArgs e)
        {
            try
            {
                var unidade = (unidade)dataGridUnidade.CurrentRow.DataBoundItem;   //Pegar linha selecionado              
                UnidadeDAO unidadedao = new UnidadeDAO();
                unidadedao.excluirUnidade(unidade);
                //MessageBox.Show("Registro excluído com sucesso!");
                carregaDadosUnidade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btExcluirReserva_Click(object sender, EventArgs e)
        {
            try
            {
                var reserva = (reserva)dataGridReserva.CurrentRow.DataBoundItem;   //Pegar linha selecionado              
                ReservaDAO reservadao = new ReservaDAO();
                reservadao.excluirReserva(reserva);
                MessageBox.Show("Registro excluído com sucesso!");
                carregaDadosReserva();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCadastrarReserva_Click(object sender, EventArgs e)
        {
            ReservaCadastro reservacadastro = new ReservaCadastro();
            reservacadastro.ShowDialog();
            carregaDadosReserva();
        }

        private void btAlterarReserva_Click(object sender, EventArgs e)
        {
            BancoDeDados banco = new BancoDeDados();
            ReservaDAO reservadao = new ReservaDAO();
            var reserva = (reserva)dataGridReserva.CurrentRow.DataBoundItem;
            var alterar = reservadao.visualizarReserva(reserva);

            ReservaCadastro formReserva = new ReservaCadastro(alterar, reservadao, "alterar"); //chama formulario            
            formReserva.ShowDialog();// Show dialog chama de forma assincrona
            carregaDadosReserva();
        }

        private void tabPageAdministracao_Click(object sender, EventArgs e)
        {

        }

        private void btExcluirFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                var feedback = (feedbacks)dataGridFeedback.CurrentRow.DataBoundItem;   //Pegar linha selecionado              
                FeedbackDAO feedbackdao = new FeedbackDAO();
                feedbackdao.excluirFeedback(feedback);
                MessageBox.Show("Registro excluído com sucesso!");
                carregaDadosFeedbacks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btExcluirProprietario_Click(object sender, EventArgs e)
        {
            try
            {
                var proprietario = (proprietario)dataGridViewProprietario.CurrentRow.DataBoundItem;   //Pegar linha selecionado              
                ProprietarioDAO proprietariodao = new ProprietarioDAO();
                proprietariodao.excluirProprietario(proprietario);
                MessageBox.Show("Registro excluído com sucesso!");
                carregaDadosProprietarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
