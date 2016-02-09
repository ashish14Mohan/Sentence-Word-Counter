using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_Word_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your sentence");
            string inputsentence = Console.ReadLine();
            //inputsentence = "This is good to see you , good to know you";
            string output = Sentence_Word_Counter_BAL.Sentence_Word_Counter.SentenceWordWithCount(inputsentence);
            Console.WriteLine("Count of words" + output);
            Console.ReadLine();
        }
    }
}
