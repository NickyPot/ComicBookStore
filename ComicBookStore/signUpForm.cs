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
    public partial class signUpForm : Form
    {
        public signUpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(emailTextBox.Text == string.Empty) && !(passwordTextBox.Text == string.Empty) && !(phoneNumTextBox.Text == string.Empty) && !(homeAddressTextBox.Text == string.Empty))
            {


                SqlConnection conn;
                string connString = "Data Source =tolmount.abertay.ac.uk; Initial Catalog =sql1704807; User ID = sql1704807; Password =2h19%7nE";

                conn = new SqlConnection(connString);
                conn.Open();

                string insert= "insert into customer (vipStatus) values ('no')";
                string count = "SELECT COUNT(vipStatus) from customer";
                SqlCommand command = new SqlCommand(insert, conn);
                command.ExecuteNonQuery();
                
                SqlCommand countCommand = new SqlCommand(count, conn);
                SqlDataReader reader = countCommand.ExecuteReader();
               
                reader.Read();
                string accountId = reader[0].ToString();
                reader.Close();

                string img;
                if (batmanCheckBox1.Checked)
                {

                    img = "batman";

                }

                else if (supermanCheckBox2.Checked)
                {

                    img = "superman";

                }

                else if (spidermanCheckBox3.Checked)
                {

                    img = "spiderman";
                }

                else
                {
                    img = "no img";
                }


                SqlCommand preparedCommand = new SqlCommand(null, conn);
                preparedCommand.CommandText = "insert into account (phoneNum, email, addressHome, avatar, personID, password)" + "values (@phoneNum, @email, @addressHome, @avatar, @personID, @password)";
                SqlParameter phoneNumParam = new SqlParameter("@phoneNum", SqlDbType.VarChar, 10);
                SqlParameter emailParam = new SqlParameter("@email", SqlDbType.VarChar, 100);
                SqlParameter addressHomeParam = new SqlParameter("@addressHome", SqlDbType.VarChar, 100);
                SqlParameter avatarParam = new SqlParameter("@avatar", SqlDbType.VarChar, 50);
                SqlParameter personIDParam = new SqlParameter("@personID", SqlDbType.Int, 0);
                SqlParameter passwordParam = new SqlParameter("@password", SqlDbType.VarChar, 200);
               

                phoneNumParam.Value = phoneNumTextBox.Text;
                emailParam.Value = emailTextBox.Text;
                addressHomeParam.Value = homeAddressTextBox.Text;
                avatarParam.Value = img;
                personIDParam.Value = accountId;
                passwordParam.Value = passwordTextBox.Text;

                preparedCommand.Parameters.Add(phoneNumParam);
                preparedCommand.Parameters.Add(emailParam);
                preparedCommand.Parameters.Add(addressHomeParam);
                preparedCommand.Parameters.Add(avatarParam);
                preparedCommand.Parameters.Add(personIDParam);
                preparedCommand.Parameters.Add(passwordParam);

                preparedCommand.Prepare();
                preparedCommand.ExecuteNonQuery();
                


                MessageBox.Show("success");


            }
        }


        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
