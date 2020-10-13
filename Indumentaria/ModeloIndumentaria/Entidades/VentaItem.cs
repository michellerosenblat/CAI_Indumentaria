using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloIndumentaria.Entidades
{
    public class VentaItem
    {
        private IndumentariaEnt prenda;
        private int cantidad;

        public VentaItem (IndumentariaEnt prenda, int cantidad)
        {
            this.prenda = prenda;
            this.cantidad = cantidad;
        }
        public double GetTotal()
        {
            return prenda.Precio * cantidad;
        }
        public IndumentariaEnt Prenda
        {
            get
            {
                return this.prenda;
            }
            set
            {
                this.prenda = value;
            }
        }
        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }
    }
}
