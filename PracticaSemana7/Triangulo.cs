using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSemana7
{
        class Triangulo
        {
            private double baseTriangulo;
            private double alturaTriangulo;

            public Triangulo(double baseTriangulo, double alturaTriangulo)
            {
                this.baseTriangulo = baseTriangulo;
                this.alturaTriangulo = alturaTriangulo;
            }

            public double CalcularArea()
            {
                return 0.5 * baseTriangulo * alturaTriangulo;
            }
        }
    }
}