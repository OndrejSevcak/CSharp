using System;
using System.Collections.Generic;
using System.Text;

namespace StringsAndEncoding
{
    public static class StringExtensionMethods
    {
        public static string[] CopyByIndexRange(this string[] array, int startIndex, int endIndex)
        {
            string[] newArray = new string[(endIndex - startIndex) + 1];

            int pos = 0;
            for(int i = startIndex; i < newArray.Length + 1; i++)
            {
                newArray[pos] = array[i];
                pos++;
            }

            return newArray;
        }

        /// <summary>
        /// Replaces all NO BRAKE SPACE chars (00a0) with SPACE CHARS (0020)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ReplaceNBSPcharWithSPACEchar(this string input)
        {
            string output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if ($"{(int)input[i]:x4}" == "00a0")
                {
                    output += (char)32;
                }
                else
                {
                    output += input[i];
                }
            }

            return output;
        }

        public static string AddSpacesBetweenCharacters(this string inputString)
        {
            inputString = inputString.Trim();
            string output = string.Empty;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (i + 1 == inputString.Length)
                {
                    output += inputString[i];
                }
                else
                {
                    output += inputString[i] + " ";
                }
            }
            return output;
        }

        public static List<TxtEncoding> ConvertToTxtEncodingObject(this string input)
        {
            List<TxtEncoding> encList = new List<TxtEncoding>();

            for (int i = 0; i < input.Length; i++)
            {
                encList.Add(new TxtEncoding
                {
                    String = input[i].ToString(),
                    Char = input[i],
                    UTF16 = $"{(int)input[i]:x4}"
                });
            }
            return encList;
        }
    }

    

    public class TxtEncoding
    {
        public string String { get; set; }
        public char Char { get; set; }
        public string UTF16 { get; set; }
    }
    
}
