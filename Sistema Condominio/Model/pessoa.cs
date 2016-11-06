namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.pessoa")]
    public partial class pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pessoa()
        {
            corpo_adm = new HashSet<corpo_adm>();
            funcionario = new HashSet<funcionario>();
            morador = new HashSet<morador>();
            proprietario = new HashSet<proprietario>();
            usuario = new HashSet<usuario>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string NOME { get; set; }

        [Required]
        [StringLength(60)]
        public string CPF { get; set; }

        [Required]
        [StringLength(60)]
        public string RG { get; set; }

        [Required]
        [StringLength(60)]
        public string TELEFONE_RESIDENCIAL { get; set; }

        [Required]
        [StringLength(20)]
        public string CELULAR { get; set; }

        [StringLength(45)]
        public string TEL_COMERC { get; set; }

        [Required]
        [StringLength(45)]
        public string EMAIL { get; set; }

        public bool NECES_ESPECIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<corpo_adm> corpo_adm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<funcionario> funcionario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<morador> morador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<proprietario> proprietario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuario> usuario { get; set; }
    }
}
