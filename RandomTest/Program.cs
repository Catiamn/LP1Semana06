using System;

namespace RandomTest
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //random number from 1 to 22
            Random r1 = new Random(22);
            Random r2 = new Random(22);

            //writes 4 lines of numbers 
            for (int i = 0; i < 4; i++)
                Console.WriteLine(r1.Next());
            Console.WriteLine();
            
            //writes 4 lines of numbers 
            for (int i = 0; i < 4; i++)
                Console.WriteLine(r2.Next());
        }
    }
}
