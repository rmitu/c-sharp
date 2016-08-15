using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palidrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i, j,flag = 1;

            Console.WriteLine("enter any word");
            str = Console.ReadLine();

            for (i = 0, j = str.Length - 1; i != j ;i++,j-- )
            {
                if (str[i] == str[j])
                { 
                
                }
                else
                {
                    flag = 0;
                }
            }

            if( flag ==1 )
            {
                Console.WriteLine("word is palindrome");
            }
            else
            {
                Console.WriteLine("Word is not palindrom");
            }

            Console.ReadLine();
        }
    }
}