﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloIndumentaria.Excepciones
{
    public class NoHayPrendasCargadasException : Exception
    {
        public NoHayPrendasCargadasException() : base("No hay prendas cargadas") { }
    }
}
