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

            FlyingRobot Robot = new FlyingRobot("ロボット");

            Console.WriteLine("名前 : {0}", Robot.GetName());

            Robot.Attack();

            FlyingRobot flyingRobot = new FlyingRobot("空飛ぶロボ");

            Console.WriteLine("名前:{0}", flyingRobot.GetName());

            flyingRobot.Attack();

            TankRobot tankRobot = new TankRobot("タンクロボ");

            Console.WriteLine("名前 : {0}", tankRobot.GetName());

            tankRobot.Attack();


            Console.ReadLine();
        }
    }
}
