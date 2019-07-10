using System.Collections.Generic;
using System.IO;
using System.Linq;
using ClassLibraryStandard;

namespace ClassLibraryNetCore
{
    public class DummyFromNetCore : IDummyFromNetCore
    {
        public List<string> EnumerateFiles(string directoryPath)
        {
            var list = Directory.EnumerateFiles(directoryPath).ToList();

            return list;
        }

    }
}
