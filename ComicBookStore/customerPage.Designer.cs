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
            this.productSearchListGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.storesTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.shopListGridView = new System.Windows.Forms.DataGridView();
            this.profileTab = new System.Windows.Forms.TabPage();
            this.cartTab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.productsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSearchListGridView)).BeginInit();
            this.storesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.productsTab);
            this.tabControl1.Controls.Add(this.storesTab);
            this.tabControl1.Controls.Add(this.profileTab);
            this.tabControl1.Controls.Add(this.cartTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 334);
            this.tabControl1.TabIndex = 0;
            // 
            // productsTab
            // 
            this.productsTab.Controls.Add(this.button3);
            this.productsTab.Controls.Add(this.productSearchListGridView);
            this.productsTab.Controls.Add(this.button2);
            this.productsTab.Controls.Add(this.productTextBox);
            this.productsTab.Controls.Add(this.label1);
            this.productsTab.Location = new System.Drawing.Point(4, 22);
            this.productsTab.Name = "productsTab";
            this.productsTab.Padding = new System.Windows.Forms.Padding(3);
            this.productsTab.Size = new System.Drawing.Size(547, 308);
            this.productsTab.TabIndex = 0;
            this.productsTab.Text = "Products";
            this.productsTab.UseVisualStyleBackColor = true;
            this.productsTab.Click += new System.EventHandler(this.Products_Click);
            // 
            // productSearchListGridView
            // 
            this.productSearchListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productSearchListGridView.Location = new System.Drawing.Point(10, 93);
            this.productSearchListGridView.Name = "productSearchListGridView";
            this.productSearchListGridView.Size = new System.Drawing.Size(336, 71);
            this.productSearchListGridView.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "GO!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(95, 7);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(100, 20);
            this.productTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name: ";
            // 
            // storesTab
            // 
            this.storesTab.Controls.Add(this.button1);
            this.storesTab.Controls.Add(this.shopListGridView);
            this.storesTab.Location = new System.Drawing.Point(4, 22);
            this.storesTab.Name = "storesTab";
            this.storesTab.Padding = new System.Windows.Forms.Padding(3);
            this.storesTab.Size = new System.Drawing.Size(547, 308);
            this.storesTab.TabIndex = 1;
            this.storesTab.Text = "Stores";
            this.storesTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Shops";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shopListGridView
            // 
            this.shopListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopListGridView.Location = new System.Drawing.Point(6, 6);
            this.shopListGridView.Name = "shopListGridView";
            this.shopListGridView.ReadOnly = true;
            this.shopListGridView.Size = new System.Drawing.Size(535, 263);
            this.shopListGridView.TabIndex = 0;
            this.shopListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // profileTab
            // 
            this.profileTab.Location = new System.Drawing.Point(4, 22);
            this.profileTab.Name = "profileTab";
            this.profileTab.Padding = new System.Windows.Forms.Padding(3);
            this.profileTab.Size = new System.Drawing.Size(547, 308);
            this.profileTab.TabIndex = 2;
            this.profileTab.Text = "Profile";
            this.profileTab.UseVisualStyleBackColor = true;
            // 
            // cartTab
            // 
            this.cartTab.Location = new System.Drawing.Point(4, 22);
            this.cartTab.Name = "cartTab";
            this.cartTab.Padding = new System.Windows.Forms.Padding(3);
            this.cartTab.Size = new System.Drawing.Size(547, 308);
            this.cartTab.TabIndex = 3;
            this.cartTab.Text = "Cart";
            this.cartTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(366, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 71);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add to Cart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.productsTab.ResumeLayout(false);
            this.productsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSearchListGridView)).EndInit();
            this.storesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shopListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage productsTab;
        private System.Windows.Forms.TabPage storesTab;
        private System.Windows.Forms.DataGridView shopListGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView productSearchListGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage profileTab;
        private System.Windows.Forms.TabPage cartTab;
        private System.Windows.Forms.Button button3;
    }
}