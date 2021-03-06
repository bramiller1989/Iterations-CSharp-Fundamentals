﻿using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count up by 2 using for loop");

            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\nCount up by 2 using while loop");

            var idx = 0;
            while (idx <= 10)
            {
                if (idx % 2 == 0)
                    Console.WriteLine(idx);

                idx++;
            }

            Console.WriteLine("\nCount down by 2 using for loop");

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
            Console.WriteLine("\nIterate over string using for loop");

            var name = "John Smith";

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine("\nIterate over string using for each loop");

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            Console.WriteLine("\nIterate over array using for each loop");

            var numbers = new int[] {1, 2, 3, 4};

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nPrompt for name then echo output in a while loop");

            while(true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;
            }

            Console.WriteLine("\nEcho random numbers with a for loop");
            var random = new Random();
            for (var i = 0; i < 10; i++)
                Console.WriteLine(random.Next(1, 10));

            Console.WriteLine("\nGenerate random password with a for loop");

            const int passwordLength = 10;
            var buffer = new char[passwordLength];

            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0,26));

            var password = new string(buffer);

            Console.WriteLine(password);
        }
    }
}
