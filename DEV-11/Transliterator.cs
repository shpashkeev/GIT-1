using System.Collections.Generic;

namespace Transliteration
{
  // Class contains method
  // that performs the process of transliteration
  // from Cyrillic to Latin or from Latin to Cyrillic.
  // According to the rules of transliteration,
  // class dictionaries are compiled
  public class Transliterator
  {
    // Process of transliteration
    public string Translit(string text, Dictionary<string, string> abc)
    {
      string outputText = text;
      foreach (var value in abc.Keys)
      {
        outputText = outputText.Replace(value, abc[value]);
      }
      return outputText;
    }

  }
}

