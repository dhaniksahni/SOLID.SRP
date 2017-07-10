using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.RectorCode
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetByFileName(string fileName);
    }
}
