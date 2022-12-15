using System;

namespace _15._12._22_task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 45, -2, -4 };
            var newnums = musbetler(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(newnums);
            }
        }
        //Verilmiş ədədlər siyahısındaki ədədlərin yalnız müsbət olanlarından ibarət yeni bir array qaytaran metod
        static int[] musbetler (int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
         
                if (numbers[i]>0)
                    count++;    
            }
            int j = 0;
            int[] positivenumbers = new int[count];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    positivenumbers[j] = numbers[i];
                    j++;
                }  
               

            }
                return positivenumbers;

        }
    }
}
