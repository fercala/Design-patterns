using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class CSistemaSonido : IComponent
    {
        private IComponent _component;
        public CSistemaSonido(IComponent component)
        {
            _component = component;
        }

        public override string ToString()
        {
            return "Radio 350XZ+\r\n" + _component.ToString();
        }
        public double Costo()
        {
            return _component.Costo() + 3500;
        }

        public string Funciona()
        {
            return _component.Funciona() + ", Enciendo el radio";
        }
    }
}
