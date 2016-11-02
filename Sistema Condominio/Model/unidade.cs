namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.unidade")]
    public partial class unidade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public unidade()
        {
            proprietario = new HashSet<proprietario>();
            unidade_morador = new HashSet<unidade_morador>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int UNIDADES_id { get; set; }

        public int TIPO_UNIDADE_ID { get; set; }

        public bool? ATIVO { get; set; }

        public virtual grupo_unidade grupo_unidade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<proprietario> proprietario { get; set; }

        public virtual tipo_unidade tipo_unidade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<unidade_morador> unidade_morador { get; set; }
    }
}
