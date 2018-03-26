using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Assignment10
{
    class Main
    {
        static void Main(string[] args)
        {
            string inputValue;
            string result;

            //Display header and instructions
            Header();
            DisplayInstructions();

            Console.Write("*******************************************************\n" +
                          "Enter name or -99 to quit: ");
            inputValue = Console.ReadLine();
            while (inputValue != "-99")
            {
                result = "";
                Console.Write("Enter running <R> or walking <W>: ");
                inputValue = Console.ReadLine();
                Console.WriteLine("*******************************************************");
                switch (inputValue)
                {
                    case "R":
                    case "r":
                        for (int i = 15; i <= 60; i += 15)
                        {
                            Console.WriteLine(i + " Minutes " + (i * 5) + " Calories");
                            result += i + " Minutes " + (i * 5) + " Calories\n";
                        }
                        MessageBox.Show(result, "Calories Burned Running");
                        break;
                    case "W":
                    case "w":
                        for (int i = 15; i <= 60; i += 15)
                        {
                            Console.WriteLine(i + " Minutes " + (i * 2.5) + " Calories");
                            result += i + " Minutes " + (i * 2.5) + " Calories\n";
                        }
                        MessageBox.Show(result, "Calories Burned Running");
                        break;
                }

                Console.Write("\n*******************************************************\n" +
                          "Enter name or -99 to quit: ");
                inputValue = Console.ReadLine();
            }
        }

        static public void Header()
        {
            Console.WriteLine("*******************************************************\n" +
                              "\tCalories Burned\n" +
                              "\tCalculate calories burned running or walking" +
                              "\tDylan Grandjean\n\t" +
                              DateTime.Today.ToShortDateString());
        }

        static public void DisplayInstructions()
        {
            Console.WriteLine("*******************************************************\n" +
                              "This program will calculate calories burned\n\t" +
                              "running or walking for 15, 30, 45 and 60 minutes\n\n" +
                              " Enter name or -99 to quit\n" +
                              " Enter R for running orW for walking\n");
        }
    }
}
