namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.unidade_morador")]
    public partial class unidade_morador
    {
        [Browsable(false)]
        public int ID { get; set; }

        [Browsable(false)]
        public int UNIDADE_ID { get; set; }

        [Browsable(false)]
        public int MORADOR_ID { get; set; }

        [Browsable(false)]
        [ForeignKey("MORADOR_ID")]
        [DisplayName("Morador")]
        public virtual morador morador { get; set; }

        [Browsable(false)]
        [ForeignKey("UNIDADE_ID")]
        [DisplayName("Unidade")]
        public virtual unidade unidade { get; set; }

        [NotMapped]
        [DisplayName("Nome")]
        public string nome { get { return morador. pessoa.NOME; } }

        [NotMapped]
        [DisplayName("CPF")]
        public string cpf { get { return morador.pessoa.CPF; } }

        [NotMapped]
        [DisplayName("Descrição")]
        public string descricao { get { return unidade.tipoUnidade.DESCRICAO; } }

        [NotMapped]
        [DisplayName("Tipo de Imóvel")]
        public string tipoImovel { get { return unidade.grupoUnidade.DESCRICAO; } }
    }
}
