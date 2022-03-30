using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    class TrackingEnemy : EnemyParent
    {
        public TrackingEnemy()
        {
            intendedPosX = 36;
            intendedPosY = 2;
            currentHealth = 3;
            maxHealth = 3;
            attack = 1;
            name = "Tracking Enemy";
        }       
    }
}
