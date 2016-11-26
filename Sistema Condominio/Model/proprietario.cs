namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.proprietario")]
    public partial class proprietario
    {
        [Browsable(false)]
        public int ID { get; set; }

        [Browsable(false)]
        public int APARTAMENTO_ID { get; set; }

        [Browsable(false)]
        public int PESSOA_ID { get; set; }

        [Browsable(false)]
        [ForeignKey("PESSOA_ID")]
        public virtual pessoa pessoa { get; set; }

        [Browsable(false)]
        [ForeignKey("UNIDADE_ID")]
        public virtual unidade unidade { get; set; }

        //Ordem das colunas para buscar na lista
        [NotMapped]
        [DisplayName("Nome")]
        public string nome { get { return pessoa.NOME; } }

        [NotMapped]
        [DisplayName("Celular")]
        public string celular { get { return pessoa.CELULAR; } }

        [NotMapped]
        [DisplayName("CPF")]
        public string cpf { get { return pessoa.CPF; } }

 
        [NotMapped]
        [DisplayName("Tipo de Imóvel")]
        public string tipoImovel { get { return unidade.grupoUnidade.DESCRICAO; } }

        [NotMapped]
        [DisplayName("Observações")]
        public string descricao { get { return unidade.tipoUnidade.DESCRICAO; } }


    }
}
