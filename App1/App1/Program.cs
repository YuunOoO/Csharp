using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Never play league of legends");
            string x = Console.ReadLine();
            Console.WriteLine(x);
            Console.WriteLine(x.Length);
            Console.WriteLine(x.ToUpper());
            Console.WriteLine(x.Contains("blue"));
            Console.WriteLine(x.IndexOf('u'));
            int y =  x.IndexOf('u');
            Console.WriteLine(x.Substring(y));
        }
    }
}
