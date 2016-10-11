using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3_day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "I ran over my neighbors bike with my car";
            int wordCount = string1.Wordcount();
            Console.WriteLine(wordCount);

            int num = 7.SubtractByEight();
            Console.WriteLine(num);

            double number = (50.2).AddSixPointTwo();
            Console.WriteLine(number);

            bool answer = false;
            Console.WriteLine(answer.returnThe());

            char twoover = 'h';
            Console.WriteLine(twoover.H);

            Console.ReadLine();
        }
    }
}
