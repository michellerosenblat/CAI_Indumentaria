﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloIndumentaria.Entidades
{
    public class IndumentariaCasual : TipoIndumentaria
    {
        public IndumentariaCasual(string origen, double porcentajeAlgodon) : base(origen, porcentajeAlgodon) { }
        public override string ToString()
        {
            return base.ToString() + "Indumentaria casual";
        }
    }
}
