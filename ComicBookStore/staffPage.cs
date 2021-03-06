﻿using System;
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
    public partial class staffPage : Form
    {
       
        DataTable dTable = null;
        BindingSource bSource = null;
        SqlDataAdapter sDA = null;
        SqlCommandBuilder commandBuild;

        public staffPage()
        {
            InitializeComponent();
        }

        private void updateShopButton_Click(object sender, EventArgs e)
        {
            string query = "select * from shop";
            sDA = searchResult.getSqlDAdapter(query);
            dTable = new DataTable();
           
            sDA.Fill(dTable);
            bSource = new BindingSource();
            bSource.DataSource = dTable;
            shopsGridView.DataSource = bSource;
        }

        private void sendEditsButton_Click(object sender, EventArgs e)
        {
            commandBuild = new SqlCommandBuilder(sDA);
            sDA.Update(dTable);
        }

        private void upProductButton_Click(object sender, EventArgs e)
        {
            string query = "select * from product";
            sDA = searchResult.getSqlDAdapter(query);
            dTable = new DataTable();

            sDA.Fill(dTable);
            bSource = new BindingSource();
            bSource.DataSource = dTable;
            productListGridView.DataSource = bSource;
        }

        private void sendProdEditButton_Click(object sender, EventArgs e)
        {
            commandBuild = new SqlCommandBuilder(sDA);
            sDA.Update(dTable);
        }

        private void shopsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

