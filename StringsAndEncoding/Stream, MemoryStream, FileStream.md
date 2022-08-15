# Stream, MemoryStream, FileStream

STREAM = representation of bytes. Flow of data between two places. 

<b>FILESTREAM</b>
- derives from abstrac class Stream
- READS and WRITES to a FILE

```csharp
string text = "Hello";
byte[] bytesArray = Encoding.UTF8.GetBytes(text);
var memoryStream = new MemoryStream(bytesArray);
```
