using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloIndumentaria.Entidades;
using ModeloIndumentaria.Excepciones;
namespace ModeloIndumentaria.Factories
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
            public static List<Cliente> GetListaClientes()
            {
                return listaClientes;
            }
            public static Cliente GetCliente(int codCliente)
            {
                Cliente cliente = listaClientes.Find(c => c.Equals(codCliente));
                if (cliente is null)
                {
                    throw new NoExisteClienteException();
                }
                else
                {
                    return cliente;
                }
            }
        
    }
}
