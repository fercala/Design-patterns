using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class CProxy
    {
        public interface ISujeto
        {
            void Peticion(int opcion);
        }
        public class ProxySensillo : ISujeto
        {
            private CCocina cocina;

            public void Peticion(int opcion)
            {
                if (cocina == null)
                {
                    Console.WriteLine("Activando el sujeto");
                    cocina = new CCocina();
                }
                switch (opcion)
                {
                    case 1:
                        cocina.RecetaSecreta();
                        break;
                    case 2:
                        cocina.Cocinar(5);
                        break;

                }

            }
        }

        public class ProxySeguro : ISujeto
        {
            private CCocina cocina;

            public void Peticion(int opcion)
            {
                string password;
                Console.WriteLine("Dame el password");
                password = Console.ReadLine();

                if (password == "abc123")
                {
                    if (cocina == null)
                    {
                        Console.WriteLine("Activando el sujeto");
                        cocina = new CCocina();

                    }
                    switch (opcion)
                    {
                        case 1:
                            cocina.RecetaSecreta();
                            break;
                        case 2:
                            cocina.Cocinar(5);
                            break;

                    }
                }
            }
        }
    }
}
