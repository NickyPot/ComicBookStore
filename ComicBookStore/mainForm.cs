using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicBookStore
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            //this form the user can't see, it's what handles the message loop
            WindowState = FormWindowState.Minimized;
            Visible = false;
            ShowInTaskbar = false;
            InitializeComponent();

            //initialise mainPage form
            var mainPage = new mainPage();
            mainPage.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
