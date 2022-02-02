using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WanderTheWasteland
{
    class Map 
    {
        static int rows;
        static int cols;

        public void Draw()
        {
            Console.SetCursorPosition(0, 0);

            rows = 20;
            cols = 40;
            Console.Write("O" + new string('-', cols) + "O");
            Console.WriteLine();

            for (int y = 0; y < rows; y++)
            {
                Console.Write("|");
                for (int x = 0; x < cols; x++)
                {                    
                    Console.Write(".");
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.Write("O" + new string('-', cols) + "O");
            Console.WriteLine();
            //Console.ReadKey(true);
        }
        public void Update()
        {

        }
    }
}
