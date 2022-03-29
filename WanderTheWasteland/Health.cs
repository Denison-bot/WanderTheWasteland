using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland 
{
    class Health : Item
    {
        public Health()
        {
            name = "HealthPack";
            itemIcon = "H";
            posX = 25;
            posY = 1;
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(posX, posY);
            Console.Write(itemIcon);
        }

    }
}
