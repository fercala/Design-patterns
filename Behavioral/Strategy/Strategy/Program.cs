using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            double x = 0;
            double y = 0;
            double r = 0;
            string option=string.Empty;

            IOperation myOperation = new CSum();
            while (option != "5")
            {
                Console.Clear();
                Console.WriteLine("1 - Suma");
                Console.WriteLine("2 - Resta");
                Console.WriteLine("3 - Multipliacion");
                Console.WriteLine("4 - Division");
                Console.WriteLine("5 - Salir");

                option = Console.ReadLine();
                if (option == "5")
                    break;

                Console.WriteLine("Dame un valor de a:");
                dato = Console.ReadLine();
                x = Convert.ToDouble(dato);

                Console.WriteLine("Dame un valor de b:");
                dato = Console.ReadLine();
                y = Convert.ToDouble(dato);

                switch (option)
                {
                    case "1":
                        myOperation = new CSum();
                        break;
                    case "2":
                        myOperation = new CSub();
                        break;
                    case "3":
                        myOperation = new CMul();
                        break;
                    case "4":
                        myOperation = new CDiv();
                        break;
                    default:
                        Console.Write("Opcion incorrecta!");
                        Console.ReadLine();
                        continue;
                }
                r = myOperation.Operation(x, y);
                Console.WriteLine("El resultado es {0}", r);
                Console.ReadLine();


            }
        }
    }
}
