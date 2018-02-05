using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            try
            {
                int num, temp, rem, revers = 0;
                Console.WriteLine("Enter an integer");
                num = int.Parse(Console.ReadLine());
                temp = num;

                while (num > 0)
                {
                    rem = num % 10;
                    revers = revers * 10 + rem;
                    num = num / 10;

                }

                Console.WriteLine("Given number is={0}", temp);
                Console.WriteLine("its Reverseis ={0}", revers);

                if (temp == revers)
                {
                    Console.WriteLine("Is palindrome");
                }

                else
                {
                    Console.WriteLine("Not a palindrome");

                }

            }
            catch (System.FormatException)
            {
                Console.WriteLine("Only integers are allowed");
            }
        
            Console.ReadLine();
    

        }
    }
}
