namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.morador")]
    public partial class morador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public morador()
        {
            enc_corresp = new HashSet<enc_corresp>();
            feedbacks = new HashSet<feedbacks>();
            relacao_morador = new HashSet<relacao_morador>();
            reserva = new HashSet<reserva>();
            unidade_morador = new HashSet<unidade_morador>();
            visita = new HashSet<visita>();
            veiculo = new HashSet<veiculo>();
            
        }

        public int ID { get; set; }

        [Browsable(false)]
        public int PESSOA_ID { get; set; }

        [DisplayName("Tipo Morador")]
        [StringLength(60)]
        public string TIPO_MORADOR { get; set; }

        [DisplayName("Data Inicio")]
        [Column(TypeName = "date")]
        public DateTime DATA_INI { get; set; }

        [DisplayName("Data Fim")]
        [Column(TypeName = "date")]
        public DateTime? DATA_FIM { get; set; }

        [Browsable(false)] // Data Annotation para não mostrar na datagrid
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<enc_corresp> enc_corresp { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<feedbacks> feedbacks { get; set; }

        
        [Browsable(false)]
        [ForeignKey("PESSOA_ID")]
        public virtual pessoa pessoa { get; set; }

        [NotMapped]
        [DisplayName("Nome")] // Definindo nome para visualização no DataGrid
        public string Morador_nome { get { return pessoa.NOME; } }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<relacao_morador> relacao_morador { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reserva> reserva { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<unidade_morador> unidade_morador { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<visita> visita { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<veiculo> veiculo { get; set; }
    }
}
