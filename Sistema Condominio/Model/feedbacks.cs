namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.feedbacks")]
    public partial class feedbacks
    {
        [Browsable(false)]
        public int ID { get; set; }

        [Browsable(false)]
        public int MORADOR_ID { get; set; }

        [NotMapped]
        [DisplayName("Nome")]
        public string nome { get { return morador.pessoa.NOME; } }

        [StringLength(60)]
        public string TIPO_FEEDBACK { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string DESCRICAO { get; set; }

        [Browsable(false)]
        [ForeignKey("MORADOR_ID")]
        public virtual morador morador { get; set; }
    }
}
