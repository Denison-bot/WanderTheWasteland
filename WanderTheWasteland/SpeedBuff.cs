using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    class SpeedBuff : Item
    {
        public void InitSpeedBuff()
        {
            name = "SpeedBuff";
            itemIcon = "S";
            posX = 1;
            posY = 12;
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(posX, posY);
            Console.Write(itemIcon);
        }
    }
}
