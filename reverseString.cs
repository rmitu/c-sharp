using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Mitu Rumy";

            Console.WriteLine(reverse(str));
            Console.ReadLine();
        }

        private static string reverse( string str)
        {
            char[] chars = str.ToCharArray();
            int j = chars.Length - 1;
            for (int i = 0; i < chars.Length / 2; i++ )
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
                j--;
            }
            return new String(chars);
        }
    }
}
