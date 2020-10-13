using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloIndumentaria.Entidades
{
    public abstract class IndumentariaEnt
    {
        protected TipoIndumentaria tipo;
        protected int codigo;
        protected int stock;
        protected double precio;
        protected string talle;

        public IndumentariaEnt (TipoIndumentaria tipo, double precio, string talle, int codigo)
        {
            this.tipo = tipo;
            this.stock = 3;
            this.precio = precio;
            this.talle = talle;
            this.codigo = codigo;
            
        }
        public abstract string GetDetalle();
        public override string ToString()
        {
            return GetDetalle();
        }
        public override bool Equals(object obj)
        {
            return (obj != null && obj is IndumentariaEnt && this.codigo == ((IndumentariaEnt)obj).codigo );
        }

        public TipoIndumentaria Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                this.stock = value;
            }
        }
        public double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
        public string Talle
        {
            get
            {
                return this.talle;
            }
            set
            {
                this.talle = value;
            }
        }
    }
}
