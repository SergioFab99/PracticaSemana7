using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSemana7
{
    class Circulo
    {
        private double radioCirculo;

        public Circulo(double radioCirculo)
        {
            this.radioCirculo = radioCirculo;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radioCirculo, 2);
        }
    }
}
