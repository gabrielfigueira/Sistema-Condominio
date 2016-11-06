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
        private pessoa pessoa;
        public void cadastrarMorador(morador morador)
        {
            BancoDeDados banco = new BancoDeDados();

            banco.pessoa.Add(morador.pessoa);
            banco.SaveChanges();
            morador.PESSOA_ID = morador.pessoa.ID;
            banco.morador.Add(morador);
            banco.SaveChanges();

        }
    }
}
