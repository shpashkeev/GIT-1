using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transliteration
{
  public class EntryPoint
  {
    private const string DefaultText = "Defautl text.\n";
    private const string AfterTransliteration = "After transliteration.\n";
    private const string ReverseTransliteration = "Reverse transliteration.\n";

    static void Main(string[] args)
    {
      try
      {
        string inputString = new TextFileReader().ReadLines(args[0]);

      }
      catch (Exception exc)
      {
        Console.WriteLine(exc.Message);
      }
    }
  }
}
