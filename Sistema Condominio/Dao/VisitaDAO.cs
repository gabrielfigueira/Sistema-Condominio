using Sistema_Condominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Condominio.Dao
{
    public class VisitaDAO
    {
        private BancoDeDados banco;
        private visita visita;

        public VisitaDAO()
        {
            banco = new BancoDeDados();
        }

        public void cadastrarVisita(visita visita)
        {
            banco.visita.Add(visita);
            banco.SaveChanges();
        }

        public void excluirVisita(visita visita)
        {
            var visi = banco.visita.Find(visita.ID);
            banco.visita.Remove(visi);
            banco.SaveChanges();
        }
    }
}
