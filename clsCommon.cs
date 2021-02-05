using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class clsCommon
    {
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
        public static byte[] AscB(string strInput)
        {            
            return Encoding.ASCII.GetBytes(strInput);
        }
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
        public static string Left(string strInput, int length)
        {
            if (string.IsNullOrEmpty(strInput))
            {
                return string.Empty;
            }
            return strInput.Substring(length);
        }
        public static string Mid(string strInput, int index, int length)
        {
            if (string.IsNullOrEmpty(strInput))
            {
                return string.Empty;
            }
            return strInput.Substring(index, length);
        }
        public static string Right(string strInput, int length)
        {
            if (string.IsNullOrEmpty(strInput))
            {
                return string.Empty;
            }
            return strInput.Substring(strInput.Length - length);
        }
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
