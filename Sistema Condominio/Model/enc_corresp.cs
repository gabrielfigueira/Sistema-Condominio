namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.enc_corresp")]
    public partial class enc_corresp
    {
        public int ID { get; set; }

        public int MORADOR_ID { get; set; }

        [StringLength(45)]
        public string NOME { get; set; }

        [Required]
        [StringLength(45)]
        public string TIPO { get; set; }

        public bool? AGUARDO { get; set; }

        public virtual morador morador { get; set; }
    }
}
