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

        public int ATIVIDADE_ID { get; set; }

        public int PESSOA_ID { get; set; }

        public virtual atividade atividade { get; set; }

        public virtual pessoa pessoa { get; set; }
    }
}
