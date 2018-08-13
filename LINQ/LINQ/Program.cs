using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static List<int> IncrementAll(List<int> numbers)
        {
            var returnValue = numbers.Select(x => x + 1);
            return returnValue.ToList();
        }

        public static int[] GetWhereDivisableBy(List<int> numbers, int divider)
        {
            var divisableNumbers = numbers.Where(x => x % divider == 0);
            return divisableNumbers.ToArray();
        }
    }
}
