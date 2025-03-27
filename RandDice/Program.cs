using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //total dos dados lançados que depois vai aparecer na console
            int total = 0;
            //second argument = seed
            Random s = new Random(int.Parse(args[1]));

            //first argument = number of times the dice is gonna be rolled
            for (int i = 0; i < int.Parse(args[0]); i++)
            {
                //the dice can roll between 1-6
                total += s.Next(1,7);
            }
            Console.WriteLine(total);

        }
    }
}
