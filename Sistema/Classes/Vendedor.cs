using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoGuisso;

namespace TralhoGumo2
{
    public class Vendedor : Usuario
    {
        public List<Compra> Compras { get; set; } = new List<Compra>();
    }
}
