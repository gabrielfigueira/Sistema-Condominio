namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.feedbacks")]
    public partial class feedbacks
    {
        public int ID { get; set; }

        public int MORADOR_ID { get; set; }

        [StringLength(60)]
        public string TIPO_FEEDBACK { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string DESCRICAO { get; set; }

        public virtual morador morador { get; set; }
    }
}
