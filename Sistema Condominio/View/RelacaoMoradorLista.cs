using MetroFramework.Forms;
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
    public partial class RelacaoMoradorLista : MetroForm
    {
        private morador morador;
        public RelacaoMoradorLista()
        {
            InitializeComponent();
        }

        public RelacaoMoradorLista(morador morador)
        {
            this.morador = morador;
            InitializeComponent();
        }
        private void RelacaoMoradorLista_Load(object sender, EventArgs e)
        {

        }
    }
}
