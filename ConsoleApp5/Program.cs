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
            // converts string to lowercase
            char wordone = word[0];
            // stores the first letter of the word as a variable
            word = word.Remove(0, 1);
            // removes the first char of the string
            word = word + wordone + "ay";
            // adds the first character of the string to the end of the string and adds the suffix "ay" to it 
            Console.WriteLine(word);
            // displays the new pig latin translated 
            Console.ReadKey();
            // waits for a key to be pressed to close the console
        }
    }
}
