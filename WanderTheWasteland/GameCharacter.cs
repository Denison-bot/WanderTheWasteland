using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    class GameCharacter
    {
        public int currentPosX;
        public int currentPosY;
        public int intendedPosX;
        public int intendedPosY;
        public string name;

        public int health;
        public int maxHealth;
        public int attack; 

        public bool Attacking(Player player, Enemy enemy)
        {
            if (player.intendedPosX == enemy.intendedPosX && player.intendedPosY == enemy.intendedPosY)
            {
                //intendedPosX = currentPosX;                
                return true;
            }
            return false;
        }

        public void PrintCorpse()
        {
            Console.SetCursorPosition(currentPosX, currentPosY);
            Console.Write("X");
            
        }

        public void TakeDamage(GameCharacter attacking, GameCharacter defending)
        {
            defending.health = defending.health - attacking.attack;
            Console.SetCursorPosition(50, 20);
            //Console.WriteLine(defending.health);
            //Console.WriteLine(attacking.health);
        }
    }
}
