using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachki0704
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split().Select(int.Parse).ToArray();

            HashSet<int> seen = new HashSet<int>();

            foreach (int num in numbers)
            {
                seen.Add(num);
            }

            Console.WriteLine(string.Join(" ", seen));
        }
    }
}
