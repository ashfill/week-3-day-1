using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3_day_1
{
  public static class bool2
    {
       public static string returnThe(this bool random)
        {
            if(random == false)
            {
                return "the";
            }
            else
            {
                return "Not the";
            }
        }
    }
}
