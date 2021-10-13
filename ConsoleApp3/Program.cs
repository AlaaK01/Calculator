//Calculator program
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            float n1 = 0;
            float n2 = 0;
            float n = 0;
            char ch = ' ';
            bool isTrue = true;

            while (isTrue)
            {
                Console.Write("Write the first number: ");
                string input = Console.ReadLine();
                if (float.TryParse(input, out n1))
                {
                    n = n1;
                    break;
                }
            }
            while (isTrue)
            {
                while (isTrue)
                {
                    Console.Write("Write the second number: ");
                    string input = Console.ReadLine();
                    if (float.TryParse(input, out n2)) break;
                }
                while (isTrue)
                {
                    Console.Write("Select one of these operation < + > , < - > , < * > , < / > : ");
                    string input = Console.ReadLine();
                    if (char.TryParse(input, out ch))
                        if (ch == '+' || ch == '-' || ch == '*' || ch == '/') break;
                }
                switch (ch)
                {
                    case ('+'):
                        {
                            n += n2;
                            break;
                        }
                    case ('-'):
                        {
                            n -= n2;
                            break;
                        }
                    case ('*'):
                        {
                            n *= n2;
                            break;
                        }
                    case ('/'):
                        {
                            if (n2 == 0) Console.WriteLine("you can not divide by zero");
                            else n /= n2;
                            break;
                        }
                }
                if (!((ch == '/') && (n2 == 0)))
                {
                    Console.WriteLine("-------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{n1} {ch} {n2} = {n}");
                    Console.ResetColor();
                }
                n1 = n;
                Console.WriteLine("-------------------------------------");
                Console.Write("To continu press any key\nTo exit press < x >\nTo start from the beginning Press < c > : ");
                string input1 = Console.ReadLine();
                if (input1 == "x") break;
                else if (input1 == "c") goto start;
            }
            Console.ReadLine();
        }
    }
}