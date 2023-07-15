using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1Herencia
{
    public class Motocicleta : Vehiculo
    {
        public int CantidadPatas {get; set;}

        public string DejarlaQuieta()
        {
            return $"Dejar la moto quieta con : {CantidadPatas}";
        }
    }
}
