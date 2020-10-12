using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Validaciones
{
    public static class Validacion
    {
        public static string GetString (string mensaje)
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
        public static double GetDouble(string mensaje)
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

        public static int GetInt(string mensaje)
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

        public static char GetTalle ()
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
    }
}
