using System;
using System.Collections.Generic;

namespace StringsAndEncoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //copyByIndexRange

            string[] stringArray = 
            {
                "hi",
                "hello",
                "hey",
                "where u at"
            };

            string[] partOfStringArray = stringArray.CopyByIndexRange(1, 2);

            Console.WriteLine(String.Join(" ", partOfStringArray));

            //ReplaceNBSPcharWithSPACEchar
            string test = "h e l l o";
            test = test.ReplaceNBSPcharWithSPACEchar();

            //ConvertToTxtEncodingObject
            List<TxtEncoding> letterEncoding = "hello world".ConvertToTxtEncodingObject();

            foreach (var item in letterEncoding)
            {
                Console.WriteLine(item.String + " - " + item.Char + " - " + item.UTF16);
            }
        }
    }
}
