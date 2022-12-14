using System;

namespace task_14._12._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // - Verilmiş ədədin verilmiş qüvvətini tapan metod

            Console.WriteLine("ededi daxil edin");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2= Convert.ToInt32(Console.ReadLine());
            var resultquvvet = quvvet(num1, num2);
            Console.WriteLine(resultquvvet);

            

        }
        static int quvvet( int num1,int num2 )
        {
            var quvvet = 1;
            for(int i=0; i<num2; i++)
            {
                quvvet *= num1;
            }
            return quvvet;
           
        }
    }
}
