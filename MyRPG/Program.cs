﻿using System;
 
 namespace MyRPG
 {

    public enum Hardness
    {
        Easy,
        Normal,
        Hard
    }

    public class Program
    {
     
        private string name;
        private float health;
        private float shield;
        /*
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
        */

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

        private static void Main()
        {
     
            GameLevel gl = new GameLevel(104, Hardness.Normal);
 
            gl.SetEnemyInRoom(1, new Enemy("Worf"));
            gl.SetEnemyInRoom(7, new Enemy("Picard"));
            gl.SetEnemyInRoom(16, new Enemy("Data"));
            gl.SetEnemyInRoom(94, new Enemy("Riker"));
            gl.SetEnemyInRoom(59, new Enemy("Troi"));
 
            Console.WriteLine($"Difficulty: {gl.GetHardness()}");
 
            Console.WriteLine($"Number of rooms: {gl.GetNumRooms()}");
 
            Console.WriteLine($"Number of enemies: {gl.GetNumEnemies()}");
 
            gl.PrintEnemies();
 
             // Este programa mostra o seguinte no ecrã:
             //
             // Difficulty: Normal
             // Number of rooms: 104
             // Number of enemies: 5
             // Room I: Worf
             // Room VII: Picard
             // Room XVI: Data
             // Room LIX: Troi
             // Room XCIV: Riker
         }
     }
 }