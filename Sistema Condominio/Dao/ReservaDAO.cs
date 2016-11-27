using Sistema_Condominio.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Condominio.Dao
{
    public class ReservaDAO
    {
        private BancoDeDados banco;

        public ReservaDAO()
        {
            banco = new BancoDeDados();
        }

        public void cadastrarReserva(reserva reserva)
        {

            BancoDeDados banco = new BancoDeDados();

            banco.reserva.Add(reserva);
            banco.SaveChanges();
        }

        public void excluirReserva(reserva reserva)
        {
            var ve = banco.reserva.Find(reserva.ID);
            banco.reserva.Remove(ve);
            banco.SaveChanges();
        }

        public void alterarReserva(reserva reserva)
        {
            var veicu = banco.reserva.Find(reserva.ID);
            banco.Entry(veicu).State = System.Data.Entity.EntityState.Modified;
            banco.SaveChanges();
        }

        public reserva visualizarReserva(reserva reserva)
        {
            var veicu = banco.reserva.Find(reserva.ID);
            return veicu;
        }
    }
}
