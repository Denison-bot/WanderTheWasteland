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

        public int health;
        public int attack; 

        public bool Attacking(Player player, Enemy enemy)
        {
            if (player.intendedPosX == enemy.currentPosX)
            {
                //intendedPosX = currentPosX;                
                if (player.intendedPosY == enemy.currentPosY)
                {
                    //intendedPosY = currentPosY;
                    return true;
                }
                return true;
            }
            return false;
        }

        public void TakeDamage()
        {
            health = health - attack;
        }
    }
}
