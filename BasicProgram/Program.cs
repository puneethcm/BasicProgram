using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Program");
            Console.WriteLine("Please choose any one program");
            Console.WriteLine("1:Calculator\n2:SwitchCase\n10:Exit");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Please enter first number");
                    int first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter second number");
                    int second = Convert.ToInt32(Console.ReadLine());
                    Calculator calculator1 = new Calculator(first, second);
                    calculator1.Addition();
                    calculator1.Substraction();

                    //Console.WriteLine("Welcome to Basic Program");
                    Console.WriteLine("Please enter third number");
                    int third = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter fourth number");
                    int fourth = Convert.ToInt32(Console.ReadLine());
                    Calculator calculator2 = new Calculator(third, fourth);
                    calculator2.Addition();
                    calculator2.Substraction();
                    break;

                case 2:
                    Console.WriteLine("Enter the  number from 1 to 7");
                    int day = Convert.ToInt32(Console.ReadLine());
                    WeekDays.FindADayWhichFallsOnWeek(day);
                    break;

                case 10:
                    break;

                default:
                    Console.WriteLine("Please choose number 1 or 2");
                    break;

            }
            Console.ReadLine();
        }
    }
}
