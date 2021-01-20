using System;

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

            Console.WriteLine("\n");
            Console.WriteLine("Count down by 2 using for loop");

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
            Console.WriteLine("\n");
            Console.WriteLine("Iterate over string using for loop");

            var name = "John Smith";

            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            Console.WriteLine("\n");
            Console.WriteLine("Iterate over string using for each loop");

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
        }
    }
}
