using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al calculador de áreas de figuras geométricas.");
            Console.WriteLine("Seleccione la figura:");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Rectángulo");
            Console.WriteLine("3. Triángulo");
            Console.WriteLine("4. Círculo");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Cuadrado.CalcularArea();
                    break;
                case 2:
                    Rectangulo.CalcularArea();
                    break;
                case 3:
                    Triangulo.CalcularArea();
                    break;
                case 4:
                    Circulo.CalcularArea();
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;

            }
        }
            class Cuadrado
        {
            public static void CalcularArea()
            {
                Console.WriteLine("Ingrese la longitud del lado del cuadrado:");
                double lado = Convert.ToDouble(Console.ReadLine());

                double area = lado * lado;

                Console.WriteLine("El área del cuadrado es: " + area);
            }
        }

        class Rectangulo
        {
            public static void CalcularArea()
            {
                Console.WriteLine("Ingrese la longitud del lado 1 del rectángulo:");
                double lado1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese la longitud del lado 2 del rectángulo:");
                double lado2 = Convert.ToDouble(Console.ReadLine());

                double area = lado1 * lado2;

                Console.WriteLine("El área del rectángulo es: " + area);
            }
        }

        class Triangulo
        {
            public static void CalcularArea()
            {
                Console.WriteLine("Ingrese la base del triángulo:");
                double baseTriangulo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese la altura del triángulo:");
                double altura = Convert.ToDouble(Console.ReadLine());

                double area = (baseTriangulo * altura) / 2;

                Console.WriteLine("El área del triángulo es: " + area);
            }
        }

        class Circulo
        {
            public static void CalcularArea()
            {
                Console.WriteLine("Ingrese el radio del círculo:");
                double radio = Convert.ToDouble(Console.ReadLine());

                double area = Math.PI * Math.Pow(radio, 2);

                Console.WriteLine("El área del círculo es: " + area);
            }
        }
    }
}
        