using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] diff = input.Split(new char[] { ' ' });
            int a;           
            var nums = from x in diff
                       where int.TryParse(x, out a)
                       select x;
            for (int i = nums.Count() - 1; i > -1 ; i--)
                Console.Write(nums.ToList()[i] + " ");
            Console.ReadKey();
        }
    }
}
