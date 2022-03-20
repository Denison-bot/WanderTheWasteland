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
        public int currentHealth;
        public int maxHealth;
        public int attack;
        //public bool attackedLast;

        public bool Attacking(Player player, RandomMoveEnemy enemy, VerticalSetEnemy enemy2, TrackingEnemy enemy3)
        {
            if (player.intendedPosX == enemy.intendedPosX && player.intendedPosY == enemy.intendedPosY ||
                player.intendedPosX == enemy2.intendedPosX && player.intendedPosY == enemy2.intendedPosY ||
                player.intendedPosX == enemy3.intendedPosX && player.intendedPosY == enemy3.intendedPosY)
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
            //attackedLast = true;
            defending.currentHealth = defending.currentHealth - attacking.attack;
            //Console.SetCursorPosition(50, 20);
            //Console.WriteLine(defending.health);
            //Console.WriteLine(attacking.health);
            if (currentHealth <= 0)
            {
                currentHealth = 0;
            }
        }

        public bool PickUpItem(Player player, Item item)
        {            
            if (player.intendedPosX == item.posX && player.intendedPosY == item.posY)
            {
                return true;   
            }
            return false;
        }
    }
}
