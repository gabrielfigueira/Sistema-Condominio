namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.veiculo")]
    public partial class veiculo
    {
        public int ID { get; set; }

        [Browsable(false)]
        public int MORADOR_ID { get; set; }

        [Browsable(false)]
        [ForeignKey("MORADOR_ID")]
        [DisplayName("Morador")]
        public virtual morador morador   { get; set; }

        [NotMapped]
        [DisplayName("Nome")]
        public string Morador_nome { get { return morador.pessoa.NOME; } }

        [DisplayName("Marca Veiculo")]
        [Required]
        [StringLength(45)]
        public string MARCA { get; set; }

        [DisplayName("Modelo Veiculo")]
        [Required]
        [StringLength(45)]
        public string MODELO { get; set; }

        [Browsable(false)]
        public int RFID { get; set; }

        [Required]
        [StringLength(45)]
        public string COR { get; set; }

        [DisplayName("Numero Placa")]
        [Required]
        [StringLength(45)]
        public string N_PLACA { get; set; }

        [DisplayName("Vaga Alugada")]
        public int VAGA_ALUGADA { get; set; }

    }
}
