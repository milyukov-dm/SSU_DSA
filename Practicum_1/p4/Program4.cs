﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("{0} * {1} = {2:#.#}", a, b, a * b);

        }
    }
}
