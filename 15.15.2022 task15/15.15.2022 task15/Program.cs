using System;

namespace _15._15._2022_task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Bosluq(Console.ReadLine()));
        }
        //Verilmiş yazıdaki son boşluq olmayan index-i qaytaran metod

        static int Bosluq (string word)
        {
            
            for (int i = 0; i < word.Length; i++)
            {
                int last = word.Length-1;
                if (word[i] != ' ')
                {
                    
                    return last;
                }
                return -1;

            }
        }

    }
}
