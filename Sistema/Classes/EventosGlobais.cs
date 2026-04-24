using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TralhoGumo2.Forms
{
    public static class EventosGlobais
    {
        public static event Action ClientesAtualizados;
        public static event Action ProdutosAtualizados;

        public static void OnClientesAtualizados()
            => ClientesAtualizados?.Invoke();

        public static void OnProdutosAtualizados()
            => ProdutosAtualizados?.Invoke();
    }

}
