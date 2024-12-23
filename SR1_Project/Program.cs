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

            Player player_ = new Player();

            player_.AddItem(new Item("つるはし"));
            player_.AddItem(new Item("巻き物"));
            player_.AddItem(new Item("ポーション"));

            player_.UseItem();

            Console.ReadLine();
        }
    }
}
