using System;

namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result; //declaring variables

            Console.WriteLine("Please enter first number: "); //1st num
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a second number: "); //2nd num
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please choose to 1)Add, 2)subtract, or 3)multiply the two numbers: "); //operation option
            int option = Convert.ToInt32(Console.ReadLine());

            if(option == 1) //addition
            {
                result = num1 + num2;
                Console.WriteLine("The result of " + num1.ToString() + " + " + num2.ToString() + " = " + result.ToString());
            }
            else if (option == 2) //subtraction
            {
                result = num1 - num2;
                Console.WriteLine("The result of " + num1.ToString() + " - " + num2.ToString() + " = " + result.ToString());
            }
            else if (option == 3) //multiplication
            {
                result = num1 * num2;
                Console.WriteLine("The result of " + num1.ToString() + " * " + num2.ToString() + " = " + result.ToString());
            }
            else
            {
                Console.WriteLine("Invalid choice"); //did not choose 1,2, or 3 
            }
            

        }
    }
}
