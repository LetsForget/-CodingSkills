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
            int shift = int.Parse(Console.ReadLine());
            string[] div = Console.ReadLine().Split(new char[] { ' ' });
            string[] result = new string[div.Length];
            
            for (int i = 0; i < result.Length; i++)
                result[i] = div[(i + shift) % div.Length];

            Console.Write(string.Join(" ", result));
            Console.ReadKey();
        }
    }
}
