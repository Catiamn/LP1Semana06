using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {

            int NumberEnemy = int.Parse(args[0]);

            Enemy[] inimigos = new Enemy[NumberEnemy];

            for(int i = 0; i < NumberEnemy; i++)
            {
                Console.Write($"Nome do inimigo {i+1}:");
                string nome = Console.ReadLine();
                inimigos[i] = new Enemy(nome);
            }

            for(int i = 0; i < NumberEnemy; i++)
            {
                    Console.Write($"{inimigos[i].GetName()} {inimigos[i].GetHealth()} {inimigos[i].GetShield()}");
                    Console.WriteLine();
            }
        }
    }

}
