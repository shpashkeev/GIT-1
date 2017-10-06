using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Transliteration
{
  // Main class method passes the text to the instance of the class Transliterator,
  // that calls methods of transliteration of the input text from Cyrillic to Latin and vice versa,
  // and outputs results.
  public class EntryPoint
  {
    private const string DefaultText = "\nDefautl text.";
    private const string AfterTransliteration = "\nAfter transliteration.";
    private const string ReverseTransliteration = "\nReverse transliteration.";

    // Parameter args - pathes to the files, that includes dictionaries and file with text
    public static void Main(string[] args)
    {
      try
      {
        string inputText;
        DictionaryBuilder dictionaryBuilder = new DictionaryBuilder();
        Transliterator transliterator = new Transliterator();

        Dictionary<string, string> cyrillicLatinDictionary = dictionaryBuilder.BuildFromFile(args[0]);
        Dictionary<string, string> latinCyrillicDictionary = dictionaryBuilder.BuildFromFile(args[1]);

        using (StreamReader file = new StreamReader(args[2], Encoding.Default))
        {
          inputText = file.ReadToEnd();
        }

        string inLatinText = transliterator.Translit(inputText, cyrillicLatinDictionary);
        string inCyrilText = transliterator.Translit(inLatinText, latinCyrillicDictionary);

        Console.WriteLine(DefaultText);
        Console.WriteLine(inputText);

        Console.WriteLine(AfterTransliteration);
        Console.WriteLine(inLatinText);

        Console.WriteLine(ReverseTransliteration);
        Console.WriteLine(inCyrilText);

        Console.ReadKey();
      }
      catch (Exception exc)
      {
        Console.WriteLine(exc.Message);
        Console.ReadKey();
      }
    }
  }
}
