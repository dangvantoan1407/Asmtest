using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asmtest.InheritanceExample
{
    public class Animal
    {
        protected double Weight { get; set; }
        protected string Name { get; set; }
        public Animal(double weight, string name)
        {
            SetMe(weight, name);
        }

        public void SetMe(double weight, string name)
        {
            Weight = weight;
            Name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Weight: {Weight} kg");
        }
        public class Lion : Animal
        {
            public Lion(double weight, string name) : base(weight, name)
            {
            }

            public override void Show()
            {
                base.Show();
                Console.WriteLine("Type: Lion");
            }
        }
        public class Tiger : Animal
        {
            public Tiger(double weight, string name) : base(weight, name)
            {
            }

            public override void Show()
            {
                base.Show();
                Console.WriteLine("Type: Tiger");
            }
        }
    }
}
