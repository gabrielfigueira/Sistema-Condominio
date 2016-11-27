using Sistema_Condominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sistema_Condominio.Dao
{
    public class UnidadeDAO
    {
        private BancoDeDados banco;

        public UnidadeDAO()
        {
            banco = new BancoDeDados();
        }

        public List<unidade> pesquisarUnidade(int pesquisa)
        {

            var resu = banco.unidade.Where(u => u.unidade_morador.Equals(pesquisa));
            return resu.ToList();
        }

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

        public void alterarMorador(unidade unidade)
        {
            banco.Entry(unidade).State = EntityState.Modified;
            banco.SaveChanges();
            var grupoUnidade = banco.grupo_unidade.Find(unidade.grupo_unidade);
            banco.Entry(grupoUnidade).State = System.Data.Entity.EntityState.Modified;
            banco.SaveChanges();

            var tipoUnidade = banco.tipo_unidade.Find(unidade.tipo_unidade);
            banco.Entry(tipoUnidade).State = System.Data.Entity.EntityState.Modified;
            banco.SaveChanges();

        }

        public void excluirUnidade(unidade unidade)
        {
            var grupoUnidade = banco.grupo_unidade.Find(unidade.GRUPO_UNIDADE_ID);
            var tipoUnidade = banco.tipo_unidade.Find(unidade.TIPO_UNIDADE_ID);
            var uni = banco.unidade.Find(unidade.ID);
            var uni_morador = banco.unidade_morador.Find(unidade.ID);

            try
            {
                banco.unidade.Remove(uni);
                banco.SaveChanges();

                banco.grupo_unidade.Remove(grupoUnidade);
                banco.SaveChanges();

                banco.tipo_unidade.Remove(tipoUnidade);
                banco.SaveChanges();

                MessageBox.Show("Registro excluído com sucesso!");

            }
            catch (Exception ex)
            {
                if (uni_morador != null)
                {
                    MessageBox.Show("Não foi possível excluir, este registro possui vínculo com Unidade_Morador");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public unidade visualizarUnidade(unidade unidade)
        {

            var uni = banco.unidade.Find(unidade.ID);
            return uni;
        }
    }
}
