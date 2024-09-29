using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Write your word");
            string word = Console.ReadLine();
            word = word.ToLower();
            word = Convert.ToString(word);
            int wordlength = word.Length;
            char wordone = word[0];
            word = word.Remove(0, 1);
            word = word + wordone + "ay";
            Console.WriteLine(word);
            Console.ReadKey();
        }
    }
}
