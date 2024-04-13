using EJEMPLO_CLASE_2.CLASE.CLASE_BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO_CLASE_2.CLASE.CLASE_HIJO
{
    internal class PlayStation : ClsConsole
    {
        public bool EsPortatil { get; set; }

        public string MostrarDetallesPS()
        {
            MostrarDetalles();
            return $"Es Portatil:{EsPortatil}";
        }
    }
}
