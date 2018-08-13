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

        public static bool AnyCapitals(string word)
        {
            var capitalLetters = word.Any(x => char.IsUpper(x));
            return capitalLetters;
        }

        public static bool AllCapitals(string word)
        {
            var capitalLetters = word.All(x => char.IsUpper(x));
            return capitalLetters;
        }

        public static int NumPairs(Dictionary<int, string> dict)
        {
            var pairCount = dict.Count;
            return pairCount;
        }
        public static int NumPairsWithKeyValue(Dictionary<int, string> dict, int x, int y)
        {
            var pairCount = dict.Where(el => el.Key > x && el.Value.Length < y).Count();
            return pairCount;
        }
        public static List<double> GetDistinctWithValue(List<double> numbers, int x)
        {
            var uniqueValues = numbers.Where(num => num < x).Distinct();
            return uniqueValues.ToList();
        }
    }
}
