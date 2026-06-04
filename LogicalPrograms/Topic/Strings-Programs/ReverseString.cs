using System.Text;

namespace LogicalPrograms.Topic.Strings_Programs
{
    public class ReverseString
    {
        /*
         * Input  : "Sonu"
         * Output : "unoS"
         * 
         * Input  : "Hello World"
         * Output : "dlroW olleH"
         */


        /// <summary>
        /// Approach: String Concatenation
        /// Time: O(n²)
        /// Space: O(n)
        /// Interview Rating: ⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ReverseStringUsingLoop(string str)
        {
            string result = "";
            if (!string.IsNullOrEmpty(str))
            {
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    result += str[i];
                }
                return result;
            }
            return string.Empty;
        }


        /// <summary>
        /// Approach: StringBuilder
        /// Time: O(n)
        /// Space: O(n)
        /// Interview Rating: ⭐⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ReverseStringUsingStringBuilder(string str)
        {
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(str))
            {
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    sb.Append(str[i]);
                }
                return sb.ToString();
            }
            return string.Empty;
        }

        /// <summary>
        /// Approach: Character Array
        /// Time: O(n)
        /// Space: O(n)
        /// Interview Rating: ⭐⭐⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ReverserStringUsingCharacterArray(string str)
        {

            if (!string.IsNullOrWhiteSpace(str))
            {
                char[] chars = str.ToCharArray();
                int lPointer = 0;
                int rPointer = str.Length - 1;
                while (lPointer < rPointer)
                {
                    char temp = chars[lPointer];
                    chars[lPointer] = chars[rPointer];
                    chars[rPointer] = temp;
                    lPointer++;
                    rPointer--;
                }
                return new string(chars);
            }

            return str;
        }

        /// <summary>
        /// Approach: LINQ
        /// Time: O(n)
        /// Space: O(n)
        /// Interview Rating: ⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ReverserStringUsingLinQ(string str)
        {
            var revStr = new string(str.Reverse().ToArray());
            return revStr;
        }

        /// <summary>
        /// Approach: Recursion
        /// Time: O(n²)
        /// Space: O(n)
        /// Interview Rating: ⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ReverserStringUsingRecursion(string str)
        {
            if (str.Length < 1)
                return str;
            return ReverserStringUsingRecursion(str.Substring(1)) + str[0];
        }

        /// <summary>
        /// Approach: Recursion
        /// Time: O(n)
        /// Space: O(n)
        /// Interview Rating: ⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ReverserStringUsingStack(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                Stack<char> stack = new Stack<char>();
                StringBuilder sb = new StringBuilder();
                foreach (char c in str)
                {
                    stack.Push(c);
                }

                while (stack.Count > 0)
                {
                    sb.Append(stack.Pop());
                }

                return sb.ToString();
            }
            return str;
        }

        /// <summary>
        /// Approach: Character Array
        /// Time: O(n)
        /// Space: O(n)
        /// Interview Rating: ⭐⭐⭐⭐⭐
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ReverserStringUsingStackBestOptimal(string str)
        {
            char[] chars = str.ToCharArray();
            int lPointer = 0;
            int rPointer = chars.Length - 1;
            while (lPointer < rPointer)
            {
                (chars[lPointer], chars[rPointer]) = (chars[rPointer], chars[lPointer]);
                lPointer++;
                rPointer--;
            }

            return new string(chars);
        }
    }
}
