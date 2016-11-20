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
    public partial class UnidadeCadastro : MetroForm
    {
        public UnidadeCadastro()
        {
            InitializeComponent();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbTipoImovel.SelectedItem.Equals("Prédio")){
                tbQtdApart.Enabled = false;
                tbAndar.Enabled = false;         
            }
        }

        private void Unidade_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {



            this.Hide();
            Index index = new Index();
            index.ShowDialog();
        }
    }
}
