using Sistema_Condominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Condominio.Dao
{
    class UnidadeDAO
    {
        public void cadastrarUnidade(unidade unidade)
        {

            BancoDeDados banco = new BancoDeDados();
            banco.grupo_unidade.Add(unidade.grupo_unidade);
            banco.SaveChanges();

            banco.tipo_unidade.Add(unidade.tipo_unidade);
            banco.SaveChanges();

            unidade.ID = unidade.grupo_unidade.ID;
            banco.unidade.Add(unidade);
            banco.SaveChanges();
        }
    }
}
