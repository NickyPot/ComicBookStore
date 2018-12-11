using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ComicBookStore
{
    public partial class managementPage : Form
    {

        DataTable dTable = null;
        BindingSource bSource = null;
        SqlDataAdapter sDA = null;
        SqlCommandBuilder commandBuild;


        public managementPage()
        {
            InitializeComponent();
        }

        private void managementPage_Load(object sender, EventArgs e)
        {
            
        }

        private void sendShopButton_Click(object sender, EventArgs e)
        {
            commandBuild = new SqlCommandBuilder(sDA);
            sDA.Update(dTable);
        }

        private void updateShopButton_Click(object sender, EventArgs e)
        {
            string query = "select * from shop";
            sDA = searchResult.getSqlDAdapter(query);
            dTable = new DataTable();

            sDA.Fill(dTable);
            bSource = new BindingSource();
            bSource.DataSource = dTable;
            shopDataGridView.DataSource = bSource;
        }

        //sendEditProdButton
        private void button2_Click(object sender, EventArgs e)
        {
            commandBuild = new SqlCommandBuilder(sDA);
            sDA.Update(dTable);
        }

        //updateProdListButton
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from product";
            sDA = searchResult.getSqlDAdapter(query);
            dTable = new DataTable();

            sDA.Fill(dTable);
            bSource = new BindingSource();
            bSource.DataSource = dTable;
            prductsDataGridView.DataSource = bSource;
        }

        private void updateCustButton_Click(object sender, EventArgs e)
        {
            string query = "select * from customer";
            sDA = searchResult.getSqlDAdapter(query);
            dTable = new DataTable();

            sDA.Fill(dTable);
            bSource = new BindingSource();
            bSource.DataSource = dTable;
            customersDataGridView.DataSource = bSource;

        }

        private void sendCustEditsButton_Click(object sender, EventArgs e)
        {
            commandBuild = new SqlCommandBuilder(sDA);
            sDA.Update(dTable);

        }
    }
}
