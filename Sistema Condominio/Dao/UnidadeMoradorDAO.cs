using Sistema_Condominio.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Condominio.Dao
{
    public class UnidadeMoradorDAO
    {


        private BancoDeDados banco;
        public UnidadeMoradorDAO()
        {
            banco = new BancoDeDados();
        }

        public void cadastrarMoradorUnidade(unidade_morador unidadeMorador)
        {
            banco.unidade_morador.Add(unidadeMorador);
            banco.SaveChanges();
        }

        public void excluirVeiculo(unidade_morador unidadeMorador)
        {
            var ve = banco.unidade_morador.Find(unidadeMorador.ID);
            banco.unidade_morador.Remove(ve);
            banco.SaveChanges();
        }

        public List<unidade_morador> pesquisarUnidadeMorador(String pesquisa)
        {
            var resu = banco.unidade_morador.Where(v => v.nome.Contains(pesquisa)); //nao sei pq colocou cor no veiculo
            return resu.ToList();
        }

        public unidade_morador visualizarUnidadeMorador(unidade_morador unidadeMorador)
        {
            var veicu = banco.unidade_morador.Find(unidadeMorador.ID);
            return veicu;
        }

        public void alterarUnidadeMorador(unidade_morador unidadeMorador)
        {
            var veicu = banco.unidade_morador.Find(unidadeMorador.ID);
            banco.Entry(veicu).State = System.Data.Entity.EntityState.Modified;
            banco.SaveChanges();
        }


    }
}
