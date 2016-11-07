namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.tipo_unidade")]
    public partial class tipo_unidade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipo_unidade()
        {
            unidade = new HashSet<unidade>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        public int QNTD_COMODO { get; set; }

        [StringLength(45)]
        public string ANDAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<unidade> unidade { get; set; }
    }
}
