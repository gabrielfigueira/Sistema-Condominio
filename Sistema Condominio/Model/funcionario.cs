namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.funcionario")]
    public partial class funcionario
    {
        public int ID { get; set; }

        public int PESSOA_ID { get; set; }

        [StringLength(255)]
        public string ATIVIDADE_FUNCIONARIO { get; set; }

        public virtual pessoa pessoa { get; set; }
    }
}
