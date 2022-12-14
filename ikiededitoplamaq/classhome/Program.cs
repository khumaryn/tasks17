using System;

namespace classhome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod 
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            var sumcemleri = numberssum(num1, num2);
            Console.WriteLine(sumcemleri);

        }
        static int numberssum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
