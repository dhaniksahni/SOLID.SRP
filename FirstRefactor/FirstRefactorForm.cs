using SOLID.SRP.RectorCode;
using System;
using System.Windows.Forms;

namespace SOLID.SRP.FirstRefactor
{
    public partial class FirstRefactorForm : Form
    {
        public FirstRefactorForm()
        {
            InitializeComponent();
        }

        private IProductRepository repository=null;
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            FileDialogReader.Filter = "XML Document (*.xml)|*.xml|All Files (*.*)|*.*";
            var result = FileDialogReader.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFileName.Text = FileDialogReader.FileName;

                lstProduct.Items.Clear();
                var fileName = txtFileName.Text;

                lstProduct.Items.Clear();
                var products = repository.GetByFileName(fileName);
                foreach (Product product in products)
                {
                    var item = new ListViewItem(new[]
                    {
                         product.Id.ToString(),
                         product.Name,
                         product.UnitPrice.ToString(),
                         product.Discontinued.ToString()
                     });
                    lstProduct.Items.Add(item);
                }
            }
        }
    }
}