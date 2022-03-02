using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    class Health : Item
    {
        public void InitHealth()
        {
            itemIcon = "H";
        }

        public void Draw(int x, int y)
        {
            posX = x;
            posY = y;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(posX, posY);
            Console.Write(itemIcon);
        }

        
    }
}
