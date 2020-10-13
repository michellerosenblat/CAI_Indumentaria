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
        public Venta (List <VentaItem> items, Cliente cliente, int estado, int codigo)
        {
            this.items = items;
            this.cliente = cliente;
            this.estado = estado;
            this.codigo = codigo;
        }
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }
    }
}
