using SOLID.SRP.RectorCode;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace SOLID.SRP.SecondRefactorCode
{
    public class ProductRepository : IProductRepository
    {
        private readonly IFileLoader loader;
        private readonly IProductMapper mapper;
        public ProductRepository()
        {
            loader = new FileLoader();
            mapper = new ProductMapper();

        }
        public IEnumerable<Product> GetByFileName(string fileName)
        {
            var products = new List<Product>();
            using (Stream input = loader.Load(fileName))
            {
                var reader = XmlReader.Create(input);
                while (reader.Read())
                {
                    if (reader.Name != "product") continue;
                    var product = mapper.Map(reader);
                    products.Add(product);
                }
            }
            return products;        }
    }
}