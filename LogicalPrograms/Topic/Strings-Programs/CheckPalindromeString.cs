using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms.Topic.Strings_Programs
{
    public class CheckPalindromeString
    {
        /// <summary>
        /// Approach: String Concatenation
        /// Time: O(n²)
        /// Space: O(n)
        /// Interview Rating: ⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool IsCheckPalindromeStringUsingReverseStringCompare(string str)
        {
            string strReverseString = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                strReverseString += str[i];
            }
            return str == strReverseString;
        }


        /// <summary>
        /// Approach: StringBuilder
        /// Time: O(n)
        /// Space: O(n)
        /// Interview Rating: ⭐⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool IsCheckPalindromeStringUsingStringBuilder(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            StringBuilder strReverseStringBuilder = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                strReverseStringBuilder.Append(str[i]);
            }
            return str == strReverseStringBuilder.ToString();
        }


        // <summary>
        /// Approach: Character Array
        /// Time: O(n)
        /// Space: O(n)
        /// Interview Rating: ⭐⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool IsPalindromeUsingCharArray(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            char[] chars = str.ToCharArray();
            int lPointer = 0;
            int rPointer = chars.Length - 1;

            while (lPointer < rPointer)
            {
                (chars[lPointer], chars[rPointer]) = (chars[rPointer], chars[lPointer]);
                lPointer++;
                rPointer--;
            }
            return str == new string(chars);
        }


        // <summary>
        /// Approach: LINQ
        /// Time: O(n)
        /// Space: O(n)
        /// Interview Rating: ⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool IsPalindromeUsingLinq(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            string strRev = new string(str.Reverse().ToArray());
            return str == strRev;
        }

        // <summary>
        /// Approach: Recursion
        /// Time: O(n²)
        /// Space: O(n)
        /// Interview Rating: ⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool IsPalindromeUsingRecursion(string str)
        {
            if (str.Length <= 1)
                return true;

            if (str[0] != str[str.Length - 1])
                return false;

            return IsPalindromeUsingRecursion(
            str.Substring(1, str.Length - 2));
        }

        // <summary>
        /// Approach: Two Pointer
        /// Time: O(n)
        /// Space: O(1)
        /// Interview Rating: ⭐⭐⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool IsPalindromeUsingTwoPointers(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            int lPointer = 0;
            int rPointer = str.Length - 1;
            while (lPointer < rPointer)
            {
                if (str[lPointer] != str[rPointer])
                {
                    return false;
                }
                lPointer++;
                rPointer--;
            }
            return true;
        }
    }
}
