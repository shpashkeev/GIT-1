using System;
using System.Collections.Generic;
using System.Text;

namespace Transliteration
{
  public class Transliterator
  {
    public string DirectTransliteration(string defaultText)
    {
      StringBuilder sb = new StringBuilder();

      string[] words = SplitIntoTokens(defaultText);
      foreach (var word in words)
      {
        string outputWord = word;
        foreach (var value in CyrilLatinDictionary.Keys)
        {
          if (outputWord.Contains(value))
          {
            outputWord = outputWord.Replace(value, CyrilLatinDictionary[value]);
          }
        }
        sb.Append(outputWord);
        sb.Append(" ");
      }
      return sb.ToString();
    }
    public static string[] SplitIntoTokens(string s)
    {
      return s.Split(null as char[], StringSplitOptions.RemoveEmptyEntries);
    }
    public static readonly Dictionary<string, string> CyrilLatinDictionary = new Dictionary<string, string>
    {
      {"еее", "eyeye"},
      {"ае", "aye"},
      {"Ае", "Aye"},
      {"ее", "eye"},
      {"Ее", "Eye"},
      {"ие", "iye"},
      {"Ие", "Iye"},
      {"ое", "oye"},
      {"Ое", "Oye"},
      {"уе", "uye"},
      {"Уе", "Uye"},
      {"ъе", "ye"},
      {"ые", "yye"},
      {"ье", "ye"},
      {"эе", "eye"},
      {"Эе", "Eye"},
      {"юе", "yuye"},
      {"яе", "yaye"},
      {"Яе", "Yaye"},
      {"аё", "aye"},
      {"её", "eye"},
      {"Её", "Eye"},
      {"иё", "iye"},
      {"оё", "oye"},
      {"Оё", "Oye"},
      {"уё", "uye"},
      {"Уё", "Uye"},
      {"ъё", "ye"},
      {"ыё", "yye"},
      {"ьё", "ye"},
      {"эё", "eye"},
      {"юё", "yuye"},
      {"яё", "yaye"},
      {"ья", "ia"},
      {"ий", "iy"},
      {"ый", "iy"},
      {"а", "a"},
      {"б", "b"},
      {"в", "v"},
      {"г", "g"},
      {"д", "d"},
      {"е", "e"},
      {"ё", "e"},
      {"ж", "zh"},
      {"з", "z"},
      {"и", "i"},
      {"й", "y"},
      {"к", "k"},
      {"л", "l"},
      {"м", "m"},
      {"н", "n"},
      {"о", "o"},
      {"п", "p"},
      {"р", "r"},
      {"с", "s"},
      {"т", "t"},
      {"у", "u"},
      {"ф", "f"},
      {"х", "kh"},
      {"ц", "ts"},
      {"ч", "ch"},
      {"ш", "sh"},
      {"щ", "shch"},
      {"ы", "y"},
      {"э", "e"},
      {"ю", "yu"},
      {"я", "ya"},
      {"А", "A"},
      {"Б", "B"},
      {"В", "C"},
      {"Г", "G"},
      {"Д", "D"},
      {"Е", "E"},
      {"Ё", "E"},
      {"Ж", "Zh"},
      {"З", "Z"},
      {"И", "I"},
      {"Й", "Y"},
      {"К", "K"},
      {"Л", "L"},
      {"М", "M"},
      {"Н", "N"},
      {"О", "O"},
      {"П", "P"},
      {"Р", "R"},
      {"С", "S"},
      {"Т", "T"},
      {"У", "U"},
      {"Ф", "F"},
      {"Х", "Kh"},
      {"Ц", "Ts"},
      {"Ч", "Ch"},
      {"Ш", "Sh"},
      {"Щ", "Shch"},
      {"Ы", "Y"},
      {"Э", "E"},
      {"Ю", "Yu"},
      {"Я", "Ya"}
    };

    public static readonly Dictionary<string, string> LatinCyrilDictionary = new Dictionary<string, string>
    {
      {"eyeye", "еее"},
      {"shch", "щ"},
      {"Shch", "Щ"},
      {"yuye", "юе"},
      {"Yuye", "Юе"},
      {"yaye", "яе"},
      {"Yaye", "Яе"},
      {"aye", "ае"},
      {"Aye", "Ае"},
      {"eye", "ее"},
      {"Eye", "Ее"},
      {"iye", "ие"},
      {"Iye", "Ие"},
      {"oye", "ое"},
      {"Oye", "Ое"},
      {"uye", "уе"},
      {"Uye", "Уе"},
      {"yye", "ые"},
      {"ye", "ье"},
      {"ia", "ья"},
      {"iy", "ий"},
      {"zh", "ж"},
      {"Zh", "Ж"},
      {"kh", "х"},
      {"Kh", "Х"},
      {"ts", "ц"},
      {"Ts", "Ц"},
      {"ch", "ч"},
      {"Ch", "Ч"},
      {"sh", "ш"},
      {"Sh", "Ш"},
      {"yu", "ю"},
      {"Yu", "Ю"},
      {"ya", "я"},
      {"Ya", "Я"},
      {"a", "а"},
      {"b", "б"},
      {"v", "в"},
      {"g", "г"},
      {"d", "д"},
      {"e", "е"},
      {"z", "з"},
      {"i", "и"},
      {"y", "й"},
      {"k", "к"},
      {"l", "л"},
      {"m", "м"},
      {"n", "н"},
      {"o", "о"},
      {"p", "п"},
      {"r", "р"},
      {"s", "с"},
      {"t", "т"},
      {"u", "у"},
      {"f", "ф"},
      {"y", "ы"},
      {"A", "А"},
      {"B", "Б"},
      {"V", "В"},
      {"G", "Г"},
      {"D", "Д"},
      {"E", "Е"},
      {"Z", "З"},
      {"I", "И"},
      {"Y", "Й"},
      {"K", "К"},
      {"L", "Л"},
      {"M", "М"},
      {"N", "Н"},
      {"O", "О"},
      {"P", "П"},
      {"R", "Р"},
      {"S", "С"},
      {"T", "Т"},
      {"U", "У"},
      {"F", "Ф"}
    };
  }
}

