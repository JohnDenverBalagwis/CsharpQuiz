using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();
            Grade();
            TrueOrFalse();
        }
        static void Calculator()
        {
            int num1, num2, num3;
            Console.WriteLine("\n=========================================");
            Console.WriteLine("\tSUM");
            Console.WriteLine("=========================================");
            Console.Write("Enter Number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 3: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nTHE SUM IS : " + (num1 + num2 + num3));
            Console.WriteLine("=========================================\n");
        }
        static void Grade()
        {
            decimal grade1, grade2, grade3, grade4;
            Console.WriteLine("\n=========================================");
            Console.WriteLine("\tGRADE AVERAGE");
            Console.WriteLine("=========================================");
            Console.Write("Enter grade in programming: ");
            grade1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter grade in networking: ");
            grade2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter grade in Philippine history: ");
            grade3 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter grade in life of rizal: ");
            grade4 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("=========================================");
            Console.WriteLine("THE Average IS : " + ((grade1 + grade2 + grade3 + grade4)/4));
        }
        static void TrueOrFalse()
        {
            int a, b;
            Console.WriteLine("\n=========================================");
            Console.WriteLine("\tTRUE OR FALSE");
            Console.WriteLine("=========================================");
            Console.Write("Enter Number 1: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=========================================");
            if (a == b)
            {
                Console.WriteLine("OUTPUT: True");
            }
            else
            {
                Console.WriteLine("OUTPUT: False");
            }

            Console.Write("\nWANT TO ENTER AGAIN [Y/N]? ");
            string option = Console.ReadLine();

            if (option == "y" || option == "Y")
            {
                Calculator();
            }
            else
            {
                Console.WriteLine("THANK YOU FOR USING THIS PROGRAM, BYE...");
                Console.ReadLine();
            }
        }
    }
}
