using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1Herencia
{
    public abstract class Vehiculo
    {
       public string Marca { get; set; }
       public string Modelo { get; set; }
        public string ArrancarMotor() 
        {
            return "Enciendo el motor";
        }


    }
}
