﻿using EJEMPLO_CLASE_2.CLASE.CLASE_BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO_CLASE_2.CLASE.CLASE_HIJO
{
    internal class Nintendo : ClsConsole
    {
        public bool EsPortatil { get; set; } 

        public string MostrarDetallesNintendo()
        {
            MostrarDetalles();
            return $"Es portatil: {EsPortatil}";
        }
    }
     

}