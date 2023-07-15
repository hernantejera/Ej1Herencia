using System.Reflection.PortableExecutable;

namespace Ej1Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche = new Coche()
            {
                CantidadPuertas = 5,
                Marca = "Renault",
                Modelo = "Clio",
            };
            Motocicleta motocicleta = new Motocicleta()
            {
                CantidadPatas = 1,
                Marca = "Honda",
                Modelo = "Tornado",
            };
            Console.WriteLine($"El coche tiene {coche.CantidadPuertas} " +
                $"puertas , su marca es {coche.Marca} y su modelo es {coche.Modelo}");
            Console.WriteLine($"Para limpiar el parabrisas {coche.LimpiaParabrisas()}");

            Console.WriteLine($"La motocicleta tiene {motocicleta.CantidadPatas}" +
                $" patas , su marca es {motocicleta.Marca} y su modelo es {motocicleta.Modelo}");
            Console.WriteLine($"{motocicleta.DejarlaQuieta()}");
        }
    }
}