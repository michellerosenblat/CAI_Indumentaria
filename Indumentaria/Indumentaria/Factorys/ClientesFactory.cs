using ModeloIndumentaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Factorys
{
    public static class ClientesFactory
    {
        private static List<Cliente> listaClientes;
        
        static ClientesFactory()
        {
            listaClientes = new List<Cliente>();
            listaClientes.Add(new Cliente("Juan", "Perez", 1));
            listaClientes.Add(new Cliente("Roberto", "Juarez", 2));
            listaClientes.Add(new Cliente("Martina", "Rodriguez", 3));
        }
        public static List <Cliente> GetListaClientes()
        {
            return listaClientes;
        }
    }
}
