using System;
using System.Collections.Generic;
using System.IO;

namespace ReplacementOfCharacterGroups
{
  public class FileReader
  {
    private const string FileReaderError = "File reader error";

    public List<string> ReadLines(string path)
    {
      StreamReader file = new StreamReader(path);
      List<string> result = new List<string>();
      string line;
      try
      {
        while ((line=file.ReadLine()) != null)
        {
          result.Add(line);
        }
        return result;
      }
      catch (Exception e)
      {
        throw new Exception(FileReaderError);
      }
    }
  }
}
