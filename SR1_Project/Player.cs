using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_Project
{
    internal class Player
    {
        private string name;
        private int level;

        Item item_ = new Item("");

        public Player(Item item)
        {

        }

        public void UseItem()
        {
            item_.Use();
        }

        //    public void Attck()
        //    {
        //        Console.WriteLine("攻撃!!");
        //    }

        //    public void Defense()
        //    {
        //        Console.WriteLine("防御した");
        //    }

        //    public void LevelUp()
        //    {
        //        level++;
        //    }

        //    public string GetName()
        //    {
        //        return name;
        //    }

        //    public int GetLevel()
        //    {
        //        return level;
        //    }

    }
}
