using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSemana7
{
        class Rectangulo
        {
            private double baseRectangulo;
            private double alturaRectangulo;

            public Rectangulo(double baseRectangulo, double alturaRectangulo)
            {
                this.baseRectangulo = baseRectangulo;
                this.alturaRectangulo = alturaRectangulo;
            }

            public double CalcularArea()
            {
                return baseRectangulo * alturaRectangulo;
            }
        }
}
