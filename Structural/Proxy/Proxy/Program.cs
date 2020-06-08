using System;
using System.Security.Cryptography.X509Certificates;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {

            // No podemos acceder a la clase
            //CProxy.CCocina miCocina = new Cproxy.Ccocina
            Console.WriteLine("---------Proxy Sensillo----------");

            CProxy.ISujeto miProxySensillo = new CProxy.ProxySensillo();
            miProxySensillo.Peticion(1);
            Console.WriteLine("---------");
            miProxySensillo.Peticion(2);

            Console.WriteLine("---------Proxy Seguro----------");
            CProxy.ISujeto miProxySeguro = new CProxy.ProxySeguro();
            miProxySeguro.Peticion(1);
            Console.WriteLine("---------");
            miProxySeguro.Peticion(2);
            Console.WriteLine("---------");

        }
    }
}
