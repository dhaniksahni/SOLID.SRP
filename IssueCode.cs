using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace SOLID.SRP
{
    public partial class IssueCode : Form
    {
        public IssueCode()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            FileDialogReader.Filter = "XML Document (*.xml)|*.xml|All Files (*.*)|*.*";
            var result = FileDialogReader.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFileName.Text = FileDialogReader.FileName;

                lstProduct.Items.Clear();
                var fileName = txtFileName.Text;
                using (var fs = new FileStream(fileName, FileMode.Open))
                {
                    var reader = XmlReader.Create(fs);
                    while (reader.Read())
                    {
                        if (reader.Name != "product") continue;
                        var id = reader.GetAttribute("id");
                        var name = reader.GetAttribute("name");
                        var unitPrice = reader.GetAttribute("unitPrice");
                        var discontinued = reader.GetAttribute("discontinued");
                        var item = new ListViewItem(
                        new string[] { id, name, unitPrice, discontinued });
                        lstProduct.Items.Add(item);
                    }
                }
            }
        }
    }

}