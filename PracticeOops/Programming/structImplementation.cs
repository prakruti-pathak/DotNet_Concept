﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Programming
{
    internal class structImplementation
    {
        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            // Constructor
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            // Method
            public void Display()
            {
                Console.WriteLine($"Point({X}, {Y})");
            }
        }
    }
}
