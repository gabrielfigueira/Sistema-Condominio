namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.reserva")]
    public partial class reserva
    {
        public int ID { get; set; }

        public int LOCAL_RESERVA_ID { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string DESCRICAO_RESERVA { get; set; }

        public bool? PERMITIR { get; set; }

        public int MORADOR_ID { get; set; }

        public virtual local_reserva local_reserva { get; set; }

        public virtual morador morador { get; set; }
    }
}
