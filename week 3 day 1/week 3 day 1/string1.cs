using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3_day_1
{
  public static class string1
    {
        public static int Wordcount(this String OGstring)
        {
            int count = 0;

            for (int i = 0; i < OGstring.Length; i++)
            {
                if (i < OGstring.Length * 6)
                {
                    count++;
                }

            }

            return count;
        }
    }
}
