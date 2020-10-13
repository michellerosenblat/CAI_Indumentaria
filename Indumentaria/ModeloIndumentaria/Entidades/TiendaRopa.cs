using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ModeloIndumentaria.Excepciones;
using ModeloIndumentaria;
using ModeloIndumentaria.Factories;

namespace ModeloIndumentaria.Entidades
{
    public class TiendaRopa
    {
        private List<IndumentariaEnt> inventario;
        private List<Venta> ventas;
        private int ultimoCodigo;
        public TiendaRopa()
        {
            inventario = new List<IndumentariaEnt>();
            ventas = new List<Venta>();
            ultimoCodigo = 0;
        }
        private int GetProximoCodigo()
        {
            return ultimoCodigo + 1;
        }
        private int GetProximoCodVenta()
        { 
                if (ventas.Any())
                {
                    return ventas.Max(a => a.Codigo)+1;
                }
                else
                    return 1;
            }
        public void Agregar(IndumentariaEnt indumentaria)
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
        public void Modificar (IndumentariaEnt indumentaria)
        {

        }
        public void QuitarStockDe (List <VentaItem> ventaItem)
        {
            foreach (VentaItem vt in ventaItem)
            {
                vt.Prenda.Stock -= vt.Cantidad;
            }
        }
        public IndumentariaEnt ExistePrenda(int codIndumentaria)
        {
            IndumentariaEnt ind;
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
        public bool HayStockSuficienteDe (IndumentariaEnt indumentaria, int cantidad)
        {
            return indumentaria.Stock >= cantidad;
        }
        public void IngresarOrden (List <VentaItem> ventaItems, int codCliente)
        {
            Cliente cliente = ClientesFactory.GetCliente(codCliente);
            foreach (VentaItem vt in ventaItems)
            {
                //esto habria que hacerlo en quitarstock?
                if (!HayStockSuficienteDe(vt.Prenda, vt.Cantidad))
                {
                    throw new NoHayStockSuficienteException();
                }
            }
            if (cliente != null)
            { 
                Venta venta = new Venta(ventaItems, cliente, (int)EstadoVenta.Iniciada, GetProximoCodigo());
                
         }
            else
            {
                throw new NoHayStockSuficienteException();
            }
        }
        public List <IndumentariaEnt> Listar()
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
