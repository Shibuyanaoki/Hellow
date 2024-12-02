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

            Random random = new Random(Environment.TickCount);
            List<int> numbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int r = random.Next(-5, 5 + 1);
                numbers.Add(r);
            }


            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();

        }
    }
}
