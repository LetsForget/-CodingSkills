using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thirdt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(new char[] { ' ' });
            string[] arr2 = Console.ReadLine().Split(new char[] { ' ' });

            for (int i = 0; i < arr2.Length; i++)
            {
                int quan = 0;
                for (int j = 0; j < arr1.Length; j++)
                    if (arr2[i].Contains(arr1[j]))
                        quan++;
                Console.WriteLine(quan);
            }
            Console.ReadKey();
        }
    }
}
