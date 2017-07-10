using System.IO;

namespace SOLID.SRP.SecondRefactorCode
{
    public interface IFileLoader
    {
        Stream Load(string fileName);
    }
}
