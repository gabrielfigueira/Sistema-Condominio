namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.unidade_morador")]
    public partial class unidade_morador
    {
        public int ID { get; set; }

        public int UNIDADE_ID { get; set; }

        public int MORADOR_ID { get; set; }

        public virtual morador morador { get; set; }

        public virtual unidade unidade { get; set; }
    }
}
