using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28Apr18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userInput.Text == "emil" && passwordInput.Text == "1234")
            {
                successLogin successLogin = new successLogin();
                successLogin.Show();
                this.Hide();
            }
            else if ((userInput.Text == "" && passwordInput.Text == "") || (userInput.Text == "" || passwordInput.Text == ""))
            {
                LblLoginStatus.Text = string.Empty;
            }
            else
            {
                LblLoginStatus.ForeColor = Color.Red;
                LblLoginStatus.Text = "* False Username or Password";
                userInput.Text = string.Empty;
                passwordInput.Text = string.Empty;
            }
        }
    }
}
