using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1_Modular_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator MyCalc = new Calculator();

            //The calculator name is displayed below
            Console.WriteLine("############################################################");
            Console.WriteLine("###############    C#      C A L C U L A T O R    ###############");
            Console.WriteLine("############################################################");
            Console.WriteLine("");

            //The bool actually is calculating the loop
            bool calcLoop = true;
            while (calcLoop == true)
            {
                //the console below is let you adding the variable that you want.
                Console.Write("Enter your first number: ");
                double inputOne = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter your second number: ");
                double inputTwo = Convert.ToDouble(Console.ReadLine());

                //Below are listed the three different option for the programme.
                Console.WriteLine("\nMenu");
                Console.WriteLine("Enter 1 for Circle");
                Console.WriteLine("Enter 2 for Triangle");
                Console.WriteLine("Enter 3 for Rectangle");
                Console.WriteLine("");

                //The int code is letting you add the choice to the programme
                int opChoice = Convert.ToInt32(Console.ReadLine());
                switch (opChoice)
                {
                    case 1:
                        Console.WriteLine("\nYour Answer is: " + MyCalc.Circle(inputOne, inputTwo).ToString());
                        break;
                    case 2:
                        Console.WriteLine("\nYour Answer is: " + MyCalc.Triangle(inputOne, inputTwo).ToString());
                        break;
                    case 3:
                        Console.WriteLine("\nYour Answer is: " + MyCalc.Rectangle(inputOne, inputTwo).ToString());
                        break;
                    default:
                        Console.WriteLine("\nYou should enter a number from the menu.");
                        break;

                }


                //below isimplemented the another option question 
                Console.WriteLine("");
                Console.Write("\nDo you want to try another sum? Y/N: ");
                string restartChoice = Console.ReadLine().ToUpper();

                // The if code is used as an alternative option
                if (restartChoice == "Y")
                {
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                // The else code has been implemented as extra option to the programme when is no working.
                else
                {
                    Console.WriteLine("Press any key to continue");
                    calcLoop = false;
                }
            }
        }
    }
}