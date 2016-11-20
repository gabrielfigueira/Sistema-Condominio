using MetroFramework.Forms;
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
    public partial class VeiculoCadastro : MetroForm
    {
        public VeiculoCadastro()
        {
            InitializeComponent();
        }

        private void VeiculoCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            MoradorPesquisar moradorPesquisar = new MoradorPesquisar();
            moradorPesquisar.Show();
        }
    }
}
