using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{

    class RandomMoveEnemy : EnemyParent
    {
        public RandomMoveEnemy()
        {
            intendedPosX = 25;
            intendedPosY = 2;
            currentHealth = 5;
            maxHealth = 5;
            attack = 1;
            name = "Random Enemy";
        }
    }
}
