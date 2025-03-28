using System;
using System.Collections.Generic;
using Humanizer;

 namespace MyRPG
 {
     public class GameLevel
     {
        private Hardness difficulty;
        public Hardness GetHardness() => difficulty;

        private int numberRoom;

        public int GetNumRooms() => numberRoom;
        
        private List<Enemy> enemies;
        private int numenemies = 0;
        public int GetNumEnemies() => numenemies;

        public GameLevel(int numberRoom,Hardness difficulty)
        {
            this.difficulty = difficulty;
            this.numberRoom = numberRoom;
            enemies = new List<Enemy>();
            for (int i = 0; i < numberRoom; i++)
            {
                enemies.Add(null);
            }
        }

        public void SetEnemyInRoom(int numberRoom, Enemy enemy)
        {
            if (enemies[numberRoom] != null) return;
            enemies[numberRoom] = enemy;
            numenemies++;
        }

        /// <summary>
        /// print final com os diferentes "rooms" e os seus numeros e os inimigos presentes no mesmos
        /// </summary>
        public void PrintEnemies()
        {
            foreach (Enemy enemy in enemies)
            {
                if (enemy == null) continue;
                int index = enemies.IndexOf(enemy);
                Console.WriteLine($"Room {index.ToRoman()}: {enemy.GetName()}");
            }
        }
     }
 }