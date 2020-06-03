using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class CNitrogeno : IComponent
    {
        private IComponent _component;

        public CNitrogeno(IComponent compoenent)
        {
            _component = compoenent;
        }
        public override string ToString()
        {
            return "Sistema de Nitrogeno\r\n" + _component.ToString();
        }
        public double Costo()
        {
            return _component.Costo() + 4500;
        }

        public string Funciona()
        {
            return _component.Funciona() + ", Nitrogeno listo";

        }
        public void UsaN()
        {
            Console.WriteLine("Nitrogeno en uso");
        }
    }
}
