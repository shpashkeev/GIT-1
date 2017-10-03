using System.IO;
using System.Text;

namespace Transliteration
{
  // Class contains a method
  // that reads lines from a text file.
  public class TextFileReader
  {
    // The complete file path is specified by the path parameter.
    // StreamReader class constructor initializes the encoding to UTF8Encoding.
    public string ReadLines(string path)
    {
      using (StreamReader file = new StreamReader(path, System.Text.Encoding.Default))
      {
        string line;
        StringBuilder result = new StringBuilder();
        while ((line = file.ReadLine()) != null)
        {
          result.Append(line);
        }
        return result.ToString();
      }
    }
  }
}
