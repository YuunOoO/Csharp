using System;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] luckynumbers = { 25, 11, 12, 3, 41, 23, 22, 523 };
            string[] friends = new string[2];
            friends[0] = "John Cena";
            friends[1] = "Andrea Larosa";
            hey("Dareczek");
            MultipleText("Siema", 5);
            Aray2d();
            try 
            {
                Console.WriteLine("Try to divide by 0");
                Console.WriteLine("enter first number");
                decimal x = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("enter second number");
                decimal y = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(x/y);
            }
            catch(DivideByZeroException wtf)
            {
                Console.WriteLine(wtf.Message);
            }
        }

        static void hey(string name)
        {
            Console.WriteLine("Hey "+ name);
        }

        static void MultipleText(string whatever, int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(whatever);
        }

        static void Aray2d()
        {
            int[,] tab = {
            {1, 1 },
            {2, 2 },
            {3, 3 },
            {4, 4 },
            {5, 5 } 
            };
            //Console.WriteLine(tab[1, 0]);
            for (int i=0;i<tab.Length/2;i++) 
                Console.WriteLine(tab[i,0]+", "+ tab[i,1]);
        }
    }
}
