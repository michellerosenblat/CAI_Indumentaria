﻿using ModeloIndumentaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Factorys
{
    static class TipoIndumentariaFactory
    {
        private static List<TipoIndumentaria> listaTipoIndumentarias;

        static TipoIndumentariaFactory()
        {
            listaTipoIndumentarias = new List<TipoIndumentaria>();
            listaTipoIndumentarias.Add(new IndumentariaCasual("China", 50));
            listaTipoIndumentarias.Add(new IndumentariaDeportiva("Japón", 30));
            listaTipoIndumentarias.Add(new IndumentariaFormal("Pakistan", 100));
        }
        public static List <TipoIndumentaria> GetListaTipoIndumentaria ()
        {
            return listaTipoIndumentarias;
        }

        public static TipoIndumentaria GetTipoIndumentaria (int codigo)
        {
            switch (codigo) { 
                case 1:
                return listaTipoIndumentarias.Find(tp => tp.GetType()== (IndumentariaCasual);
                 break;
                case 2:
                    return listaTipoIndumentarias.Find(tp => tp.GetType() == IndumentariaDeportiva);
                    break;
                case 3:
                    return listaTipoIndumentarias.Find(tp => tp.GetType() == IndumentariaFormal);
                    break;
            }

        }

    }
}
