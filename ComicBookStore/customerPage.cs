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

        public string avatar="";
        
        public customerPage()
        {

            InitializeComponent();
            int custId = Int32.Parse(Form1.customerId);
            string query = "select customer.vipStatus, account.phoneNum, account.email, account.addressHome, account.avatar from customer inner join account on customer.customerID = account.personID where customer.customerID =" + custId;
            profileGridView.DataSource = searchResult.nPBindtoGridview(query);
            profileGridView.Columns["avatar"].Visible = false;

            avatar = profileGridView.Rows[0].Cells["avatar"].Value.ToString();
            if (profileGridView.Rows[0].Cells["avatar"].Value.ToString() == "batman")
            {

                avatarPictureBox.Image = Properties.Resources.batman;
            }

            else if (profileGridView.Rows[0].Cells["avatar"].Value.ToString() == "superman")
            {

                avatarPictureBox.Image = Properties.Resources.superman;
            }

            else if (profileGridView.Rows[0].Cells["avatar"].Value.ToString() == "spiderman")
            {

                avatarPictureBox.Image = Properties.Resources.spiderman;
            }

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

            if (avatar == "batman")
            {

                adLabel.Text = "Batman new 52 issue 199 coming next week!";
            }

            else if (avatar == "superman") {

                adLabel.Text = "Superman new 52 issue 199 coming next week!";

            }
            else if (avatar == "spiderman")
            {

                adLabel.Text = "New spiderman figure coming next week!";

            }

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
            string stockQuery = "update product set stockNumber = stockNumber -" + 1 + "where itemNum = '" + itemNum + "'";
            searchResult.insertInto(stockQuery);
            MessageBox.Show("Item successfully added to your card");
            
         
        }
        //when pressed it fetches the current state of the cart table for the user
        private void updateCartButton_Click(object sender, EventArgs e)
        {
            int custId = Int32.Parse(Form1.customerId);
            string query = "select product.itemNum, product.productName, product.msrp from product inner join cart on product.itemNum=cart.itemNum where cart.customerId= "+ custId + "";
            cartDataGridView.DataSource = searchResult.nPBindtoGridview(query);

        }

        //when pressed it deletes the top 1 column of cart where the item number is the one of the item in the rows cell
        private void cartDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cartDataGridView.Columns["removeItemButton"].Index) {

                string query = "delete top (1) from cart where itemNum = '" + cartDataGridView.CurrentRow.Cells["itemNum"].Value.ToString() + "'";
                searchResult.insertInto(query);

                string stockQuery = "update product set stockNumber = stockNumber +" + 1 + "where itemNum = '" + cartDataGridView.CurrentRow.Cells["itemNum"].Value.ToString() + "'";
                searchResult.insertInto(stockQuery);



            }
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            if (storeComboBox.Text != null)
            {
                if (fastDeliveryCheckBox.Checked || normalDeliveryCheckBox.Checked)
                {

                    int custId = Int32.Parse(Form1.customerId);
                    string addToOrderHistory = "insert into orderHistory(customerId, itemNum) select customerId, itemNum from cart where customerId ='" + custId + "'";
                    searchResult.insertInto(addToOrderHistory);
                    string deleteQuery = "delete from cart where customerId ='" + custId + "'";
                    searchResult.insertInto(deleteQuery);

                    int totalPaid = 0;
                    for (int i = 0; i < cartDataGridView.Rows.Count; i++)
                    {


                        totalPaid += Convert.ToInt32(cartDataGridView.Rows[i].Cells["msrp"].Value);
                    }

                    if (fastDeliveryCheckBox.Checked)
                    {

                        totalPaid += 5;

                    }

                    else if (normalDeliveryCheckBox.Checked)
                    {

                        totalPaid += 1;
                    }


                    string stockQuery = "update customer set buyingStreak = buyingStreak +" + 1 + "where customerID = '" + custId + "'";
                    searchResult.insertInto(stockQuery);
                    MessageBox.Show(profileGridView.Rows[0].Cells["buyingStreak"].Value.ToString());
                    if (Convert.ToInt32(profileGridView.Rows[0].Cells["buyingStreak"].Value) > 10)
                    {

                        string vipQuery = "update customer set vipStatus = 'yes' where customerID = '" + custId + "'";
                        searchResult.insertInto(vipQuery);
                        totalPaid = totalPaid - 2;
                    }


                    MessageBox.Show("You paid: " + totalPaid + "£");
                    string revenueQuery = "update shop set revenue = revenue +" + totalPaid + "where name = '" + storeComboBox.Text + "'";
                    searchResult.insertInto(revenueQuery);




                }

                else { MessageBox.Show("Please select delivery method"); }
            }
            else { MessageBox.Show("Please select a store"); }

        }

        private void profileTab_Click(object sender, EventArgs e)
        {
            

        }

        private void updateProfileTableButton_Click(object sender, EventArgs e)
        {


            int custId = Int32.Parse(Form1.customerId);
            string query = "select customer.vipStatus, customer.buyingStreak, account.phoneNum, account.email, account.addressHome, account.avatar, names.firstName, names.secondName from customer inner join account on customer.customerID = account.personID inner join names on customer.customerID = names.customerId where customer.customerID ='" + custId.ToString()+"'";
            profileGridView.DataSource = searchResult.nPBindtoGridview(query);
            profileGridView.Columns["avatar"].Visible = false;
            MessageBox.Show(custId.ToString());
            avatar = profileGridView.Rows[0].Cells["avatar"].Value.ToString();
            if (profileGridView.Rows[0].Cells["avatar"].Value.ToString() == "batman") {
  
                avatarPictureBox.Image = Properties.Resources.batman;
            }
      
            else if (profileGridView.Rows[0].Cells["avatar"].Value.ToString() == "superman") {
        
                avatarPictureBox.Image = Properties.Resources.superman;
            }
    
            else if (profileGridView.Rows[0].Cells["avatar"].Value.ToString() == "spiderman")
            {
        
                avatarPictureBox.Image = Properties.Resources.spiderman;
            }





        }

        private void avatarPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void profileGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    static class searchResult
    {

        public static SqlDataAdapter getSqlDAdapter(string query) {

            SqlConnection conn;
            string connString = "Data Source =tolmount.abertay.ac.uk; Initial Catalog =sql1704807; User ID = sql1704807; Password =2h19%7nE";

            conn = new SqlConnection(connString);
            conn.Open();

            SqlDataAdapter dA = new SqlDataAdapter(query, conn);
            return dA;
        }
        
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
