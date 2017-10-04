using System;

namespace Transliteration
{
  public class EntryPoint
  {
    private const string DefaultText = "\nDefautl text.";
    private const string AfterTransliteration = "\nAfter transliteration.";
    private const string ReverseTransliteration = "\nReverse transliteration.";

    static void Main(string[] args)
    {
      try
      {
        Transliterator translit = new Transliterator();
        string inputText = new TextFileReader().ReadLines(args[0]);

        string inLatinText = translit.DirectTransliteration(inputText);

        string inCyrilText = translit.ReverseTransliteration(inLatinText);

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
