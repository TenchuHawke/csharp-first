using System;
using System.Collections.Generic;

namespace ConsoleApplication {
    public class Program {
        public static void Main (string[] args) {
            RandomArray();
            TossCoin();
            TossMultipleCoins(500);
            string [] NameList = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            string [] NamesOut = Names(NameList);

            
        }
        public static int[] RandomArray () {
            int[] Output = new int[10];
            Random rand = new Random ();

            for (int i = 0; i < 10; i++) {
                Output[i] = rand.Next (5 , 25);
            }
            int Min = Output[0];
            int Max = Output[0];
            int Sum = 0;

            for (int i = 0; i < 10; i++) {
                if (Output[i] < Min) {
                    Min = Output[i];
                }
                if (Output[i] > Max) {
                    Max = Output[i];
                }
                Sum += Output[i];
            }
            System.Console.WriteLine ("Minimum: " + Min);
            System.Console.WriteLine ("Maximum: " + Max);
            System.Console.WriteLine ("Sum: " + Sum);
            return Output;
        }

        public static string TossCoin () {
            string Result = "";
            Random rand = new Random ();
            System.Console.WriteLine ("Tossing a Coin!");
            if (rand.Next (0, 1) == 0) {
                Result = "Heads";
            } else {
                Result = "Tails";
            }
            System.Console.WriteLine (Result + "!");
            return Result;
        }
        public static double TossMultipleCoins (int num) {
            Random rand = new Random ();
            int count = 0;
            for (int i = 0; i < num; i++) {
                if (rand.Next (0, 1) == 0) {
                    count++;
                }
            }
            return (double) count/num;
        }
        public static string [] Names (string [] nameList)
        {
            List <string> OutputList = new List<string>();
            for (int i = 0; i < nameList.Length; i++)
            {
                if (nameList[i].Length>5)
                {
                    OutputList.Add(nameList[i]);
                }
            }
            int [] randArray = new int[OutputList.Count];
            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i]=i;
            }
            int temp = 0;
            int index = 0;
            Random rand = new Random();
            for (int i = 0; i < randArray.Length; i++)
            {
                index = rand.Next(0, randArray.Length);
                temp = randArray[i];
                randArray[i] = randArray[index];
                randArray[index] = temp;
            }
            int j = 0;
            string [] Output = new string [OutputList.Count];
            foreach (string item in OutputList)
            {
                Output[randArray[j]]=item;
                j++;
            }
            return Output;
        }
    }
}