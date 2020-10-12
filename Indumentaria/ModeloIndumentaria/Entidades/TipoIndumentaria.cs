using System;
using System.CodeDom;
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
        protected int codigoTipoIndumentaria;

        public TipoIndumentaria (string origen, double porcentajeAlgodon, int codigoTipoIndumentaria)
        {
            this.origen = origen;
            this.porcentajeAlgodon = porcentajeAlgodon;
            this.codigoTipoIndumentaria = codigoTipoIndumentaria;
        }
        public int Codigo
        {
            get
            {
                return this.Codigo;
            }
            set
            {
                this.Codigo = value;
            }
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
        public override string ToString()
        {
            return "Origen: " + origen + ", porcentaje de algodon: " + porcentajeAlgodon;

        }
    }
}
