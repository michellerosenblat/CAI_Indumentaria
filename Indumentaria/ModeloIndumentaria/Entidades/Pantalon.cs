using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloIndumentaria.Entidades
{
    public class Pantalon : Indumentaria
    {
        private string material;
        private bool tieneBolsillos;
        public override string GetDetalle()
        {
            if (tieneBolsillos)
            {
                return "Es un pantalon con bolsilos y material " + material;
            }
            else
            {
                return "Es un pantalon sin bolsillos y material " + material;
            }
           
        }
    }
}
