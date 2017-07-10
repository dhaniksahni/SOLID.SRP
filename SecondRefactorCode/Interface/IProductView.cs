using SOLID.SRP.RectorCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.SecondRefactorCode
{
    public interface IProductView
    {
        void Initialize(ProductPresenter presenter);
        string GetFileName();
        void ShowProducts(IEnumerable<Product> products);
        void SetFileName(string fileName);
    }
}
