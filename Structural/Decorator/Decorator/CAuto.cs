using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{

    public class CAuto : IComponent
    {
        private string _modelo;
        private string _caracterisiticas;
        public double _costo;

        public CAuto(string modelo, string carcteristicas, double costo)
        {
            this._modelo = modelo;
            this._caracterisiticas = carcteristicas;
            this._costo = costo;
        }
        public void Puertas(bool estado)
        {
            if (estado)
            {
                Console.WriteLine("Puerta cerrada");
            }
            else
            {
                Console.WriteLine("Puerta abierta");
            }
        }

        public override string ToString()
        {
            return string.Format("Modelo {0}. {1} \r\n", _modelo, _caracterisiticas);
        }

        public double Costo()
        {
            return _costo;
        }

        public string Funciona()
        {
            return "Encendi el motor";
        }
    }
}
