using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloIndumentaria.Excepciones
{
    public class NoExisteClienteException : Exception
    {
        public NoExisteClienteException () : base ("No existe cliente") { }
    }
}
