namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.veiculo")]
    public partial class veiculo
    {
        public int ID { get; set; }

        public int MORADOR_ID { get; set; }

        [Required]
        [StringLength(45)]
        public string MARCA { get; set; }

        [Required]
        [StringLength(45)]
        public string MODELO { get; set; }

        public int RFID { get; set; }

        [Required]
        [StringLength(45)]
        public string COR { get; set; }

        [Required]
        [StringLength(45)]
        public string N_PLACA { get; set; }

        public int VAGA_ALUGADA { get; set; }

        public virtual morador morador { get; set; }
    }
}
