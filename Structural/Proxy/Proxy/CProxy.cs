using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    /// <summary>
    /// Haremos uso de anidadmiento adentro de la clase
    /// Esto hace que cualquier clase colocada como privada y anidada
    /// solo sea conocida por Cproxy
    /// </summary>
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
                else
                {
                    Console.WriteLine("Acceso Denegado");
                }
            }
        }

        //Esta es la clase que estamos protegiendo con el proxy
        private class CCocina
        {
            public void RecetaSecreta()
            {
                Console.WriteLine("Pan");
                Console.WriteLine("Aceite de oliva");
                Console.WriteLine("Especias");
                Console.WriteLine("Jamon");
                Console.WriteLine("Queso");
            }
            public void Cocinar(int n)
            {
                Console.WriteLine("Cocinando {0} recestas", n);
            }
        }
    }
}
