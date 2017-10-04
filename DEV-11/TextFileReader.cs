using System.IO;
using System.Text;

namespace Transliteration
{
  // Class contains a method
  // that reads lines from a text file.
  public class TextFileReader
  {
    // The complete file path is specified by the path parameter.
    // StreamReader class constructor initializes the ANSI encoding .
    public string ReadText(string path)
    {
      using (StreamReader file = new StreamReader(path, Encoding.Default))
      {
        return file.ReadToEnd();
      }
    }
  }
}
