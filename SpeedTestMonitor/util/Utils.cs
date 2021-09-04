using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTestMonitor.util
{
    class Utils
    {

        public static String valueInTwoSpaces(int value)
        {
            if (value < 10)
            {
                return "0" + value;
            }

            return value+"";
        }

        internal static int removeNegative(int value)
        {
            if (value < 0)
            {
                value *= -1;
            }

            return value;
        }
    }
}
