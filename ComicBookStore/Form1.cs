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
    public partial class Form1 : Form

    {

        private static string _customerId;
        public static string customerId {
            get { return _customerId; }
            set { _customerId = customerId; }

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (!(emailTextBox.Text == string.Empty) && !(passwordTextBox.Text == string.Empty)) {

                SqlConnection conn;
                string connString = "Data Source =tolmount.abertay.ac.uk; Initial Catalog =sql1704807; User ID = sql1704807; Password =2h19%7nE";

                conn = new SqlConnection(connString);
                conn.Open(); 

                

                SqlCommand prepCommand = new SqlCommand(null, conn);
                prepCommand.CommandText = "select * from account where email = @email and password = @password";
                SqlParameter emailParam = new SqlParameter("@email", SqlDbType.VarChar, 100);
                SqlParameter passwordParam = new SqlParameter("@password", SqlDbType.VarChar, 200);

                int hashedPassword = passwordTextBox.Text.GetHashCode();
                string saltedPassword = hashedPassword.ToString() + "asdfasd";

                emailParam.Value = emailTextBox.Text;
                passwordParam.Value = saltedPassword;

                prepCommand.Parameters.Add(emailParam);
                prepCommand.Parameters.Add(passwordParam);

                prepCommand.Prepare();
               SqlDataReader data = prepCommand.ExecuteReader();


                int accounts=0;
                int staff = 0;
                while (data.Read()) {
                    accounts++;
                }

                data.Close();

                if (accounts == 1)
                {
                    

                    string selectStaff = "select staffId from account where email = '" + emailTextBox.Text + "'and staffId is not null";

                    SqlCommand command1 = new SqlCommand(selectStaff);

                    command1.Connection = conn;

                    SqlDataReader data1 = command1.ExecuteReader();

                    string staffId ="";
                    while (data1.Read())
                    {
                        staff++;
                        staffId = data1[0].ToString();
                    }

                    
                    data1.Close();


                    if (staff == 1)
                    {
                        //if it comes here it means they are staff
                       // MessageBox.Show("You are staff");
                        string selectManagement = "select managementStatus from staff where staffId = " + staffId;
                        string management = searchResult.nPBindtoGridview(selectManagement).Rows[0]["managementStatus"].ToString();
                        
                        if (management == "yes")
                        {

                            managementPage managPage = new managementPage();
                            managPage.Show();
                        }

                        else {
                            staffPage staffPage = new staffPage();
                            staffPage.Show();    

                        }

                    }

                    else {
                        //if it comes here it means they are a customer
                        string selectUserId = "select personID from account where email = '" + emailTextBox.Text + "'";

                        SqlCommand userIdCommand = new SqlCommand(selectUserId);

                        userIdCommand.Connection = conn;

                        SqlDataReader userIdData = userIdCommand.ExecuteReader();
                        userIdData.Read();
                        _customerId = userIdData[0].ToString();
                       
                        MessageBox.Show(userIdData[0].ToString());

                        customerPage customerPage = new customerPage();
                        customerPage.Show();

                    }

                    }

                else { MessageBox.Show("no accounts"); }

            }
        }

       
    }
}
