namespace SOLID.SRP.FirstRefactor
{
    partial class FirstRefactorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstProduct = new System.Windows.Forms.ListView();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.FileDialogReader = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lstProduct
            // 
            this.lstProduct.Location = new System.Drawing.Point(152, 98);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(404, 91);
            this.lstProduct.TabIndex = 5;
            this.lstProduct.UseCompatibleStateImageBehavior = false;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(152, 54);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(404, 20);
            this.txtFileName.TabIndex = 4;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(26, 48);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(95, 31);
            this.btnLoadFile.TabIndex = 3;
            this.btnLoadFile.Text = "Read File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // FileDialogReader
            // 
            this.FileDialogReader.FileName = "openFileDialog1";
            // 
            // FirstRefactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 243);
            this.Controls.Add(this.lstProduct);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnLoadFile);
            this.Name = "FirstRefactorForm";
            this.Text = "FirstRefactorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstProduct;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.OpenFileDialog FileDialogReader;
    }
}