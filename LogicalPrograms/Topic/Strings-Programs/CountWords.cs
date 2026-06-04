using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogicalPrograms.Topic.Strings_Programs
{
    public class CountWords
    {
        /*
         * Problem Statement
         * Given a string, count the total number of words present in it.
         * Examples
         * Input  : "Hello World"
         * Output : 2
         * 
         * Input  : "I am a .NET Developer"
         * Output : 5
         * 
         * Input  : "   Hello    World   "
         * Output : 2
         */


        /// <summary>
        /// Approach: String Concatenation
        /// Time: O(n)
        /// Space: O(n)
        /// Interview Rating: ⭐⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int CountWordsUsingSplit(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                return str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            }
            return 0;
        }


        /// <summary>
        /// Approach: String Concatenation
        /// Time: O(n)
        /// Space: O(n)
        /// Interview Rating: ⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int CountWordsUsingRegex(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                return Regex.Matches(str, @"\b\w+\b").Count;
            }
            return 0;
        }


        /// <summary>
        /// Approach: Manual Loop
        /// Time: O(n)
        /// Space: O(1)
        /// Interview Rating: ⭐⭐⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int CountWordsUsingLoop(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;
            int count = 0;
            bool isWord = false;

            foreach (char ch in str)
            {
                if (!char.IsWhiteSpace(ch))
                {
                    if (!isWord)
                    {
                        count++;
                        isWord = true;
                    }
                }
                else
                {
                    isWord = false;
                }
            }

            return count;
        }

        /// <summary>
        /// Approach: Char Array
        /// Time: O(n)
        /// Space: O(n)
        /// Interview Rating: ⭐⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int CountWordsUsingCharArray(string str)
        {
            if(!string.IsNullOrWhiteSpace(str))
            {
                int count = 0;
                char[] chars= str.ToCharArray();
                bool isWord = false;
                foreach (char ch in chars)
                {
                    if (!char.IsWhiteSpace(ch))
                    {
                        if (!isWord)
                        {
                            count++;
                            isWord = true;
                        }
                    }
                    else
                    {
                        isWord = false;
                    }
                }
                return count;
            }
            return 0;
        }

        /// <summary>
        /// Approach: StringReader
        /// Time: O(n)
        /// Space: O(n)
        /// Interview Rating: ⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int CountWordsUsingStringReader(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                int count = 0;

                using StringReader reader=new StringReader(str);
                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    count += line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
                }

                return count;
            }
            return 0;
        }


    }
}
