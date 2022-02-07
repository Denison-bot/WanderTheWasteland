using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    
    class Enemy
    {
        static int x;
        static int y;
        public void EnemyInit()
        {
            x = 25;
            y = 12;
        }
        public void Update()
        {

        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("E");
        }
    }
}
