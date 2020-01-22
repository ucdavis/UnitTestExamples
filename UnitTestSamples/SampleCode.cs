using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSamples
{
    public static class SampleCode
    {
        public static string Reverse(string value)
        {
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string ReverseWords(string str)
        {
            int i;
            StringBuilder reverseSentence = new StringBuilder();


            int Start = str.Length - 1;
            int End = str.Length; 

            while (Start > 0)
            {
                if (str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverseSentence.Append(str[i]);
                        i++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }

            for (i = 0; i <= End; i++)
            {
                reverseSentence.Append(str[i]);
            }

            return reverseSentence.ToString();
        }

        public static async Task<bool> Example1()
        {

            return await Task.FromResult(false);
        }

        public static async Task<bool> Example2()
        {
    
            throw new Exception("Bah");
            return await Task.FromResult(true);
        }
    }
}
