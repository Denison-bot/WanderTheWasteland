using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    class Item
    {
        public int posX;
        public int posY;
        public string name;
        public string itemIcon;

        public void UseItem(Item item, Player player)
        {
            if (name == "HealthPack")
            {
                Heal(player);
                itemIcon = "";
                posX = 0;
                posY = 0;
            }
            else if (name == "PowerBuff")
            {
                itemIcon = "";
                posX = 0;
                posY = 0;
            }
        }
        public void Heal(Player player)
        {
            player.currentHealth = player.currentHealth + 1;
        }

        
    }
}
