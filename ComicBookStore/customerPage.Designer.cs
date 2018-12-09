namespace ComicBookStore
{
    partial class customerPage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.productsTab = new System.Windows.Forms.TabPage();
            this.storesTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.productsTab);
            this.tabControl1.Controls.Add(this.storesTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 317);
            this.tabControl1.TabIndex = 0;
            // 
            // productsTab
            // 
            this.productsTab.Location = new System.Drawing.Point(4, 22);
            this.productsTab.Name = "productsTab";
            this.productsTab.Padding = new System.Windows.Forms.Padding(3);
            this.productsTab.Size = new System.Drawing.Size(547, 291);
            this.productsTab.TabIndex = 0;
            this.productsTab.Text = "Products";
            this.productsTab.UseVisualStyleBackColor = true;
            this.productsTab.Click += new System.EventHandler(this.Products_Click);
            // 
            // storesTab
            // 
            this.storesTab.Location = new System.Drawing.Point(4, 22);
            this.storesTab.Name = "storesTab";
            this.storesTab.Padding = new System.Windows.Forms.Padding(3);
            this.storesTab.Size = new System.Drawing.Size(547, 291);
            this.storesTab.TabIndex = 1;
            this.storesTab.Text = "Stores";
            this.storesTab.UseVisualStyleBackColor = true;
            // 
            // customerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 405);
            this.Controls.Add(this.tabControl1);
            this.Name = "customerPage";
            this.Text = "customerPage";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage productsTab;
        private System.Windows.Forms.TabPage storesTab;
    }
}