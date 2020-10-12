using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloIndumentaria.Entidades
{
    public class Venta
    {
        private List<VentaItem> items;
        private Cliente cliente;
        private int estado;
        private int codigo;

        public double GetTotalPedido()
        {
            double total=0;
            foreach (VentaItem item in items)
            {
                total += item.GetTotal();
            }
            return total;
        }
    }
}
