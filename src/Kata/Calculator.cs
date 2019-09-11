using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s = "")
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;    
            }

            var strings = s.Split(",");
            if (strings.Length == 1)
            {
                return int.Parse(s);
            }
            int result = int.Parse(strings.First()) + int.Parse(strings.Last());

            return result;
        }
    }
}