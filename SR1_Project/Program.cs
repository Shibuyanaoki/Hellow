using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Player player_ = new Player(new Item("こん棒"));

            player_.UseItem();

            Console.ReadLine();
        }
    }
}
