# Stream, MemoryStream, FileStream

STREAM = representation of bytes. Flow of data between two places. 

<b>FILESTREAM</b>
- derives from abstract class Stream
- READS and WRITES to a FILE

<b>MEMORYSTREAM</b>
- derives from abstract class Stream
- READS and WRITES to MEMORY (e.g. read binary data from db without having to create a file)

```csharp
string text = "Hello";
byte[] bytesArray = Encoding.UTF8.GetBytes(text);
var memoryStream = new MemoryStream(bytesArray);
```
