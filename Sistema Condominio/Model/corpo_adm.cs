namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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

        [Browsable(false)]
        public int ID { get; set; }

        [Browsable(false)]
        public int PESSOA_ID { get; set; }

        [Browsable(false)]
        public int CARGO_CORPO_ADMIN_id { get; set; }

        [Browsable(false)]
        [ForeignKey("CARGO_CORPO_ID")]
        public virtual cargo_corpo_admin cargo_corpo_admin { get; set; }

        [Browsable(false)]
        [ForeignKey("PESSOA_ID")]
        public virtual pessoa pessoa { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orcamentos> orcamentos { get; set; }

        [NotMapped]
        [DisplayName("Nome")]
        public string nome { get { return pessoa.NOME; } }

        [NotMapped]
        [DisplayName("Cargo")]
        public string cargo { get { return cargo_corpo_admin.DESCRICAO; } }
    }
}
