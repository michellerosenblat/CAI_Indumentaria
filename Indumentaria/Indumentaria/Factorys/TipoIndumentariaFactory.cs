using ModeloIndumentaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ModeloIndumentaria.Excepciones;

namespace Indumentaria.Factorys
{
    public static class TipoIndumentariaFactory
    {
        private static List<TipoIndumentaria> listaTipoIndumentarias;

        static TipoIndumentariaFactory()
        {
            listaTipoIndumentarias = new List<TipoIndumentaria>();
            listaTipoIndumentarias.Add(new IndumentariaCasual("China", 50, 1));
            listaTipoIndumentarias.Add(new IndumentariaDeportiva("Japón", 30, 2));
            listaTipoIndumentarias.Add(new IndumentariaFormal("Pakistan", 100, 3));
        }
        public static List <TipoIndumentaria> GetListaTipoIndumentaria ()
        {
            return listaTipoIndumentarias;
        }

        public static TipoIndumentaria GetTipoIndumentaria (int codigo)
        {
            TipoIndumentaria tipoIndumentariaADevolver = listaTipoIndumentarias.Find(tp => tp.Codigo == codigo);
            if (tipoIndumentariaADevolver is null)
            {
                throw new NoExisteTipoCategoriaException();
            }
            else
                return tipoIndumentariaADevolver;
            }

        }

    }
