using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        public TiendaRopa()
        {
            inventario = new List<Indumentaria>();
            ultimoCodigo = 0;
        }
        private int GetProximoCodigo()
        {
            return ultimoCodigo + 1;
        }
        public void Agregar(Indumentaria indumentaria)
        {
            inventario.Add (indumentaria);
        }
        public void AgregarCamisa (TipoIndumentaria tipo, double precio, string talle, bool tieneEstampa, string tipoManga)
        {
            ultimoCodigo = GetProximoCodigo();
           Agregar(new Camisa(tipo, precio, talle, tieneEstampa, tipoManga, ultimoCodigo));

        }
        public void AgregarPantalon (TipoIndumentaria tipo, double precio, string talle, bool tieneBolsillos, string material)
        {
            ultimoCodigo = GetProximoCodigo();
            Agregar(new Pantalon(tipo, precio, talle, tieneBolsillos, material, ultimoCodigo));
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

        public Indumentaria ExistePrenda(int codIndumentaria)
        {
            Indumentaria ind;
            if (inventario is null)
            {
                throw new NoHayPrendasCargadasException();
            }
            else
            {
                ind = inventario.Find(i => i.Codigo == codIndumentaria);
            }
            if (ind is null)
            {
                throw new NoHayPrendasCargadasException(codIndumentaria);
            }
            else
                return ind;
        }
        public bool HayStockSuficienteDe (Indumentaria indumentaria, int cantidad)
        {
            return indumentaria.Stock >= cantidad;

        }
        public void IngresarOrden (int codIndumentaria,  int cantidad, int codCliente)
        {
            Indumentaria ind = ExistePrenda(codIndumentaria);
            if (HayStockSuficienteDe (ind, cantidad))
            {

            }
            else
            {
                throw new NoHayStockSuficienteException();
            }
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
