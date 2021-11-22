using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demo.Interfaces;

namespace Demo.Classes
{
    public class CountVowels : ICountVowels
    {
        public int CalCulateVowels(string fullName)
        {
            int vowelCounter = 0;

            if (fullName != null)
            {
                var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
                foreach (char c in fullName.ToLower())
                {
                    if (vowels.Contains(c))
                    {
                        vowelCounter++;
                    }
                }
            }

            return vowelCounter;
        }
    }
}