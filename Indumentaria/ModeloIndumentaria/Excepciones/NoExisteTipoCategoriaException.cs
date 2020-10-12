using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloIndumentaria.Excepciones
{
    public class NoExisteTipoCategoriaException : Exception
    {
        public NoExisteTipoCategoriaException() : base("No existe categoria con dicho codigo") { }
    }
}
