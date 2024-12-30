using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_Project
{
    internal class Circle : Shape
    {
        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine("〇");
        }

    }
}
