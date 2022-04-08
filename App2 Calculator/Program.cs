using System;

namespace App2_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number!: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the anoter number!: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("What u wanna do with them?");
            Console.WriteLine("1. sum");
            Console.WriteLine("2. multiply");
            Console.WriteLine("3. divide");
            Console.WriteLine("... etc no need more options here just test");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (!(choice is  int)) System.Environment.Exit(0);
            switch(choice)
            {
                case 1:
                    Console.WriteLine(num1 + num2);
                    break;
                case 2:
                    Console.WriteLine(num1 * num2);
                    break;
                case 3:
                    if (num2 != 0)
                        Console.WriteLine(num1 / num2);
                    else Console.WriteLine("Nope");
                    break;
                default:
                    Console.WriteLine("wrong number");
                    break;
            }
            
        }
    }
}
