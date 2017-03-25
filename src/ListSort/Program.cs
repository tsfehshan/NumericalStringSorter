using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ListSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> str = new List<string> { "1", "2", "5", "10", "3", "4", "BBB", "AAA", "1A" , "2BV" };
            Func<string, int> intParser = input =>
            {
                int result;
                if (!int.TryParse(input, out result))
                    return int.MaxValue;

                return result;
            };

            var query = str.OrderBy(s=>s).OrderBy(c => intParser(c));
        }
    }
}
