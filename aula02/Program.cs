﻿using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word!!");
            
            if (args.GetLength(0) > 0)
            {
                Console.WriteLine(args.GetValue(0));
            }
            else
            {
                Console.Write("Está funcionando");
            }

        }
    }
}
