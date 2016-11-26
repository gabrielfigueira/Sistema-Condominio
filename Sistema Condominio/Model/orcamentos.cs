namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.orcamentos")]
    public partial class orcamentos
    {
        [Browsable(false)]
        public int ID { get; set; }

        [Browsable(false)]
        public int CORPO_ADM_ID { get; set; }

        [Browsable(false)]
        [ForeignKey("TIPO_UNIDADE_ID")]
        public virtual corpo_adm corpo_adm { get; set; }

        [NotMapped]
        [DisplayName("Nome")]
        public string nome { get { return corpo_adm.pessoa.NOME; } }

        [DisplayName("Valor")]
        public double VALOR { get; set; }

        [Required]
        [StringLength(45)]
        [DisplayName("Situação")]
        public string SITUACAO { get; set; }

        [NotMapped]
        [DisplayName("Tipo de Cargo")]
        public string cargo { get { return corpo_adm.cargo_corpo_admin.DESCRICAO; } }

        [Required]
        [StringLength(100)]
        [DisplayName("Descrição")]
        public string DESCRICAO { get; set; }
    }
}
