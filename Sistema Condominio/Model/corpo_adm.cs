namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.corpo_adm")]
    public partial class corpo_adm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public corpo_adm()
        {
            orcamentos = new HashSet<orcamentos>();
        }

        public int ID { get; set; }

        public int PESSOA_ID { get; set; }

        public int CARGO_CORPO_ADMIN_id { get; set; }

        public virtual cargo_corpo_admin cargo_corpo_admin { get; set; }

        public virtual pessoa pessoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orcamentos> orcamentos { get; set; }
    }
}
