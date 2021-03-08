using System;

namespace CodingChallenge.ReversingString
{
    public class StringUtilities
    {
        public static string Reverse(string s)
        {
            var arrayChar = s.ToCharArray();
            var endChar = arrayChar.Length - 1;
            for (int startChar = 0; startChar <= endChar; startChar++)
            {
                var temp = arrayChar[startChar];
                arrayChar[startChar] = arrayChar[endChar];
                arrayChar[endChar] = temp;
                endChar--;
            }
            return new string(arrayChar);
        }
    }
}
