namespace Sistema_Condominio.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemacondominio.funcionario")]
    public partial class funcionario
    {

        [Browsable(false)]
        public int ID { get; set; }

        [Browsable(false)]
        public int PESSOA_ID { get; set; }


        //[Browsable(false)]
        //public virtual pessoa pessoa { get; set; }


        [Browsable(false)]
        [ForeignKey("PESSOA_ID")]
        public virtual pessoa pessoa { get; set; }

        //Dados a serem listados nos dataGrid

        [NotMapped]
        [DisplayName("Nome")]
        public string Funcionario_nome { get { return pessoa.NOME; } }

        [NotMapped]
        [DisplayName("Email")]
        public string Funcionario_email { get { return pessoa.EMAIL; } }

        [NotMapped]
        [DisplayName("Email")]
        public string Funcionario_celular { get { return pessoa.CELULAR; } }

        [DisplayName("Atividades")]
        [StringLength(255)]
        public string ATIVIDADE_FUNCIONARIO { get; set; }
    }
}
