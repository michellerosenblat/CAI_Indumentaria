using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloIndumentaria;
using ModeloIndumentaria.Excepciones;
using ModeloIndumentaria.Entidades;
using Indumentaria.Factorys;
using Indumentaria.Validaciones;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Indumentaria
{
    class Program
    {
    
        static void Main(string[] args)
        {
            int opcionMenu = 0 ;
            TiendaRopa tienda = new TiendaRopa();
        int codTipoIndumentaria;
        double precio;
        string talle;
        char camisaOPantalon;
            string tipoManga;
            string material;
            bool tieneEstampa;
            bool tieneBolsillos;
            int codIndumentaria;
            int cantidad;
            int codCliente;
            bool ingresarOtraPrenda;
        TipoIndumentaria tipoIndumentaria;
            do
            {
            try {
                    DesplegarMenu();
                    opcionMenu = Validacion.PedirInt("opcion de menú");
               switch (opcionMenu)
                    { 
                    case 1:
                        try {
                                ListarIndumentariaDe(tienda);
                        }
                        catch (NoHayPrendasCargadasException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 2:
                        // Agregar indumentaria
                        try
                        {
                            ListarTipoIndumentaria();
                            codTipoIndumentaria = Validacion.PedirInt("codigo de tipo de indumentaria");
                            tipoIndumentaria = TipoIndumentariaFactory.GetTipoIndumentaria(codTipoIndumentaria);
                            precio = Validacion.PedirDouble("precio de la indumentaria");
                            talle = Validacion.PedirTalle();
                            camisaOPantalon = Validacion.PedirCamisaOPantalon();
                                switch (camisaOPantalon)
                                {
                                    case 'C':
                                        tieneEstampa = Validacion.PedirSON("si tiene estampa ingrese S, caso contrario N");
                                        tipoManga = Validacion.PedirString("tipo de manga");
                                        tienda.AgregarCamisa(tipoIndumentaria, precio, talle, tieneEstampa, tipoManga);
                                        break;
                                    case 'P':
                                        tieneBolsillos = Validacion.PedirSON("si tiene bolsillos ingrese S, caso contrario N");
                                        material = Validacion.PedirString("material");
                                        tienda.AgregarPantalon(tipoIndumentaria, precio, talle, tieneBolsillos, material);
                                        break;
                                    default:
                                        break;
                                }
                                
                        }
                            

                        catch (NoExisteTipoCategoriaException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                        case 5:
                            //Ingresar orden
                            try {
                                List<VentaItem> ventaItems = new List<VentaItem>();
                            ListarIndumentariaDe(tienda);
                            codCliente = Validacion.PedirInt("codigo del cliente");
                                do
                                {
                                    codIndumentaria = Validacion.PedirInt("codigo de la indumentaria a comprar");
                                    IndumentariaEnt ind = tienda.ExistePrenda(codIndumentaria);
                                    cantidad = Validacion.PedirInt("cantidad del producto");
                                    ventaItems.Add(new VentaItem(ind, cantidad));
                                    ingresarOtraPrenda = Validacion.PedirSON("S para agregar otra prenda a la venta, N para terminar");
                                }
                                while (ingresarOtraPrenda);
                                tienda.IngresarOrden(ventaItems, codCliente);
                            }
                            catch (NoHayPrendasCargadasException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                    }
                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            }
            while (opcionMenu != 10);
              
        }
            static void DesplegarMenu ()
            {
                Console.WriteLine("Ingrese 1 para listar indumentarias");
                Console.WriteLine("Ingrese 2 para agregar indumentarias");
                 Console.WriteLine("Ingrese 3 para modificar indumentarias");

        }
        static void ListarIndumentariaDe(TiendaRopa tienda)
        {
            List<ModeloIndumentaria.Entidades.IndumentariaEnt> listaIndumentaria = tienda.Listar();
            foreach (ModeloIndumentaria.Entidades.IndumentariaEnt ind in listaIndumentaria)
            {
                Console.WriteLine(ind.GetDetalle());
            }
        }
        static void ListarTipoIndumentaria()
        {
            List<TipoIndumentaria> listado = TipoIndumentariaFactory.GetListaTipoIndumentaria();
            foreach (TipoIndumentaria tp in listado)
            {
                Console.WriteLine(tp.ToString());
            }
        }
    }
}
