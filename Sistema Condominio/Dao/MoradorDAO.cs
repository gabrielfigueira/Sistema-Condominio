using Sistema_Condominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Sistema_Condominio.Dao
{
    public class MoradorDAO
    {
        private BancoDeDados banco;

        public MoradorDAO()
        {
            banco = new BancoDeDados();
        }

        public void cadastrarMorador(morador morador)
        {
            banco.pessoa.Add(morador.pessoa);
            banco.SaveChanges();
            morador.PESSOA_ID = morador.pessoa.ID;
            banco.morador.Add(morador);
            banco.SaveChanges();
        }

        public void excluirMorador(morador morador)
        {
            var pessoa = banco.pessoa.Find(morador.PESSOA_ID);
            var mora = banco.morador.Find(morador.ID);
            banco.morador.Remove(mora);
            banco.SaveChanges();
            banco.pessoa.Remove(pessoa);
            banco.SaveChanges();
        }

        public List<morador> pesquisarMorador(String pesquisa)
        {
            var resu = banco.morador.Where(m => m.pessoa.NOME.Contains(pesquisa));
            return resu.ToList();
        }

        public morador visualizarMorador(morador morador)
        {
            var mora = banco.morador.Find(morador.ID);
            return mora;
        }

        public void alterarMorador(morador morador)
        {
            banco.Entry(morador).State = EntityState.Modified;
            banco.SaveChanges();
            var pessoa = banco.pessoa.Find(morador.PESSOA_ID);
            banco.Entry(pessoa).State = System.Data.Entity.EntityState.Modified;
            banco.SaveChanges();
        }
    }
}
