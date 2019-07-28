using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "this forbidden mess of an age rating 0127504740";
            List<int> digit = new List<int>();
            List<string> nonDigit = new List<string>();
            List<int> skip = new List<int>();
            List<int> take = new List<int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digit.Add(int.Parse(text[i].ToString()));
                }
                else
                {
                    nonDigit.Add(text[i].ToString());
                }
            }
            for (int i = 0; i < digit.Count; i++)
            {
                if (i % 2 == 0)
                {
                    take.Add(digit[i]);
                }
                else
                {
                    skip.Add(digit[i]);
                }
            }
            List<string> result = new List<string>();

            for (int i = 0; i < take.Count; i++)
            {
                nonDigit.Take(take[i]).Skip(skip[i]);
            }
            

        }
    }
}
