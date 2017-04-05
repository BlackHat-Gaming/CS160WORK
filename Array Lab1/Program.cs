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
            bool keepGoing = true;
            bool scoreValidation;
            bool difficultyValidation;
            double highScore = 0;
            double lowScore = 0;
            double sumOfScores = 0;
            double lastScore = 0;
            double difficultyLevel;
            double[] judge = new double[7];
            //start
            Console.WriteLine("Welcome to the Diver Score Calculator!");
            for (int i = 0; i < judge.Length;)
            {
                judge[i] = EnterScore(out scoreValidation);
                if (scoreValidation && judge[i] >= 0 && judge [i] <= 10)
                    i++;
                else
                    Console.WriteLine("You entered an invalid value.");
            }
            Console.WriteLine("\nPlease enter difficulty of the dive.\nRange: 1.2 - 3.8");
            //entering difficulty
            while (keepGoing)
            {
                difficultyLevel = EnterDifficulty(out difficultyValidation);
                if (difficultyValidation && difficultyLevel >= 1.2 && difficultyLevel <= 3.8)
                {
                    highScore = judge.Max();
                    lowScore = judge.Min();
                    sumOfScores = judge.Sum();
                    sumOfScores -= (highScore + lowScore);
                    lastScore = sumOfScores * difficultyLevel * .6;
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
        static double EnterScore(out bool valid)
        {
            Console.Write("Please enter your score: ");
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
