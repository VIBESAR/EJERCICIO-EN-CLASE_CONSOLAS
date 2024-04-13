using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO_CLASE_2.CLASE.CLASE_BASE
{
    internal class ClsConsole
    {
        public string Marca { get; set; }

        public int AnioLanzamiento { get; set; }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Marca: {Marca}, año lanzamiento: {AnioLanzamiento},");
        }
    }
}
