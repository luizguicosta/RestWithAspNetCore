using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspNetCore.Utils
{
    public static class UtilsForNumbers
    {
        public static bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any
                                                                                , System.Globalization.NumberFormatInfo.InvariantInfo
                                                                                , out number);
            return isNumber;
        }
    }
}
