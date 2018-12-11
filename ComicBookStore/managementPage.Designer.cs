namespace ComicBookStore
{
    partial class managementPage
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.shopsTabPage = new System.Windows.Forms.TabPage();
            this.shopDataGridView = new System.Windows.Forms.DataGridView();
            this.sendShopButton = new System.Windows.Forms.Button();
            this.productTabPage = new System.Windows.Forms.TabPage();
            this.sendEditProdButton = new System.Windows.Forms.Button();
            this.updateProdListButton = new System.Windows.Forms.Button();
            this.prductsDataGridView = new System.Windows.Forms.DataGridView();
            this.customersTabPage = new System.Windows.Forms.TabPage();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.updateShopButton = new System.Windows.Forms.Button();
            this.updateCustButton = new System.Windows.Forms.Button();
            this.sendCustEditsButton = new System.Windows.Forms.Button();
            this.ordersTab = new System.Windows.Forms.TabPage();
            this.updateOrdersButton = new System.Windows.Forms.Button();
            this.sendEditOrdersButton = new System.Windows.Forms.Button();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.TabControl1.SuspendLayout();
            this.shopsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataGridView)).BeginInit();
            this.productTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prductsDataGridView)).BeginInit();
            this.customersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.ordersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.shopsTabPage);
            this.TabControl1.Controls.Add(this.productTabPage);
            this.TabControl1.Controls.Add(this.customersTabPage);
            this.TabControl1.Controls.Add(this.ordersTab);
            this.TabControl1.Location = new System.Drawing.Point(13, 13);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(683, 502);
            this.TabControl1.TabIndex = 0;
            // 
            // shopsTabPage
            // 
            this.shopsTabPage.Controls.Add(this.shopDataGridView);
            this.shopsTabPage.Controls.Add(this.sendShopButton);
            this.shopsTabPage.Controls.Add(this.updateShopButton);
            this.shopsTabPage.Location = new System.Drawing.Point(4, 22);
            this.shopsTabPage.Name = "shopsTabPage";
            this.shopsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.shopsTabPage.Size = new System.Drawing.Size(675, 476);
            this.shopsTabPage.TabIndex = 0;
            this.shopsTabPage.Text = "Shops";
            this.shopsTabPage.UseVisualStyleBackColor = true;
            // 
            // shopDataGridView
            // 
            this.shopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopDataGridView.Location = new System.Drawing.Point(7, 4);
            this.shopDataGridView.Name = "shopDataGridView";
            this.shopDataGridView.Size = new System.Drawing.Size(668, 415);
            this.shopDataGridView.TabIndex = 2;
            // 
            // sendShopButton
            // 
            this.sendShopButton.Location = new System.Drawing.Point(486, 425);
            this.sendShopButton.Name = "sendShopButton";
            this.sendShopButton.Size = new System.Drawing.Size(93, 45);
            this.sendShopButton.TabIndex = 1;
            this.sendShopButton.Text = "Send Edits";
            this.sendShopButton.UseVisualStyleBackColor = true;
            this.sendShopButton.Click += new System.EventHandler(this.sendShopButton_Click);
            // 
            // productTabPage
            // 
            this.productTabPage.Controls.Add(this.sendEditProdButton);
            this.productTabPage.Controls.Add(this.updateProdListButton);
            this.productTabPage.Controls.Add(this.prductsDataGridView);
            this.productTabPage.Location = new System.Drawing.Point(4, 22);
            this.productTabPage.Name = "productTabPage";
            this.productTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.productTabPage.Size = new System.Drawing.Size(675, 476);
            this.productTabPage.TabIndex = 1;
            this.productTabPage.Text = "Products";
            this.productTabPage.UseVisualStyleBackColor = true;
            // 
            // sendEditProdButton
            // 
            this.sendEditProdButton.Location = new System.Drawing.Point(477, 428);
            this.sendEditProdButton.Name = "sendEditProdButton";
            this.sendEditProdButton.Size = new System.Drawing.Size(91, 42);
            this.sendEditProdButton.TabIndex = 2;
            this.sendEditProdButton.Text = "Send Product Edits";
            this.sendEditProdButton.UseVisualStyleBackColor = true;
            this.sendEditProdButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // updateProdListButton
            // 
            this.updateProdListButton.Location = new System.Drawing.Point(574, 428);
            this.updateProdListButton.Name = "updateProdListButton";
            this.updateProdListButton.Size = new System.Drawing.Size(95, 42);
            this.updateProdListButton.TabIndex = 1;
            this.updateProdListButton.Text = "Update Product List";
            this.updateProdListButton.UseVisualStyleBackColor = true;
            this.updateProdListButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // prductsDataGridView
            // 
            this.prductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prductsDataGridView.Location = new System.Drawing.Point(7, 7);
            this.prductsDataGridView.Name = "prductsDataGridView";
            this.prductsDataGridView.Size = new System.Drawing.Size(662, 415);
            this.prductsDataGridView.TabIndex = 0;
            // 
            // customersTabPage
            // 
            this.customersTabPage.Controls.Add(this.sendCustEditsButton);
            this.customersTabPage.Controls.Add(this.updateCustButton);
            this.customersTabPage.Controls.Add(this.customersDataGridView);
            this.customersTabPage.Location = new System.Drawing.Point(4, 22);
            this.customersTabPage.Name = "customersTabPage";
            this.customersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.customersTabPage.Size = new System.Drawing.Size(675, 476);
            this.customersTabPage.TabIndex = 2;
            this.customersTabPage.Text = "Customers";
            this.customersTabPage.UseVisualStyleBackColor = true;
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Location = new System.Drawing.Point(7, 7);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.Size = new System.Drawing.Size(662, 394);
            this.customersDataGridView.TabIndex = 2;
            // 
            // updateShopButton
            // 
            this.updateShopButton.Location = new System.Drawing.Point(585, 425);
            this.updateShopButton.Name = "updateShopButton";
            this.updateShopButton.Size = new System.Drawing.Size(84, 45);
            this.updateShopButton.TabIndex = 0;
            this.updateShopButton.Text = "Update Shop Data";
            this.updateShopButton.UseVisualStyleBackColor = true;
            this.updateShopButton.Click += new System.EventHandler(this.updateShopButton_Click);
            // 
            // updateCustButton
            // 
            this.updateCustButton.Location = new System.Drawing.Point(589, 437);
            this.updateCustButton.Name = "updateCustButton";
            this.updateCustButton.Size = new System.Drawing.Size(79, 36);
            this.updateCustButton.TabIndex = 3;
            this.updateCustButton.Text = "Update Customer List";
            this.updateCustButton.UseVisualStyleBackColor = true;
            this.updateCustButton.Click += new System.EventHandler(this.updateCustButton_Click);
            // 
            // sendCustEditsButton
            // 
            this.sendCustEditsButton.Location = new System.Drawing.Point(498, 437);
            this.sendCustEditsButton.Name = "sendCustEditsButton";
            this.sendCustEditsButton.Size = new System.Drawing.Size(85, 36);
            this.sendCustEditsButton.TabIndex = 4;
            this.sendCustEditsButton.Text = "Send Customer Edits";
            this.sendCustEditsButton.UseVisualStyleBackColor = true;
            this.sendCustEditsButton.Click += new System.EventHandler(this.sendCustEditsButton_Click);
            // 
            // ordersTab
            // 
            this.ordersTab.Controls.Add(this.ordersDataGridView);
            this.ordersTab.Controls.Add(this.sendEditOrdersButton);
            this.ordersTab.Controls.Add(this.updateOrdersButton);
            this.ordersTab.Location = new System.Drawing.Point(4, 22);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.Padding = new System.Windows.Forms.Padding(3);
            this.ordersTab.Size = new System.Drawing.Size(675, 476);
            this.ordersTab.TabIndex = 3;
            this.ordersTab.Text = "Orders";
            this.ordersTab.UseVisualStyleBackColor = true;
            // 
            // updateOrdersButton
            // 
            this.updateOrdersButton.Location = new System.Drawing.Point(573, 429);
            this.updateOrdersButton.Name = "updateOrdersButton";
            this.updateOrdersButton.Size = new System.Drawing.Size(96, 41);
            this.updateOrdersButton.TabIndex = 0;
            this.updateOrdersButton.Text = "Update Orders List";
            this.updateOrdersButton.UseVisualStyleBackColor = true;
            this.updateOrdersButton.Click += new System.EventHandler(this.updateOrdersButton_Click);
            // 
            // sendEditOrdersButton
            // 
            this.sendEditOrdersButton.Location = new System.Drawing.Point(486, 429);
            this.sendEditOrdersButton.Name = "sendEditOrdersButton";
            this.sendEditOrdersButton.Size = new System.Drawing.Size(81, 41);
            this.sendEditOrdersButton.TabIndex = 1;
            this.sendEditOrdersButton.Text = "Send Order Edits";
            this.sendEditOrdersButton.UseVisualStyleBackColor = true;
            this.sendEditOrdersButton.Click += new System.EventHandler(this.sendEditOrdersButton_Click);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Location = new System.Drawing.Point(7, 7);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(662, 403);
            this.ordersDataGridView.TabIndex = 2;
            // 
            // managementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 527);
            this.Controls.Add(this.TabControl1);
            this.Name = "managementPage";
            this.Text = "managementPage";
            this.Load += new System.EventHandler(this.managementPage_Load);
            this.TabControl1.ResumeLayout(false);
            this.shopsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataGridView)).EndInit();
            this.productTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prductsDataGridView)).EndInit();
            this.customersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ordersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage shopsTabPage;
        private System.Windows.Forms.TabPage productTabPage;
        private System.Windows.Forms.TabPage customersTabPage;
        private System.Windows.Forms.DataGridView shopDataGridView;
        private System.Windows.Forms.Button sendShopButton;
        private System.Windows.Forms.Button sendEditProdButton;
        private System.Windows.Forms.Button updateProdListButton;
        private System.Windows.Forms.DataGridView prductsDataGridView;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.Button updateShopButton;
        private System.Windows.Forms.Button sendCustEditsButton;
        private System.Windows.Forms.Button updateCustButton;
        private System.Windows.Forms.TabPage ordersTab;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.Button sendEditOrdersButton;
        private System.Windows.Forms.Button updateOrdersButton;
    }
}