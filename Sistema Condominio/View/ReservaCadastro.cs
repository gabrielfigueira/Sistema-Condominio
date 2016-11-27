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
using MetroFramework.Forms;

namespace Sistema_Condominio.View
{
    public partial class ReservaCadastro : MetroForm
    {
        private int morador_id;
        private reserva reserva;
        private ReservaDAO reservadao;
        public string metodo;

        public ReservaCadastro()
        {
            InitializeComponent();
        }

        private void ReservaCadastro_Load(object sender, EventArgs e)
        {
            if (metodo == "alterar")
            {
                preencheFormularioReserva();
            }

        }

        public ReservaCadastro(reserva reserva, ReservaDAO reservadao, string metodo) // Sobrecarga de metodo para passar parametro de morador
        {
            this.metodo = metodo;
            this.reserva = reserva;
            this.reservadao = reservadao;
            InitializeComponent();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            MoradorPesquisar moradorPesquisar = new MoradorPesquisar();
            moradorPesquisar.ShowDialog();
            tbNome.Text = moradorPesquisar.retornarMorador().pessoa.NOME;
            morador_id = moradorPesquisar.retornarMorador().ID;
        }

        private void carregaReserva()
        {
            if (reserva == null)
            {
                reserva = new reserva();
            }

            reserva.MORADOR_ID = reserva.MORADOR_ID;
            reserva.DESCRICAO_RESERVA = tbDescricao.Text;
            reserva.LOCAL_RESERVA = tbLocal.Text;
            reserva.PERMITIR = checkBoxPermitir.Checked;
        }

        private void btCadastrarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                reserva = new reserva();
                carregaReserva();
                ReservaDAO reservaDao = new ReservaDAO();
                reservaDao.cadastrarReserva(reserva);

                MessageBox.Show("Reserva Salvo");
                Index index = new Index();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void preencheFormularioReserva()
        {

            tbNome.Text = reserva.morador.pessoa.NOME;
            tbDescricao.Text = reserva.DESCRICAO_RESERVA;
            tbLocal.Text = reserva.LOCAL_RESERVA;
            checkBoxPermitir.Checked = Convert.ToBoolean(reserva.PERMITIR);
        }

        private void textButtonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                carregaReserva();
                reservadao.alterarReserva(reserva);
                MessageBox.Show("Alterado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }
    }
}
