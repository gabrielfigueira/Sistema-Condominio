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

        public VeiculoDAO()
        {
            banco = new BancoDeDados();
        }

        public void cadastrarVeiculo(veiculo veiculo)
        {
            banco.veiculo.Add(veiculo);
            banco.SaveChanges();
        }

        public void excluirVeiculo(veiculo veiculo)
        {
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
            var veicu = banco.veiculo.Find(veiculo.ID);
            banco.Entry(veicu).State = System.Data.Entity.EntityState.Modified;
            banco.SaveChanges();
        }
    }
}
