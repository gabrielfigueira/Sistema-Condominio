namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.visita")]
    public partial class visita
    {
        [Browsable(false)]
        public int ID { get; set; }

        [Browsable(false)]
        public int MORADOR_ID { get; set; }

        [Required]
        [StringLength(45)]
        public string NOME { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATA_ENTRADA { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATA_SAIDA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_PREVISTA { get; set; }

        public virtual morador morador { get; set; }
    }
}
