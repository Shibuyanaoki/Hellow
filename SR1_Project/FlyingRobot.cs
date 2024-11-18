using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_Project
{
    internal class FlyingRobot : Robot
    {

        public FlyingRobot(string name) : base(name)
        {
        }

        public override void Attack()
        {

            Console.WriteLine("{0}は、爆弾を落とした!!", name);

        }
    }
}
