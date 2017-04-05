/*Developer: Connor Spangler
 * Date April 19, 2017
 * Purpose: App that records water depths at certain times
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            double[,] depth = new double[4, 5];
            //program start
            while (continueCheck)
            {
                Console.WriteLine("Welcome to the Depth Recorder!\n");
                Choose:
                MakeChoiceCity(out city, out cityPosition, out cityCheck);
                MakeChoiceTime(out time,out timePosition, city, out timeCheck);
                if (cityPosition > 4 || cityPosition < 0 || timePosition > 3 || timePosition < 0
                    || !cityCheck || !timeCheck)
                {
                    Console.WriteLine("You have entered an invalid answer");
                    Console.ReadKey();
                    Console.Clear();
                    goto Choose;
                }

                depth[timePosition, cityPosition] = EnterDepth(out depthCheck);
                if (!depthCheck)
                {
                        Console.WriteLine("You have entered an invalid answer");
                        Console.ReadKey();
                        Console.Clear();
                        goto Choose;
                }
                Console.WriteLine("Would you like to enter another value? Yes/No");
                if (Console.ReadLine() == "Yes")
                {
                    continueCheck = true;
                    Console.Clear();
                }
                else
                {
                    continueCheck = false;
                    Console.Clear();
                }
            }
            Display(depth);
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
        static void Display(double[,] depth)
        {
            string title = "Depth Chart";
            string bar = "********************************************";
            Console.WriteLine("{0,53}\n{1,67}",title, bar);
            Console.WriteLine("\t\tSurf City\tSolomons\tHilton Head\tMiami\tSavannah");
            Console.WriteLine("7:00 A.M. {0,12}{1,15}{2,18}{3,12}{4,9}", depth[0, 0], depth[0, 1], depth[0, 2], depth[0, 3], depth[0, 4]);
            Console.WriteLine("12:00 Noon {0,11}{1,15}{2,18}{3,12}{4,9}", depth[1, 0], depth[1, 1], depth[1, 2], depth[1, 3], depth[1, 4]);
            Console.WriteLine("5:00 P.M. {0,12}{1,15}{2,18}{3,12}{4,9}", depth[2, 0], depth[2, 1], depth[2, 2], depth[2, 3], depth[2, 4]);
            Console.WriteLine("9:00 P.M. {0,12}{1,15}{2,18}{3,12}{4,9}", depth[3, 0], depth[3, 1], depth[3, 2], depth[3, 3], depth[3, 4]);
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
