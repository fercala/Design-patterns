using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class CSuspension : IComponent
    {
        private IComponent _component;

        public CSuspension(IComponent compoenent)
        {
            _component = compoenent;
        }
        public override string ToString()
        {
            return "Suspension de alto desempeño\r\n" + _component.ToString();
        }
        public double Costo()
        {
            return _component.Costo() + 63850;
        }

        public string Funciona()
        {
            return _component.Funciona() + ", Elevando suspension";

        }
        
    }
}
