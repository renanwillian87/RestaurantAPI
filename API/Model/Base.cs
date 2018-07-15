using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public abstract class Base
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Status { get; set; }
    }
}