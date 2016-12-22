using System;

namespace DailyChallenge286 {
    class Program {
        static void Main()
        {
            Console.WriteLine("120 = " + ReverseFactorial(120));
            Console.WriteLine("150 = " + ReverseFactorial(150));
            Console.WriteLine("3628800 = " + ReverseFactorial(3628800));
            Console.WriteLine("479001600 = " + ReverseFactorial(479001600));
            Console.WriteLine("6 = " + ReverseFactorial(6));
            Console.WriteLine("18 = " + ReverseFactorial(18));

            Console.ReadLine();
        }

        static string ReverseFactorial(int input)
        {
            double a = input;
            int i = 2;

            while (a > 1) {
                a = (a / i);
                if (a.Equals(1)) return i.ToString() + "!";
                i++;                
            }
            return "NONE";            
        }
    }
}
