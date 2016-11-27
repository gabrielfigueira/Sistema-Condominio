using Sistema_Condominio.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Condominio.Dao
{
    public class FeedbackDAO
    {
        private BancoDeDados banco;

        public FeedbackDAO()
        {
            banco = new BancoDeDados();
        }

        public void cadastrarFeedback(feedbacks feedback)
        {
            BancoDeDados banco = new BancoDeDados();

            banco.feedbacks.Add(feedback);
            banco.SaveChanges();
        }

        public void excluirFeedback(feedbacks feedback)
        {
            var ve = banco.feedbacks.Find(feedback.ID);
            banco.feedbacks.Remove(ve);
            banco.SaveChanges();
        }

        public void alterarFeedback(feedbacks feedback)
        {
            var feed = banco.feedbacks.Find(feedback.ID);
            banco.Entry(feed).State = System.Data.Entity.EntityState.Modified;
            banco.SaveChanges();
        }

        public feedbacks visualizarFeedback(feedbacks feedback)
        {
            var feed = banco.feedbacks.Find(feedback.ID);
            return feed;
        }


    }
}
