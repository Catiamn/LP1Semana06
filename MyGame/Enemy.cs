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
    }
}
