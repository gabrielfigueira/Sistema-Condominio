namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.usuario")]
    public partial class usuario
    {
        public int ID { get; set; }

        [Column("USUARIO")]
        [Required]
        [StringLength(45)]
        public string USUARIO1 { get; set; }

        [Required]
        [StringLength(45)]
        public string SENHA { get; set; }

        public int PESSOA_ID { get; set; }

        public virtual pessoa pessoa { get; set; }
    }
}
