using System;

namespace _13._13._2022_task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // - Verilmiş string dəyərində a hərfinin olub olmadığını qaytaran metod
            Console.WriteLine("sozu daxil edin");
            var word = Console.ReadLine();
            var resultword = Aletter(word);
            Console.WriteLine(resultword);
                
        }
        static string Aletter(string word)
        {
            bool hasA = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'A') 
                {
                    hasA = true;
                    break;
                }


            }
            if (hasA == true)
            {
                Console.WriteLine("A herfi var");
            }
            else
            {
                Console.WriteLine("A herfi yoxdur");
            }
            return word;
        }
    }
}
