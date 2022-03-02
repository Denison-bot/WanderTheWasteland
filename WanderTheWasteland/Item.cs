using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    class Item
    {
        public int posX;
        public int posY;
        public string name;
        public string itemIcon;

        public void RemoveIcon()
        {
            itemIcon = " ";
            Console.Write(itemIcon);
        }
    }
}
