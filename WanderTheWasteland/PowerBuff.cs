using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    class PowerBuff : Item
    {
        public void InitPowerBuff()
        {
            name = "PowerBuff";
            itemIcon = "P";
            posX = 38;
            posY = 1;
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(posX, posY);
            Console.Write(itemIcon);
        }

    }
}
