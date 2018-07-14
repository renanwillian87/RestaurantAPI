using System;

namespace Model
{
    public abstract class Base
    {
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Status { get; set; }
    }
}