using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloIndumentaria;
using ModeloIndumentaria.Excepciones;
using ModeloIndumentaria.Entidades;

namespace Indumentaria

    class Program
    {
        static void Main(string[] args)
        {
            int opcionMenu = 0 ;
            TiendaRopa tienda = new TiendaRopa();
        double precio;
        char talle;
        TipoIndumentaria tipoIndumentaria;
            do
            {
            try { 
               switch (opcionMenu)
                {
                    case 1:
                        try { 
                        tienda.Listar();
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
                            
                        }
                        catch ()

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
            List<ModeloIndumentaria.Entidades.Indumentaria> listaIndumentaria = tienda.Listar();
            foreach (ModeloIndumentaria.Entidades.Indumentaria ind in listaIndumentaria)
            {
                Console.WriteLine(ind.GetDetalle());
            }
        }
    }
}
