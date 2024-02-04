using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    public static class SentenceExtension
    {
        public static void SentenceToSplit(this string sentence)
        {
            string[] split = sentence.Split(' ');

            foreach (var item in split)
            {
                Console.WriteLine(item);
            }

        }
    }
}
