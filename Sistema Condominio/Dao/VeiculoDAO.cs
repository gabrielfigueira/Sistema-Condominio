using Sistema_Condominio.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Condominio.Dao
{
    public class VeiculoDAO
    {
        private BancoDeDados banco;

        public void cadastrarVeiculo(veiculo veiculo)
        {
            BancoDeDados banco = new BancoDeDados();
            banco.veiculo.Add(veiculo);
            banco.SaveChanges();

        }

        public void excluirVeiculo(veiculo veiculo)
        {
            veiculo = new Model.veiculo();
            var ve = banco.veiculo.Find(veiculo.ID);
            banco.veiculo.Remove(ve);
            banco.SaveChanges();
        }

        public List<veiculo> pesquisarVeiculo(String pesquisa)
        {
              var resu = banco.veiculo.Where(v => v.COR.Contains(pesquisa));
              return resu.ToList();

        }

        public veiculo visualizarVeiculo(veiculo veiculo)
        {
            var veicu = banco.veiculo.Find(veiculo.ID);
            return veicu;
        }

        public void alterarVeiculo(veiculo veiculo)
        {
            banco.Entry(veiculo).State = EntityState.Modified;
            banco.SaveChanges();
        }
    }
}
