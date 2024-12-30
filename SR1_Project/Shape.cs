using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SR1_Project
{
    internal class Shape
    {
        protected float area;

        public float Area()
        {
            return area;
        }

        public virtual void Draw()
        {
            Console.WriteLine("図形...");
        }

    }
}
