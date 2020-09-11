using System;
using System.ComponentModel;

namespace Calculater
{
    class Program
    {
        static void Main(string[] args)
        {

            bool runtime = false;

            while (!runtime)

            {
                Console.WriteLine("Welcome to my very first Calculator App ");
                Console.WriteLine("Enter Number : ");

                double num = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Function : ");

                string calcFunction = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter Second Number : ");

                double num2 = Convert.ToDouble(Console.ReadLine());


                

                switch (calcFunction)
                {
                    case "+":

                        Console.WriteLine("The answer is : {0}", num + num2);

                        break;

                    case "-":
                        Console.WriteLine("The answer is : {0}", num - num2);
                        break;

                    case "/":

                        while (num2 == 0)
                        {
                            Console.WriteLine("Please Enter a Non-Zero Number ...");
                            num2 = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("The answer is : {0}", num / num2);
                        break;

                    case "*":
                        Console.WriteLine("The answer is : {0}", num * num2);
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;


                }


            Console.WriteLine("please press 'q and ENTER' to Quit the Calculator . Otherwise Press any ");
            if (Console.ReadLine() == "q") runtime = true;


            }
            return;
        }
    }
}

