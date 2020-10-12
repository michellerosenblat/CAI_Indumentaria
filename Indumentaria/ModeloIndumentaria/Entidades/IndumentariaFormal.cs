using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloIndumentaria.Entidades
{
    public class IndumentariaFormal : TipoIndumentaria
    {
        public IndumentariaFormal (string origen, double porcentajeAlgodon, int codigo) : base (origen, porcentajeAlgodon, codigo) { }

        public override string ToString()
        {
            return  "Indumentaria formal " + base.ToString() ;
        }
    }
}
