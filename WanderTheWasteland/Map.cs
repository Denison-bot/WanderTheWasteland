﻿using System;
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

        public char[,] map = new char[,]
        {
            {'┌', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '┬', '─', '─', '─', '─', '─', '─', '─', '─', '┬', '─', '─', '─', '─', '─', '┬', '─', '─', '─', '─', '─', '─', '─', '─', '┐'},
            {'│', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '│', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '│', ' ', ' ', ' ', ' ', ' ', '│', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '│'},
            {'│', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '│', ' ', ' ', ' ', ' ', ' ', '│', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '│'},
            {'├', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '┘', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '└', '─', ' ', ' ', ' ', '─', '┤', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '│'},
            {'│', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '│', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '│'},
            {'│', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '│', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '│'},
            {'│', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '│', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '│'},
            {'├', '─', '─', ' ', ' ', ' ', ' ', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '┘', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '│'},
            {'│', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '│'},
            {'│', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '│'},
            {'│', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '│'},
            {'│', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '│'},
            {'│', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '│'},
            {'└', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '─', '┘'},
        };
            
        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(0, 0);
            rows = map.GetLength(0);
            cols = map.GetLength(1);          

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    char element = map[y, x];
                    Console.Write(element);
                }
                Console.WriteLine();
            }
        }

        public bool IsWall(int x, int y)
        {
            if (map[y, x] == '│' || map[y, x] == '─' || map[y, x] == '┤' || map[y, x] == '┘' || map[y,x] == '└')
            {
                return true;
            }
            return false;
        }

        public void Update()
        {

        }
       
    }
}
