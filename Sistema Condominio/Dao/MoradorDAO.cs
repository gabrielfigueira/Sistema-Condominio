using Sistema_Condominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Condominio.Dao
{
    class MoradorDAO
    {
        private String _pesquisa;
        public void cadastrarMorador(morador morador)
        {
            BancoDeDados banco = new BancoDeDados();

            banco.pessoa.Add(morador.pessoa);
            banco.SaveChanges();
            morador.PESSOA_ID = morador.pessoa.ID;
            banco.morador.Add(morador);
            banco.SaveChanges();

        }

        public void excluirMorador(morador morador)
        {
            BancoDeDados banco = new BancoDeDados();
            var pessoa = banco.pessoa.Find( morador.PESSOA_ID);
            var mora = banco.morador.Find(morador.ID);
            banco.morador.Remove(mora);
            banco.SaveChanges();
            banco.pessoa.Remove(pessoa);
            banco.SaveChanges();
        }

    }
}
