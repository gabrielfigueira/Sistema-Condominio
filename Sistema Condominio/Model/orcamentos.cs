namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.orcamentos")]
    public partial class orcamentos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int CORPO_ADM_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        public double VALOR { get; set; }

        [Required]
        [StringLength(45)]
        public string SITUACAO { get; set; }

        public virtual corpo_adm corpo_adm { get; set; }
    }
}
