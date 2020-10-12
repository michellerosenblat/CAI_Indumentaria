using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloIndumentaria.Excepciones;

namespace ModeloIndumentaria.Entidades
{
    public class TiendaRopa
    {
        private List<Indumentaria> inventario;
        private List<Venta> ventas;
        private int ultimoCodigo;
        private int GetProximoCodigo()
        {
            return ultimoCodigo + 1;
        }
        public void Agregar (Indumentaria indumentaria)
        {

        }
        public void Modificar (Indumentaria indumentaria)
        {

        }
        public void Quitar (Indumentaria indumentaria)
        {

        }
        public void IngresarOrden (Venta venta)
        {

        }
        public List <Indumentaria> Listar()
        {
            if (inventario is null)
            {
                throw new NoHayPrendasCargadasException();
            }
            else
            {
                return inventario;
            }
            
        }
        /*public List <Orden> ListarOrden()
        {

        }
        public void DevolverOrden (Orden orden)
        {

        }*/
    }
}
