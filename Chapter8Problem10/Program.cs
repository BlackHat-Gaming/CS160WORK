/*Developer: Connor Spangler
 * Date April 19, 2017
 * Purpose: App that records water depths at certain times in certain citys
 */
using System;

namespace Chapter8Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string city;
            bool cityCheck;
            bool timeCheck;
            bool depthCheck;
            double time = 0;
            int cityPosition = 0;
            int timePosition = 0;
            bool continueCheck = true;
            double averageDepthCity = 0;
            double averageDepthTime = 0;
            double[,] depth = new double[5, 6];
            double deep = 0;
            //program start
            while (continueCheck)
            {
                Console.WriteLine("Welcome to the Depth Recorder!\n");
                MakeChoiceCity(out city, out cityPosition, out cityCheck);
                MakeChoiceTime(out time,out timePosition, city, out timeCheck);
                if (cityPosition <= 4 && cityPosition >= 0 && timePosition <= 3 && timePosition >= 0
                && cityCheck && timeCheck)
                {
                    deep = EnterDepth(out depthCheck);
                    if (depthCheck)
                    {
                        depth[timePosition, cityPosition] = deep;
                    }
                    else
                    {
                        Console.WriteLine("You have entered an invalid answer");
                        Console.ReadKey();
                        depth[timePosition, cityPosition] = 0;
                    }
                }
                else
                {
                    Console.WriteLine("You have entered an invalid answer");
                    Console.ReadKey();
                }
                Console.WriteLine("Would you like to enter another value? Y/N");
                if (Console.ReadLine() == "Y")
                {
                    continueCheck = true;
                    Console.Clear();
                }
                else
                {
                    continueCheck = false;
                    Console.Clear();
                }
                //gets averages
            }
            for (int c = 0; c < depth.GetLength(1); c++)
            {
                for (int i = 0; i < 5; i++)
                    averageDepthCity += depth[i, c];
                averageDepthCity = averageDepthCity / 4;
                depth[4, c] = averageDepthCity;
                averageDepthCity = 0;
            }
            for (int r = 0; r < depth.GetLength(0); r++)
            {
                for (int i = 0; i < 5; i++)
                    averageDepthTime += depth[r, i];
                averageDepthTime = averageDepthTime / 5;
                depth[r, 5] = averageDepthTime;
                averageDepthTime = 0;
            }
            DisplayChart(depth);
            Console.ReadKey();
        }

        //METHODS:
        //allows user to pick city
        static void MakeChoiceCity(out string city, out int numb1, out bool valid)
        {
            city = "";
            Console.WriteLine("Please select the city you would like" +
                              " to enter a depth for.");
            Console.WriteLine("1.) Surf City\n2.) Solomons\n3.) Hilton Head"+
                              "\n4.) Miami\n5.) Savannah/n");
            Console.Write("Your choice(Type the labeled #): ");
            valid = int.TryParse(Console.ReadLine(), out numb1);
            city = CityCheck(numb1, city);
            numb1--;
        }

        //Allows user to enter time
        static void MakeChoiceTime(out double time, out int numb1, string city, out bool valid)
        {
            time = 0;
            Console.WriteLine("\nPlease select the time this" +
                              " depth was recorded in {0}.", city);
            Console.WriteLine("1.) 7:00 A.M.\n2.) 12:00 Noon\n3.) 5:00 P.M." +
                              "\n4.) 9:00 P.M.");
            Console.Write("Your choice(Type the labeled #): ");
            valid = int.TryParse(Console.ReadLine(), out numb1);
            time = TimeCheck(numb1, time);
            numb1--;
        }

        //Allows user to enter depth
        static double EnterDepth(out bool valid)
        {
            double depth;
            Console.Write("\nEnter a depth: ");
            string entered = Console.ReadLine();
            valid = double.TryParse(entered, out depth);
            return depth;
        }
        //Displays Table
        static void DisplayChart(double[,] depth)
        {
            string title = "Depth Chart";
            string bar = "********************************************";
            Console.WriteLine("{0,53}\n{1,67}",title, bar);
            Console.WriteLine("\t\tSurf City\tSolomons\tHilton Head\tMiami\tSavannah\tTime Averages");
            Console.WriteLine("7:00 A.M. {0,12}{1,15}{2,18}{3,12}{4,9}{5,20}"               
                            , depth[0, 0].ToString("f"), depth[0, 1].ToString("f"), depth[0, 2].ToString("f"), depth[0, 3].ToString("f")
                            , depth[0, 4].ToString("f"), depth[0,5].ToString("f"));
            Console.WriteLine("12:00 Noon {0,11}{1,15}{2,18}{3,12}{4,9}{5,20}"
                            ,depth[1, 0].ToString("f"), depth[1, 1].ToString("f"), depth[1, 2].ToString("f"), depth[1, 3].ToString("f")
                            , depth[1, 4].ToString("f"), depth[1,5].ToString("f"));
            Console.WriteLine("5:00 P.M. {0,12}{1,15}{2,18}{3,12}{4,9}{5,20}"
                            , depth[2, 0].ToString("f"), depth[2, 1].ToString("f"), depth[2, 2].ToString("f"), depth[2, 3].ToString("f")
                            , depth[2, 4].ToString("f"), depth[2,5].ToString("f"));
            Console.WriteLine("9:00 P.M. {0,12}{1,15}{2,18}{3,12}{4,9}{5,20}"
                            , depth[3, 0].ToString("f"), depth[3, 1].ToString("f"), depth[3, 2].ToString("f"), depth[3, 3].ToString("f")
                            , depth[3, 4].ToString("f"), depth[3,5].ToString("f"));
            Console.WriteLine("City Averages: {0,7}{1,15}{2,18}{3,12}{4,9}"
                            , depth[4, 0].ToString("f"), depth[4, 1].ToString("f"), depth[4, 2].ToString("f"), depth[4, 3].ToString("f")
                            , depth[4, 4].ToString("f"));

        }
        //method encapsulation for checking time
        private static double TimeCheck(int numb1, double time)
        {
            switch (numb1)
            {
                case 1:
                    time = 700;
                    break;
                case 2:
                    time = 1200;
                    break;
                case 3:
                    time = 1700;
                    break;
                case 4:
                    time = 2100;
                    break;
                default:
                    time = 0;
                    Console.WriteLine("Invalid option");
                    break;
            }
            return time;
        }
        //encapsulation of CityMethod
        private static string CityCheck(int numb1, string city)
        {
            switch (numb1)
            {
                case 1:
                    city = "Surf City";
                    break;
                case 2:
                    city = "Solomons";
                    break;
                case 3:
                    city = "Hilton Head";
                    break;
                case 4:
                    city = "Miami";
                    break;
                case 5:
                    city = "Savannah";
                    break;
                default:
                    city = "";
                    Console.WriteLine("Invalid option");
                    break;
            }
            return city;
        }
    }
}
