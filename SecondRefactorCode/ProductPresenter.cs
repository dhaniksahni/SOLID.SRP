using SOLID.SRP.RectorCode;
using System.Windows.Forms;
using System.IO;

namespace SOLID.SRP.SecondRefactorCode
{
    public class ProductPresenter
    {
        private readonly OpenFileDialog openFileDialog;
        private readonly IProductRepository repository;
        private readonly IProductView view;
        public ProductPresenter()
        {
            view = new ViewForm();
            view.Initialize(this);
            repository = new ProductRepository();
            openFileDialog = new OpenFileDialog();
        }
        public IProductView View
        {
            get { return view; }
        }
        public void BrowseForFileName()
        {
            openFileDialog.Filter = "XML Document (*.xml)|*.xml|All Files (*.*)|*.*";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                view.SetFileName(openFileDialog.FileName);
        }
        public void GetProducts()
        {
            BrowseForFileName();
            var products = repository.GetByFileName(view.GetFileName());
            view.ShowProducts(products);
        }
    }
}
