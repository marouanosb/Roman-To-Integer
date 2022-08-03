using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    public class RomanToInteger
    {

        static Dictionary<char, int> dc = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        
        public static int RomanToInt(string s)
        {
            int num = 0;
            s = s
                .Replace("IV", "IIII")
                .Replace("IX", "VIIII")
                .Replace("XL", "XXXX")
                .Replace("XC", "LXXXX")
                .Replace("CD", "CCCC")
                .Replace("CM", "DCCCC");
            foreach (char c in s)
            {
                num += dc[c];
            }
            return num;
        }

        static void Main(string[] agrs)
        {
            String roman;
            Console.Write("Imput : ");
            roman = Console.ReadLine();
            Console.WriteLine("Output : " + RomanToInt(roman.ToUpper()));
        }
    }
}
