using SOLID.SRP.RectorCode;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SOLID.SRP.SecondRefactorCode
{
    public partial class ViewForm : Form, IProductView
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private ProductPresenter presenter;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            presenter.BrowseForFileName();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            presenter.GetProducts();
        }
        public void ShowProducts(IEnumerable<Product> products)
        {
            lstView.Items.Clear();
            foreach (Product product in products)
            {
                var item = new ListViewItem(new[]
                {
                     product.Id.ToString(),
                     product.Name,
                     product.UnitPrice.ToString(),
                     product.Discontinued.ToString()
                 });
                lstView.Items.Add(item);
            }
        }
        public string GetFileName()
        {
            return txtFileName.Text;
        }
        public void SetFileName(string fileName)
        {
            txtFileName.Text = fileName;
            btnLoad.Enabled = true;
        }

        public void Initialize(ProductPresenter _presenter)
        {
            presenter = _presenter;
        }
    }
}