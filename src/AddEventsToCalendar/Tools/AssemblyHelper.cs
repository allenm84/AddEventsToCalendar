using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddEventsToCalendar
{
  public static class AssemblyHelper
  {
    public static Stream OpenStream(string name)
    {
      var assembly = typeof(AssemblyHelper).Assembly;
      var names = assembly.GetManifestResourceNames();
      var key = names.Single(n => n.EndsWith(name));
      var stream = assembly.GetManifestResourceStream(key);
      stream.Seek(0, SeekOrigin.Begin);
      return stream;
    }
  }
}
