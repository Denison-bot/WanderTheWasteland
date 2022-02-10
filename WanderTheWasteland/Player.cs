using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    class Player
    {
        static char input;
        public int currentPosX;
        public int currentPosY;
        public int intendedPosX;
        public int intendedPosY;

        public void PlayerInit()
        {
            intendedPosX = 2;
            intendedPosY = 2;
        }

        public void Draw()
        {
            //Console.Clear();
            currentPosX = intendedPosX;
            currentPosY = intendedPosY;
            Console.SetCursorPosition(currentPosX, currentPosY);
            Console.WriteLine("@");
        }
        
        public void Update(ref bool gameOver, Map map)
        {
            ConsoleKeyInfo readKeyInput = Console.ReadKey(true);
            input = readKeyInput.KeyChar;

            if (input == 'w')
            {
                intendedPosY--;
                if (map.IsWall(intendedPosX, intendedPosY) == true)
                {
                    intendedPosY++;
                }
            }
            else if (input == 's')
            {
                intendedPosY++;
                if (map.IsWall(intendedPosX, intendedPosY) == true)
                {
                    intendedPosY--;
                }
            }
            else if (input == 'a')
            {
                intendedPosX--;
                if (map.IsWall(intendedPosX, intendedPosY) == true)
                {
                    intendedPosX++;
                }
            }
            else if (input == 'd')
            {
                intendedPosX++;
                if (map.IsWall(intendedPosX, intendedPosY) == true)
                {
                    intendedPosX--;
                }
            }
            else if (input == 'p')
            {
                gameOver = true;
            }
        }

        public void QuitCheck(ref bool gameOver)
        {
            ConsoleKeyInfo readKeyInput = Console.ReadKey(true);
            input = readKeyInput.KeyChar;

            if (input == 'p')
            {
                 gameOver = true;
            }
        }
    }
}
