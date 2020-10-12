using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloIndumentaria.Entidades
{
    public class VentaItem
    {
        private Indumentaria prenda;
        private int cantidad;

        public VentaItem (Indumentaria prenda, int cantidad)
        {
            this.prenda = prenda;
            this.cantidad = cantidad;
        }
        public double GetTotal()
        {
            return prenda.Precio * cantidad;
        }
    }
}
