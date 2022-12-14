using System;

namespace _13._13._2022_task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş 4 ədədin ortalamasını tapıq qaytaran metod
            Console.WriteLine("ededleri daxil edin");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            var resultorta = edediorta(num1, num2, num3, num4);
            Console.WriteLine(resultorta);

        }
        static int edediorta(int num1, int num2, int num3, int num4)
        {
            int sum = num1 + num2 + num3 + num4; 
            int count = 4;
            int ededorta = sum / count;
            return ededorta;
            
            
            
            
               
                
            


        }
    }
}
