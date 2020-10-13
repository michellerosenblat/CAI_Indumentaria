using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloIndumentaria.Excepciones
{
    public class NoHayStockSuficienteException : Exception
    {
        public NoHayStockSuficienteException() : base("No hay stock suficiente") { }
    }
}
