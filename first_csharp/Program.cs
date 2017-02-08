using System;

namespace ConsoleApp {
    class Program {

        static void Main (string [] args) {
            for (int i = 0; i < 256; i++)
            {
                System.Console.WriteLine (i);
            }
                        for (int i = 1; i < 101; i++)
            {
                bool printme = false;
                if ((double) i / 5 == (int) i/5)
                {
                   printme = !printme; 
                }
                if ((double) i/3 == (int) i/3)
                {
                    printme = !printme;
                }
                if (printme)
                {
                    System.Console.WriteLine (i);
                }
            }
            for (int i = 1; i < 101; i++)
            {
                bool printme = false;
                if ((double) i / 5 == (int) i/5)
                {
                   printme = !printme; 
                   System.Console.WriteLine ("fizz");
                }
                if ((double) i/3 == (int) i/3)
                {
                    printme = !printme;
                    System.Console.WriteLine ("buzz");
                }
                if (((double) i/3 == (int) i/3) && ((double) i / 5 == (int) i/5))
                {
                    System.Console.WriteLine ("fizbuzz");
                }
            }
            for (int i = 1; i < 101; i++) {
                bool printme = false;
                if (i % 5 == 0) {
                    printme = !printme;
                    System.Console.WriteLine ("fizz");
                }
                if (i % 3 == 0) {
                    printme = !printme;
                    System.Console.WriteLine ("buzz");
                }
                if ((i % 3 == 0) && (i % 5 == 0)) {
                    System.Console.WriteLine ("fizbuzz");
                }
            }
            Random rand = new Random ();
            for (int i = 1; i < 11; i++) {
                bool printme = false;

                int choice = (int) (rand.NextDouble () * 100 + 1);
                if (choice % 5 == 0) {
                    printme = !printme;
                    System.Console.WriteLine ("fizz");
                }
                if (choice % 3 == 0) {
                    printme = !printme;
                    System.Console.WriteLine ("buzz");
                }
                if ((choice % 3 == 0) && (choice % 5 == 0)) {
                    System.Console.WriteLine ("fizbuzz");
                }
            }
        }
    }
};