namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.relacao_morador")]
    public partial class relacao_morador
    {
        public int ID { get; set; }

        [Required]
        [StringLength(45)]
        public string GRAU_PARENTESCO { get; set; }

        [Required]
        [StringLength(45)]
        public string DT_NASC { get; set; }

        [StringLength(45)]
        public string CELULAR { get; set; }

        public int MORADOR_ID { get; set; }

        public virtual morador morador { get; set; }
    }
}
