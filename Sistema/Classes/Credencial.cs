using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using TralhoGumo2;

namespace TrabalhoGuisso
{
    [Table("tbl_credencial")]
    public class Credencial
    {
        public const String SALT = "1FnM6_";
        public Int64 Id { get; set; }
        public String SenhaHash { get; set; }
        [NotMapped]
        public String SenhaTexto { get; set; }
        public Perfil Perfil { get; set; }
        public DateTime UltimoAcesso { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
        public static String ComputeSHA256(string input, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(salt + input));
                return String.Concat(bytes.Select(b => b.ToString("X2")));
            }
        }
    }
}