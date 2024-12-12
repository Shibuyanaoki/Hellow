using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_Project
{
    internal class Player
    {
        Item item_ = new Item("");

        public Player(Item item)
        {
            item_ = item;
        }

        public void UseItem()
        {
            item_.Use();
        }
    }
}
