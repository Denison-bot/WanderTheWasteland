using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    class VerticalSetEnemy : EnemyParent
    {
        private bool movingUp = true;

        public VerticalSetEnemy()
        {
            intendedPosX = 17;
            intendedPosY = 5;
            currentHealth = 3;
            maxHealth = 3;
            attack = 5;
            name = "Vertical Enemy";
        }
    }
}