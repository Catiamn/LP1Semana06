using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
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
        }
    }
}
