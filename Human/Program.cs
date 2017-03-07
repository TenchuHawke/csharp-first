using System;

namespace ConsoleApplication {
    public class Program {
        public static void Main (string[] args) {
            Human Bob = new Human ("Bob");
            Human Lenny = new Human ("Lenny", 120, 4, 2, 1);
            Bob.attack (Lenny);
            string table = "";
            Bob.attack (table);
        }
    }
    public class Human {
        public int Health;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public string Name;

        public Human (string name) {
            Name = name;
            Health = 100;
            Dexterity = 3;
            Intelligence = 3;
            Strength = 3;
            }
        public Human (string name, int health, int strength, int dexterity, int intelligence) {
            Name = name;
            Health = health;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }
        public void attack (object target) {
            if (target is Human) {
                Human Target = target as Human;
                Target.Health -= (this.Strength * 5);
                System.Console.WriteLine ("Your attack does " + (this.Strength * 5) + " damage to " + Target.Name);
            } else {
                System.Console.WriteLine ("Your Attack is ineffective on that target!");
            }
        }
    }
}