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

            List<Robot> robots = new List<Robot>();

            for (int i = 0; i < 15; i++)
            {
                int r = random.Next(0, 1 + 1);

                if (r == 0)
                {
                    robots.Add(new TankRobot("タンクロボット"));
                }
                else if (r == 1)
                {
                    robots.Add(new FlyingRobot("空飛ぶロボット"));
                }
            }

            foreach (Robot robot in robots)
            {
                robot.Attack();
            }

            Console.ReadLine();
        }
    }
}
