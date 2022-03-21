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

        public void UseItem(Item item, Player player, HUD hud)
        {
            if (name == "HealthPack")
            {
                Heal(player);
                itemIcon = "";
                posX = 0;
                posY = 0;
                hud.action = "Player Healed";
            }
            else if (name == "PowerBuff")
            {
                BuffAttack(player);
                itemIcon = "";
                posX = 0;
                posY = 0;
                hud.action = "Player Attack Buffed";
            }
            else if (name == "SpeedBuff")
            {
                BuffSpeed(player);
                itemIcon = "";
                posX = 0;
                posY = 0;
                hud.action = "Player Speed Buffed";
            }
        }
        public void Heal(Player player)
        {
            player.currentHealth = player.currentHealth + 1;
            if (player.currentHealth >= 3)
            {
                player.currentHealth = 3;
            }
        }

        public void BuffAttack(Player player)
        {
            player.attack = 3;
        }

        public void BuffSpeed(Player player)
        {
            player.speedBuffed = true;                        
        }
    }
}
