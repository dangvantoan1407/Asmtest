using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asmtest.GeometryExample
{
    public class CyLinder
    {
        public double Radius
        {
            get; set;
        }
        public double Height { get; set; }
        public double BaseArea { get; set; }
        public double LateralArea { get; set; }
        public double TotalArea { get; set; }
        public double Volume { get; set; }
        public void Process(double radius, double height)
        {
            Radius = radius;
            Height = height;

            BaseArea = CalculateBaseArea();
            LateralArea = CalculateLateralArea();
            TotalArea = CalculateTotalArea();
            Volume = CalculateVolume();
        }
        private double CalculateBaseArea()
        {
            return Radius * Radius * Math.PI;
        }

        private double CalculateLateralArea()
        {
            return 2 * Math.PI * Radius * Height;
        }

        private double CalculateTotalArea()
        {
            return 2 * Math.PI * Radius * (Height + Radius);
        }

        private double CalculateVolume()
        {
            return Math.PI * Radius * Radius * Height;
        }
        public void Result()
        {
            Console.WriteLine($"Base Area: {BaseArea}");
            Console.WriteLine($"Lateral Area: {LateralArea}");
            Console.WriteLine($"Total Area: {TotalArea}");
            Console.WriteLine($"Volume: {Volume}");
        }


    }
}
