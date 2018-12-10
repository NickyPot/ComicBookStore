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

    
    public partial class customerPage : Form
    {
        
        public customerPage()
        {

            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Products_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //shows the shoplist on the gridview
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select name, district, openingTime, phoneNum from shop";
            shopListGridView.DataSource = searchResult.nPBindtoGridview(query);
            
        }

        //product search button
        private void button2_Click(object sender, EventArgs e)
        {
            
            string query = "select * from prouct where ";
            productSearchListGridView.DataSource = searchResult.pBindToGridView(query, productTextBox.Text);
        }

        //add to cart button
        private void button3_Click(object sender, EventArgs e)
        {
            
           
           // MessageBox.Show(Form1.customerId);
            //make new function (void)
            int custId = Int32.Parse(Form1.customerId);
            string itemNum = productSearchListGridView.Rows[0].Cells["itemNum"].Value.ToString();
            string query = "insert into cart (customerId, itemNum) values('" + custId + "', '" + itemNum + "')";

            searchResult.insertInto(query);
            MessageBox.Show("Item successfully added to your card");
            
         
        }
    }

    static class searchResult
    {
        //not prepared
        public static DataTable nPBindtoGridview(string query)
        {

            SqlConnection conn;
            string connString = "Data Source =tolmount.abertay.ac.uk; Initial Catalog =sql1704807; User ID = sql1704807; Password =2h19%7nE";

            conn = new SqlConnection(connString);
            conn.Open();

            SqlDataAdapter dA = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            dA.Fill(dataTable);
            return dataTable;

        }

        //preapared
        public static DataTable pBindToGridView(string query, string paramText) {

            SqlConnection conn;
            string connString = "Data Source =tolmount.abertay.ac.uk; Initial Catalog =sql1704807; User ID = sql1704807; Password =2h19%7nE";

            conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand preparedCommand = new SqlCommand(null, conn);
            preparedCommand.CommandText = "select * from product where productName = @productName";
            SqlParameter productName = new SqlParameter("@productName", SqlDbType.VarChar, 50);
            productName.Value = paramText;
            preparedCommand.Parameters.Add(productName);

            SqlDataAdapter preparedDA = new SqlDataAdapter();
            DataTable prepDataTable = new DataTable();
            preparedCommand.Prepare();
            preparedDA.SelectCommand = preparedCommand;
            preparedDA.Fill(prepDataTable);
            return prepDataTable;
        }

        public static void insertInto(string query) {

            SqlConnection conn;
            string connString = "Data Source =tolmount.abertay.ac.uk; Initial Catalog =sql1704807; User ID = sql1704807; Password =2h19%7nE";

            conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand insertCommand = new SqlCommand(query, conn);
            insertCommand.ExecuteNonQuery();

        }
    }
}
