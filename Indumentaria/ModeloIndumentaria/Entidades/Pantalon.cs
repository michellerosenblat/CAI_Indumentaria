using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloIndumentaria.Entidades
{
    public class Pantalon : IndumentariaEnt
    {
        private string material;
        private bool tieneBolsillos;
        public Pantalon (TipoIndumentaria tipo, double precio, string talle, bool tieneBolsillos, string material, int codigo) : base (tipo, precio, talle, codigo){
            
                this.material = material;
                this.tieneBolsillos = tieneBolsillos;
            }
        public override string GetDetalle()
        {
            if (tieneBolsillos)
            {
                return "Codigo: " + codigo + "Es un pantalon con bolsilos y material " + material;
            }
            else
            {
                return "Codigo: " + codigo + "Es un pantalon sin bolsillos y material " + material;
            }
           
        }
    }
}
