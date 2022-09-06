using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bezao_technical
{
    public class Leapyear
    {
        public static void LeapYears()
        {
            // Define start year and counter
            int currentYear = 2022;
            int counter = 0;

            // limit counts to 20
            while(counter < 20)
            {
                currentYear++;
                // Check if year is multiple of 400, multiple of 4 and not multiple of 100
                if((currentYear % 400 == 0) || ((currentYear % 4 == 0) && (currentYear % 100 != 0)))
                {
                    Console.WriteLine(currentYear);
                    // Increment counter for subsequent program termination
                    counter++;
                }
            }
        }
    }
}
