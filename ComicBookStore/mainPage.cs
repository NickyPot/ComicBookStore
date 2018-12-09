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
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void mainPage_Load(object sender, EventArgs e)
        {

        }
        Form1 formOne = new Form1();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formOne.Show();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            string connString = "Data Source =tolmount.abertay.ac.uk; Initial Catalog =sql1704807; User ID = sql1704807; Password =2h19%7nE";

            conn = new SqlConnection(connString);
            conn.Open();

            SqlDataAdapter dA = new SqlDataAdapter("select * from product", conn);
            DataTable dataTable = new DataTable();
            dA.Fill(dataTable);
            productList.DataSource = dataTable;


            
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        signUpForm signUpForm = new signUpForm();
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signUpForm.Show();
        }
    }
    }

