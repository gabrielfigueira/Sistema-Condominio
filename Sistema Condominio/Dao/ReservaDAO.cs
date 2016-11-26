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


    }
}
