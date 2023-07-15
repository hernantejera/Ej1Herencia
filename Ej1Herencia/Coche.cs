using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1Herencia
{
    public  class Coche : Vehiculo
    {
        public int CantidadPuertas {get;set;}

        public string LimpiaParabrisas() 
        {
            return "Prendo el limpia parabrisas ";
        }
    }
}
