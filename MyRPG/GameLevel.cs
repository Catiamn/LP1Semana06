using System;
using System.Collections.Generic;
using Humanizer;

 namespace MyRPG
 {
     public class GameLevel
     {
        private Hardness difficulty;
        public Hardness GetHardness() => difficulty

        private int numberRoom;

        public int GetNumRooms() => numberRoom;
        
        private List<Enemy> enemies;
        private int numenemies = 0;
        public int GetNumEnemies() => numenemies;

        public GameLevel(int numberRoom, MyRPG.Hardness difficulty)
        {
            this.difficulty = difficulty;
            this.numberRoom = numberRoom;
            enemies = new List<Enemy>();
            for (int i = 0; i < numberRoom; i++)
            {
                enemies.Add(null);
            }
        }



     }
 }