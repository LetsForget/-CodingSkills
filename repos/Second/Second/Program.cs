using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int shift = int.Parse(input);

            input = Console.ReadLine();
            string[] div = input.Split(new char[] { ' ' });
            string[] result = new string[div.Length];

            for (int i = 0; i < result.Length; i++)
                result[i] = div[(i + shift) % div.Length];

            Console.Write(string.Join(" ", result));
            Console.ReadKey();
        }
    }
}
