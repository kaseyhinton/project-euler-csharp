﻿using System;
using project_euler.problems;

namespace project_euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Project Euler");
            Problem1.Solve();
            Problem2.Solve();
            Problem3.Solve();
            Problem4.Solve();
            Console.ReadLine();
        }
    }
}
