using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent miAuto = new CAuto("2018", "4 puertas", 200000);

            Console.WriteLine(miAuto);
            ((CAuto)miAuto).Puertas(true);
            Console.WriteLine("------------");

            miAuto = new CSistemaSonido(miAuto);
            Console.WriteLine("Costo: " + miAuto.Costo());
            Console.WriteLine("Funciona: " + miAuto.Funciona());
            Console.WriteLine(miAuto);
            Console.WriteLine("------------");

            miAuto = new CNitrogeno(miAuto);
            Console.WriteLine("Costo: " + miAuto.Costo());
            Console.WriteLine("Funciona: " + miAuto.Funciona());
            Console.WriteLine(miAuto);
            Console.WriteLine("------------");

            miAuto = new CSuspension(miAuto);
            Console.WriteLine("Costo: " + miAuto.Costo());
            Console.WriteLine("Funciona: " + miAuto.Funciona());
            Console.WriteLine(miAuto);
            Console.WriteLine("------------");


        }
    }
}
