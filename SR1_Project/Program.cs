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

            Player player = new Player("ロト", 1);

            //player.level = 9999;

            Console.WriteLine("レベル : {0}", player.GetLevel());
            Console.WriteLine("名前 : {0}",player.GetName());

            player.Attck();
            player.Defense();

            player.LevelUp();
            Console.WriteLine("レベル : {0}",player.GetLevel());

            Console.ReadLine();
        }
    }
}
