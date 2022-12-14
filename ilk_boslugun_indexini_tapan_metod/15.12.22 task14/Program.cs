using System;

namespace _15._12._22_task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(bosluqolmayan(Console.ReadLine()));
        }
        ////Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod
        static int bosluqolmayan(string index)
        {
            for (int i = 0; i < index.Length; i++)
            {
                if (index[i] != ' ')
                    return i;
            }
            return -1;
        } 
}
}
