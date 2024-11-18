using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_Project
{
    internal class Robot
    {
        protected string name;

        public Robot(string name)
        {
            this.name = name;
        }

        //public void PowerOn()
        //{
        //    powerStatus = true;
        //    Console.WriteLine("{0}は、起動した!!", name);
        //}

        //public void PowerOff()
        //{
        //    powerStatus = false;
        //    Console.WriteLine("{0}は、停止した...", name);
        //}

        public string GetName()
        {
            return name;
        }

        public virtual void Attack()
        {
            Console.WriteLine("{0}は、攻撃した！", name);
        }

        //public bool GetPowerStatus()
        //{
        //    return powerStatus;
        //}


    }
}
