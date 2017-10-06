using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Transliteration
{
  public class DictionaryBuilder
  {
    public Dictionary<string, string> BuildFromFile(string filePath)
    {
      string line;
      Dictionary<string, string> dictionary = new Dictionary<string, string>();
      using (StreamReader file = new StreamReader(filePath, Encoding.Default))
      {
        while ((line = file.ReadLine()) != null)
        {
          string[] pair = line.Split('-');
          if ((pair[0]).Any() && (pair[1]).Any())
          {
            dictionary.Add(pair[0], pair[1]);
            continue;
          }
          throw new ArgumentNullException();
        }
      }
      return dictionary;
    }
  }
}
