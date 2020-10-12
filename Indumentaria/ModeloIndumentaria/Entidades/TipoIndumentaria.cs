using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloIndumentaria.Entidades
{
    public class TipoIndumentaria
    {
        protected string origen;
        protected double porcentajeAlgodon;

        public TipoIndumentaria (string origen, double porcentajeAlgodon)
        {
            this.origen = origen;
            this.porcentajeAlgodon = porcentajeAlgodon;
        }
        public string Origen
        {
            get
            {
                return this.origen;
            }
            set
            {
                this.origen = value;
            }
        }

        public double PorcentajeAlgodon
        {
            get
            {
                return this.porcentajeAlgodon;
            }
            set
            {
                this.porcentajeAlgodon = value;
            }
        }
    }
}
