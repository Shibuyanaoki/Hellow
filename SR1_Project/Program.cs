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

            FlyingRobot flyingRobot = new FlyingRobot("空飛ぶロボット");

            TankRobot tankRobot = new TankRobot("タンクロボット");

            Random random = new Random(Environment.TickCount);

            for(int i = 0; i< 15; i++)
            {
                int r = random.Next(0, 1+1);

                if (r == 0)
                {
                    tankRobot.Attack();
                }
                else if (r == 1)
                {
                    flyingRobot.Attack();
                }
            }




            Console.ReadLine();
        }
    }
}
