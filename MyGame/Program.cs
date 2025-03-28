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
                Console.Write($"Nome do inimigo {i+1}: ");
                string nome = Console.ReadLine();
                inimigos[i] = new Enemy(nome);
            }

            for(int i = 0; i < NumberEnemy; i++)
            {
                inimigos[i].PickupPowerUp(PowerUp.Shield,120);
                inimigos[i].TakeDamage(30);
                Console.WriteLine($"{inimigos[i].GetName()} {inimigos[i].GetHealth()} {inimigos[i].GetShield()}");
                    
            }

            foreach (Enemy inimigo in inimigos)
             {
                 inimigo.PickupPowerUp(PowerUp.Shield, Random.Shared.Next(10, 50));
                 Console.WriteLine($"PowerUp Shield: {inimigo.GetName()} {inimigo.GetHealth()} {inimigo.GetShield()}");
 
                 inimigo.TakeDamage(Random.Shared.Next(10, 100));
                 Console.WriteLine($"TakeDamage: {inimigo.GetName()} {inimigo.GetHealth()} {inimigo.GetShield()}");
 
                 inimigo.PickupPowerUp(PowerUp.Health, Random.Shared.Next(10, 50));
                 Console.WriteLine($"PowerUp Health: {inimigo.GetName()} {inimigo.GetHealth()} {inimigo.GetShield()}\n");
             }
 
             Console.WriteLine($"\nTotal de PowerUps: {Enemy.GetPowerUpsCollected()}");
        }
    }

}
