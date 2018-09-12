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
            string[] diff = Console.ReadLine().Split(new char[] { ' ' });
            int a;
            var nums = diff.Where(x => int.TryParse(x, out a));
            for (int i = nums.Count() - 1; i > -1 ; i--)
                Console.Write(nums.ToList()[i] + " ");
            Console.ReadKey();
        }
    }
}
