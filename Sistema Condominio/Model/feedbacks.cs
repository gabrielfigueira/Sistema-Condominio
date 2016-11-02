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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int TIPO_FEEDBACKS_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string DESCRICAO { get; set; }

        public int MORADOR_ID { get; set; }

        public virtual morador morador { get; set; }

        public virtual tipo_feedbacks tipo_feedbacks { get; set; }
    }
}
