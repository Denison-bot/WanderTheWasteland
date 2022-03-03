﻿using System;
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
            name = "HealthPack";
            itemIcon = "H";
            posX = 1;
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
