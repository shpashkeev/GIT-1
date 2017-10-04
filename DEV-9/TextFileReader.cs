using System.Collections.Generic;
using System.IO;

namespace ReplacementOfCharacterGroups
{
  // Class contains a method
  // that reads lines from a text file.
  public class TextFileReader
  {
    // The complete file path is specified by the path parameter.
    // StreamReader class constructor initializes the encoding to UTF8Encoding.
    public List<string> ReadLines(string path)
    {
      List<string> result = new List<string>();
      string line;

      using (StreamReader file = new StreamReader(path))
      {
        while ((line = file.ReadLine()) != null)
        {
          result.Add(line);
        }
        return result;
      }
    }
  }
}
