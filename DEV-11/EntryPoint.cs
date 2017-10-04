using System;

namespace Transliteration
{
  // Main class method passes the text to the instance of the class Transliterator
  // that calls methods of transliteration of the input text from Cyrillic to Latin and vice versa
  // and outputs results.
  public class EntryPoint
  {
    private const string DefaultText = "\nDefautl text.";
    private const string AfterTransliteration = "\nAfter transliteration.";
    private const string ReverseTransliteration = "\nReverse transliteration.";

    // Parameter args - path to the file
    public static void Main(string[] args)
    {
      try
      {
        Transliterator translit = new Transliterator();
        string inputText = new TextFileReader().ReadText(args[0]);

        string inLatinText = translit.FromCyrillicToLatin(inputText);

        string inCyrilText = translit.FromLatinToCyrillic(inLatinText);

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
