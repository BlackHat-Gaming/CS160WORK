using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] judge = new double[7];
            int numb = 1;
            //start
            Console.WriteLine("Welcome to the Diver Score Calculator!");
            RetrieveData(judge, numb);
            Console.WriteLine("\nPlease enter difficulty of the dive.\nRange: 1.2 - 3.8");
            DisplayData(judge);
        }
        static void RetrieveData(double[] judge, int numb)
        {
            bool scoreValidation;
            for (int i = 0; i < judge.Length;)
            {
                Console.Write("Judge {0} please enter your score (Ranges 0 - 10): ", numb);
                judge[i] = EnterScore(out scoreValidation);
                if (scoreValidation && judge[i] >= 0 && judge[i] <= 10)
                {
                    i++;
                    numb++;
                }
                else
                    Console.WriteLine("You entered an invalid value.");
            }
        }
        static void DisplayData(double[] judge)
        {
            bool keepGoing = true;
            double difficultyLevel;
            double lastScore = 0;
            bool difficultyValidation;
            while (keepGoing)
            {
                difficultyLevel = EnterDifficulty(out difficultyValidation);
                if (difficultyValidation && difficultyLevel >= 1.2 && difficultyLevel <= 3.8)
                {
                    CalculateScore(judge, out lastScore, ref difficultyLevel);
                    Console.WriteLine("The final score is {0}", lastScore);
                    Console.ReadKey();
                    break;
                }
                else
                    Console.WriteLine("You entered an invalid value.");
                keepGoing = true;
            }
            Console.ReadKey();
        }
        static double CalculateScore(double[] judge, out double lastScore, ref double difficultyLevel)
        {
            double highScore = judge.Max();
            double lowScore = judge.Min();
            double sumOfScores = judge.Sum();
            sumOfScores -= (highScore + lowScore);
            return lastScore = sumOfScores * difficultyLevel * .6;
        }
        static double EnterScore(out bool valid)
        {
            string entered = Console.ReadLine();
            double score;
            valid = double.TryParse(entered, out score);
            return score;
        }
        static double EnterDifficulty(out bool valid)
        {
            Console.WriteLine("Please enter the difficulty: ");
            string entered = Console.ReadLine();
            double difficultyLevel;
            valid = double.TryParse(entered, out difficultyLevel);
            return difficultyLevel;

        }
    }
}
