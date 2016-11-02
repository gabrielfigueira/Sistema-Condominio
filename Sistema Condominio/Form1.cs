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

namespace Sistema_Condominio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BancoDeDados banco = new BancoDeDados();

            banco.pessoa.Add(new pessoa()
            {
                ID = 1,
                NOME = "Gabriel",
                CPF = "321321",
                RG = "312312321",
                TELEFONE_RESIDENCIAL = "312321",
                TEL_COMERC = "23112231",
                CELULAR = "23312321",
                EMAIL = "gabriel@gabriel.com",
                NECES_ESPECIAL = true
            }); 
                       
            banco.SaveChanges();

            MessageBox.Show("Salvei");

        }
    }
}
