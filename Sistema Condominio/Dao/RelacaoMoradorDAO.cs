using Sistema_Condominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Condominio.Dao
{
    public class RelacaoMoradorDAO
    {
        private BancoDeDados banco;
        private relacao_morador relacao_morador;

           public RelacaoMoradorDAO()
        {
            banco = new BancoDeDados();
        }

        public void cadastrarRelacaoMorador(relacao_morador relacao_morador)
        {            
            banco.relacao_morador.Add(relacao_morador);
            banco.SaveChanges();
        }

        public void excluirRelacaoMorador(relacao_morador relacao_morador)
        {
            var parente = banco.relacao_morador.Find(relacao_morador.ID);
            banco.relacao_morador.Remove(parente);
            banco.SaveChanges();
        }
    }
}
