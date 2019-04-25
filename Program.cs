

using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r = new Rectangulo();
            r.BaseRectangulo = 4.0;
            r.AlturaRectangulo = 3.0;
            r.Color = "Rojo";
 
            Console.WriteLine(r.calcularArea());
            Console.WriteLine(r.calcularPerimetro());
            

            // Deconstructor 4.7.2
            (var baseRect, var alturaRect) = r;

            Console.WriteLine(baseRect);
            Console.WriteLine(alturaRect);

            Console.ReadLine();
        }
    }
}
