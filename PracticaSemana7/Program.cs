using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSemana7
{
        class Program
        {
            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("Elija la figura que desea operar:");
                    Console.WriteLine("1. Rectángulo");
                    Console.WriteLine("2. Círculo");
                    Console.WriteLine("3. Triángulo");
                    Console.WriteLine("4. Salir");

                    //Profe Tanaka el ToLower convierte una serie a caracteres en minúsculas para que en caso de que lo ponga en mayusculas ,no lo saque del programa
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion == 4)
                    {
                        Console.WriteLine("Gracias por usar el programa. ¡Hasta luego!");
                        break;
                    }

                    //Tanaka el double se encarga de poner una cantidad de decimales superior al float 
                    double area = 0;

                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingrese la base del rectángulo: ");
                            double baseRectangulo = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese la altura del rectángulo: ");
                            double alturaRectangulo = Convert.ToDouble(Console.ReadLine());
                            Rectangulo rectangulo = new Rectangulo(baseRectangulo, alturaRectangulo);
                            area = rectangulo.CalcularArea();
                            break;
                        case 2:
                            Console.Write("Ingrese el radio del círculo: ");
                            double radioCirculo = Convert.ToDouble(Console.ReadLine());
                            Circulo circulo = new Circulo(radioCirculo);
                            area = circulo.CalcularArea();
                            break;
                        case 3:
                            Console.Write("Ingrese la base del triángulo: ");
                            double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese la altura del triángulo: ");
                            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                            Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo);
                            area = triangulo.CalcularArea();
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                            continue;
                    }

                    Console.WriteLine($"El área de la figura es: {area}");
                }
            }
        }
    
}