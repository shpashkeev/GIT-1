using System.IO;
using System.Text;

namespace Transliteration
{
  // Class contains a method
  // that reads text from a text file.
  public class TextDataReader
  {
    // The complete file path is specified by the path parameter.
    // StreamReader class constructor initializes the ANSI encoding.
    public string ReadFromTextFile(string path)
    {
      using (StreamReader file = new StreamReader(path, Encoding.Default))
      {
        return file.ReadToEnd();
      }
    }
  }
}
