using Sistema_Condominio.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Condominio.Dao
{
    public class ProprietarioDAO
    {
        private BancoDeDados banco;

        public ProprietarioDAO()
        {
            banco = new BancoDeDados();
        }

        public void cadastrarProprietario(proprietario proprietario)
        {

            BancoDeDados banco = new BancoDeDados();

            banco.proprietario.Add(proprietario);
            banco.SaveChanges();
        }

        public void excluirProprietario(proprietario proprietario)
        {
            var ve = banco.proprietario.Find(proprietario.ID);
            banco.proprietario.Remove(ve);
            banco.SaveChanges();
        }

        public proprietario visualizarProprietario(proprietario proprietario)
        {
            var prop = banco.proprietario.Find(proprietario.ID);
            return prop;
        }


    }
}
