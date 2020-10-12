using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Indumentaria.Factorys;
using ModeloIndumentaria.Entidades;

namespace Indumentaria.Validaciones
{
    public static class Validacion
    {
        public static string PedirString (string mensaje)
        {
            string input;
            do
            {
                Console.WriteLine("Ingrese " + mensaje);
                input = Console.ReadLine();
            }
            while (input == "");
            return input;
        }
        public static double PedirDouble(string mensaje)
        {
            string input;
            double num;
            do
            {
                Console.WriteLine("Ingrese " + mensaje);
                input = Console.ReadLine();
            }
            while (!double.TryParse(input, out num));
            return num;
        }

        public static int PedirInt(string mensaje)
        {
            string input;
            int num;
            do
            {
                Console.WriteLine("Ingrese " + mensaje);
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out num));
            return num;
        }

        public static char PedirTalle ()
        {
            char talle;
            string input;
            do
            {
                Console.WriteLine("Ingrese talle (S, M, L, XL)");
                input = Console.ReadLine();
            }
            while (!char.TryParse(input, out talle) && input != "S" && input != "M" && input != "L" && input != "XL");
            return talle;
        }

            public static void ListarTiposIndumentaria()
        {
            List<TipoIndumentaria> listaTipoIndumentaria = TipoIndumentariaFactory.GetListaTipoIndumentaria();
            foreach (TipoIndumentaria ti in listaTipoIndumentaria)
            {
                Console.WriteLine(ti.ToString());
            }
        }
    }
}
