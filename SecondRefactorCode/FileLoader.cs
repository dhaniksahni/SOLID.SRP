using System.IO;

namespace SOLID.SRP.SecondRefactorCode
{
    public class FileLoader : IFileLoader
    {
        public Stream Load(string fileName)
        {
            return new FileStream(fileName, FileMode.Open);
        }
    }
}