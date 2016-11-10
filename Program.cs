using CodingDojo.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("{0} -> {1}", 4888, ArabicRoman.ArabicToRoman(4888)));
            Console.WriteLine(String.Format("{0} -> {1}", 1515, ArabicRoman.ArabicToRoman(1515)));
            Console.WriteLine(String.Format("{0} -> {1}", 2002, ArabicRoman.ArabicToRoman(2002)));
            Console.WriteLine(String.Format("{0} -> {1}", 1030, ArabicRoman.ArabicToRoman(1030)));
            Console.WriteLine(String.Format("{0} -> {1}", 900, ArabicRoman.ArabicToRoman(900)));
            Console.WriteLine(String.Format("{0} -> {1}", 666, ArabicRoman.ArabicToRoman(666)));
            Console.WriteLine(String.Format("{0} -> {1}", 509, ArabicRoman.ArabicToRoman(509)));
            Console.WriteLine(String.Format("{0} -> {1}", 15, ArabicRoman.ArabicToRoman(15)));
            Console.WriteLine(String.Format("{0} -> {1}", 14, ArabicRoman.ArabicToRoman(14)));
            Console.WriteLine(String.Format("{0} -> {1}", 13, ArabicRoman.ArabicToRoman(13)));
            Console.WriteLine(String.Format("{0} -> {1}", 12, ArabicRoman.ArabicToRoman(12)));
            Console.WriteLine(String.Format("{0} -> {1}", 11, ArabicRoman.ArabicToRoman(11)));

            Console.WriteLine();
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(String.Format("{0} -> {1}", i, ArabicRoman.ArabicToRoman(i)));
            }           

            Console.ReadLine();
        }

        
    }
}
