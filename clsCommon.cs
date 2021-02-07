using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class clsCommon
    {
        /// <summary>
        /// The MidB function is used with byte data held within a string. 
        /// </summary>
        /// <param name="strInput">The string that you wish to extract from.</param>
        /// <param name="index">The starting position of the substring.</param>
        /// <param name="length">The length of the substring.</param>
        /// <returns>Byte data contained in a string</returns>
        /// Create : 2021/02/05
        public static string MidB(string strInput, int index, int length) 
        {
            if (string.IsNullOrEmpty(strInput))
            {
                return string.Empty;
            }
            strInput = strInput.Substring(index, length);
            var bytes = Encoding.GetEncoding("SJIS").GetBytes(strInput);
            byte[] byteArr = new byte[length];
            Array.Copy(bytes, byteArr, length);
            strInput = Encoding.GetEncoding("SJIS").GetString(byteArr);
            return strInput;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strInput">The string that you wish to extract from.</param>
        /// <returns></returns>
        public static byte[] AscB(string strInput)
        {            
            return Encoding.ASCII.GetBytes(strInput);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strInput">The string that you wish to extract from.</param>
        /// <param name="length">The length of the substring.</param>
        /// <returns>Byte data contained in a string</returns>
        /// Create : 2021/02/05
        public static string LeftB(string strInput, int length)
        {
            if (string.IsNullOrEmpty(strInput))
            {
                return string.Empty;
            }
            var bytes = Encoding.GetEncoding("SJIS").GetBytes(strInput);
            byte[] byteArr = new byte[length];
            Array.Copy(bytes, byteArr, length);
            strInput = Encoding.GetEncoding("SJIS").GetString(byteArr);
            return strInput;
        }

        /// <summary>
        /// The LEFT function allows you to extract a substring from a string, starting from the left-most character.
        /// </summary>
        /// <param name="strInput">The string that you wish to extract from.</param>
        /// <param name="length">The length of the substring.</param>
        /// <returns>A string/text value</returns>
        /// Create : 2021/02/05
        public static string Left(string strInput, int length)
        {
            if (string.IsNullOrEmpty(strInput))
            {
                return string.Empty;
            }
            return strInput.Substring(length);
        }

        /// <summary>
        /// The MID function extracts a substring from a string (starting at any position).
        /// </summary>
        /// <param name="strInput">The string that you wish to extract from.</param>
        /// <param name="index">The starting position of the substring.</param>
        /// <param name="length">The length of the substring.</param>
        /// <returns>A string/text value</returns>
        /// Create : 2021/02/05
        public static string Mid(string strInput, int index, int length)
        {
            if (string.IsNullOrEmpty(strInput))
            {
                return string.Empty;
            }
            return strInput.Substring(index, length);
        }

        /// <summary>
        /// The RIGHT function extracts a substring from a string starting from the right-most character.
        /// </summary>
        /// <param name="strInput">The string that you wish to extract from.</param>
        /// <param name="length">The length of the substring.</param>
        /// <returns>A string/text value</returns>
        public static string Right(string strInput, int length)
        {
            if (string.IsNullOrEmpty(strInput))
            {
                return string.Empty;
            }
            return strInput.Substring(strInput.Length - length);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <returns>Created number </returns>
        public static string Space(int count)
        {
            string space = "";
            if (count > 1)
            {
                for (int i = 1; i <= count; i++)
                {
                    space = space.PadRight(i);
                }
            }
            return space;
        }

        /// <summary>
        /// Is the string a number ? 
        /// true : number
        /// false : not number
        /// </summary>
        /// <param name="strInput">The string that you wish to extract from.</param>
        /// <returns>Is the string a number</returns>
        /// Create : 2021/02/05
        public static bool IsNumber(string strInput)
        {
            bool result = true;
            for (int i = 0; i <= strInput.Length - 1; i++)
            {
                result = Char.IsNumber(strInput, i);
            }
            return result;
        }
    }
}
