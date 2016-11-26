namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.reserva")]
    public partial class reserva
    {
        [Browsable(false)]
        public int ID { get; set; }

        [Browsable(false)]
        public int MORADOR_ID { get; set; }

        [NotMapped]
        [DisplayName("Nome")]
        public string nome { get { return morador.pessoa.NOME; } }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string DESCRICAO_RESERVA { get; set; }

        [StringLength(60)]
        public string LOCAL_RESERVA { get; set; }

        public bool? PERMITIR { get; set; }

        [Browsable(false)]
        [ForeignKey("MORADOR_ID")]
        public virtual morador morador { get; set; }


    }
}
