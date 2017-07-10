using SOLID.SRP.RectorCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SOLID.SRP.SecondRefactorCode
{
    public interface IProductMapper
    {
        Product Map(XmlReader reader);
    }
}
