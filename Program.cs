using Asmtest.GeometryExample;
using Asmtest.InheritanceExample;
using static Asmtest.InheritanceExample.Animal;

namespace Asmtest
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Geometry Example: Cylinder Properties Calculation\n");

            Console.Write("Enter the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nCalculation Results:");

            CyLinder cylinder = new CyLinder();
            cylinder.Process(radius, height);
            cylinder.Result();

        }
        static void Main2(string[] args)
        {
           Animal lion = new Lion(200, "Simba");
            Animal tiger = new Tiger(180, "Rajah");

            Console.WriteLine("Animal Details:\n");

            Console.WriteLine("Lion:");
            lion.Show();
            Console.WriteLine();

            Console.WriteLine("Tiger:");
            tiger.Show();
            Console.WriteLine();
        }

    }
}