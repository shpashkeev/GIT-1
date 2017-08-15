
using System.Collections.Generic;

namespace ProductsStorage
{
  public interface Command
  {
    void execute(List<Product> products, string arg);
  }
}
