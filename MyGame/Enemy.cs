using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        private static int powerupsCollected;
 
         static Enemy() {
             powerupsCollected = 0;
         }
        public Enemy(string name)
        {
            this.name = name; //this para aceder a variaveis de instancia 
            health = 100;
            shield = 0;
        }
        public void SetName(string newName)
        {
            name = newName.Substring(0, Math.Min(8, newName.Length)); //nome que tem o maximo de 8 caracters 
        }
        public string GetName()
        {
            return name;
        }
        public float GetShield()
        {
            return shield;
        }
        public float GetHealth()
        {
            return health;
        }

        public void PickupPowerUp(PowerUp powerup, float n)
         {
             if (powerup == PowerUp.Health)
             {
                health +=  n;
                if (health >= 100 ) health = 100 ;
             }
             else if (powerup == PowerUp.Shield)
             {
                shield += n;
                if (shield >= 100)  shield = 100 ;
             }
         }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
            powerupsCollected++;
        }
 
        public static int GetPowerUpsCollected()
        {
            return powerupsCollected;

        }
    }
}
