using System;
using System.Collections.Generic;

namespace Permutation
{
    public static class Permutation
    {
        public static bool IsPermutationString(string str1, string str2)
        {
            if (str1 == null || str2 == null)
            {
                throw new NullReferenceException();
            }
            
            if (str1.Length != str2.Length)
            {
                return false;
            }
            
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (var symbol in str1)
            {
                if (dictionary.ContainsKey(symbol))
                {
                    dictionary[symbol]++;
                }
                else
                {
                    dictionary[symbol] = 1;
                }
            }

            foreach (var symbol in str2)
            {
                if (dictionary.ContainsKey(symbol))
                {
                    dictionary[symbol]--;

                    if (dictionary[symbol] < 0)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}