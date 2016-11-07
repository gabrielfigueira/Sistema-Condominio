using Sistema_Condominio.Model;
using System;
using System.Data.Entity;
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
    public partial class MoradorLista : Form
    {
       // private morador morador;
        
        public MoradorLista()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {       
         
        }

        private void MoradorLista_Load(object sender, EventArgs e)
        {
            carregaDadosMorador();
        }

        private void carregaDadosMorador()
        {
            BancoDeDados banco = new BancoDeDados();
            var lista = banco.morador.Include(m => m.pessoa).ToList();
            dataGridListaMorador.DataSource = lista;
        }
    }
}
