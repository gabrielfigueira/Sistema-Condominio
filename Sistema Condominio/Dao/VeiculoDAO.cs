using Sistema_Condominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Condominio.Dao
{
    class VeiculoDAO
    {
        public void cadastrarVeiculo(veiculo veiculo)
        {
            BancoDeDados banco = new BancoDeDados();
            banco.veiculo.Add(veiculo);
            banco.SaveChanges();

        }
    }
}
