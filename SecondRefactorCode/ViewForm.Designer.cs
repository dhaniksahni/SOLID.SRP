namespace SOLID.SRP.SecondRefactorCode
{
    partial class ViewForm
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.fileReaderDialog = new System.Windows.Forms.OpenFileDialog();
            this.lstView = new System.Windows.Forms.ListView();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(24, 37);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // fileReaderDialog
            // 
            this.fileReaderDialog.FileName = "openFileDialog1";
            // 
            // lstView
            // 
            this.lstView.Location = new System.Drawing.Point(148, 70);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(186, 167);
            this.lstView.TabIndex = 1;
            this.lstView.UseCompatibleStateImageBehavior = false;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(148, 37);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(414, 20);
            this.txtFileName.TabIndex = 2;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 356);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.btnLoad);
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog fileReaderDialog;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.TextBox txtFileName;
    }
}