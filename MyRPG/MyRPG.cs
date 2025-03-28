using System;

namespace MyRPG
{
    public class MyRPG
    {
        
        public enum Hardness
     {
         Easy,
         Normal,
         Hard
     }
     
         private string name;
         private float health;
         private float shield;
         public MyRPG(string name)
         {
             this.name = name;
             health = 100;
             shield = 0;
         }
 
         public string GetName()
         {
             return name;
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