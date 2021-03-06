using System.Collections.Generic;

namespace SimpleStackBenchmark.Implemenations.StringIsNumber
{
    public static class StringIsNumber
    {
        private readonly static HashSet<char> numbers = new HashSet<char> {'0','1','2','3','4','5','6','7','8','9'};
        private readonly static List<char> numbersList = new List<char> {'0','1','2','3','4','5','6','7','8','9'};
        
        public static bool IsNumberHashSet(string text)
        {
            foreach(char character in text.ToCharArray())
            {
                if(!numbers.Contains(character))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsNumberList(string text)
        {
            foreach(char character in text.ToCharArray())
            {
                if(!numbersList.Contains(character))
                {
                    return false;
                }
            }
            return true;
        }
    }
}