using System;
using System.ComponentModel.DataAnnotations.Schema;
using TralhoGumo2;

namespace TrabalhoGuisso
{
    [Table("tbl_usuario")]
    public class Usuario
    {
        public UInt64 Id { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Gmail { get; set; }
        public Credencial Credencial { get; set; } = new Credencial();
        public override string ToString()
        {
            return Nome;
        }
    }
}