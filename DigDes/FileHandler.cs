using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DigDes
{
  public class FileHandler
  {
    public FileStream OpenFile(string filename)
    {
      FileStream stream = File.Open(filename, FileMode.Open);
      return stream;
    }

    public 
  }
}
