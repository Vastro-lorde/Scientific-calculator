using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Scientific_calculator
{
    public static class Validate
    {
        public static bool binaryValidation(string firstInput, string secondInput)
        {
            bool success = int.TryParse(firstInput, out _);
            bool success2 = int.TryParse(secondInput, out _);

            if (success && success2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool singleValidation(string firstInput)
        {
            bool success = int.TryParse(firstInput, out _);
            if (success)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
