using System;
using System.Collections.Generic;

namespace ConsoleApplication {
    public class Program {
        public static void Main (string[] args) {
            for (int i = 1; i < 256; i++) {
                Console.WriteLine (i);
            }

            for (int i = 1; i < 256; i += 2) {
                Console.WriteLine (i);
            }

            int sum = 0;
            for (int i = 0; i < 256; i++) {
                sum += i;
                Console.WriteLine ("new Number: " + i + " Sum: " + sum);
            }

            int[] X = { 1, 3, 5, 7, 9, 13 };
            for (int i = 0; i < X.Length; i++) {
                Console.WriteLine (X[i]);
            }

            Console.WriteLine (MaxNum (X));

            Console.WriteLine (Average (X));

            int[] Y = Array255 ();
            foreach (int val in Y) {
                System.Console.WriteLine (val);
            }

            int[] Z = { 1, 5, 10, -2 };
            int[] A = GreaterThanY (Z, 3);
            foreach (int val in A) {
                System.Console.WriteLine (val);
            }
            int[] B = (SquareVal (Z));

            foreach (int val in B) {
                System.Console.WriteLine (val);
            }

            int[] W = MMA (Z);
            foreach (int val in W) {
                System.Console.WriteLine (val);
            }

            int[] T = { 1, 5, 19, 7, -2 };
            int[] V = ShiftVal (T);
            foreach (int val in T) {
                Console.WriteLine (val);
            }

            int[] S = {-1, -3, 2 };
            string[] U = NumToString (S);
            foreach (string val in U) {
                Console.WriteLine (val);
            }

        }
        public static int MaxNum (int[] X) {
            int Max = X[0];
            for (int i = 1; i < X.Length; i++) {
                if (X[i] > Max) {
                    Max = X[i];
                }
            }
            return Max;
        }

        public static int Average (int[] X) {
            int sum = 0;
            for (int i = 0; i < X.Length; i++) {
                sum += X[i];
            }
            return (sum / (X.Length));
        }

        public static int[] Array255 () {
            int[] X = new int[128];
            for (int i = 1; i < 256; i += 2) {
                X[i / 2] = i;
            }
            return X;
        }
        public static int[] GreaterThanY (int[] X, int Z) {
            List<int> Output = new List<int> { };

            for (int i = 0; i < X.Length; i++) {
                if (X[i] > Z) {
                    Output.Add (X[i]);
                }
            }
            int[] OutputArray = new int[Output.Count];
            for (int i = 0; i < Output.Count; i++) {
                OutputArray[i] = Output[i];
            }
            return OutputArray;
        }
        public static int[] SquareVal (int[] X) {
            for (int i = 0; i < X.Length; i++) {
                X[i] *= X[i];
            }
            return X;
        }
        public static int[] MMA (int[] X) {
            int[] OutputArray = new int[3];
            int Max = X[0];
            int Min = X[0];
            int Sum = 0;
            for (int i = 0; i < X.Length; i++) {
                Sum += X[i];
                if (X[i] > Max) {
                    Max = X[i];
                }
                if (X[i] < Min) {
                    Min = X[i];
                }
            }
            OutputArray[0] = Max;
            OutputArray[1] = Min;
            OutputArray[2] = Sum / X.Length;
            return OutputArray;
        }
        public static int[] ShiftVal (int[] X) {
            for (int i = 0; i < X.Length - 1; i++) {
                X[i] = X[i + 1];
            }
            X[X.Length - 1] = 0;
            return X;
        }

        public static string[] NumToString (int[] X) {
            string[] Output = new string[X.Length];
            for (int i = 0; i < X.Length; i++) {
                if (X[i] < 0) {
                    Output[i] = "Dojo";
                } else {
                    Output[i] = X[i].ToString ();
                }
            }
            return Output;
        }
    }
}