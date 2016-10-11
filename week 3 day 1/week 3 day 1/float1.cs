using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3_day_1
{
    public static class float1
    {
        public static double subtract(this float car)
        {
            Console.WriteLine("please enter a number you would like subtracted");
            string z = Console.ReadLine();

            return car - (Convert.ToDouble(z));
        }
    }
}
