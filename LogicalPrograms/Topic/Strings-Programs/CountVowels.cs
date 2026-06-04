using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms.Topic.Strings_Programs
{
    public class CountVowels
    {

        /*
         * Vowels: a, e, i, o, u AND A, E, I, O, U
         * 
         * Input  : "Sonu"
         * Output : 2
         * Explanation: o, u = 2 vowels
         * 
         * Input  : "Hello World"
         * Output : 3
         * 
         * Explanation:e, o, o = 3 vowels
         */

        /// <summary>
        /// Approach: If Condition
        /// Time: O(n)
        /// Space: O(1)
        /// Interview Rating: ⭐⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int CountVowelsUsingIf(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                int count = 0;
                foreach (char c in str)
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                        c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U'
                        )
                    {
                        count++;
                    }
                }

                return count;
            }
            return 0;
        }


        /// <summary>
        /// Approach: Lowercase Conversion
        /// Time: O(n)
        /// Space: O(n)
        /// Interview Rating: ⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int CountVowelsUsingLowerCase(string str)
        {
            int count = 0;
            str = str.ToLowerInvariant();

            foreach (char c in str)
            {
                if (c == 'a' || c == 'e' || c == 'o' || c == 'u')
                {
                    count++;
                }
            }
            return count;
        }


        /// <summary>
        /// Approach: Contains()
        /// Time: O(n)
        /// Space: O(1)
        /// Interview Rating: ⭐⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int CountVowelsUsingContains(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                int count = 0;
                string vowels = "aeiouAEIOU";
                foreach (char c in str)
                {
                    if (vowels.Contains(c))
                    {
                        count++;
                    }
                }
                return count;
            }
            return 0;
        }


        /// <summary>
        /// Approach: HashSet
        /// Time: O(n)
        /// Space: O(1)
        /// Interview Rating: ⭐⭐⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int CountVowelsUsingHashSet(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                HashSet<char> vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u',
                                                             'A', 'E', 'I', 'O', 'U'
                                                           };
                int count = 0;
                foreach (char c in str)
                {
                    if (vowels.Contains(c))
                    {
                        count++;
                    }
                }
                return count;
            }
            return 0;
        }


        /// <summary>
        /// Approach: HashSet
        /// Time: O(n)
        /// Space: O(1)
        /// Interview Rating: ⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int CountVowelsUsingLinq(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                return str.Count(x => "aeiouAEIOU".Contains(x));
            }
            return 0;
        }

        /// <summary>
        /// Approach: Switch
        /// Time: O(n)
        /// Space: O(1)
        /// Interview Rating: ⭐⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int CountVowelsUsingSwitch(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                int count = 0;
                foreach (char ch in str)
                {
                    switch (ch)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                            count++;
                            break;
                    }
                }
            }
            return 0;
        }
    }
}
