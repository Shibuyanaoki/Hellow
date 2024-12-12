using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_Project
{
    internal class Item : Robot
    {
        public Item(string name) : base(name)
        {
        }
        public void Use()
        {
            Console.WriteLine("{0}を使った", name);
        }

    }
}
