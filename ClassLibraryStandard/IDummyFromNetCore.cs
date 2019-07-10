using System.Collections.Generic;

namespace ClassLibraryStandard
{
    public interface IDummyFromNetCore
    {
        List<string> EnumerateFiles(string directoryPath);
    }
}