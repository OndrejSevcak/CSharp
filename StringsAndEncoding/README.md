<h3>Strings in C# </h3>

- string = sequence of characters
- character = unicode character in the range U+0000 to U+FFFF
- unicode = the Unicode Standard provides a unique number for every character, no matter what platform, device, application or language

<h3>STRING </h3>

- is a REFERENCE TYPE = it is immutable (you can not change the contents of a string). Every time we modify an existing string we a creating a new memory! => new object is
                        being referenced. Old string became unreferenced and waits for garbage collector to delete them. 
                      
- can contain NULL - in .NET, strings can contain null characters with no problems

<h3>CHAR </h3>

- .NET System.Char structure type that represents a Unicode UTF-16 character.
- the default value of the char type is \0, that is, U+0000.

You can specify a char value with:
 - a character literal -> 'j'
 - a Unicode escape sequence, which is \u followed by the four-symbol hexadecimal representation of a character code -> '\u006A'
 - a hexadecimal escape sequence, which is \x followed by the hexadecimal representation of a character code -> '\x006A'
 - you can also cast the value of a character code into the corresponding char value -> (char)106
 
 <h3>LITERALS </h3>
 - how you hard-code strings into C# programs
 
 RAGULAR LITERALS = start and end with "", various characters like \ needs to be escaped \\
 VERBATIM LITERALS = have @ before opening "
 
 
- Regular literal   Verbatim literal	  Resulting string

- "Hello"	          @"Hello"	          Hello
- "Backslash: \\"	  @"Backslash: \"	    Backslash: \
- "Quote: \""	      @"Quote: """	      Quote: "


 <h3>ESCAPE SEQUENCES</h3>

\\ - backslash
\b - backspace
\n - new line
\r - cariage return
\t - horizontal tab
\uXXX - unicode hex escape


<h3>Built-in ENCODING SCHEMES</h3>

- ASCII - is only 7 bit
- UTF8 - Each character is encoded as a sequence of 1-4 bytes
- UTF16 - Each character is encoded as a sequence of 2 bytes
        - UTF-16 is effectively how characters are maintained internally in .NET
