using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again)
            {
                //print whole numbers to n
                int i, sum = 0;
                Console.WriteLine("Pick a number, let's count to it.");
                int userInput = Int32.Parse(Console.ReadLine());
                for (i = 1; i <= userInput; i++)

                Console.Write(",{0} ", i);
                Console.ReadLine();
                Console.WriteLine("");

                //print whole numbers in reverse
                 Console.WriteLine("Pick a number, let's count from it.");
                 int reverseInput = Int32.Parse(Console.ReadLine());
                 for (i = reverseInput; i >= 1; i--)

                     Console.Write(",{0} ", i);
                     Console.ReadLine();

             //print all even numbers 1-100
             Console.WriteLine("Pick a number, let's count even numbers to 100.");
             int evenInput = Int32.Parse(Console.ReadLine());
             for (i = evenInput; i <= 100; i++)
                 if (i % 2 == 0)
                     Console.Write(",{0}", i);
                     Console.ReadLine();

                //print all odd numbers 1-100
                Console.WriteLine("Pick a number, let's count odd numbers to 100.");
                int oddInput = Int32.Parse(Console.ReadLine());
                for (i = oddInput; i <= 100; i++)
                    if (i % 2 != 0)
                        Console.Write(",{0}", i);
                        Console.ReadLine();

                //add all whole numbers
               
                Console.WriteLine("Pick a number, let's add them all up to it.");
                int sumInput = Int32.Parse(Console.ReadLine());
                for (i = 1; i <= sumInput; i++)
                {
                    sum = sum + i;
                    Console.Write(",{0}", i);
                }
                Console.WriteLine();
                Console.WriteLine("The sum is: {0}", sum);
                Console.ReadLine();
                {
                    Console.WriteLine("Enter a number: ");
                    i = Convert.ToInt32(Console.ReadLine());
                    int result;
                    result = i * 1;
                    Console.WriteLine("The table is: {0} x {1} = {2}", i, 1, result);
                    result = i * 2;
                    Console.WriteLine("            : {0} x {1} = {2}", i, 2, result);
                    result = i * 3;
                    Console.WriteLine("            : {0} x {1} = {2}", i, 3, result);
                    result = i * 4;
                    Console.WriteLine("            : {0} x {1} = {2}", i, 4, result);
                    result = i * 5;
                    Console.WriteLine("            : {0} x {1} = {2}", i, 5, result);
                    result = i * 6;
                    Console.WriteLine("            : {0} x {1} = {2}", i, 6, result);
                    result = i * 7;
                    Console.WriteLine("            : {0} x {1} = {2}", i, 7, result);
                    result = i * 8;
                    Console.WriteLine("            : {0} x {1} = {2}", i, 8, result);
                    result = i * 9;
                    Console.WriteLine("            : {0} x {1} = {2}", i, 9, result);
                    result = i * 10;
                    Console.WriteLine("            : {0} x {1} = {2}", i, 10, result);
                }
                    Console.WriteLine("Play again? Enter (y)es or (n)o");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "n")
                    {
                        again = false;
                    }
            }
        }
    }
}
