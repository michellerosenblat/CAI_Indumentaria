using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloIndumentaria.Entidades
{
    public class Camisa : IndumentariaEnt
    {
        private bool tieneEstampado;
        private string tipoManga;

        public Camisa (TipoIndumentaria tipo, double precio, string talle, bool tieneEstampado, string tipoManga, int codigo) : base (tipo, precio, talle, codigo)
        {
            this.tieneEstampado = tieneEstampado;
            this.tipoManga = tipoManga;
        }
        public override string GetDetalle()
        {
            if (tieneEstampado)
            {
                return "Codigo: " +codigo + " camisa con estampa y con tipo de manga " + tipoManga;
            }
            return "Codigo: " + codigo + "Camisa sin estampa y con tipo de manga " + tipoManga;
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
