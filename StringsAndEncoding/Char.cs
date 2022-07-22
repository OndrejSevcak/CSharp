using System;
using System.Collections.Generic;
using System.Text;

namespace StringsAndEncoding
{
    internal class Char
    {
        //System.Char VALUE type represents a Unicode UTF-16 character
        //Default value is \0, whis is U+0000
        //String type is a sequence of char values (instances)

        private void Explanation()
        {
            var chars = new[]
            {
                'j',        // - character literal
                '\u006A',   // - unicode four-symbol hex representation
                '\x006A',   // - hexadecimal escape sequence
                (char)106   // - casting
            };

            Console.WriteLine(String.Join(" - ", chars));  // j - j - j - j
        }
    }
}
