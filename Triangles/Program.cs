using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Program
    {

        static void Main(string[] args)
        {
            Triangle trg1 = new Triangle(7, 7, 7);
            Triangle trg2 = new Triangle(7, 6, 3);
            Triangle trg3 = new Triangle(5, 5, 3);
            Triangle trg4 = new Triangle(4, 5, 3);
            Triangle trg5 = new Triangle(8, 8, 8);
            Triangle trg6 = new Triangle(9, 53, 2);

            Console.WriteLine("Равносторонние треугольники : \n");
            foreach(string trg in Triangle.equalTrgs)
            {
                Console.WriteLine(trg+"\n");
            }
            Console.WriteLine();

            Console.WriteLine("Равнобедренные треугольники : \n");
            foreach (string trg in Triangle.esoscleTrgs)
            {
                Console.WriteLine(trg + "\n");
            }
            Console.WriteLine();

            Console.WriteLine("Прямоугольные треугольники : \n");
            foreach (string trg in Triangle.rectangleTrgs)
            {
                Console.WriteLine(trg + "\n");
            }
            Console.WriteLine();

            Console.WriteLine("Произвольные треугольники : \n");
            foreach (string trg in Triangle.randomTrgs)
            {
                Console.WriteLine(trg + "\n");
            }
            Console.WriteLine();

            Console.WriteLine("Треугольники, которые нельзя построить : \n");
            foreach (string trg in Triangle.notTrgs)
            {
                Console.WriteLine(trg + "\n");
            }
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
