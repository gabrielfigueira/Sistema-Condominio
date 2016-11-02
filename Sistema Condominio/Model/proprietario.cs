namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.proprietario")]
    public partial class proprietario
    {
        public int ID { get; set; }

        public int APARTAMENTO_ID { get; set; }

        public int PESSOA_ID { get; set; }

        public virtual pessoa pessoa { get; set; }

        public virtual unidade unidade { get; set; }
    }
}
