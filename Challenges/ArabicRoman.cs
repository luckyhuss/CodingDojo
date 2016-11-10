using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo.Challenges
{
    /// <summary>
    /// First Coding DOJO
    /// 03/11/16 ; 10/11/16
    /// </summary>
    class ArabicRoman
    {
        /// <summary>
        /// Convert Arabic to Roman numbers
        /// </summary>
        /// <param name="number">Arabic number</param>
        /// <returns>Roman number</returns>
        public static string ArabicToRoman(int number)
        {
            if ((number < 0) || (number > 4999)) throw new ArgumentOutOfRangeException("Value should be b/w 1 and 4999");

            if (number >= 1000) return String.Format("M{0}", ArabicToRoman(number - 1000));
            if (number >= 900) return String.Format("CM{0}", ArabicToRoman(number - 900));
            if (number >= 500) return String.Format("D{0}", ArabicToRoman(number - 500));
            if (number >= 400) return String.Format("CD{0}", ArabicToRoman(number - 400));
            if (number >= 100) return String.Format("C{0}", ArabicToRoman(number - 100));
            if (number >= 90) return String.Format("XC{0}", ArabicToRoman(number - 90));
            if (number >= 50) return String.Format("L{0}", ArabicToRoman(number - 50));
            if (number >= 40) return String.Format("XL{0}", ArabicToRoman(number - 40));
            if (number >= 10) return String.Format("X{0}", ArabicToRoman(number - 10));
            if (number >= 9) return String.Format("IX{0}", ArabicToRoman(number - 9));
            if (number >= 5) return String.Format("V{0}", ArabicToRoman(number - 5));
            if (number >= 4) return String.Format("IV{0}", ArabicToRoman(number - 4));
            if (number >= 1) return String.Format("I{0}", ArabicToRoman(number - 1));
            if (number == 0) return string.Empty;

            throw new ArgumentOutOfRangeException("Please check your input value");
        }
    }
}
