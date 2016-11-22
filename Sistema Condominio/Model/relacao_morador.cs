namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.relacao_morador")]
    public partial class relacao_morador
    {
        public int ID { get; set; }


        [DisplayName("Grau de Parentesco")]
        [Required]
        [StringLength(45)]
        public string GRAU_PARENTESCO { get; set; }

        [DisplayName("Data de Nascimento")]
        [Required]
        [StringLength(45)]
        public string DT_NASC { get; set; }

        [DisplayName("Celular")]
        [StringLength(45)]
        public string CELULAR { get; set; }

        [Browsable(false)]
        public int MORADOR_ID { get; set; }

        [Browsable(false)]
        public virtual morador morador { get; set; }
    }
}
