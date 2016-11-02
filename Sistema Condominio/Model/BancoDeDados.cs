namespace Sistema_Condominio.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BancoDeDados : DbContext
    {
        public BancoDeDados()
            : base("name=BancoDeDados")
        {
        }

        public virtual DbSet<atividade> atividade { get; set; }
        public virtual DbSet<cargo_corpo_admin> cargo_corpo_admin { get; set; }
        public virtual DbSet<corpo_adm> corpo_adm { get; set; }
        public virtual DbSet<enc_corresp> enc_corresp { get; set; }
        public virtual DbSet<feedbacks> feedbacks { get; set; }
        public virtual DbSet<funcionario> funcionario { get; set; }
        public virtual DbSet<grupo_unidade> grupo_unidade { get; set; }
        public virtual DbSet<local_reserva> local_reserva { get; set; }
        public virtual DbSet<morador> morador { get; set; }
        public virtual DbSet<orcamentos> orcamentos { get; set; }
        public virtual DbSet<pessoa> pessoa { get; set; }
        public virtual DbSet<proprietario> proprietario { get; set; }
        public virtual DbSet<relacao_morador> relacao_morador { get; set; }
        public virtual DbSet<reserva> reserva { get; set; }
        public virtual DbSet<tipo_feedbacks> tipo_feedbacks { get; set; }
        public virtual DbSet<tipo_morador> tipo_morador { get; set; }
        public virtual DbSet<tipo_unidade> tipo_unidade { get; set; }
        public virtual DbSet<unidade> unidade { get; set; }
        public virtual DbSet<unidade_morador> unidade_morador { get; set; }
        public virtual DbSet<veiculo> veiculo { get; set; }
        public virtual DbSet<visita> visita { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<atividade>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<atividade>()
                .HasMany(e => e.funcionario)
                .WithRequired(e => e.atividade)
                .HasForeignKey(e => e.ATIVIDADE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cargo_corpo_admin>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<cargo_corpo_admin>()
                .HasMany(e => e.corpo_adm)
                .WithRequired(e => e.cargo_corpo_admin)
                .HasForeignKey(e => e.CARGO_CORPO_ADMIN_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<corpo_adm>()
                .HasMany(e => e.orcamentos)
                .WithRequired(e => e.corpo_adm)
                .HasForeignKey(e => e.CORPO_ADM_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<enc_corresp>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<enc_corresp>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<feedbacks>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<grupo_unidade>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<grupo_unidade>()
                .HasMany(e => e.unidade)
                .WithRequired(e => e.grupo_unidade)
                .HasForeignKey(e => e.UNIDADES_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<local_reserva>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<local_reserva>()
                .HasMany(e => e.reserva)
                .WithRequired(e => e.local_reserva)
                .HasForeignKey(e => e.LOCAL_RESERVA_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<morador>()
                .HasMany(e => e.enc_corresp)
                .WithRequired(e => e.morador)
                .HasForeignKey(e => e.MORADOR_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<morador>()
                .HasMany(e => e.feedbacks)
                .WithRequired(e => e.morador)
                .HasForeignKey(e => e.MORADOR_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<morador>()
                .HasMany(e => e.relacao_morador)
                .WithRequired(e => e.morador)
                .HasForeignKey(e => e.MORADOR_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<morador>()
                .HasMany(e => e.reserva)
                .WithRequired(e => e.morador)
                .HasForeignKey(e => e.MORADOR_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<morador>()
                .HasMany(e => e.unidade_morador)
                .WithRequired(e => e.morador)
                .HasForeignKey(e => e.MORADOR_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<morador>()
                .HasMany(e => e.visita)
                .WithRequired(e => e.morador)
                .HasForeignKey(e => e.MORADOR_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<morador>()
                .HasMany(e => e.veiculo)
                .WithRequired(e => e.morador)
                .HasForeignKey(e => e.MORADOR_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<orcamentos>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<orcamentos>()
                .Property(e => e.SITUACAO)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.RG)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.TELEFONE_RESIDENCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.TEL_COMERC)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .HasMany(e => e.corpo_adm)
                .WithRequired(e => e.pessoa)
                .HasForeignKey(e => e.PESSOA_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pessoa>()
                .HasMany(e => e.funcionario)
                .WithRequired(e => e.pessoa)
                .HasForeignKey(e => e.PESSOA_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pessoa>()
                .HasMany(e => e.morador)
                .WithRequired(e => e.pessoa)
                .HasForeignKey(e => e.PESSOA_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pessoa>()
                .HasMany(e => e.proprietario)
                .WithRequired(e => e.pessoa)
                .HasForeignKey(e => e.PESSOA_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<relacao_morador>()
                .Property(e => e.GRAU_PARENTESCO)
                .IsUnicode(false);

            modelBuilder.Entity<relacao_morador>()
                .Property(e => e.DT_NASC)
                .IsUnicode(false);

            modelBuilder.Entity<relacao_morador>()
                .Property(e => e.CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<reserva>()
                .Property(e => e.DESCRICAO_RESERVA)
                .IsUnicode(false);

            modelBuilder.Entity<tipo_feedbacks>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<tipo_feedbacks>()
                .HasMany(e => e.feedbacks)
                .WithRequired(e => e.tipo_feedbacks)
                .HasForeignKey(e => e.TIPO_FEEDBACKS_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tipo_morador>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<tipo_morador>()
                .HasMany(e => e.morador)
                .WithRequired(e => e.tipo_morador)
                .HasForeignKey(e => e.TIPO_MORADOR_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tipo_unidade>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<tipo_unidade>()
                .Property(e => e.ANDAR)
                .IsUnicode(false);

            modelBuilder.Entity<tipo_unidade>()
                .HasMany(e => e.unidade)
                .WithRequired(e => e.tipo_unidade)
                .HasForeignKey(e => e.TIPO_UNIDADE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<unidade>()
                .HasMany(e => e.proprietario)
                .WithRequired(e => e.unidade)
                .HasForeignKey(e => e.APARTAMENTO_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<unidade>()
                .HasMany(e => e.unidade_morador)
                .WithRequired(e => e.unidade)
                .HasForeignKey(e => e.UNIDADE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<veiculo>()
                .Property(e => e.MARCA)
                .IsUnicode(false);

            modelBuilder.Entity<veiculo>()
                .Property(e => e.MODELO)
                .IsUnicode(false);

            modelBuilder.Entity<veiculo>()
                .Property(e => e.COR)
                .IsUnicode(false);

            modelBuilder.Entity<veiculo>()
                .Property(e => e.N_PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<visita>()
                .Property(e => e.NOME)
                .IsUnicode(false);
        }
    }
}
