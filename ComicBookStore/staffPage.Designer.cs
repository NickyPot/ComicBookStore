namespace ComicBookStore
{
    partial class staffPage
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
            this.shopTabPage = new System.Windows.Forms.TabPage();
            this.updateShopButton = new System.Windows.Forms.Button();
            this.sendEditsButton = new System.Windows.Forms.Button();
            this.shopsGridView = new System.Windows.Forms.DataGridView();
            this.productTabPage = new System.Windows.Forms.TabPage();
            this.productListGridView = new System.Windows.Forms.DataGridView();
            this.sendProdEditButton = new System.Windows.Forms.Button();
            this.upProductButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.shopTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopsGridView)).BeginInit();
            this.productTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.shopTabPage);
            this.tabControl1.Controls.Add(this.productTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(510, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // shopTabPage
            // 
            this.shopTabPage.Controls.Add(this.updateShopButton);
            this.shopTabPage.Controls.Add(this.sendEditsButton);
            this.shopTabPage.Controls.Add(this.shopsGridView);
            this.shopTabPage.Location = new System.Drawing.Point(4, 22);
            this.shopTabPage.Name = "shopTabPage";
            this.shopTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.shopTabPage.Size = new System.Drawing.Size(502, 352);
            this.shopTabPage.TabIndex = 0;
            this.shopTabPage.Text = "Shops";
            this.shopTabPage.UseVisualStyleBackColor = true;
            // 
            // updateShopButton
            // 
            this.updateShopButton.Location = new System.Drawing.Point(405, 309);
            this.updateShopButton.Name = "updateShopButton";
            this.updateShopButton.Size = new System.Drawing.Size(91, 37);
            this.updateShopButton.TabIndex = 1;
            this.updateShopButton.Text = "Update Shop Data";
            this.updateShopButton.UseVisualStyleBackColor = true;
            this.updateShopButton.Click += new System.EventHandler(this.updateShopButton_Click);
            // 
            // sendEditsButton
            // 
            this.sendEditsButton.Location = new System.Drawing.Point(324, 309);
            this.sendEditsButton.Name = "sendEditsButton";
            this.sendEditsButton.Size = new System.Drawing.Size(75, 37);
            this.sendEditsButton.TabIndex = 2;
            this.sendEditsButton.Text = "Send Edits";
            this.sendEditsButton.UseVisualStyleBackColor = true;
            this.sendEditsButton.Click += new System.EventHandler(this.sendEditsButton_Click);
            // 
            // shopsGridView
            // 
            this.shopsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopsGridView.Location = new System.Drawing.Point(7, 7);
            this.shopsGridView.Name = "shopsGridView";
            this.shopsGridView.Size = new System.Drawing.Size(489, 273);
            this.shopsGridView.TabIndex = 0;
            this.shopsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shopsGridView_CellContentClick);
            // 
            // productTabPage
            // 
            this.productTabPage.Controls.Add(this.productListGridView);
            this.productTabPage.Controls.Add(this.sendProdEditButton);
            this.productTabPage.Controls.Add(this.upProductButton);
            this.productTabPage.Location = new System.Drawing.Point(4, 22);
            this.productTabPage.Name = "productTabPage";
            this.productTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.productTabPage.Size = new System.Drawing.Size(502, 352);
            this.productTabPage.TabIndex = 1;
            this.productTabPage.Text = "Products";
            this.productTabPage.UseVisualStyleBackColor = true;
            // 
            // productListGridView
            // 
            this.productListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productListGridView.Location = new System.Drawing.Point(6, 6);
            this.productListGridView.Name = "productListGridView";
            this.productListGridView.Size = new System.Drawing.Size(490, 277);
            this.productListGridView.TabIndex = 2;
            // 
            // sendProdEditButton
            // 
            this.sendProdEditButton.Location = new System.Drawing.Point(311, 309);
            this.sendProdEditButton.Name = "sendProdEditButton";
            this.sendProdEditButton.Size = new System.Drawing.Size(92, 37);
            this.sendProdEditButton.TabIndex = 1;
            this.sendProdEditButton.Text = "Send Product Edits";
            this.sendProdEditButton.UseVisualStyleBackColor = true;
            this.sendProdEditButton.Click += new System.EventHandler(this.sendProdEditButton_Click);
            // 
            // upProductButton
            // 
            this.upProductButton.Location = new System.Drawing.Point(409, 309);
            this.upProductButton.Name = "upProductButton";
            this.upProductButton.Size = new System.Drawing.Size(87, 37);
            this.upProductButton.TabIndex = 0;
            this.upProductButton.Text = "Update Product List";
            this.upProductButton.UseVisualStyleBackColor = true;
            this.upProductButton.Click += new System.EventHandler(this.upProductButton_Click);
            // 
            // staffPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 402);
            this.Controls.Add(this.tabControl1);
            this.Name = "staffPage";
            this.Text = "staffPage";
            this.tabControl1.ResumeLayout(false);
            this.shopTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shopsGridView)).EndInit();
            this.productTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage shopTabPage;
        private System.Windows.Forms.TabPage productTabPage;
        private System.Windows.Forms.DataGridView shopsGridView;
        private System.Windows.Forms.Button updateShopButton;
        private System.Windows.Forms.Button sendEditsButton;
        private System.Windows.Forms.DataGridView productListGridView;
        private System.Windows.Forms.Button sendProdEditButton;
        private System.Windows.Forms.Button upProductButton;
    }
}