using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain_Combinations
{
    class DomainCombinations
    {
        const int charactersCount = 26;
        const int length = 4;
        const string domainTld = ".com";

        // generate english alphabet
        static char[] alphabet = Enumerable.Range(97, 26).Select(l => (char)l).ToArray();

        static int[] arr = new int[length];

        static HashSet<string> combinations = new HashSet<string>();

        static void Main()
        {
            Generate(0);
        }

        static void Generate(int index)
        {
            if (index >= length)
            {
                Save();
            }
            else
            {
                for (int i = 0; i < charactersCount; i++)
                {
                    arr[index] = i;
                    Generate(index + 1);
                }
            }
        }

        static void Save()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append((char)alphabet[arr[i]]);
            }

            sb.Append(domainTld);

            combinations.Add(sb.ToString());
        }
    }
}
