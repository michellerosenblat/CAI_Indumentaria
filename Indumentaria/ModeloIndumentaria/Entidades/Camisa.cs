using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloIndumentaria.Entidades
{
    public class Camisa : Indumentaria
    {
        private bool tieneEstampado;
        private string tipoManga;

        public Camisa (TipoIndumentaria tipo, double precio, char talle, bool tieneEstampado, string tipoManga) : base (tipo, precio, talle)
        {
            this.tieneEstampado = tieneEstampado;
            this.tipoManga = tipoManga;
        }
        public override string GetDetalle()
        {
            if (tieneEstampado)
            {
                return "Camisa con estampa y con tipo de manga " + tipoManga;
            }
            return "Camisa sin estampa y con tipo de manga " + tipoManga;
        }

        public bool TieneEstampado
        {
            get
            {
                return tieneEstampado;
            }
            set
            {
                tieneEstampado = value;
            }
        }
        public string TipoManga
        {
            get
            {
                return tipoManga;
            }
            set
            {
                tipoManga = value;
            }
        }
    }
}
