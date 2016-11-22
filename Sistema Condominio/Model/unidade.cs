namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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
            tipo_unidade = new tipo_unidade();
            grupo_unidade = new grupo_unidade();
        }

        //[Browsable(false)] => Não "aparece na tela"
        [Browsable(false)]
        public int ID { get; set; }

        [Browsable(false)]
        public int TIPO_UNIDADE_ID { get; set; }

        [Browsable(false)]
        public int GRUPO_UNIDADE_ID { get; set; }

        [Browsable(false)]
        public virtual grupo_unidade grupo_unidade { get; set; }

        [Browsable(false)]
        public virtual tipo_unidade tipo_unidade { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<proprietario> proprietario { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<unidade_morador> unidade_morador { get; set; }

        [Browsable(false)]
        [ForeignKey("GRUPO_UNIDADE_ID")]
        public virtual grupo_unidade grupoUnidade { get; set; }

        [Browsable(false)]
        [ForeignKey("TIPO_UNIDADE_ID")]
        public virtual tipo_unidade tipoUnidade { get; set; }

        //Ordem das colunas para buscar na lista
        [NotMapped]
        [DisplayName("Tipo de Imóvel")]
        public string tipoImovel { get { return grupoUnidade.DESCRICAO; } }

        [NotMapped]
        [DisplayName("Quantidade de Comodos")]
        public int quantComodo { get { return tipoUnidade.QNTD_COMODO; } }

        [NotMapped]
        [DisplayName("Quantidade de Apartamento")]
        public int quantApartamento { get { return grupoUnidade.QNT_APARTAMENTO.GetValueOrDefault(); } }

        [NotMapped]
        [DisplayName("Quantidade de Andares")]
        public string quantAndares { get { return tipoUnidade.ANDAR; } }

        public bool? ATIVO { get; set; }

        [NotMapped]
        [DisplayName("Observações")]
        public string descricao { get { return tipoUnidade.DESCRICAO; } }

    }
}
