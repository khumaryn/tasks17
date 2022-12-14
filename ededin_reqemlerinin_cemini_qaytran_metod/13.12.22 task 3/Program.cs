using System;
using System.Diagnostics.CodeAnalysis;

namespace _13._12._22_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // - Verilmiş ədədin rəqəmləri cəmini qaytaran metod
            Console.WriteLine("ededi daxil edin");

            int num = Convert.ToInt32(Console.ReadLine());

            var result = Reqemcem(num);
            Console.WriteLine(result);

        }


        static int Reqemcem ( int num )
        {
            var sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = (num - num % 10) / 10;

            }
            return sum;
            
            


        }








    }

}    

